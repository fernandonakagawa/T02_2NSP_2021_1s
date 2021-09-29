using System;

namespace Projeto_Aula01
{
    class Program
    {
        static int global1, global2;
        static void Main(string[] args)
        {
            //Console.WriteLine("Oi mundo!");
            /*
             * 
             asdasdasdsadwqefzxkaksd
             * */
            /*
             * 
            int a;
            a = 10;
            int A = 20;
            string texto = "boa noite";
            bool logico = true;
            float numero = 3.14f;
            char caractere = 'x';

            const float PI = 3.14f;

            //int a;

            Console.WriteLine("Digite um texto");
            texto = Console.ReadLine();
            Console.WriteLine(texto + texto);

            Random rnd = new Random();
            int x = rnd.Next(10);
            Console.WriteLine(x);

            x += 10;
            Console.WriteLine(x);

            int y = 0;
            if(y == 0)
            {
                Console.WriteLine("y é igual a 0");
                //y = 1; desnecessário
            }
            else if(y == 1)
            {
                Console.WriteLine("y é igual a 1");
            }
            else
            {
                Console.WriteLine("y não é igual a 0");
            }

            y = 0;
            while(y < 10)
            {
                Console.Write(y + " ");
                y++;
            }

            y = 0;
            do
            {
                Console.WriteLine("Digite um número POSITIVO");
                y = int.Parse(Console.ReadLine());
            } while (y < 0);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            string[] textos = new string[5];
            textos[0] = "Capa";
            textos[1] = "Sumário";
            textos[2] = "Introdução";
            textos[3] = "Cap. 1";
            textos[4] = "Cap. 2";
            //textos[5] = "Referências";
            string[] textos2 = {"Capa", "Sumário", "Introdução",
            "Cap. 1", "Cap. 2"};

            for(int i = 0; i < textos.Length; i++)
            {
                Console.WriteLine(textos[i]);
            }

            foreach (string s in textos)
            {
                Console.WriteLine(s);
            }

            */

            Cumprimentar();
            Cumprimentar();
            Cumprimentar();

            CumprimentarNome("Andre");

            global1 = 3;
            global2 = 8;
            int res = Soma();
            Console.WriteLine(res);

            float valor = Juros(1000f, 0.08f);
            Console.WriteLine("O valor dos juros é de R$" + valor+".");
            Console.WriteLine("O valor dos juros a 5% é de R$" +
                Juros(1000f, 0.05f) + ".");
        }

        static void Cumprimentar()
        {
            Console.WriteLine("Olá!");
            Console.WriteLine("Que você tenha um bom dia!");
        }

        static void CumprimentarNome(string nome)
        {
            Console.WriteLine("Olá " + nome + "!");
            Console.WriteLine("Que você tenha um bom dia!");
        }

        static int Soma()
        {
            return global1 + global2;
        }

        static float Juros(float quantia, float juros)
        {
            float resultado = quantia * juros;
            return resultado;
        }

    }
    
}
