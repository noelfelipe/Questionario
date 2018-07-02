using System;
using System.Collections.Generic;
using System.IO;

namespace ListaDeArquivos
{
    class Telefone
    {
        public string Tel { get; set; }
        public string Alocado { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Telefone> lista = new List<Telefone>();

            string[] arquivos = Directory.GetFiles("C:\\Users\\noel.silva\\Desktop\\Telefones", "*txt");

            foreach (string arq in arquivos)
            {

                Telefone telefone = new Telefone();

                StreamReader s;

                string Arquivos = arq;

                s = File.OpenText(Arquivos);

                string tel = s.ReadLine();

                telefone.Alocado = arq;
                telefone.Tel = tel;

                lista.Add(telefone);

            }

            foreach (var item in lista)
            {
                Console.WriteLine(@"Telefone: {0};      Arquivo: {1};", item.Tel, item.Alocado);
                Console.WriteLine(@"----------------------------------------------------------");
            }


            Console.ReadKey();

        }
    }
}


