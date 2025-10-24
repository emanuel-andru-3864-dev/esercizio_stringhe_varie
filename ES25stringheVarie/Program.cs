using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES25stringheVarie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s= "ANNA MARIA GIOVANNA";
            //  0123456789012345678
            string s2;
            char c = 'A';
            int posizione;
            //VIS. LA/E POSIZIONE/I DELLA LETTERA A NELLA STRINGA S
            cercaLettera(s, c); // s c sono parametri attuali
            c = 'N';
            Console.WriteLine();
           posizione= cercaPrimaPosizione(s, c);
            if (posizione == -1)
                Console.WriteLine("NON C'E'");
            else
                Console.WriteLine("TROVATA NELLA POSIZIONE " + (posizione + 1).ToString());

           
            Console.WriteLine("\n");
            s2 = s.Substring(5);
            Console.WriteLine(s);
            Console.WriteLine(s2);

            s2 = s.Substring(5,3);
            Console.WriteLine(s2);
            //--fare splelling 
            Console.WriteLine("SPLELLING");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write( s.Substring(i,1)+ " ");
            }
            Console.WriteLine();
            //ricerco 1 carattere
            posizione = s.IndexOf("M");
            if (posizione == -1)
                Console.WriteLine("NON TROVATA");
            else
                Console.WriteLine("TROVATA IN POSIZIONE "+ (posizione+1).ToString());

            //X COMPITO: VIS. TUTTE LE POSIZIONI DELLA LETTERA N usando IndexOf con 2
            //--------------------------------------------------------------
            s2 = s.Replace("N", "_");
            Console.WriteLine(s2);
            Console.ReadKey();

        }

        private static int cercaPrimaPosizione(string s, char c)
        {
            //trovare la 1° posizione del carattere c nella stringa s
            int p = -1;
            int i = 0;
            do
            {
                if (c == s[i])
                    p = i;
                else
                    i = i + 1;
            }while (i < s.Length && p==-1);
            return p;
        }

        private static void cercaLettera(string s, char c)
        {               //   s  c sono parametri formali
            //variabili locali 
            //RICERCA SEQUENZIALE CON CARATTERI CHE SI POSSONO RIPETERE
            int i;
            bool trovato = false;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    Console.Write((i + 1).ToString() + " ");
                    trovato = true;
                }
            }
            if (!trovato)
                Console.WriteLine($"il carattere {c} in {s} NON C'E'");
        }
    }
}
