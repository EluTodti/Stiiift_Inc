using System;
using System.Collections.Generic;
using System.Linq;

namespace PicSim
{
    class Memory
    {
        #region Singleton
        private static Memory instance;
        private Memory()
        {
        }
        public static Memory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Memory();
                }
                return instance;
            }
        }
        #endregion
        //Spezialregister
        private int PC;
        public int pc
        {
            get
            {
                return PC;
            }
            set
            {
                PC = value;
                schreibePCInRam(Const.PCL,value);
            }
        }
        public int pcHelper
        {
            set
            {
                PC = value;
            }
        }
       private void schreibePCInRam(int f, int val)
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
            if (ram[5, Const.STATUS] == 1)
            {
                f = f + Const.bank;
            }
            for (int i = 0; i < 8; i++)
            {
                ram[i, f] = int.Parse(binVal[7 - i].ToString());
            }

            RegisterSynchronisieren(f, val);
        }
        public int WReg = 0;
        #region Stack
        public Stack<int> Stack = new Stack<int>();
        public int[] StackArray = new int[8];
        public int[] StackArrayHelper = new int[8];
        #endregion Stack
        #region StepBackInit
        //public Stack<Array> BackStack = new Stack<Array>();
        public int length = 256;        //mem.ram.length wirft exception, deshalb hard-coded
        public int BackCount = 0;
        public int[,,] BackArray = new int[8, 259, 100];
        public Stack<int> Stack_Backhelper = new Stack<int>();
        public bool BackEnabled = true;
        //0-255 = ram
        //256: 0:PC, 1:WReg, 2: Laufzeitzähler, 3: Quarzfrequenz 
        #endregion StepBackInit
        public int[] BefehlsArray = new int[666];
        public int[,] ram = new int[8, 256];
        #region Breakpoints
        //Breakpoints
        public int BPArrayIndex = 0;
        public int[] BreakPointArray = new int[10];
        #endregion Breakpoints
        #region Laufzeitzähler
        public double Laufzeitzaehler = 0;
        public double LaufzeitIntervall = 0;
        public double Quarzfrequenz = 2500;
        public void IncLaufzeitzaehler()
        {
            Laufzeitzaehler = Laufzeitzaehler * 1.0 + LaufzeitIntervall * 1.0;
        }
        #endregion Laufzeitzähler
        #region WDT
        public double watchdog = 0;
        public bool WDTTimeOut = false;
        public void IncWDT()
        {
            watchdog = watchdog * 1.0 + LaufzeitIntervall * 1.0;
        }
        public bool PrescalerTIMER0;
        public int prescaler = 0;
        #endregion WDT
        #region Timer0
        public int TimerValOld = 0;
        public int TimerValNew = 0;
        public int TimerInhibit = 0;
        public bool TwoCycles = false;
        public void decTimerInhibit()
        {
            TimerInhibit--;
        }
        #endregion Timer0
        #region RA4
        public int Ra4Flanke = 0;
        private int ra4new = 0;
        public int Ra4new
        {
            get
            {
                return this.ra4new;
            }
            set
            {
                this.ra4new = value;
            }
        }
        private int ra4old = 0;
        public int Ra4old
        {
            get
            {
                return this.ra4old;
            }
            set
            {
                this.ra4old = value;
            }
        }

        private int rb0new = 0;
        public int Rb0new
        {
            get
            {
                return rb0new;
            }
            set
            {
                rb0new = value;
            }
        }
        private int rb0old = 0;
        public int Rb0old
        {
            get
            {
                return rb0old;
            }
            set
            {
                value = rb0new;
            }
        }
        public bool Rb0Int = false;

        private int rb4new = 0;
        public int Rb4new
        {
            get
            {
                return rb4new;
            }
            set
            {
                rb4new = value;
            }
        }
        private int rb4old = 0;
        public int Rb4old
        {
            get
            {
                return rb4old;
            }
            set
            {
                value = rb4new;
            }
        }
        public bool Rb4Int = false;

        private int rb5new = 0;
        public int Rb5new
        {
            get
            {
                return rb5new;
            }
            set
            {
                rb4new = value;
            }
        }
        private int rb5old = 0;
        public int Rb5old
        {
            get
            {
                return rb5old;
            }
            set
            {
                value = rb5new;
            }
        }
        public bool Rb5Int = false;

        private int rb6new = 0;
        public int Rb6new
        {
            get
            {
                return rb6new;
            }
            set
            {
                rb6new = value;
            }
        }
        private int rb6old = 0;
        public int Rb6old
        {
            get
            {
                return rb6old;
            }
            set
            {
                value = rb6new;
            }
        }
        public bool Rb6Int = false;

        private int rb7new = 0;
        public int Rb7new
        {
            get
            {
                return rb7new;
            }
            set
            {
                rb7new = value;
            }
        }
        private int rb7old = 0;
        public int Rb7old
        {
            get
            {
                return rb7old;
            }
            set
            {
                value = rb7new;
            }
        }
        public bool Rb7Int = false;

        public void setWReg(int val)
        {
            //TODTDO: CARRY checken
            //Umgang mit negativen Werten
            if (val < 0)
            {
                while (val < 0)
                {
                    val = 256 + val;
                }

                WReg = val;
            }

            if (val > 255)
            {
                WReg = val & 0x00FF;
            }
            else
            {
                WReg = val;
            }
        }
        #endregion RA4
        public bool statusdurchgang = true;
        public void RegisterSynchronisieren(int fileadresse, int filevalue)
        {
            if (fileadresse == Const.INDF || fileadresse == Const.PCL || fileadresse == Const.STATUS
                || fileadresse == Const.FSR || fileadresse == Const.PCLATH || fileadresse == Const.INTCON)
            {

                //befehle.schreibeInRam(fileadresse,filevalue);
                if (filevalue > 255)
                {
                    filevalue = filevalue & 0x00FF;
                }

                string binVal = Convert.ToString(filevalue, 2);
                //Nullen werden bei String vorrangestellt bis 8 Zeichen
                while (binVal.Length < 8)
                {
                    binVal = binVal.Insert(0, "0");
                }
                binVal.ToArray(); //Array enthält immer 8 Bit

                for (int i = 0; i < 8; i++)
                {
                    ram[i, fileadresse + Const.bank] = int.Parse(binVal[7 - i].ToString());
                }
            }
            if (fileadresse - 128 == Const.INDF || fileadresse - 128 == Const.PCL || fileadresse - 128 == Const.STATUS
                || fileadresse - 128 == Const.FSR || fileadresse - 128 == Const.PCLATH ||
                fileadresse - 128 == Const.INTCON)
            {
                //befehle.schreibeInRam(fileadresse,filevalue);
                if (filevalue > 255)
                {
                    filevalue = filevalue & 0x00FF;
                }

                string binVal = Convert.ToString(filevalue, 2);
                //Nullen werden bei String vorrangestellt bis 8 Zeichen
                while (binVal.Length < 8)
                {
                    binVal = binVal.Insert(0, "0");
                }
                binVal.ToArray(); //Array enthält immer 8 Bit

                for (int i = 0; i < 8; i++)
                {
                    ram[i, fileadresse - 128] = int.Parse(binVal[7 - i].ToString());
                }
            }
        }
        #region StepBack
        public int CountOfStepsSafed = 0;
        public bool StepBackEnabled = true;
        public void SafeBack()
        {
            /* Mit Stack
            for (int adresse = 0; adresse < length; adresse++)
            {
                for (int bits = 0; bits < 8; bits++)
                {
                    BackArray[bits, adresse] = ram[bits, adresse];
                }
            }
            */
            //Mit Array
            if (CountOfStepsSafed < 100)
            {
                CountOfStepsSafed++;
            }
            Safe();
            BackCount++;
            //BackStack.Push(BackArray);

            //Ringarray
            if (BackCount == 100)
            {
                BackCount = 0;
            }
        }
        //Für SafeBack
        private void Safe()
        {
            for (int adresse = 0; adresse < length; adresse++)
            {
                for (int bits = 0; bits < 8; bits++)
                {
                    BackArray[bits, adresse, BackCount] = ram[bits, adresse];
                }
            }

            //Register
            //Siehe //StepBack
            BackArray[0, 256, BackCount] = pc;
            BackArray[1, 256, BackCount] = WReg;
            BackArray[2, 256, BackCount] = (int)Laufzeitzaehler;
            BackArray[3, 256, BackCount] = (int)Quarzfrequenz;
            BackArray[4, 256, BackCount] = TimerValOld;
            BackArray[5, 256, BackCount] = TimerValNew;
            BackArray[6, 256, BackCount] = TimerInhibit;
            BackArray[7, 256, BackCount] = (int)watchdog;
            BackArray[0, 258, BackCount] = prescaler;
            if (PrescalerTIMER0)
            {
                BackArray[1, 258, BackCount] = 1;
            }
            else
            {
                BackArray[1, 258, BackCount] = 0;
            }
            BackArray[2, 258, BackCount] = ra4old;
            BackArray[3, 258, BackCount] = ra4new;
            
            //Stack
            Stack_Backhelper = new Stack<int>(Stack.Reverse());
            for (int StackPos = 0; StackPos < 8; StackPos++)
            {
                try
                {
                    BackArray[StackPos, 257, BackCount] = Stack_Backhelper.Pop();

                }
                catch (InvalidOperationException)
                {
                    //Falls Stack leer
                }
            }
        }
        #endregion StepBack
    }

}
