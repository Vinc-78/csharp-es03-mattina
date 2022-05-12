using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        private int iDimensioneFinestra = 10;
        private string StringaCorrente = "";

        public ShowMessage(int iDimensioneFinestra, string StringaCorrente)
        {
            this.iDimensioneFinestra = iDimensioneFinestra;
            this.StringaCorrente = StringaCorrente;
        }

        public ShowMessage(int iDimensioneFinestra)
        {
            this.iDimensioneFinestra = iDimensioneFinestra;
            this.StringaCorrente = "";
        }

        public void AppendMessage(string addString)
        {

            int capo = this.iDimensioneFinestra;

            this.StringaCorrente = this.StringaCorrente + " " + addString;

            int contatore = 0;

            foreach (char c in this.StringaCorrente)
            {
                if (contatore == capo)
                {
                    Console.WriteLine();
                    contatore = 0;
                }
                else
                {
                    Console.Write(c);
                    contatore++;
                }

            }



        }

        ~ShowMessage() //distruttore
        {
            Console.WriteLine("I am destructor and I clean the resources and free up memory as soon as program closed");
            Console.ReadLine();
        }

    }
}
