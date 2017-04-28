using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSim
{
    class Memory
    {
        private static Memory instance;
        private Memory()
        {

        }

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

        public int pc = 0;

        //Stack
        public Stack<int> Stack = new Stack<int>();
        //TODO Stack in GUI



    }
}
