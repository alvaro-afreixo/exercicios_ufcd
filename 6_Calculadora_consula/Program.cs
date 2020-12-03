using System;

namespace _6_Calculadora_consula
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            double resultado = 0.0;
            Boolean validaNum1 = false;
            Boolean validaNum2 = false;
            Boolean validaOp = false;
            Boolean validaOptFinal = false;
            Boolean calcContinua = true;
            int indiceArray;
            int[] histNum1;
            int[] histNum2 = new int[5];


            while (calcContinua)
            {
                while (validaNum1 == false)
                {
                    Console.WriteLine("insira um numero inteiro\n");
                    var aux = Console.ReadLine();
                    validaNum1 = float.TryParse(aux, out num1);
                    if (!validaNum1)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }
                while (validaNum2 == false)
                {
                    Console.WriteLine("insira um numero inteiro\n");
                    var aux = Console.ReadLine();
                    validaNum2 = float.TryParse(aux, out num2);
                    if (!validaNum2)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }

                while (!validaOp)
                {
                    Console.WriteLine("escolha a operação a realizar\n");
                    Console.WriteLine("\t'+'\n\t'-'\n\t'/'\n\t'*'\n");
                    var op = Console.ReadLine();

                    switch (op)
                    {
                        case "+":
                            Console.WriteLine(num1 + num2);
                            validaOp = true;

                            break;

                        case "-":
                            Console.WriteLine(num1 - num2);
                            validaOp = true;
                            break;

                        case "/":
                            resultado = num1 / num2;
                            Console.WriteLine(resultado);
                            validaOp = true;
                            break;
                        case "*":
                            resultado = num1 / num2;
                            Console.WriteLine(resultado);
                            validaOp = true;
                            break;
                        default:
                            Console.WriteLine("escolha uma das operações da lista");
                            break;

                    }
                    // antes de cada ciclo reiniciar a variavel booleana
                    while (!validaOptFinal)
                    {
                        Console.WriteLine("escolha uma das opções realizar\n");
                        Console.WriteLine("\t'sair'\n\t'hist' - mostra o historico das 5 ultimas operações\n\t'/'\n\t'cont' - voltar a fazer mais uma operação\n");
                        var selectOpt = Console.ReadLine();

                        switch (selectOpt)
                        {
                            case "sair":
                                calcContinua = false;
                                validaOptFinal = true;
                                break;

                            case "hist":
                                // imprimir historico e sair
                                //Console.WriteLine(num1 - num2);
                                //for
                                calcContinua = false;
                                validaOptFinal = true;
                                break;
                            default:
                                Console.WriteLine("escolha uma das operações da lista");
                                break;

                        }
                    }
                }
                Console.WriteLine(num1);
            }
        }
    }
}
