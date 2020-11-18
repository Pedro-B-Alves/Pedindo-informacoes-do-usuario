using System;

namespace Pedindo_informacoes_do_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string senha;
            Console.WriteLine("Digite o seu nome de usuário");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua senha");
            senha = Console.ReadLine();
            bool Condicao = true;
            while(Condicao == true)
            {
                if (nome == senha)
                {
                   Console.WriteLine("Erro, você digitou a senha igual ao nome de usuário");
                   Console.WriteLine("Digite o seu nome de usuário");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite a sua senha");
                    senha = Console.ReadLine();
                }else
                {
                    Console.WriteLine("Você digitou o nome de usuário e a senha corretamente");
                    Condicao = false;
                }
            }
        }
    }
}
