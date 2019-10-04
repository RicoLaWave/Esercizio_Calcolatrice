using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalcolatrice;
using MyInserimento;
using MyOperazioni;


namespace MyOperazioni
{
    class Operazioni
    {

        public static int InserisciNum()
        {
            int x = 0;
            string numero;
            bool successo;
            do
            {
                Console.WriteLine("Caro Utente, inserisci il num e premi invio");
                string numero1 = Console.ReadLine();
                successo = Int32.TryParse(numero1, out x);

                if (successo == false)
                {
                    Console.WriteLine("Il valore inserito non è corretto! RIPROVARE!");
                }
            }
            while (successo == false);
            return x;
        }
    }





}
}
