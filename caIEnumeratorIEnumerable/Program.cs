using System;
using System.Collections;

namespace caIEnumeratorIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPai pai = new clsPai();

            pai.Nome = "Theodoro";
            pai.Idade = 79;

            Console.WriteLine("Nome do Pai: {0}", pai.Nome);
            Console.WriteLine("Idade do Pai: {0}", pai.Idade);
            Console.WriteLine("");

            //Só é possível percorrer pelo foreach elementos Enumerable 
            //que implementam o método GetEnumerator();
            Console.WriteLine(">> LISTA DE FILHOS <<");
            Console.WriteLine("");

            foreach (clsFilho filhos in pai)
            {
                Console.WriteLine("Nome : {0}", filhos.Nome);
                Console.WriteLine("Idade: {0}", filhos.Idade);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}