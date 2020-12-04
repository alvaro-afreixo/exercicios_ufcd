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
            Boolean validaNum1;
            Boolean validaNum2;
            Boolean validaOp;
            Boolean validaOptFinal;
            Boolean calcContinua = true;
            int indiceArray=0;
            float[] histNum1 = new float[3];
            float[] histNum2 = new float[3];
            string[] histOp = new string[3];


            while (calcContinua)
            {
                validaNum1 = false;
                while (validaNum1 == false)
                {
                    Console.WriteLine("insira um numero inteiro\n");
                    var aux = Console.ReadLine();
                    validaNum1 = float.TryParse(aux, out num1);
                    if (!validaNum1)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }
                validaNum2 = false;
                while (validaNum2 == false)
                {
                    Console.WriteLine("insira um numero inteiro\n");
                    var aux = Console.ReadLine();
                    validaNum2 = float.TryParse(aux, out num2);
                    if (!validaNum2)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }
                validaOp = false;
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
                            if (indiceArray <= 2)
                            {
                                histNum1[indiceArray] = num1;
                                histNum2[indiceArray] = num2;
                                histOp[indiceArray] = op;
                                indiceArray++;
                            }
                            else
                            {
                                for (var i = 0; i < 2; i++)
                                {
                                    
                                    histNum1[i] = histNum1[i+1];    // descartar o historico mais antigo
                                    histNum2[i] = histNum2[i+1];
                                    histOp[i] = histOp[i];
                                    //indiceArray++;
                                }
                                histNum1[indiceArray-1] = num1;   //pode-se criar um metodo para preencher array
                                histNum2[indiceArray-1] = num2;   //
                                histOp[indiceArray-1] = op;       //
                            }
                            
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
                            Console.WriteLine("{ 0:N2}", resultado);
                            validaOp = true;
                            break;
                        default:
                            Console.WriteLine("escolha uma das operações da lista");
                            break;

                    }
                    // antes de cada ciclo reiniciar a variavel booleana
                    validaOptFinal = false;
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
                                for (var i = indiceArray-1; i >= 0; i--)
                                {
                                    Console.WriteLine("{0} {1} {2}", histNum1[i], histOp[i], histNum2[i]);

                                }

                                calcContinua = false;
                                validaOptFinal = true;
                                break;
                            case "cont":
                                calcContinua = true;
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
