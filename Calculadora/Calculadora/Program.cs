using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true) 
            {
                Console.WriteLine("Peso: \r"); // será exibido na tela
                float valor = float.Parse(Console.ReadLine());
                Console.Write("\n");
                Console.WriteLine("ID Corante: \r");
                string id = Console.ReadLine();
                Console.Write("\n");

                if (id == "c0074")
                {
                    Console.Write("C0074 AMARELO DISPERSIL M-4GN \n\r");
                    float tecido1 = valor * (0.4000f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0105")
                {
                    Console.Write("C0105 AMARELO CORAFIX MER \n\r");
                    float tecido1 = valor * (0.5000f / 100);
                    Console.WriteLine("Valor na receita: " + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0146")
                {
                    Console.Write("C0146 PINK RHODAMINA DISP. 5BF \n\r");
                    float tecido1 = valor * (0.1000f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0686")
                {
                    Console.Write("C0686 VERMELHO AVINYL C-RS \n\r");
                    float tecido1 = valor * (0.0070f / 100);
                    Console.WriteLine("Valor na receita: " + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0862")
                {
                    Console.Write("C0862 AMARELO COLOCID 3RL 100% \n\r");
                    float tecido1 = valor * (0.1200f / 100);
                    Console.WriteLine("Valor na receita: " + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0885")
                {
                    Console.Write("C0885 PRETO  REMAZOL SAM \n\r");
                    float tecido1 = valor * (6.0000f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0887")
                {
                    Console.Write("C0887 LARANJA CORAFIX GD ULTRA \n\r");
                    float tecido1 = valor * (0.3700f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0888")
                {
                    Console.Write("C0888 VERMELHO CORAFIX MEGF \n\r");
                    float tecido1 = valor * (0.1300f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0889")
                {
                    Console.Write("C0888 MARINHO CORAFIX GDG \n\r");
                    float tecido1 = valor * (0.0250f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0987")
                {
                    Console.Write("C0987 VERMELHO DISPERSIL M-BS \n\r");
                    float tecido1 = valor * (0.0600f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                if (id == "c0998")
                {
                    Console.Write("C0998 AZUL ACINYL C-RL \n\r");
                    float tecido1 = valor * (0.0038f / 100);
                    Console.WriteLine("Valor na receita" + "\n\r" + tecido1 + "\n\r\n\r");
                    Console.Write("\n");

                    Console.WriteLine("Qual a % da Remonta: \r");
                    float remonta = float.Parse(Console.ReadLine());
                    Console.Write("\n");

                    float resultado = tecido1 * (remonta / 100);
                    Console.WriteLine("Remonta: \n" + resultado);
                    Console.Write("\n");

                }
                Console.WriteLine("Precione a tecla ENTER pra iniciar novamente!!!! \n");
                Console.ReadKey();  
            }
        }
    }
}
