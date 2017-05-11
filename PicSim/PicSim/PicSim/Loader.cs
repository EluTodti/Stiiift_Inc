using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSim
{
    class Loader
    {     
        public static void LadeDatei(StreamReader streamReader)
        {

            Form1 form = Form1.getInstance();
            String stringtxt;
            String befehltxt = "";
            //Datei wird in String Variable gespeichert
            //stringtxt = streamReader.ReadToEnd();
            while (!streamReader.EndOfStream)
            {
                
                var row = new DataGridViewRow();

                string aktuelleZeile = streamReader.ReadLine();
                befehltxt += aktuelleZeile +"\n";
                string hexCode = aktuelleZeile.Substring(5, 4);
                string programmzeile = aktuelleZeile.Substring(0, 4);
                string code = aktuelleZeile.Substring(26);
                form.LadeInDGVCode(row, programmzeile, code, hexCode);
            }
            MessageBox.Show(befehltxt);
            BefehleExtrahieren(befehltxt);
        }


        private static void BefehleExtrahieren(String stringtxt)
        {
            //String wird in char Array geschrieben
            Memory mem = Memory.Instance;
            char[] chartxt = new char[stringtxt.Length];

            chartxt = stringtxt.ToCharArray(0, stringtxt.Length);

            int arrIndex = 0;
            for (int i = 0; i < chartxt.Length; i++)
            {
                if (chartxt[i] == 32)
                {
                    //Index bis zum Ende der Zeile
                    for (int a = i; a < chartxt.Length; a++)
                    {
                        if (chartxt[a] == '\n')
                        {
                            i++;
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    i += 4; //Zeilennummer im Index i überspringen
                    char[] chars = { chartxt[i], chartxt[i + 1], chartxt[i + 2], chartxt[i + 3] };
                    string hexString = new string(chars);

                    int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                    //Befehle werden in Array gespeichert                        
                    mem.BefehlsArray[arrIndex] = num;
                    arrIndex += 1;

                    //Index bis zum Ende der Zeile
                    for (int a = i; a < chartxt.Length; a++)
                    {
                        if (chartxt[a] == '\n')
                        {
                            i++;
                            break;
                        }
                        i++;
                    }
                }
            }
        }
    }
}
