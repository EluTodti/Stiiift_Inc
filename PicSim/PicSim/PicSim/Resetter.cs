using System.Linq;

namespace PicSim

{
    class Resetter
    { 
        Memory mem = Memory.Instance;
        Interrupter interrupter = Interrupter.Instance;

        public void Reset()
        {
            //ResetBefehlsArray(); nur am Anfang, hat hier nix zu suchen :)
            ResetRAM();
            ResetRegister();
            ResetStackArrays();
            ResetInterrupts();
            ResetBreakPoints();
            mem.BackCount = 0;
        }

        public void ResetBreakPoints()
        {
            for (int i = 0; i < mem.BreakPointArray.Length; i++)
            {
                mem.BreakPointArray[i] = 1000000;
            }
            mem.BPArrayIndex = 0;
        }

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
            mem.ram[3, Const.STATUS] = 1;
            mem.ram[4, Const.STATUS] = 1;

            mem.ram[3, Const.STATUS + Const.bank] = 1;
            mem.ram[4, Const.STATUS + Const.bank] = 1;

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
            mem.setWReg(0);
            mem.pc = 0;
            mem.Laufzeitzaehler = 0;
            mem.Quarzfrequenz = 4000000;
            mem.LaufzeitIntervall = (double)4.0/(mem.Quarzfrequenz/(double)1000000.0);
            mem.IncomingOverFlow = false;
            mem.TwoCycles = false;
            mem.prescaler = 0;
            mem.StepBackEnabled = true;
        }

        public void ResetStackArrays()
        {
            for (int i = 0; i < mem.StackArray.Length; i++)
            {
                mem.StackArray[i] = 0;
            }
            for (int i = 0; i < mem.StackArrayHelper.Length; i++)
            {
                mem.StackArrayHelper[i] = 0;
            }
            for (int i = 0; i < mem.Stack.Count(); i++)
            {
                mem.Stack.Pop();
            }
        }

        public void ResetInterrupts()
        {
            /*
            wird im RAM zurückgesetzt
            */
        }


    }
}
