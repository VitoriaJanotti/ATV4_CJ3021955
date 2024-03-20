namespace ATV4_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATIVIDADE DA SALA DE AULA
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
        }
    }
}
