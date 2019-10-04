using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInserimento
{
    class Inserimento
    {
        public static int InsertOperazioni(int n1, int n2)
        {
            bool control = true;
            int risultato = 0;
            string ris;
            do {
                //MENU CALCOLATRICE
                Console.WriteLine("Benvenuti in Umana Calculator.\n" +
                                  "Puoi scegliere 5 operazioni:\n" +
                                  "1.SOMMA\n" +
                                  "2.SOTTRAZIONE\n" +
                                  "3.MOLTIPLICAZIONE\n" +
                                  "4.DIVISIONE CON RESTO\n" +
                                  "5.DIVISIONE SENZA RESTO\n" +
                                  "Scegli quale operazione desidera eseguire:");
                ris = Console.ReadLine();
               

                //CONTROLLI SUI COMANDI CHE L'UTENTE ESEGUIRE (o clicca i numeri o i segni)
                if (ris == "1")
                {
                    risultato = n1 + n2;
                    return risultato;
                    control = false;
                }
                else if (ris == "2")
                {
                    risultato = n1 - n2;
                    return risultato;
                    control = false;
                }
                else if (ris == "3")
                {
                    risultato = n1 *(n2);
                    return risultato;
                    control = false;
                }

                else if (ris == "4")
                {
                    risultato = (n1/n2);
                    return risultato;
                    control = false;
                }

                else if (ris == "5")
                {
                    risultato = n1%n2;
                    return risultato;
                    control = false;
                }
                else
                {
                    Console.WriteLine("Hai sbagliato!");
                }

            }
            while (control) ;
            return risultato;
        }
    }
}
