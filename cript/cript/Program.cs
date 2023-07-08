using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Criptografia
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

            Console.WriteLine("\n*************************  PROGRAMA PARA CRIPTOGRAFIA  *************************");
            Console.WriteLine("\nDigite a sua mensagem em até 128 caracteres\n");

            mess = Console.ReadLine();

            if (mess.Length > 128)          // Define o limite de caracteres da mensagem
            {
                Console.WriteLine("\nERRO. A mensagem deve conter no MÁXIMO 128 caracteres");
                Console.WriteLine("Por favor, feche o programa e tente novamente");
                Console.Write("\nPressione qualquer tecla para sair...");
            }
            else
            {
                for (i = 0; i < mess.Length; i++)
                {
                    letra = Convert.ToInt32(mess[i]) * 2;

                    cripto = cripto + Convert.ToChar(letra);
                }
                string docDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileDir = Path.Combine(docDir, "mensagem.txt");
                using (StreamWriter MSG = new StreamWriter(fileDir, true))
                {
                    MSG.WriteLine(cripto);
                }

                Console.Write("\n\nMensagem criptografada com sucesso\n\nPressione qualquer tecla para sair...");

            }

            Console.ReadKey();

        }
    }
}
