using System;

namespace _6_Calculadora_consula
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float resultado;
            Boolean validaNum1;
            Boolean validaNum2;
            Boolean validaOp;
            Boolean validaOptFinal;
            Boolean calcContinua = true;
            int indiceArray = 0;
            float[] histNum1 = new float[3];
            float[] histNum2 = new float[3];
            string[] histOp = new string[3];
            float[] histResultado = new float[3];


            while (calcContinua)
            {
                /*
                validaNum1 = false;
                // valida e regista o primeiro numero
                while (!validaNum1)
                {
                    Console.WriteLine("insira o primeiro numero \n");
                    var aux = Console.ReadLine();
                    validaNum1 = float.TryParse(aux, out num1);
                    if (!validaNum1)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }

                */

                num1 = ValidaNumero();
                /*
                validaNum2 = false;
                // valida e regista o segundo numero
                while (!validaNum2)
                {
                    Console.WriteLine("insira o segundo numero numero\n");
                    var aux = Console.ReadLine();
                    validaNum2 = float.TryParse(aux, out num2);
                    if (!validaNum2)
                        Console.WriteLine("Inseriu {0} que não é um numero", aux);
                }

                */

                num2 = ValidaNumero();


                validaOp = false;
                // Valida se o operador faz parte da lista  e calcula
                while (!validaOp)
                {
                    Console.WriteLine("escolha a operação a realizar\n");
                    Console.WriteLine("\t'+'\n\t'-'\n\t'/'\n\t'*'\n");
                    var op = Console.ReadLine();

                    // faz o calculo de acordo com a operação e armazena no historico
                    switch (op)
                    {
                        case "+":
                            resultado = num1 + num2;
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, resultado);
                            validaOp = true;
                            //preenchimento do array
                            if (indiceArray <= 2)
                            {
                                histNum1[indiceArray] = num1;
                                histNum2[indiceArray] = num2;
                                histOp[indiceArray] = op;
                                histResultado[indiceArray] = resultado;
                                indiceArray++;
                            }
                            else
                            {
                                for (var i = 0; i < 2; i++)
                                {

                                    histNum1[i] = histNum1[i + 1];    // descartar o historico mais antigo
                                    histNum2[i] = histNum2[i + 1];
                                    histOp[i] = histOp[i+1];
                                    histResultado[i] = histResultado[i + 1];
                                    //indiceArray++;
                                }
                                histNum1[indiceArray - 1] = num1;   //pode-se criar um metodo para preencher array
                                histNum2[indiceArray - 1] = num2;   //
                                histOp[indiceArray - 1] = op;       //
                                histResultado[indiceArray - 1] = resultado;
                            }

                            break;

                        case "-":
                            resultado = num1 - num2;
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, resultado);
                            validaOp = true;
                            //preenchimento do array
                            if (indiceArray <= 2)
                            {
                                histNum1[indiceArray] = num1;
                                histNum2[indiceArray] = num2;
                                histOp[indiceArray] = op;
                                histResultado[indiceArray] = resultado;
                                indiceArray++;
                            }
                            else
                            {
                                for (var i = 0; i < 2; i++)
                                {

                                    histNum1[i] = histNum1[i + 1];    // descartar o historico mais antigo
                                    histNum2[i] = histNum2[i + 1];
                                    histOp[i] = histOp[i + 1];
                                    histResultado[i] = histResultado[i + 1];
                                    //indiceArray++;
                                }
                                histNum1[indiceArray - 1] = num1;   //pode-se criar um metodo para preencher array
                                histNum2[indiceArray - 1] = num2;   //
                                histOp[indiceArray - 1] = op;       //
                                histResultado[indiceArray - 1] = resultado;
                            }
                            break;

                        case "/":
                            resultado = num1 / num2;
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, resultado);
                            validaOp = true;
                            //preenchimento do array
                            if (indiceArray <= 2)
                            {
                                histNum1[indiceArray] = num1;
                                histNum2[indiceArray] = num2;
                                histOp[indiceArray] = op;
                                histResultado[indiceArray] = resultado;
                                indiceArray++;
                            }
                            else
                            {
                                for (var i = 0; i < 2; i++)
                                {

                                    histNum1[i] = histNum1[i + 1];    // descartar o historico mais antigo
                                    histNum2[i] = histNum2[i + 1];
                                    histOp[i] = histOp[i + 1];
                                    histResultado[i] = histResultado[i + 1];
                                    //indiceArray++;
                                }
                                histNum1[indiceArray - 1] = num1;   //pode-se criar um metodo para preencher array
                                histNum2[indiceArray - 1] = num2;   //
                                histOp[indiceArray - 1] = op;       //
                                histResultado[indiceArray - 1] = resultado;
                            }
                            break;

                        case "*":
                            resultado = num1 * num2;
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, resultado);
                            validaOp = true;
                            //preenchimento do array
                            if (indiceArray <= 2)
                            {
                                histNum1[indiceArray] = num1;
                                histNum2[indiceArray] = num2;
                                histOp[indiceArray] = op;
                                histResultado[indiceArray] = resultado;
                                indiceArray++;
                            }
                            else
                            {
                                for (var i = 0; i < 2; i++)
                                {

                                    histNum1[i] = histNum1[i + 1];    // descartar o historico mais antigo
                                    histNum2[i] = histNum2[i + 1];
                                    histOp[i] = histOp[i + 1];
                                    histResultado[i] = histResultado[i + 1];
                                    //indiceArray++;
                                }
                                histNum1[indiceArray - 1] = num1;   //pode-se criar um metodo para preencher array
                                histNum2[indiceArray - 1] = num2;   //
                                histOp[indiceArray - 1] = op;       //
                                histResultado[indiceArray - 1] = resultado;
                            }
                            break;
                        default:
                            Console.WriteLine("escolha uma das operações da lista");
                            break;

                    }

                }
                // antes de cada ciclo reiniciar a variavel booleana
                validaOptFinal = false;
                // Valida se o opção final faz parte da lista  até darmos uma entrada válida
                while (!validaOptFinal)
                {
                    Console.WriteLine("escolha uma das opções realizar\n");
                    Console.WriteLine("\t'sair'\n\t'hist' - mostra o historico das 3 ultimas operações e sai\n\t'cont' - voltar a fazer mais uma operação\n");
                    var selectOpt = Console.ReadLine();
                    // realiza as tarefas de acordo com a escolha do utilizador
                    switch (selectOpt)
                    {
                        case "sair":
                            calcContinua = false;
                            validaOptFinal = true;
                            break;

                        case "hist":
                            // imprimir historico e sair
                            for (var i = indiceArray - 1; i >= 0; i--)
                            {
                                Console.WriteLine("{0} {1} {2} = {3:N3}", histNum1[i], histOp[i], histNum2[i], histResultado[i]);
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
        

        }

        //método para validar numero
        static float ValidaNumero()
        {
            bool validaNum;
            float num;
            do
            {
                Console.WriteLine("insira o primeiro numero \n");
                var aux = Console.ReadLine();
                validaNum = float.TryParse(aux, out num);
                if (!validaNum)
                    Console.WriteLine("Inseriu {0} que não é um numero", aux);
            } while (validaNum == false);
            return num;
        }
    }
}
