namespace ATV4_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc_geral;

            Console.WriteLine("MENU DE EXERCÍCIOS\n1- EXERCÍCIO DA SALA DE AULA\n2- EXERCÍOCIO 1 - LISTA\n3- EXERCÍCIO 2 - LISTA\n4- EXERCÍCIO 3 - LISTA\n5- EXERCÍCIO 4 - LISTA\n6- EXERCÍCIO 5 - LISTA\n7- EXERCÍCIO 6 - LISTA ");
            opc_geral = int.Parse(Console.ReadLine());

            switch (opc_geral)
            {



                case 1:
                    Console.WriteLine("ATIVIDADE DA SALA DE AULA");

                    int opc;
                    float n1, n2, ad, sub, mult, div;

                    Console.WriteLine("VAMOS MONTAR UMA CALCULADORA.");
                    Console.WriteLine("Digite um número para n1: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um número para n2: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escolha qual operação você deseja efetuar: \n1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)

                    {
                        case 1:
                            Console.WriteLine("Você escolheu fazer uma adição");
                            ad = n1 + n2; 
                            Console.WriteLine("Adição = {0}", ad);

                            break;

                        case 2:
                            Console.WriteLine("Você escolheu fazer uma subtração");
                            sub = n1 - n2;
                            Console.WriteLine("Subtração = {0}", sub);

                            break;

                        case 3:
                            Console.WriteLine("Você escolheu fazer uma multiplicação");
                            mult = n1 * n2;
                            Console.WriteLine("Multiplicação = {0}", mult);

                            break;

                        case 4:
                            Console.WriteLine("Você escolheu fazer uma divisão");
                            div = n1 / n2;
                            Console.WriteLine("Divisão = {0}", div);

                            break;

                        default:
                            Console.WriteLine(" opção invalida");
                            break;


                    }
                    break;

                case 2:
                    Console.WriteLine("EXERCÍCIO 1 - LISTA");

                    int opc_ds;

                    Console.WriteLine("Digite um número de 1-7: ");
                    opc_ds = int.Parse(Console.ReadLine());

                    switch (opc_ds)
                    {

                        case 1:
                            Console.WriteLine("1 - Domingo");
                            break;

                        case 2:
                            Console.WriteLine("2 - Segunda - Feira");
                            break;
                        case 3:
                            Console.WriteLine("3 - Terça - Feira");
                            break;
                        case 4:
                            Console.WriteLine("4 - Quarta - Feira");
                            break;
                        case 5:
                            Console.WriteLine("5 - Quinta - Feira");
                            break;
                        case 6:
                            Console.WriteLine("6 - Sexta - Feira");
                            break;
                        case 7:
                            Console.WriteLine("7 - Sábado");
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("EXERCÍCIO 2 - LISTA");

                    int opc3;
                    float vtc,nv;

                    Console.WriteLine("digite o valor total da compra: ");
                    vtc = float.Parse(Console.ReadLine());
                    Console.WriteLine("qual sera a forma de pagamento:\n1- à vista no dinheiro\n2- à vistano PIX\n3- débito\n4- cartão de crédito");
                    opc3 = int.Parse(Console.ReadLine());

                    switch (opc3)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu pagar à vista no dinheiro.\nPor isso você ganhou 15% de desconto.");
                            nv = vtc - (vtc * 0.15f);
                            Console.WriteLine("o valor que você vai pagar ficou: {0}", nv);
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu pagar à vista no PIX.\nPor isso você ganhou 10% de desconto.");
                            nv = vtc - (vtc * 0.10f);
                            Console.WriteLine("o valor que você vai pagar ficou: {0}", nv);
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu pagar no débito .\nPor isso você ganhou 5% de acréscimo.");
                            nv = vtc + (vtc * 0.05f);
                            Console.WriteLine("o valor que você vai pagar ficou: {0}", nv);
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu pagar no cartão de crédito.\nPor isso você ganhou 10% de acréscimo.");
                            nv = vtc + (vtc * 0.10f);
                            Console.WriteLine("o valor que você vai pagar ficou: {0}", nv);
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("EXERCÍCIO 3 - LISTA");

                    int opc_mes;

                    Console.WriteLine("Escolha o mês que você quer ver:");
                    break;

                case 5:
                    Console.WriteLine("EXERCÍCIO 4 - LISTA");
                    break;

                case 6:
                    Console.WriteLine("EXERCÍCIO 5 - LISTA");
                    break;
                case 7:
                    Console.WriteLine("EXERCÍCIO 4 - LISTA");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }
    }
}
