using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        public static void ExecutarAgenda()
        {
            var pessoas = new List<string>();

            int controle = 0;
            while (controle != 5) {
                Console.Clear();
                Console.Write("Bem Vindo a Agenda\n" +
                    "1 - Adicionar Registro\n2 - Alterar Registro\n3 - Remover Registro\n4 - Exibir Registros\n5 - Sair da Agenda\nDigite a opção desejada:\n");
                controle = Convert.ToInt32(Console.ReadLine());

                switch (controle)
                {
                    case 1: // Adicionar
                        Adicionar(pessoas);
                        break;

                    case 2: // Alterar
                        Alterar(pessoas);
                        break;

                    case 3: // Remover
                        Remover(pessoas);
                        break;

                    case 4: // Exibir
                        Exibir(pessoas);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

            Console.ReadKey();
        }

        private static void Adicionar(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Registro\nDigite na mesma linha o nome a ser adicionada: ");
            lista.Add(Console.ReadLine());
        }

        private static void Alterar(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("2 - Alterar Registro\n--------------------\n");
            Exibir(lista);

            Console.WriteLine("\n--------------------\nDigite o indice numérico do registro a ser alterado: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Registro: " + lista[indice] + "\nDigite na mesma linha os novos dados:");
            lista[indice] = Console.ReadLine();
            Console.ReadKey();
        }

        private static void Remover(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("2 - Alterar Registro\n--------------------\n");
            Exibir(lista);

            Console.WriteLine("\n--------------------\nDigite o indice numérico do registro a ser removido: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            lista.RemoveAt(indice);
            Console.ReadKey();
        }

        private static void Exibir(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("4 - Exibir Registros\n--------------------\n");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista.IndexOf(lista[i]) + " - " + lista[i]); ;
            }
        }
    }
}
