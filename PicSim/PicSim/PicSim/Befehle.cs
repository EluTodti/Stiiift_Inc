using System;
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
        
        //string binaryval = Convert.ToString(literal, 2);

        //TODO complete
        public void CheckZero()
        {

            if (WReg == 0)
            {
                //Status , 2 = 1
            }
            else
            {
                //Status , 2 = 0
            }
        }
        public void CheckCarry()
        {
            if ((WReg & 256) == 1)
            {
                //Status , 0 = 1
            }
            else
            {
                //Status , 0 = 0
            }
        }
        public void CheckDigitCarry()
        {
            //
        }


        //W Register
        public int WReg = 0;
        //Literal
        public int literal = 0;
        public void movlw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = literal;
            //PC++
            
        }

        public void andlw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = (literal & WReg);
            //PC++
            
            CheckZero();
        }

        public void iorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = (literal | WReg);
            //PC++
            
            CheckZero();

        }

        public void sublw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = (literal - WReg);
            //PC++
            
            CheckZero();
            CheckCarry();
            CheckDigitCarry();
        }

        public void xorlw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = (literal ^ WReg);
            //PC++
            
            CheckZero();
        }

        public void addlw(int binCode)
        {
            literal = binCode & 0x00FF;
            WReg = literal + WReg;
            //PC++
            
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
            mem.pc--;
        }
    }
}
