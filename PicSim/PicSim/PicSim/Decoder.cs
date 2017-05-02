using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSim
{
    class Decoder
    {
        //Singleton
        private static Decoder instance;
        private Decoder() { }
        public static Decoder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Decoder();
                }
                return instance;
            }
        }
        Befehle befehle = new Befehle();

        public void Decode(int binCode)
        {
            //BYTE-ORIENTED FILE REGISTER OPERATIONS
            if ((binCode & 0x3F00) == 0x0700)
            {
                //ADDWF
                befehle.addwf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0500)
            {
                //ANDWF
                befehle.andwf(binCode);
                return;
            }
            if ((binCode & 0x3F80) == 0x0180)
            {
                //CLRF
                befehle.clrf(binCode);
                return;
            }
            if ((binCode & 0x3F80) == 0x0100)
            {
                //CLRW
                return;
            }
            if ((binCode & 0x3F00) == 0x0900)
            {
                //COMF
                befehle.comf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0300)
            {
                //DECF
                befehle.decf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0B00)
            {
                //DECFSZ
                return;
            }
            if ((binCode & 0x3F00) == 0x0A00)
            {
                //INCF
                befehle.incf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0F00)
            {
                //INCFSZ
                return;
            }
            if ((binCode & 0x3F00) == 0x0400)
            {
                //IORWF
                befehle.iorwf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0800)
            {
                //MOVF
                befehle.movf(binCode);
                return;
            }
            if ((binCode & 0x3F80) == 0x0080)
            {
                //MOVWF
                befehle.movwf(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0300)
            {
                //DECF
                return;
            }
            if (binCode == 0x0 || binCode == 0x20 || binCode == 0x40 || binCode == 0x60)
            {
                //NOP
                befehle.nop(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x0D00)
            {
                //RLF
                return;
            }
            if ((binCode & 0x3F00) == 0x0C00)
            {
                //RRF
                return;
            }
            if ((binCode & 0x3F00) == 0x0200)
            {
                //SUBWF
                return;
            }
            if ((binCode & 0x3F00) == 0x0E00)
            {
                //SWAPF
                return;
            }
            if ((binCode & 0x3F00) == 0x0600)
            {
                //XORWF
                return;
            }

            //BIT-ORIENTED FILE REGISTER OPERATIONS
            if ((binCode & 0x3C00) == 0x1000)
            {
                //BCF
                return;
            }
            if ((binCode & 0x3C00) == 0x1400)
            {
                //BSF
                return;
            }

            if ((binCode & 0x3C00) == 0x1800)
            {
                //BTFSC
                return;
            }
            if ((binCode & 0x3C00) == 0x1C00)
            {
                //BTFSS
                return;
            }

            //LITERAL AND CONTROL OPERATIONS
            if ((binCode & 0x3E00) == 0x3E00)
            {
                //ADDLW   
                befehle.addlw(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x3900)
            {
                //ANDLW    
                befehle.andlw(binCode);
                return;
            }
            if ((binCode & 0x3800) == 0x2000)
            {
                //CALL      
                befehle.call(binCode);
                return;
            }
            if (binCode == 0x64)
            {
                //CLRWDT                
                return;
            }
            if ((binCode & 0x3800) == 0x2800)
            {
                //GOTO        
                befehle.goto_(binCode);

                return;
            }
            if ((binCode & 0x3F00) == 0x3800)
            {
                //IORLW   
                befehle.iorlw(binCode);
                return;
            }
            if ((binCode & 0x3C00) == 0x3000)
            {
                //MOVLW   
                befehle.movlw(binCode);
                return;
            }
            if (binCode == 0x9)
            {
                //RETFIE                
                return;
            }
            if ((binCode & 0x3C00) == 0x3400)
            {
                //RETLW
                befehle.retlw(binCode);
                return;
            }
            if (binCode == 0x8)
            {
                //RETURN 
                befehle.return_(binCode);
                return;
            }
            if (binCode == 0x63)
            {
                //SLEEP
                return;
            }
            if ((binCode & 0x3E00) == 0x3C00)
            {
                //SUBLW     
                befehle.sublw(binCode);
                return;
            }
            if ((binCode & 0x3F00) == 0x3A00)
            {
                //XORLW       
                befehle.xorlw(binCode);
                return;
            }
            else
            {
                MessageBox.Show("Befehl nicht gefunden:" + binCode);
            }
        }
    }
}
