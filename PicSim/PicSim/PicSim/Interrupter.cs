using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSim
{
    class Interrupter
    {
        private static Interrupter instance;

        public static Interrupter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Interrupter();
                }
                return instance;
            }
        }


        private Memory mem = Memory.Instance;
        Befehle befehle = Befehle.Instance;
        /*Initialisierung
        public bool INTRB0 = false;
        public bool INTRB4 = false;
        public bool INTRB5 = false;
        public bool INTRB6 = false;
        public bool INTRB7 = false;
        */

        public void CheckInterrupt()
        {
            //Für sleep - Unterbrechung
            if (CheckOtherInterrupts())
            {
                //PD BIT
                mem.ram[3, Const.STATUS] = 1;
            }
            //Wenn True Interrupt an Prozessor
            if (InterruptGIE() && CheckOtherInterrupts())
            {

                //clear GIE damit keine Interrupts mehr möglich
                mem.ram[7, Const.INTCON] = 0;

                mem.pc++;
                //Adresse 4 laden - Interrupt Service Routine
                befehle.call(0x04);
            }
        }

        //Siehe PIC16F84A Dokumentation, Abbildung 6-10 "INTERRUPT LOGIC"
        private bool CheckOtherInterrupts()
        {
            //TMR0 kann Sleep nicht unterbrechen, steht aber in der Abbildung so ¯\_(ツ)_/¯
            if (InterruptINT() || InterruptPORTB() || InterruptEEPROM() || InterruptTMR0())
            {
                return true;
            }
            return false;
        }



        //------------------------------------Abfragen einzelner Interrupt bits-----------------------------
        //Check GIE
        //Wenn GIE gesetzt
        private bool InterruptGIE()
        {
            if (mem.ram[7, Const.INTCON] == 1)
            {
                return true;
            }
            return false;
        }

        private bool InterruptTMR0()
        {
            //Wenn T0IE gesetzt sind TMR0 Interrupts möglich
            if (mem.ram[5, Const.INTCON] == 1)
            {
                //Wenn TMR0 überläuft wird T0IF gesetzt, was TMR0 Interrupt auslöst
                if (mem.ram[2, Const.INTCON] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private bool InterruptINT()
        {
            if (mem.ram[4, Const.INTCON] == 1)
            {
                if (mem.ram[1, Const.INTCON] == 1)
                {
                    return true;
                }
            }
            return false;
            //TODO : The status of the GIE bit decides whether the processor branches to the interrupt vector following wake-up
        }

        private bool InterruptPORTB()
        {
            //RBIE set?
            if (mem.ram[3, Const.INTCON] == 1)
            {
                //RBIF Set wenn interrupt bei RB4-7
                if (mem.ram[0, Const.INTCON] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private bool InterruptEEPROM()
        {
            //EEIE gesetzt und somit Interrupt erlaubt?
            if (mem.ram[6, Const.INTCON] == 1)
            {
                //EEIF gesetzt? (completion of a data EEPROM write cycle)
                if (mem.ram[4, Const.EECON1 + 128] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public void CheckRA4()
        {
            mem.Ra4old = mem.ram[4, Const.PORTA];

            if (mem.Ra4old == 1 && mem.Ra4new == 0)
            {
                mem.Ra4Flanke = 1;
            }

            if (mem.Ra4old == 0 && mem.Ra4new == 1)
            {
                mem.Ra4Flanke = 2;
            }

            mem.Ra4new = mem.ram[4, Const.PORTA];
        }

        public void CheckRB0()
        {
            mem.Rb0old = mem.ram[0, Const.PORTB];

            if (mem.ram[0, Const.OPTION_REG + 128] == 0) //falling
            {
                if (mem.Rb0old == 1 && mem.Rb0new == 0)
                {
                    mem.ram[1, Const.INTCON] = 1;
                }
            }
            else //rising
            {
                if (mem.Rb0old == 0 && mem.Rb0new == 1)
                {
                    mem.ram[1, Const.INTCON] = 1;
                }
            }

            mem.Rb0new = mem.ram[0, Const.PORTB];
        }
        public void ChechRB47()
        {
            mem.Rb4old = mem.ram[4, Const.PORTB];
            mem.Rb5old = mem.ram[5, Const.PORTB];
            mem.Rb6old = mem.ram[6, Const.PORTB];
            mem.Rb7old = mem.ram[7, Const.PORTB];

            if (mem.ram[4, Const.TRISB] == 1) //falls input
            {
                if (mem.Rb4old != mem.Rb4new)
                    mem.ram[0, Const.INTCON] = 1;
            }
            if (mem.ram[5, Const.TRISB] == 1) //falls input
            {
                if (mem.Rb5old != mem.Rb5new)
                    mem.ram[0, Const.INTCON] = 1;
            }
            if (mem.ram[6, Const.TRISB] == 1) //falls input
            {
                if (mem.Rb6old != mem.Rb6new)
                    mem.ram[0, Const.INTCON] = 1;
            }
            if (mem.ram[7, Const.TRISB] == 1) //falls input
            {
                if (mem.Rb7old != mem.Rb7new)
                    mem.ram[0, Const.INTCON] = 1;
            }

            mem.Rb4new = mem.ram[4, Const.PORTB];
            mem.Rb5new = mem.ram[5, Const.PORTB];
            mem.Rb6new = mem.ram[6, Const.PORTB];
            mem.Rb7new = mem.ram[7, Const.PORTB];

        }
    }
}
