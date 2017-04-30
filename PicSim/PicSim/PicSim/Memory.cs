using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSim
{
    class Memory
    {
        //Singleton
        private static Memory instance;
        private Memory(){}
        public static Memory Instance
        {
            get
            {
                if(instance == null)
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

        public int[] BefehlsArray = new int[666];
        public int[,] ram = new int[8, 256];

    }
}
