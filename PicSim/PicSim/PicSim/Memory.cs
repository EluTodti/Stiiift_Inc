using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSim
{
    class Memory
    {
        //Singleton
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

        //Spezialregister
        public int pc = 0;

        public int WReg = 0;

        public Stack<int> Stack = new Stack<int>();
        public int[] StackArray = new int[8];
        public int[] StackArrayHelper = new int[8];

        public int[] BefehlsArray = new int[666];
        public int[,] ram = new int[8, 256];

        public void setWReg(int val)
        {
            //TODTDO: CARRY checken
            //Umgang mit negativen Werten
            if (val < 0)
            {
                while (val < 0)
                {
                    WReg = 256 + val;
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

        public bool statusdurchgang = true;

        //RegisterSynchronisieren bei Adressierung
        //eingefügt in befehle.schreibeInRam();
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

        public void CheckRegister()
        {
            //PD Bit checken
            if (ram[3, Const.STATUS] == 0)
            {
                //TODO den PIC schlafen lassen, bis powerup oder clrwdt
                //TODO Backgroundworker anhalten
                while (true)
                {
                    //Wenn clrwdt --> PD = 1
                    if (ram[3,Const.STATUS] == 1)
                    {
                        return;
                    }
                    //TODO evtl sleep einbauen?
                }
            }
        }
    }

}
