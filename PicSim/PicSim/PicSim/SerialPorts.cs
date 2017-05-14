using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace PicSim
{
    class SerialPorts
    {
        Befehle befehle = Befehle.Instance;

        private System.IO.Ports.SerialPort comPort;

        public SerialPorts(string PortName)
        {
            comPort = new System.IO.Ports.SerialPort(PortName, 4800, Parity.None, 8, StopBits.One);
            comPort.ReadTimeout = 500;
            comPort.WriteTimeout = 500;
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
            return ((Wert >> 4) & 0xF) + 0x30;
        }
        private int HoleFileValue(int FileAddress)
        {
            return befehle.getFileVal(FileAddress);
        }
        private string ZuSendendeDaten()
        {
            string ONTrisA = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.TRISA + 128))); // 31h = 11 0001
            string UNTrisA = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.TRISA + 128))); // 3Fh = ? -als Ascii Zeichen 11 1111
            string ONPortA = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.PORTA))); //30h = 0
            string UNPortA = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.PORTA))); //30h = 0
            string ONTrisB = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.TRISB + 128))); // 3Fh = ? -als Ascii Zeichen 11 1111
            string UNTrisB = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.TRISB + 128))); // 3Fh = ? -als Ascii Zeichen 11 1111
            string ONPortB = KonvertiereZuASCII(HoleOberesNibble(HoleFileValue(Const.PORTB))); //30h = 0
            string UNPortB = KonvertiereZuASCII(HoleUnteresNibble(HoleFileValue(Const.PORTB))); //30h = 0
            //string CR = KonvertiereZuASCII(CarriageReturn);

            return ONTrisA + UNTrisA + ONPortA + UNPortA + ONTrisB + UNTrisB + ONPortB + UNPortB + CarriageReturn;
        }
        private string KonvertiereZuASCII(int Zeichen)
        {
            string helper = "";
            return helper + Convert.ToChar(Zeichen); //Damit automatisch ein String returnt wird
        }


        //ON = OberesNibble UN = UnteresNibble  CR = CarriageReturn
        public string PCsenden()  //Tris und Portinfoss
        {
            //SendLine
            //ONTrisA UNTrisA, ONPortA UNPortA, ONTrisB UNTrisB, ONPortB UNTrisB, CR
            //if (!comPort.IsOpen)
            //{
            //    comPort.Open();
            //}
            if (comPort.IsOpen)
            {
                return ZuSendendeDaten();
                //comPort.Write(ZuSendendeDaten());
            }
            return "Error";
        }


        public string PCempfangen()
        {
            //GetLine
            //ONPortA UNPortA, ONPortB UNPortB, CR
            //input = comPort.ReadTo("" + CarriageReturn);
            input = comPort.ReadLine();
            DecodeDaten(input);
            return input;
        }

        private void DecodeDaten(string Empfangen)
        {
            MessageBox.Show(Empfangen);
            //Zeichen extrahieren
            string RecONPortA = Empfangen.Substring(0, 1); 
            string RecUNPortA = Empfangen.Substring(1, 1);
            string RecONPortB = Empfangen.Substring(2, 1);
            string RecUNPortB = Empfangen.Substring(3, 1);
            //DecodeStringZuHex();
            DecodeHexstringZuInt(RecONPortA, RecUNPortA, RecONPortB, RecUNPortB);
        }

        private void DecodeHexstringZuInt(string _RecONPortA, string _RecUNPortA, string _RecONPortB, string _RecUNPortB)
        {
            //Strings zusammenführen
            string PortA = _RecONPortA + _RecUNPortA;
            string PortB = _RecONPortB + _RecUNPortB;
            //Strings in Int umwandeln
            //int WPortA = Int32.Parse()
            PortA = (Convert.ToString(Convert.ToInt32(PortA, 16), 2));
            PortB = (Convert.ToString(Convert.ToInt32(PortB, 16), 2));
        }
        //private void DecodeStringZuHex(string _RecONPortA, string _RecUNPortA, string _RecONPortB, string _RecUNPortB)
        //{
        //    //Zeichen in Hex umwandeln
        //    int DecONPortA = Int32.Parse(_RecONPortA, System.Globalization.NumberStyles.HexNumber);
        //    int DecUNPortA = Int32.Parse(_RecUNPortA, System.Globalization.NumberStyles.HexNumber);
        //    int DecONPortB = Int32.Parse(_RecONPortB, System.Globalization.NumberStyles.HexNumber);
        //    int DecUNPortB = Int32.Parse(_RecUNPortB, System.Globalization.NumberStyles.HexNumber);
        //    DecodeHexZuBinaer(DecONPortA, DecUNPortA, DecONPortB, DecUNPortB);
        //}
        //private void DecodeHexZuBinaer(int _RecONPortA, int _RecUNPortA, int _RecONPortB, int _RecUNPortB)
        //{
        //    string WONPortA = Convert.ToString(_RecONPortA,2);
        //    string WUNPortA = Convert.ToString(_RecUNPortA, 2);
        //    string WONPortB = Convert.ToString(_RecONPortB, 2);
        //    string WUNPortB = Convert.ToString(_RecUNPortB, 2);
        //    SchreibeInRAM(WONPortA, WUNPortA, WONPortB, WUNPortB);
        //}
        private void SchreibeInRAM(string _WPortA, string _WPortB)
        {
            befehle.schreibeInRam(Const.PORTA, );
        }

        public string ReadLine()
        {
            return comPort.ReadLine();
        }
        public void Open()
        {
            try
            {
            comPort.Open();
            }
            catch
            {
                MessageBox.Show("Comport ist schon geöffnet");
            }            
        }
        public void Close()
        {
            comPort.Close();
        }
        #endregion

    }
}
