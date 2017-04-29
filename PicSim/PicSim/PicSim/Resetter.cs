using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSim

{
    class Resetter
    { 
        Memory mem = Memory.Instance;

        public void ResetBefehlsArray()
        {
            for (int i = 0; i < mem.BefehlsArray.Length; i++)
            {
                mem.BefehlsArray[i] = 0;
            }
        }

        public void ResetRAM()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mem.ram[j, i] = 0;
                }
            }
            mem.ram[4, Const.STATUS] = 1;
            mem.ram[5, Const.STATUS] = 1;

            mem.ram[4, Const.STATUS + Const.bank] = 1;
            mem.ram[5, Const.STATUS + Const.bank] = 1;

            mem.ram[0, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[1, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[2, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[3, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[4, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[5, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[6, Const.OPTION_REG + Const.bank] = 1;
            mem.ram[7, Const.OPTION_REG + Const.bank] = 1;

            mem.ram[0, Const.TRISA + Const.bank] = 1;
            mem.ram[1, Const.TRISA + Const.bank] = 1;
            mem.ram[2, Const.TRISA + Const.bank] = 1;
            mem.ram[3, Const.TRISA + Const.bank] = 1;
            mem.ram[4, Const.TRISA + Const.bank] = 1;

            mem.ram[0, Const.TRISB + Const.bank] = 1;
            mem.ram[1, Const.TRISB + Const.bank] = 1;
            mem.ram[2, Const.TRISB + Const.bank] = 1;
            mem.ram[3, Const.TRISB + Const.bank] = 1;
            mem.ram[4, Const.TRISB + Const.bank] = 1;
            mem.ram[5, Const.TRISB + Const.bank] = 1;
            mem.ram[6, Const.TRISB + Const.bank] = 1;
            mem.ram[7, Const.TRISB + Const.bank] = 1;
        }

        public void ResetRegister()
        {
            mem.WReg = 0;
            mem.pc = 0;
        }

    }
}
