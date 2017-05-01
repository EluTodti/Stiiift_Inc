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
        public int literal = 0;
        public int fileAdress = 0;
        private int destination;

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
            string binVal = Convert.ToString(val, 2);
            binVal.ToArray();
            for (int i = 0; i < binVal.Length; i++)
            {
                mem.ram[i, f] = int.Parse(binVal[binVal.Length - i - 1].ToString());
            }
        }

        //TODO complete
        public void CheckZero()
        {

            if (mem.WReg == 0)
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
            if ((mem.WReg & 256) == 1)
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
        
        //Befehle für Stackänderungen
        public void StackPop()
        {
            mem.pc = mem.Stack.Pop();
            mem.StackArray = mem.Stack.ToArray();
        }
        public void StackPush()
        {
            mem.Stack.Push(mem.pc);
            mem.StackArray = mem.Stack.ToArray();
        }
        //==============================

        //Befehle         
        
        public void movlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = literal;            
        }

        public void andlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = (literal & mem.WReg);                     
            CheckZero();
        }

        public void iorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = (literal | mem.WReg);            
            CheckZero();
        }

        public void sublw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = (literal - mem.WReg);
            CheckZero();
            CheckCarry();
            CheckDigitCarry();
        }

        public void xorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = (literal ^ mem.WReg);
            CheckZero();
        }

        public void addlw(int binCode)
        {
            literal = binCode & 0x00FF;
            mem.WReg = literal + mem.WReg;
            CheckZero();
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
            mem.WReg = literal;
            StackPop();
            mem.pc--;
        }

        public void movwf(int binCode)
        {
            fileAdress = binCode & 0x007F;
            schreibeInRam(fileAdress, mem.WReg);
        }

        public void addwf(int binCode)
        {
            int fileVal;
            fileAdress = binCode & 0x007F;
            destination = binCode & 0x0080;

            fileVal = getFileVal(fileAdress);

            if (destination == 0)
            {
                mem.WReg = mem.WReg + fileVal;
            }
            else
            {              
                schreibeInRam(fileAdress, mem.WReg + fileVal);
            }
        }   
    }
}
