using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Exercicios
{
    class Program
    {
        static void Main(string[] args)

        {

            string usuario;
            string usuario_senha;
            string usuario_1;
            string usuario_1_senha;
            int esc;

            Console.WriteLine("Bem-vindo ao Conrado's International Bank");
            Console.WriteLine("Opções: \n");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Login");
            Console.WriteLine("\nDigite uma opção: ");
            esc = int.Parse(Console.ReadLine());

            if (esc == 1)
            {

                Console.WriteLine("Digite o nome do novo usuário: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Digite a senha do novo usuário: ");
                usuario_senha = Console.ReadLine();
                Console.WriteLine("Usuário cadastrado com sucesso!");

                 
                Console.WriteLine("LOGIN DE USUÁRIO");
                Console.WriteLine("Digite o usuário: ");
                usuario_1 = Console.ReadLine();
                Console.WriteLine("Digite a senha: ");
                usuario_1_senha = Console.ReadLine();
                    if (usuario != usuario_1)
                    {
                        Console.WriteLine("Usuário ou senha incorretos.");
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);


                        if (usuario_senha != usuario_1_senha)
                        {

                            Console.WriteLine("Usuário ou senha incorretos.");
                            Console.ReadLine();
                            Console.Clear();
                            Main(null);

                        }

                    }
                    else
                    {
                        Console.WriteLine("Você fez login com sucesso.");
                    }
                            
            }
                
            Console.ReadKey();
        }

        static void Atividade() 
        {
        
            int numero;

            Console.WriteLine("Digite um numero de 1 a 10");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10){
                Console.WriteLine("Isto é ilegal. Tente novamente.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
                //return para e fecha o programa...
                //return;
            }
             
            Console.WriteLine("Obrigado, adeus.");
            Console.ReadKey();

        }
    }
}
