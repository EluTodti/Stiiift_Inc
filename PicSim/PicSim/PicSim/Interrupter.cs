namespace PicSim
{
    class Interrupter
    {
        #region Singleton
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
        #endregion Singleton
        #region Init
        private Memory mem = Memory.Instance;
        Befehle befehle = Befehle.Instance;
        #endregion Init

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
            if (InterruptINT() || InterruptPORTB()||InterruptEEPROM() || InterruptTMR0())
            {
                return true;
            }
            return false;
        }

        #region Abfrage einzelne Interrupt bits
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

        //Check TMR0 Interrupt
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

        //Check INT Interrupt (RB0/INT)
        private bool InterruptINT()
        {
            //INT INTERRUPT
            if (mem.ram[4, Const.INTCON ]==1)
            {
                if (mem.ram[1, Const.INTCON] == 1)
                {
                    return true;
                }
            }
            return false;
            //TODO : The status of the GIE bit decides whether the processor branches to the interrupt vector following wake-up
        }

        //Check Interrupt PortB<7-4>
        private bool InterruptPORTB()
        {
            //RBIE set?
            if (mem.ram[3,Const.INTCON] == 1)
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
        #endregion Abfrage einzelne Interrupt bits

    }
}
