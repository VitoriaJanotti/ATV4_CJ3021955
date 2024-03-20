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

                    int mes, dias, ano;


                    Console.WriteLine("Digite o número de um mês (1 a 12): ");
                    mes = int.Parse(Console.ReadLine());


                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("O mês é janeiro e tem 31 dias.");
                            break;

                        case 2:
                            Console.WriteLine("Qual é o ano: ");
                            ano = int.Parse(Console.ReadLine());
                            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                            {
                                Console.WriteLine("O mês é fevereiro e tem 29 dias,pois, o ano é bissexto");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("O mês é fevereiro e tem 28 dias");
                                break;
                            }

                        case 3:
                            Console.WriteLine("O mês é março e tem 31 dias.");
                            break;

                        case 4:
                            Console.WriteLine("O mês é abril e tem 30 dias.");
                            break;

                        case 5:
                            Console.WriteLine("O mês é maio e tem 31 dias.");
                            break;

                        case 6:
                            Console.WriteLine("O mês é junho e tem 30 dias.");
                            break;

                        case 7:
                            Console.WriteLine("O mês é julho e tem 31 dias.");
                            break;

                        case 8:
                            Console.WriteLine("O mês é agosto e tem 31 dias.");
                            break;

                        case 9:
                            Console.WriteLine("O mês é setembro e tem 30 dias.");
                            break;

                        case 10:
                            Console.WriteLine("O mês é outubro e tem 31 dias.");
                            break;

                        case 11:
                            Console.WriteLine("O mês é novembro e tem 30 dias.");
                            break;

                        case 12:
                            Console.WriteLine("O mês é dezembro e tem 31 dias.");
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel ler o mês.");
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("EXERCÍCIO 4 - LISTA");

                    int opc2;
                    float n1_2, n2_2, ad_2, sub_2, mult_2, div_2,pot1, pot2;

                    Console.WriteLine("VAMOS MONTAR UMA CALCULADORA.");
                    Console.WriteLine("Digite um número para n1: ");
                    n1_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um número para n2: ");
                    n2_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escolha qual operação você deseja efetuar: \n1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão");
                    opc2 = int.Parse(Console.ReadLine());

                    switch (opc2)

                    {
                        case 1:
                            Console.WriteLine("Você escolheu fazer uma adição");
                            ad_2 = n1_2 + n2_2;
                            Console.WriteLine("Adição = {0}", ad_2);

                            break;

                        case 2:
                            Console.WriteLine("Você escolheu fazer uma subtração");
                            sub_2 = n1_2 - n2_2;
                            Console.WriteLine("Subtração = {0}", sub_2);

                            break;

                        case 3:
                            Console.WriteLine("Você escolheu fazer uma multiplicação");
                            mult_2 = n1_2 * n2_2;
                            Console.WriteLine("Multiplicação = {0}", mult_2);

                            break;

                        case 4:
                            Console.WriteLine("Você escolheu fazer uma divisão");
                            div_2 = n1_2 / n2_2;
                            Console.WriteLine("Divisão = {0}", div_2);

                            break;
                        case 5:
                            Console.WriteLine("Você escolheu fazer uma potenciação");
                            pot1 = n1_2 * n1_2;
                            pot2 = n2_2 * n2_2;
                            Console.WriteLine("Potencia 1 = {0}\nPotencia 2 = {1}", pot1, pot2);
                            break;

                        default:
                            Console.WriteLine(" opção invalida");
                            break;
                    }
                    break;

                case 6:
                    Console.WriteLine("EXERCÍCIO 5 - LISTA");

                    int codigo;
                    float salario, novo_salario;

                    Console.WriteLine("Digite o valor do seu sálario: ");
                    salario =  int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o codigo do seu cargo:\nProfessor - 101\nSecretário - 102\nPublicitário - 103\nJornalista - 204\nMecânico - 206\nEstagiário - 301\nTécnico de TI - 302");
                    codigo = int.Parse(Console.ReadLine());

                    switch (codigo)     
                    {
                        case 101:
                            novo_salario = salario + (salario * 0.75f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 102:
                            novo_salario = salario + (salario * 0.97f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 103:
                            novo_salario = salario + (salario * 1.17f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 204:
                            novo_salario = salario + (salario * 0.89f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 206:
                            novo_salario = salario + (salario * 1.324f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 301:
                            novo_salario = salario + (salario * 1.04f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        case 302:
                            novo_salario = salario + (salario * 1.46f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                        default:
                            novo_salario = salario + (salario * 4.35f);
                            Console.WriteLine("Novo Salário = {0}", novo_salario);
                            break;
                    }
                    break;

                case 7:
                    Console.WriteLine("EXERCÍCIO 4 - LISTA");

                    Console.WriteLine("VAMOS CALCULAR IMPOSTOS");

                    float sal;
                    int opc6;

                    Console.WriteLine("**digite o número referente ao seu salário** \n 1-Até R$ 1.903,98 \n 2-Entre R$ 1.903,99 e R$ 2.826,65 \n 3-Entre R$ 2.826,66 e R$ 3.751,05 \n 4-Entre R$ 3.751,06 e R$ 4.664,6 \n 5- Acima de R$ 4.664,68");
                    opc6 = int.Parse(Console.ReadLine());

                    switch (opc6)
                    {
                        case 1:
                            Console.WriteLine("você está isento de imposto");
                            break;
                        case 2:
                            sal = opc6 - (opc6 * 0.075f);
                            Console.WriteLine("seu salário será: {0}", sal);
                            break;
                        case 3:
                            sal = opc6 - (opc6 * 0.15f);
                            Console.WriteLine("seu salário será: {0}", sal);
                            break;
                        case 4:
                            sal = opc6 - (opc6 * 0.225f);
                            Console.WriteLine("seu salário será: {0}", sal);
                            break;
                        case 5:
                            sal = opc6 - (opc6 * 0.275f);
                            Console.WriteLine("seu salário será: {0}", sal);
                            break;
                        default:
                            Console.WriteLine(" opção invalida");
                            break;
                    }
                    break;
                
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }
    }
}
