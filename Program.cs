using System;

namespace csharp_es03_mattina
{
    internal class Program
    {

        static void Main(string[] args)  //entry point
        {
            /* Scrivere un classe che mostra a video un testo di stringhe dopo aver deciso 
            le dimensini/spazio del testo (ossia dopo quanti caratteri andare a capo)
             prevedere la possibilità di passare una stringa di partenza nell'istanza e 
            aggiungere delle stringhe richiamando il metodo e continuare a scrivere */

            ShowMessage frase = new ShowMessage(10, "Ciao");

            frase.AppendMessage("ho iniziato a ");

            frase.AppendMessage("scrivere un codice");


            /* Aggiungere una classe che forma un borsellino, ogni volta che
             chiamo il metodo Add(valore) il borsellino si incrementa del valore
            passato come parametro e lo stampo a schermo. La classe si chiama 
            Borsellino e il metodo int Add */

            int valore;

            string sValore = Console.ReadLine();
            valore = Convert.ToInt32(sValore);

            while (valore != 0) 
            
            {
                Console.WriteLine(Borsellino.Add(valore));
                sValore = Console.ReadLine();
                valore =Convert.ToInt32(sValore);
            }

        }

    }

}
