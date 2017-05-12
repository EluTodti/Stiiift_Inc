using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSim
{
    class SerialPorts
    {
        Befehle befehle = Befehle.Instance;

        private System.IO.Ports.SerialPort comPort;

        public SerialPorts(string PortName)
        {
            comPort = new System.IO.Ports.SerialPort(PortName, 4800, Parity.None, 8, StopBits.One);
        }

        public int CarriageReturn = 0x0D;
        private int UnteresNibble = 0;
        private int OberesNibble = 0;
        private string input ="";
        #region Funktionen 
        public int HoleUnteresNibble(int Wert)
        {
            return (Wert & 15) + 0x30;
        }
        public int HoleOberesNibble(int Wert)
        {
            return (Wert >> 4) + 0x30;
        }
        private int HoleFileValue(int FileAddress)
        {
            return befehle.getFileVal(FileAddress);
        }
        private string ZuSendendeDaten()
        {
            string ONTrisA = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.TRISA + 128)));
            string UNTrisA = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.TRISA + 128)));
            string ONPortA = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.PORTA)));
            string UNPortA = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.PORTA)));
            string ONTrisB = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.TRISB + 128)));
            string UNTrisB = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.TRISB + 128)));
            string ONPortB = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.PORTB)));
            string UNPortB = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.PORTB)));

            return ONTrisA + UNTrisA + ONPortA + UNPortA + ONTrisB + UNTrisB + ONPortB + UNPortB + CarriageReturn;
        }
        private string KonvertiereZuASCII(int Zeichen)
        {
            string helper = "";
            return helper + Convert.ToChar(Zeichen); //Damit automatisch ein String returnt wird
        }


        //ON = OberesNibble UN = UnteresNibble  CR = CarriageReturn
        public void PCsenden()  //Tris und Portinfoss
        {
            //SendLine
            //ONTrisA UNTrisA, ONPortA UNPortA, ONTrisB UNTrisB, ONPortB UNTrisB, CR
            if (!comPort.IsOpen)
            {
                comPort.Open();
            }
            comPort.Write(ZuSendendeDaten());
       }

        public void open()
        {
            comPort.Open();
        }
        public void PCempfangen()
        {
            //GetLine
            //ONPortA UNPortA, ONPortB UNPortB, CR
            input = comPort.ReadTo("" + Convert.ToChar(CarriageReturn));
            DecodeDaten();
        }

        private void DecodeDaten()
        {
            MessageBox.Show(input);
        }

#endregion

    }
}
