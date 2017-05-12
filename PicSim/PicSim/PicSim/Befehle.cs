using System;
using System.Linq;
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

        public void InkrementWDT()
        {
            mem.LaufzeitIntervall = 4.0 / (mem.Quarzfrequenz / 1000000.0);
            if (!mem.PrescalerTIMER0)
            {
                int bitVal = getFileVal(0x81) & 0x7;

                switch (bitVal)
                {
                    case 0:
                        if (mem.prescaler % 1 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 1:
                        if (mem.prescaler % 2 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }                        
                        else
                            IncrementPrescaler();
                        break;
                    case 2:
                        if (mem.prescaler % 4 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 3:
                        if (mem.prescaler % 8 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 4:
                        if (mem.prescaler % 16 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 5:
                        if (mem.prescaler % 32 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 6:
                        if (mem.prescaler % 64 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                    case 7:
                        if (mem.prescaler % 128 == 0)
                        {
                            IncrementPrescaler();
                            mem.watchdog += mem.LaufzeitIntervall;
                        }
                        else
                            IncrementPrescaler();
                        break;
                }
            }
            else
            {
                mem.watchdog += mem.LaufzeitIntervall;
            }
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

        private void BitSetOderBitClear(byte bit, int fileaddress, bool BitSetIfTrue)
        {
            if (BitSetIfTrue)
            {
                schreibeInRam(fileaddress, getFileVal(fileaddress) | (int)Math.Pow(2, bit));
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

        public void CheckCarry(int val)
        {
            if (val > 255)
            {
                mem.ram[0, Const.STATUS] = 1;
            }
            else
            {
                mem.ram[0, Const.STATUS] = 0;
            }
        }

        public void CheckDigitCarry(int val)
        {
            if (val > 15)
            {
                mem.ram[1, Const.STATUS] = 1;
            }
            else
            {
                mem.ram[1, Const.STATUS] = 0;
            }
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
        public void IncrementPrescaler()
        {
            mem.prescaler = 0xFF & mem.prescaler;
            mem.prescaler++;
        }
        public void CheckPrescalerMode()
        {
            if (mem.ram[3, Const.OPTION_REG + 128] == 1)
            {
                mem.PrescalerTIMER0 = false;
            }
            else
            {
                mem.PrescalerTIMER0 = true;
            }          
        }
        
        public void CheckPrescaler()
        {
            if (mem.PrescalerTIMER0)
            {
                int bitVal = getFileVal(0x81) & 0x7;

                switch (bitVal)
                {
                    case 0:
                        if (mem.prescaler % 2 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 1:
                        if (mem.prescaler % 4 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 2:
                        if (mem.prescaler % 8 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 3:
                        if (mem.prescaler % 16 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 4:
                        if (mem.prescaler % 32 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 5:
                        if (mem.prescaler % 64 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 6:
                        if (mem.prescaler % 128 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                    case 7:
                        if (mem.prescaler % 256 == 0)
                            IncrementTimer();
                        else
                            IncrementPrescaler();
                        break;
                }
            }
            else
            {
                int TimerAdress = 0x01;
                int Timer = getFileVal(TimerAdress);

                if (mem.ram[5, Const.STATUS] == 1)   //Check Bank - if Bank 1 then:
                {
                    TimerAdress -= 128;
                }
                schreibeInRam(TimerAdress, Timer + 1);
            }             
        }
        public void GetTimerValOld()
        {
            mem.TimerValOld = getFileVal(Const.TMR0);
        }
        public void CheckTimerMode()
        {
            if (mem.ram[5, Const.OPTION_REG + 128] == 0) //Timer Mode TOCS
            {
                TimerMode();   
            }
            else
            {
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
        }
              
        public void IncrementTimer()
        {
            int TimerAdress = 0x01;
            int Timer = getFileVal(TimerAdress);

            if (mem.ram[5, Const.STATUS] == 1)   //Check Bank - if Bank 1 then:
            {
                TimerAdress -= 128;
            }

            if (Timer == 0)
            {
                //Muss vom Benutzer in Software wieder gecleart werden ¯\_(ツ)_/¯
                mem.ram[2, Const.INTCON] = 1;
                setZero(1);
            }

            schreibeInRam(TimerAdress, Timer + 1);
            IncrementPrescaler();
        }


        public void TimerMode()
        {
            //Timer Mode                     
            mem.TimerValNew = getFileVal(0x01);
            if (!(mem.TimerValOld == mem.TimerValNew))
            {
                mem.prescaler = 0;
                mem.TimerInhibit = 2;
                mem.IncomingOverFlow = false;
                mem.TimerInhibit++; //Da unten decrement
            }

            if (mem.TimerInhibit == 0)
            {
                CheckPrescaler();
            }
            else
            {
                mem.decTimerInhibit();
            }
        }

        public void PreInstructions(int binCode)
        {

            mem.SafeBack();
            GetTimerValOld();


            fileAdress = binCode & 0x007F;
            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            literal = binCode & 0x00FF;
            destination = binCode & 0x0080;
        }

        public void PostInstruction()
        {
            CheckPrescalerMode();
            CheckTimerMode();
            mem.pc++;
            InkrementWDT();
            mem.IncLaufzeitzaehler();
        }
        public void TwoCycles()
        {
            CheckPrescalerMode();
            CheckTimerMode();
            InkrementWDT();
            mem.IncLaufzeitzaehler();
        }
        //==
        //Befehle         

        public void movlw(int binCode)
        {
            PreInstructions(binCode);
            mem.setWReg(literal);                   
            mem.setWReg(literal); 
            PostInstruction();
        }

        public void andlw(int binCode)
        {
            PreInstructions(binCode);

            mem.setWReg(literal & mem.WReg);                     
            CheckZero(mem.WReg);

            PostInstruction();
        }

        public void iorlw(int binCode)
        {
            PreInstructions(binCode);

            mem.setWReg(literal | mem.WReg);            
            CheckZero(mem.WReg);

            PostInstruction();
        }

        public void sublw(int binCode)
        {
            PreInstructions(binCode);
            //helper für Überprüfung des Carry Bits
            int helper = ((255 - mem.WReg + 1) & 0xFF) + literal;
            int helperDC = (((255 - mem.WReg + 1) & 0x0F) + (literal & 0x0F));
            mem.setWReg(literal + (~mem.WReg +1));
            CheckZero(mem.WReg);
            CheckCarry(helper);
            CheckDigitCarry(helperDC); 
                                   
            PostInstruction();
        }

        public void xorlw(int binCode)
        {
            PreInstructions(binCode);

            mem.setWReg(literal ^ mem.WReg);
            CheckZero(mem.WReg);
            
            PostInstruction();
        }

        public void addlw(int binCode)
        {
            PreInstructions(binCode);

            int helperDC = (literal & 0x0F) + (mem.WReg & 0x0F);
            mem.setWReg(literal + mem.WReg);
            
            CheckZero(mem.WReg);
            CheckCarry(mem.WReg);
            CheckDigitCarry(helperDC); 
                       
            PostInstruction();
        }

        public void  goto_(int binCode)
        {
            PreInstructions(binCode);

            //TODO 2 Cycles            
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;
            TwoCycles();
             
            PostInstruction();
        }

        public void call(int binCode)
        {
            PreInstructions(binCode);

            //TODO 2 Cycles
            mem.pc++;
            StackPush();
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;
            TwoCycles();

            PostInstruction();
        }

        public void nop(int binCode)
        {
            PreInstructions(binCode);
            //Nope
            PostInstruction();
        }

        public void return_(int binCode)
        {
            PreInstructions(binCode);

            StackPop();
            //PC -1, da in for Schleife erhöht
            mem.pc--;

            TwoCycles();
            PostInstruction();
        }

        public void retlw(int binCode)
        {
            PreInstructions(binCode);

            mem.setWReg(literal);
            StackPop();
            mem.pc--;
            TwoCycles();

            PostInstruction();
        }

        public void movwf(int binCode)
        {
            PreInstructions(binCode);

            schreibeInRam(fileAdress, mem.WReg);           

            PostInstruction();
        }

        public void addwf(int binCode)
        {
            PreInstructions(binCode);
            int helperDC = (fileVal & 0x0F) + (mem.WReg & 0x0F);

            if (destination == 0)
            {
                mem.setWReg(mem.WReg + fileVal);
                
            }
            else
            {              
                schreibeInRam(fileAdress, mem.WReg + fileVal);
            }
            CheckZero(mem.WReg + fileVal);
            CheckCarry(mem.WReg + fileVal);
            CheckDigitCarry(helperDC);  
                               
            PostInstruction();
        } 

        public void andwf(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(mem.WReg & fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, mem.WReg & fileVal);
            }
            CheckZero(mem.WReg & fileVal);
            
            PostInstruction();
        } 

        public void clrf(int binCode)
        {
            PreInstructions(binCode);

            schreibeInRam(fileAdress, 0);
            setZero(1);
            
            PostInstruction();
        }

        public void comf(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(255 - fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, 255 - fileVal);
            }
            CheckZero(255 - fileVal);
          
            PostInstruction();
        }

        public void decf(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(fileVal - 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal - 1);
            }
            CheckZero(fileVal - 1);         

            PostInstruction();
        }

        public void incf(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(fileVal + 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal + 1);
            }
            CheckZero(fileVal + 1);           

            PostInstruction();
        }

        public void movf(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                if (fileAdress == 1)
                {
                    mem.setWReg(fileVal);
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
            CheckZero(fileVal);

            PostInstruction();
        }

        public void iorwf(int binCode)
        {
            PreInstructions(binCode);

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

            PostInstruction();
        }

        public void subwf(int binCode)
        {
            PreInstructions(binCode);

            //(~mem.WReg + 1) = Complement(WReg) + 1 = - WReg
            int helper = ((255 - mem.WReg + 1) & 0xFF ) + fileVal;
            int helperDC = (((255 - mem.WReg + 1) & 0x0F) + (fileVal & 0x0F));

            fileVal = fileVal + (~mem.WReg + 1);
            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }
            CheckZero(fileVal);
            CheckCarry(helper);
            CheckDigitCarry(helperDC);   
                    
            PostInstruction();
        }

        public void swapf(int binCode)
        {
            PreInstructions(binCode);
            //SwapNibbles
            fileVal = SwapNibbles(fileVal);

            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }          
            PostInstruction();

        }

        public void xorwf(int binCode)
        {
            PreInstructions(binCode);

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
                      
            PostInstruction();
        }

        public void clrw(int binCode)
        {
            PreInstructions(binCode);

            mem.setWReg(0);
            setZero(1);    
                   
            PostInstruction();
        }

        //Test4
        public void rlf(int binCode)
        {
            PreInstructions(binCode);

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
            //CheckCarry wird bereits geprüft        
            PostInstruction();
        }

        public void rrf(int binCode)
        {
            PreInstructions(binCode);

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
            //CheckCarry wird bereits geprüft        
            PostInstruction();
        }

        //Test5

        public void bsf(int binCode)
        {
            PreInstructions(binCode);

            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, true);
            PostInstruction();
        }

        public void bcf(int binCode)
        {
            PreInstructions(binCode);
            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, false);            
            PostInstruction();
        }

        public void btfsc(int binCode)
        {
            PreInstructions(binCode);
            bit = (byte)((binCode >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 1)
            {

            }
            else
            {
                TwoCycles();
                mem.pc++;
            }           

            PostInstruction();
        }

        public void btfss(int binCode)
        {
            PreInstructions(binCode);
            bit = (byte)((binCode >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 0)
            {

            }
            else
            {
                TwoCycles();
                mem.pc++;
            }          
            PostInstruction();
        }

        public void decfsz(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(fileVal - 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal - 1);
            }
            //neu zuweisen, da oben geändert
            fileVal = getFileVal(fileAdress);

            if (fileVal == 0)
            {
                TwoCycles();
            }                      
            PostInstruction();
        }

        public void incfsz(int binCode)
        {
            PreInstructions(binCode);

            if (destination == 0)
            {
                mem.setWReg(fileVal + 1);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal + 1);
            }
            fileVal = getFileVal(fileAdress);
            if (fileVal == 0)
            {
                TwoCycles();
            }

            PostInstruction();
        }

        public void clrwdt(int binCode)
        {
            PreInstructions(binCode);
            //TODO 00H -> WDT bzw Startwert 18.000
            //TODO 0 -> WDT prescaler bzw. Startwert
            mem.ram[Const.STATUS, 3] = 1;
            mem.ram[Const.STATUS, 4] = 1;
           // watchdog.watchdog = 0;
            if (!mem.PrescalerTIMER0)
            {
                mem.prescaler = 0;
            }
            //TODO TMR0 ++          
            PostInstruction();
        }

        public void sleep(int binCode)
        {
            PreInstructions(binCode);
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
            PostInstruction();
        }


        //TODO überprüfen
        public void retfie(int binCode)
        {
            PreInstructions(binCode);
            //exit interrupt routine
            //TODO richtig?
            StackPop();
            //enable Interrupts
            mem.ram[7, Const.INTCON] = 1;
            //pc-1 da in for Schleife +1
            mem.pc--;
            TwoCycles();

            PostInstruction();
        }
    }
}
