using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOperazioni;
using MyInserimento;

namespace MyCalcolatrice
{
    class Program
    {
        public static void Main (string[] args)
        {
            int op;
            Console.WriteLine("Benvenuto in UMANA CALCULATOR!");

            int num1 = Operazioni.InserisciNum();
            Console.WriteLine(num1);
            int num2 = Operazioni.InserisciNum();
            Console.WriteLine(num2);

       
            op = Inserimento.InsertOperazioni(num1,num2);
   
            Console.WriteLine("Il risultato è:" +op);
            Console.ReadLine();
        }
    }
}
