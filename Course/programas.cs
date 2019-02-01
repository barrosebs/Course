using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Globalization;

namespace Course
{
    public class programas
    {
        public void primeiroPrograma()
        {
            Console.WriteLine("\n\n ------------PRIMEIRO SISTAMA-----------");

            char genero = 'M';
            int idade = 32;
            double saldo = 15.600;
            string nome = "Eduardo Barros";
            Console.Write("Bom dia!");
            Console.Write("Boa tarde");
        }

        public void segundoPrograma()
        {
            char genero = 'M';
            int idade = 32;
            double saldo = 15.600;
            string nome = "Eduardo Barros";

            Console.WriteLine("\n\n ------------SEGUNDO SISTAMA-----------");
            Console.WriteLine("Seu nome é " + nome + ", idade " + idade + ", sexo " + genero + "." + " Você tem um saldo em conta de " + saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo {2:F2} reais", nome, idade, saldo); //técnica do plaholders

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais"); //técnica da interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //técnica de concatenaão

        }

        public void terceiroPrograma()
        {

            Console.WriteLine("\n\n----------------TERCEIRO SISTEMA = AULA: SAÍDA DE DADOS--------------------");

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade1 = 30;
            int codigo = 5290;
            char genero1 = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.5;
            double medida = 53.234567;

            Console.WriteLine($"{produto1} cujo preço é {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");
            Console.WriteLine($"Registro {idade1} anos de idade, código {codigo} e gênero: {genero1}");
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine($"Arredondamento (três casas decimais): {medida:F3}");
            Console.WriteLine("Separado decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));

        }

        public void quartoPrograma()
        {
            Console.WriteLine("\n\n----------------QUARTO SISTEMA = AULA: OPERAÇÕES ARITIMÉTICOS--------------------");
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            float n4 = (float)10 / 8; // modo cast 
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c; // pode ser assim 
            double delta2 = Math.Pow(b, 2.0) - 4.0 * a * c;//usando a função de calculo Math
            double x1 = (-b + Math.Sqrt(delta2)) / (2 * a);// () defini a prioridade e ordem na equação

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("Resultado delta: " + delta2);
            Console.WriteLine("Resultado da equação: " + x1);

        }

        public void quintoPrograma()
        {

            Console.WriteLine("\n\n----------------QUINTO SISTEMA = AULA: OPERAÇÕES DE ATRIBUIÇÃO --------------------");
            int a1 = 10;
            Console.Write("A = " + a1);

            int b = ++a1;// é diferente de ++a

            Console.Write(" e B = " + b);

            int c = a1--;
            Console.Write(" é diferente de C: " + c);


            Console.WriteLine(" e de A: " + a1);

        }

        public void entradaDeDados()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("\n\n************VETOR***********");

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public void segundaEntradaDeDados()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(), CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(), CultureInfo.InvariantCulture);


        }
        public void primeiroExercicioDeFixacao()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomec = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha) ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine(nomec);
            Console.WriteLine(qtd);
            Console.WriteLine(preco);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);

        }

        public void primeiroExercicio()
        {
            int v1, v2, soma;
            Console.WriteLine("Digite os dois valores:");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("Soma = " + soma);

        }
        public void estruturaCondicional()
        {
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }
        }
        public void SegundaEstruturaConmdicional()
        {
            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
                Console.WriteLine("Boa noite!!");
        }

        public void estruturaEnquanto()
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0)
            {

                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo!!");
        }

        public void estruturaPara()
        {
            Console.Write("Quantos números inteiros você vai digitar: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }

        public void exercicioPrimeiroEFor()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i < x; i++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine("O resultado de X é: " + i);
                }
            }
            Console.ReadLine();
        }

        public void exercicioSegundoEFor()
        {
            int saida_in = 0;
            int saida_out = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 10 && x <= 20)
                {
                    saida_in = saida_in + 1;
                }
                else
                {
                    saida_out = saida_out + 1;
                }
                Console.WriteLine(saida_in + " in");
                Console.WriteLine(saida_out + " ou");
            }


        }
        public void triguloPOO()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }

        public void EstoqueDeProdutoPOO()
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("Dados atualizados: " + p);

        }

        public static void ExercioDoisPOOFuncionario()
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do " + f);

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.Write("Digite a porcentagem para aumento do salário: ");
            double percentual = int.Parse(Console.ReadLine());
            f.AumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("Dados atualizados: " + f);
        }

        public void Aluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine();
            Console.Write("Nome do Aluno: ");
            a.AlunoNovo = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite as três notas do aluno: ");

        }

        public static void Circulo()
        {


            Console.Write("Entre com o valor do Rario: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"), CultureInfo.InvariantCulture);

        }

        public static void ExercicioMatriz()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)//percorrer linha
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)//percorrer linha
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count++);
        }

        public static void OrderEnums()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //convertendo enum em string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// Convertendo string tipo enum
            Console.WriteLine(os);


        }

    }
}
