using System;
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
        Memory mem = Memory.Instance;
        private int literal = 0;
        private int fileAdress = 0;
        private int fileVal = 0;
        private int destination;
        private byte bit;

        //string binaryval = Convert.ToString(literal, 2);

        private int getFileVal(int f)
        {
            int FileVal = 0;

            for (int i = 0; i < 8; i++)
            {
                FileVal += mem.ram[i, f] * (int)Math.Pow(2, i);
            }
            return FileVal;
        }

        private void schreibeInRam(int f, int val)
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
            for (int i = 0; i < mem.StackArrayHelper.Length; i++)
            {
                mem.StackArray[i] = mem.StackArrayHelper[i];
            }
        }
        //==============================

        //Befehle         
        
        public void movlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal);            
        }

        public void andlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal & mem.WReg);                     
            CheckZero(mem.WReg);
        }

        public void iorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal | mem.WReg);            
            CheckZero(mem.WReg);
        }

        public void sublw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal - mem.WReg);
            CheckZero(mem.WReg);
            CheckCarry();
            CheckDigitCarry();
        }

        public void xorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal ^ mem.WReg);
            CheckZero(mem.WReg);
        }

        public void addlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal + mem.WReg);
            CheckZero(mem.WReg);
            CheckCarry();
            CheckDigitCarry();
        }

        public void  goto_(int binCode)
        {
            //TODO 2 Cycles            
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;
        }

        public void call(int binCode)
        {
            //TODO 2 Cycles
            mem.pc++;
            StackPush();
            int pclath = 0;  //<< 7;         //TODO pclath
            int adresse = (binCode & 0x07FF);
            mem.pc = adresse + pclath;
            //PC -1, da in for Schleife erhöht
            mem.pc--;
        }

        public void nop(int binCode)
        {
            //Nope
        }

        public void return_(int binCode)
        {
            StackPop();
            //PC -1, da in for Schleife erhöht
            mem.pc--;
        }

        public void retlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.setWReg(literal);
            StackPop();
            mem.pc--;
        }

        public void movwf(int binCode)
        {
            fileAdress = binCode & 0x007F;
            IndirekteAdressierung(fileAdress);
            schreibeInRam(fileAdress, mem.WReg);

        }

        public void addwf(int binCode)
        {            
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
        } 

        public void andwf(int binCode)
        {
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
        } 

        public void clrf(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            schreibeInRam(fileAdress, 0);
            setZero(1);
        }

        public void comf(int binCode)
        {
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
        }

        public void decf(int binCode)
        {
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
        }

        public void incf(int binCode)
        {
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
        }

        public void movf(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            destination = binCode & 0x0080;

            if (destination == 0)
            {
                mem.setWReg(fileVal);
            }
            else
            {
                schreibeInRam(fileAdress, fileVal);
            }
            CheckZero(fileVal);
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

        }

        public void subwf(int binCode)
        {
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
        }

        public void swapf(int binCode)
        {
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
        }

        public void xorwf(int binCode)
        {
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
        }

        public void clrw(int binCode)
        {
            mem.setWReg(0);
            setZero(1);
        }


        //Test4
        public void rlf(int binCode)
        {
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
        }


        public void rrf(int binCode)
        {
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
        }

        //Test5

        public void bsf(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, true);
        }

        public void bcf(int binCode)
        {
            fileAdress = binCode & 0x007F;
            bit = (byte)((binCode >> 7) & 0x7);

            BitSetOderBitClear(bit, fileAdress, false);
        }

        public void btfsc(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            bit = (byte)((fileVal >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 1)
            {

            }
            else
            {
                nop(binCode);
                mem.pc++;
            }
        }

        public void btfss(int binCode)
        {
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            bit = (byte)((fileVal >> 7) & 0x7);

            int Bool = mem.ram[bit, fileAdress];
            if (Bool == 0)
            {

            }
            else
            {
                nop(binCode);
                mem.pc++;
            }
        }


        public void decfsz(int binCode)
        {
            decf(binCode);
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            if (fileVal == 0)
            {
                nop(binCode);
                mem.pc++;
            }
        }



        public void incfsz(int binCode)
        {
            incf(binCode);
            fileAdress = binCode & 0x007F;

            IndirekteAdressierung(fileAdress);

            fileVal = getFileVal(fileAdress);
            if (fileVal == 0)
            {
                nop(binCode);
                mem.pc++;
            }
        }

    }
}
