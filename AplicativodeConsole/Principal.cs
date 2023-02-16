
namespace AplicativodeConsole
{
    public class Principal
    {
        // modificado de acesso "public"
        // retorno do método "void, int, string"
        // assinatura é o chamador do método "Start"
        public void Start()
        {
            Menu();
        }

        public void Menu()
        {
            int opcao = 1;

            while (opcao != 0)
            {
               
                Console.WriteLine("Informe o Usuário:");
                string login = Console.ReadLine();
                Console.WriteLine("\n ****************************");
                Console.WriteLine($"\n ***** Bem-Vindo(A) {login} *****");
                Console.WriteLine("\n ****************************");
                Console.WriteLine("Selecione uma Opção:");
                Console.WriteLine("1 - Operações");
                Console.WriteLine("2 - Sair");
              
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("OP 1 - Leitor numérico com apuração do \n       maior elemento e sua posição.\n");
                        Console.WriteLine("OP 2 - Leitor numérico de algarismos inteiros com apuração \n       dos números pares e suas quantidades.\n");
                        Console.WriteLine("OP 3 - Leitor de dois vetores (A e B) de mesma proporção \n       gerando um terceiro vetor (C) onde cada elemento \n       é a soma dos elementos correspondentes de (A e B).\n");
                        Console.WriteLine("OP 4 - Leitor de algarismos reais com apuração da \n       média aritmética de todos elementos com visualização \n       dos elementos que estão abaixo da média.\n");
                        Console.WriteLine("OP 5 - Leitor de algarismos inteiros com visualização \n       da média aritmética somente dos números pares.\n");
                        Console.WriteLine("OP 6 - .....................\n");
                        Console.WriteLine("OP 7 - .....................\n");
                        Console.WriteLine("OP 8 - .....................\n");
                        Console.WriteLine("OP 9 - Calaculadora de lucros, abaixo de 10%, entre 10% e 20% \n       lucro acima de 20%. Valor total das compras \n       valor total de venda e lucro total.\n");
                        int operaçãousuario = int.Parse(Console.ReadLine());

                        if (operaçãousuario == 1)

                        {
                            Execercicio1();
                        }
                        
                        else if (operaçãousuario == 2)
                        {
                            Execercicio2();
                        }

                        else if (operaçãousuario == 3)
                        {
                             Exercicio3();
                        }

                        else if (operaçãousuario == 4)
                        {
                            Exercicio4();
                        }

                        else if (operaçãousuario == 5)
                        {
                            //Exercicio5();
                        }

                        else if (operaçãousuario == 6)
                        {
                            //Execercicio6();
                        }

                        else if (operaçãousuario == 7)
                        {
                            //Execercicio7();
                        }

                        else if (operaçãousuario == 8)
                        {
                            //Execercicio8();
                        }

                        else if (operaçãousuario == 9)
                        {
                            //Execercicio9();
                        }

                        else
                        {
                            Console.WriteLine("Opção não encontrada, tente novamente");
                        }
                        break;

                        case 2:
                           break;
              

                    default:
                        break;
                }

            }
        }

        public void Execercicio1()
        {
            Console.WriteLine("Digite a quantidade de numeros");
            int tamanho = int.Parse(Console.ReadLine());
            double[] numeros = new double[tamanho];

            var maiorNumero = 0.0;
            var posicaoDoMaiorNumero = 0;

            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                    posicaoDoMaiorNumero = i;
                }
            }

            Console.WriteLine($"Maior numero {maiorNumero}");
            Console.WriteLine($"Posição do maior numero {posicaoDoMaiorNumero}");
            Console.ReadKey();
            Console.Clear();
        }

        public void Execercicio2()
        {
            int qtdNumeros = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtdNumeros];

            int qtdPares = 0;

            for (int i = 0; i < qtdNumeros; i++)
                numeros[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdNumeros; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                    qtdPares++;
                }
            }
            Console.Write($"\n{qtdPares}");
        }

        public void Exercicio3()
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[] a = new int[quantidade];
            int[] b = new int[quantidade];
            int[] c = new int[quantidade];


            for (int i = 0; i < quantidade; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < quantidade; i++)
            {
                b[i] = int.Parse(Console.ReadLine());

                c[i] = a[i] + b[i];
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(c[i]);
            }
        }

        public void Exercicio4()
        {
            int tamanho = int.Parse(Console.ReadLine());
            double[] quantidade = new double[tamanho];
            double media = 0.0;

            for (int i = 0; i < tamanho; i++)
            {
                quantidade[i] = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < tamanho; i++)
            {
                media += quantidade[i];

            }

            media = media / tamanho;

            Console.WriteLine(media);

            for (int i = 0; i < tamanho; i++)
            {
                if (quantidade[i] < media)

                {
                    Console.WriteLine(quantidade[i]);
                }

            }



        }

        public void Exercicio9()
        {

        }


    }
       
    
}
