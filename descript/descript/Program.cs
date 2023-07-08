using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Descriptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            string mess, cripto;
            int i, letra;

            cripto = "";
            mess = "";
            letra = 0;

            Console.WriteLine("\n************************  PROGRAMA PARA DESCRIPTOGRAFIA  ***********************");
            string docDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileDir = Path.Combine(docDir, "mensagem.txt");
            using (StreamReader REC = new StreamReader(fileDir))
            {
                mess = REC.ReadLine();
            }

            for (i = 0; i < mess.Length; i++)
            {
                letra = Convert.ToInt32(mess[i]) / 2;

                cripto = cripto + Convert.ToChar(letra);
            }

            Console.WriteLine("Mensagem descriptografada >>> {0}", cripto);
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}