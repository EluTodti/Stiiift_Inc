﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSim
{
    class Befehle
    {
        //Singleton
        private static Befehle instance;

        private Befehle()
        {
        }

        public static Befehle Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Befehle();
                }
                return instance;
            }
        }

        Memory mem = Memory.Instance;
        private int literal = 0;
        private int fileAdress = 0;
        private int fileVal = 0;
        private int destination;
        private byte bit;
        //string binaryval = Convert.ToString(literal, 2);

        public int getFileVal(int f)
        {
            int FileVal = 0;

            for (int i = 0; i < 8; i++)
            {
                FileVal += mem.ram[i, f] * (int)Math.Pow(2, i);
            }
            return FileVal;
        }

        public void schreibeInRam(int f, int val)
        {

            if (val > 255)
            {
                val = val & 0x00FF;
            }

            string binVal = Convert.ToString(val, 2);
            //Nullen werden bei String vorrangestellt bis 8 Zeichen
            while (binVal.Length < 8)
            {
                binVal = binVal.Insert(0, "0");
            }
            binVal.ToArray(); //Array enthält immer 8 Bit
            if (mem.ram[5, Const.STATUS] == 1)
            {
                f = f + Const.bank;
            }
            for (int i = 0; i < 8; i++)
            {
                mem.ram[i, f] = int.Parse(binVal[7 - i].ToString());
            }

            mem.RegisterSynchronisieren(f, val);
        }

        private void BitSetOderBitClear(byte bit,int fileaddress, bool BitSetIfTrue)
        {
            if (BitSetIfTrue)
            {
                schreibeInRam(fileaddress ,getFileVal(fileaddress) | (int) Math.Pow(2, bit));
            }
            else
            {
                schreibeInRam(fileaddress, getFileVal(fileaddress) & (0xFF - (int)Math.Pow(2, bit)));
            }
        }

        private void IndirekteAdressierung(int fileadress)
        {
            //Wenn INDF adressiert, lese Wert aus FSR-Adresse : movwf indirect => indirect adressing
            
            //Beispiel: 10H=0
            //steht in FST 10H, so adressiert addwf 10H --> 10H=1
            if (fileadress == 0)
            {
                fileAdress = getFileVal(Const.FSR);
            }
        }

        //TODO complete!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Argumentübergabe, da die Operation an sich auf 0 überprüft werden muss, nicht nur das WReg.
        public void CheckZero(int val)
        {
            if (val == 0)
            {
                mem.ram[2, Const.STATUS] = 1;               
            }
            else
            {
                mem.ram[2, Const.STATUS] = 0;
            }
        }

        public void CheckCarry()
        {
            if (mem.WReg > 255)
            {
                mem.ram[0, Const.STATUS] = 1;
            }
            else
            {
                mem.ram[0, Const.STATUS] = 0;
            }
        }

        public void CheckDigitCarry()
        {
            //
        }

        public void setZero(int n)
        {
            mem.ram[2, Const.STATUS] = n;
        }

        public void setCarry(int n)
        {
            mem.ram[0, Const.STATUS] = n;
        }

        public void setDigitCarry(int n)
        {
            mem.ram[0, Const.STATUS] = n;
        }

        //Swap Nibbles
        public int SwapNibbles(int fileValue)
        {
            //LowerNibble
            int NewLowerNibble = (fileValue >> 4) & 0x0F;
            //UpperNibble
            fileValue = (fileValue << 4) & 0xF0;
            //New fileVal
            fileValue = fileValue + NewLowerNibble;

            return fileValue;
        }

        //Befehle für Stackänderungen
        public void StackPop()
        {
            mem.pc = mem.Stack.Pop();
            mem.StackArray[mem.Stack.Count()] = 0;
           
        }
        public void StackPush()
        {
            mem.Stack.Push(mem.pc);

            mem.StackArrayHelper = mem.Stack.ToArray();
            try
            {
                for (int i = 0; i < mem.StackArrayHelper.Length; i++)
                {
                    mem.StackArray[i] = mem.StackArrayHelper[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("StepBack sollte nicht zwischen call und return ausgeführt werden! PicSim bitte resetten.");
            }
        }

        public void GetTimerValOld()
        {
            mem.TimerValOld = getFileVal(Const.TMR0);
        }
        public void CheckTimer()
        {
            //Check for Mode
            if (mem.ram[5, Const.OPTION_REG + 128] == 0)
            {
                //Timer Mode                     
                mem.TimerValNew = getFileVal(0x01);
                if (!(mem.TimerValOld == mem.TimerValNew))
                {
                    //mem.setTimerInhibit();
                    mem.TimerInhibit = 2;
                    mem.IncomingOverFlow = false;
                    mem.TimerInhibit++; //Da unten decrement
                }

                if (mem.TimerInhibit == 0)
                {
                    int val = getFileVal(0x01);
                    int f = 0x01;

                    if (mem.ram[5, Const.STATUS] == 1)   //Check Bank - if Bank 1 then:

                    {
                        f -= 128;
                    }

                    schreibeInRam(f, val + 1);

                    if (mem.IncomingOverFlow)
                    {
                        //Muss vom Benutzer in Software wieder gecleart werden ¯\_(ツ)_/¯
                        mem.ram[2, Const.INTCON] = 1;
                        setZero(1);
                        mem.IncomingOverFlow = false;
                    }

                    if (getFileVal(1) == 255)
                    {
                        mem.IncomingOverFlow = true;
                        //Bei ZweiZykligen Befehlen werden diese hier abgefangen, damit der Overflow direkt festgestellt wird
                        if (mem.TwoCycles)
                        {
                            mem.ram[2, Const.INTCON] = 1;

                            if (mem.ram[5, Const.STATUS] == 1)   //Check Bank - if Bank 1 then:

                            {
                                f -= 128;
                            }
                            schreibeInRam(f, val + 1);

                            mem.IncomingOverFlow = false;
                            mem.TwoCycles = false;
                        }
                    }
                    //Bei Zweizykligen Befehlen, wenn kein Overflow stattfinden kann
                    if (mem.TwoCycles)
                    {
                        schreibeInRam(f, val + 1);
                        mem.TwoCycles = false;
                    }
                    if (getFileVal(1) == 255)
                    {
                        mem.IncomingOverFlow = true;
                    }
                }
                else
                {
                    if (mem.TwoCycles)
                        mem.decTimerInhibit();
                    mem.decTimerInhibit();
                }

            }
            //Counter Mode
            /*
            if (mem.ram[4, Const.OPTION_REG + 128] == 0)
            {
                //rising edge

                if (mem.Ra4ValOld == 0 && mem.Ra4ValNew == 1)
                {
                    schreibeInRam(Const.TMR0, getFileVal(Const.TMR0) + 1);
                }

                //falling edge
                if (mem.Ra4ValOld == 1 && mem.Ra4ValNew == 0)
                {
                    befehle.schreibeInRam(Const.TMR0, befehle.getFileVal(Const.TMR0) + 1);
                }
            }*/
        }
        public void PreInstructions(int binCode)
        {
            setZero(0);
            setCarry(0);
            setDigitCarry(0);
            GetTimerValOld();
            mem.TwoCycles = false;

            fileAdress = binCode & 0x007F;
            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            literal = binCode & 0x00FF;
            destination = binCode & 0x0080;
        }

        public void PostInstruction()
        {
            CheckTimer();
            mem.pc++;
            mem.IncLaufzeitzaehler();

        }
        //==
        //Befehle         

        public void movlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;

            mem.setWReg(literal);
            CheckTimer();     

            mem.setWReg(literal); 
            PostInstruction();           

        }

        public void andlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal & mem.WReg);                     
            CheckZero(mem.WReg);

            CheckTimer();

            PostInstruction();
        }

        public void iorlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal | mem.WReg);            
            CheckZero(mem.WReg);
            PostInstruction();
        }

        public void sublw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal - mem.WReg);
            CheckZero(mem.WReg);
            CheckCarry();
            CheckDigitCarry();
            CheckTimer();
            PostInstruction();
        }

        public void xorlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal ^ mem.WReg);
            CheckZero(mem.WReg);
            CheckTimer();
            PostInstruction();
        }

        public void addlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal + mem.WReg);
            CheckZero(mem.WReg);
            CheckCarry();
            CheckDigitCarry();
            CheckTimer();
            PostInstruction();
        }

        public void  goto_(int binCode)
        {
            GetTimerValOld();
            //TODO 2 Cycles            
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;

            mem.IncLaufzeitzaehler();
            mem.TwoCycles = true;
            CheckTimer();

            PostInstruction();
        }

        public void call(int binCode)
        {
            GetTimerValOld();
            //TODO 2 Cycles
            mem.pc++;
            StackPush();
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;

            mem.IncLaufzeitzaehler();
            mem.TwoCycles = true;
            CheckTimer();

            PostInstruction();
        }

        public void nop(int binCode)
        {
            GetTimerValOld();
            CheckTimer();
            //Nope
            PostInstruction();
        }

        public void return_(int binCode)
        {
            GetTimerValOld();
            StackPop();
            //PC -1, da in for Schleife erhöht
            mem.pc--;

            mem.IncLaufzeitzaehler();
            mem.TwoCycles = true;
            CheckTimer();

            PostInstruction();
        }

        public void retlw(int binCode)
        {
            GetTimerValOld();
            literal = binCode & 0x00FF;
            mem.setWReg(literal);
            StackPop();
            mem.pc--;

            mem.IncLaufzeitzaehler();
            mem.TwoCycles = true;

            CheckTimer();

            PostInstruction();
        }

        public void movwf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;
            IndirekteAdressierung(fileAdress);
            schreibeInRam(fileAdress, mem.WReg);
            CheckTimer();

            PostInstruction();
        }

        public void addwf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;
 

            if (destination == 0)
            {
                mem.setWReg(mem.WReg + fileVal);
                
            }
            else
            {              
                schreibeInRam(fileAdress, mem.WReg + fileVal);
            }
            CheckZero(mem.WReg + fileVal);
            CheckCarry();
            CheckDigitCarry();

            CheckTimer();

            PostInstruction();

        } 

        public void andwf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            if (destination == 0)
            {
                mem.setWReg(mem.WReg & fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, mem.WReg & fileVal);
            }
            CheckZero(mem.WReg & fileVal);

            CheckTimer();

            PostInstruction();

        } 

        public void clrf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            schreibeInRam(fileAdress, 0);
            setZero(1);

            CheckTimer();

            PostInstruction();

        }

        public void comf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            if (destination == 0)
            {
                mem.setWReg(255 - fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, 255 - fileVal);
            }
            CheckZero(255 - fileVal);

            CheckTimer();

            PostInstruction();

        }

        public void decf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            if (destination == 0)
            {
                mem.setWReg(fileVal - 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal - 1);
            }
            CheckZero(fileVal - 1);

            CheckTimer();


            PostInstruction();

        }

        public void incf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            if (destination == 0)
            {
                mem.setWReg(fileVal + 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal + 1);
            }
            CheckZero(fileVal + 1);

            CheckTimer();

            PostInstruction();

        }

        public void movf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

           
            if (destination == 0)
            {
                if (fileAdress == 1)
                {
                    mem.setWReg(fileVal + 1);

                }
                else
                {
                    mem.setWReg(fileVal);
                }
            }
            else
            {
                if (fileAdress == 1)
                {
                    mem.setWReg(fileVal + 1);
                }
                else
                {
                    schreibeInRam(fileAdress, fileVal);
                }
            }
            CheckTimer();
            CheckZero(fileVal);
            PostInstruction();
        }

        public void iorwf(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            fileVal = fileVal | mem.WReg;
            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }
            CheckZero(fileVal);

            CheckTimer();

            PostInstruction();

        }

        public void subwf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            //Complement(WReg) + 1 = - WReg
            fileVal = fileVal + (~mem.WReg + 1);
            fileVal = fileVal & 0x000000FF;
            //d=0 or d=1 ?
            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }
            CheckZero(fileVal);
            CheckCarry();
            CheckDigitCarry();

            CheckTimer();

            PostInstruction();

        }

        public void swapf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;
            //SwapNibbles
            fileVal= SwapNibbles(fileVal);

            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }

            CheckTimer();

            PostInstruction();

        }

        public void xorwf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            fileVal = fileVal ^ mem.WReg;
            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }
            CheckZero(fileVal);

            CheckTimer();

            PostInstruction();

        }

        public void clrw(int binCode)
        {
            GetTimerValOld();
            mem.setWReg(0);
            setZero(1);

            CheckTimer();

            PostInstruction();

        }


        //Test4
        public void rlf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);
            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            int carryBit = mem.ram[0, Const.STATUS];



            if (carryBit == 1)
            {
                if (fileVal >= 128)
                {
                    mem.ram[0, Const.STATUS] = 1;
                }
                else
                {
                    mem.ram[0, Const.STATUS] = 0;
                }
                fileVal = fileVal << 1;
                fileVal += 1;

            }

            else
            {
                if (fileVal >= 128)
                {
                    mem.ram[0, Const.STATUS] = 1;
                }
                else
                {
                    mem.ram[0, Const.STATUS] = 0;
                }

                fileVal = fileVal << 1;
            }

            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }

            else
            {
                schreibeInRam(fileAdress, fileVal);
            }

            CheckTimer();

            PostInstruction();

        }



        public void rrf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;
            IndirekteAdressierung(fileAdress);
            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            int carryBit = mem.ram[0, Const.STATUS];
            if (carryBit == 1)
            {
                fileVal += 256;
            }

            if ((fileVal % 2) == 1)
            {

                fileVal = fileVal >> 1;
                mem.ram[0, Const.STATUS] = 1;
            }

            else
            {
                fileVal = fileVal >> 1;
                mem.ram[0, Const.STATUS] = 0;
            }


            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }

            else
            {
                schreibeInRam(fileAdress, fileVal);
            }

            CheckTimer();

            PostInstruction();

        }

        //Test5

        public void bsf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, true);


            CheckTimer();

            PostInstruction();

        }

        public void bcf(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;
            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, false);

            CheckTimer();

            PostInstruction();

        }

        public void btfsc(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            bit = (byte)((binCode >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 1)
            {

            }
            else
            {
                nop(binCode);
                mem.TwoCycles = true;


            }

            CheckTimer();

            PostInstruction();

        }

        public void btfss(int binCode)
        {
            GetTimerValOld();
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            bit = (byte)((binCode >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 0)
            {

            }
            else
            {
                nop(binCode);
                mem.TwoCycles = true;
            }

            CheckTimer();

            PostInstruction();

        }


        public void decfsz(int binCode)
        {
            GetTimerValOld();
            decf(binCode);
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            if (fileVal == 0)
            {
                nop(binCode);
                mem.TwoCycles = true;
            }

            CheckTimer();

            PostInstruction();

        }



        public void incfsz(int binCode)
        {
            GetTimerValOld();
            incf(binCode);
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            if (fileVal == 0)
            {
                nop(binCode);
                mem.TwoCycles = true;
            }

            CheckTimer();

            PostInstruction();

        }


        public void clrwdt(int binCode)
        {
            GetTimerValOld();
            //TODO 00H -> WDT bzw Startwert 18.000
            //TODO 0 -> WDT prescaler bzw. Startwert
            mem.ram[Const.STATUS, 3] = 1;
            mem.ram[Const.STATUS, 4] = 1;
            //TODO TMR0 ++

            CheckTimer();

            PostInstruction();

        }

        public void sleep(int binCode)
        {
            GetTimerValOld();
            /*  *Kann unterbrochen werden durch:
                *clrwdt (PD bit = 1)
                *Interrupt auf RB0, RB4-7 (nur wenn als input)
                *RESET (wenn wdt aus)
                *
            */
            //Prinzipiell clrwdt(binCode) mit Const.Status, 4 = 1
            mem.ram[Const.STATUS, 3] = 0;
            mem.ram[Const.STATUS, 4] = 1;
            //Kein TMR0 erhöhen, da in clrwdt ++

            CheckTimer();

            PostInstruction();

        }


        //TODO überprüfen
        public void retfie(int binCode)
        {
            GetTimerValOld();
            //exit interrupt routine
            //TODO richtig?
            StackPop();
            //enable Interrupts
            mem.ram[7, Const.INTCON] = 1;
            //pc-1 da in for Schleife +1
            mem.pc--;

            mem.IncLaufzeitzaehler();
            mem.TwoCycles = true;


            CheckTimer();

            PostInstruction();

        }

    }
}
