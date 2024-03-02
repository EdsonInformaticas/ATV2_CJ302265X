namespace ATV2_CJ302265X
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //projeto 1

            float valor, salario, novo_salario;




            Console.WriteLine("Qual é o seu salário?");
            salario = float.Parse(Console.ReadLine());
            valor = (salario / 100) * 25;
            novo_salario = valor + salario;
            Console.WriteLine("seu novo salario é: {0}", novo_salario);

            //projeto 2
            int n, n1, n2, resul;
            Console.WriteLine("Digite um numero.");
            n = int.Parse(Console.ReadLine());
            n1 = n * 3 + 1;
            n2 = n * 2 - 1;
            resul = n1 + n2;
            Console.WriteLine("a soma dos valores são: {0}", resul);

            //projeto 3 
            float v, v2;
            Console.WriteLine("o valor inicial dos seus investimentos é de R$ 1000,00");

            v = 1000;
            v2 = (v / 100) * 3.4f;
            v = v - v2;
            v2 = (v / 100) * 2.8f;
            v = v + v2;
            v2 = (v / 100) * 14;
            v = v + v2;
            v2 = (v / 100) * 8.5f;
            v = v - v2;

            Console.WriteLine("o valor atual de seus investimentos é de R$ {0}", v);


            //ATV 2 projeto1


            float metros1; float cm1; float mm1;

            Console.WriteLine("Digite um valor em metros");
            metros1 = float.Parse(Console.ReadLine());
            cm1 = metros1 / 100;
            mm1 = metros1 / 1000;
            Console.WriteLine("Este valor em centrimetros é {0}, e em milímetros é {1}", cm1, mm1);


            //ATV 2 projeto3

            float altura1; float peso1; float IMC1; float altura2;

            Console.WriteLine("Qual seu peso?");
            peso1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura?");
            altura1 = float.Parse(Console.ReadLine());
            altura2 = altura1 * altura1;
            IMC1 = peso1 / altura2;
            Console.WriteLine("Seu IMC é {0}", IMC1);


            //ATV 2 projeto4

            float aluno1, aluno2, aluno3, nota1, nota2, nota3, media1, mediaA, media2;

            Console.WriteLine("Digite três quantidades de alunos que tiraram uma nota, e depois as notas de cada quantia de alunos, em linhas separadas");
            aluno1 = float.Parse(Console.ReadLine());
            nota1 = float.Parse(Console.ReadLine());
            aluno2 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            aluno3 = float.Parse(Console.ReadLine());
            nota3 = float.Parse(Console.ReadLine());
            media1 = (aluno1 * nota1) + (aluno2 * nota2) + (aluno3 * nota3);
            mediaA = aluno1 + aluno2 + aluno3;
            media2 = media1 / mediaA;

            Console.WriteLine("A média ponderada dos aluno é {0}", media2);

            //ATV 2 projeto5

            float V, Vo, a, t;

            Console.WriteLine("Vamos descobrir a velocidade de um corpo, escreva a: Velocidade inicial do corpo, aceleração, e o intervalo de tempo, respectivamente");
            Vo = float.Parse(Console.ReadLine());
            a = float.Parse(Console.ReadLine());
            t = float.Parse(Console.ReadLine());
            V = Vo + (a * t);
            Console.WriteLine("A velocidade do corpo é {0}", V);

            //ATV 2 projeto6

            float valor0, salario0, novo_salario0;
            Console.WriteLine("Qual é o seu salário?");
            salario0 = float.Parse(Console.ReadLine());
            valor0 = (salario / 100) * 25;
            novo_salario0 = valor0 + salario0;
            Console.WriteLine("seu novo salario é: {0}", novo_salario0);

            //ATV 2 projeto7

            float reais, dolar;

            Console.WriteLine("Digite o valor em reais que deseja converter para dólares");
            reais = float.Parse(Console.ReadLine());
            dolar = reais * 4.95f;
            Console.WriteLine("Este valor em dólares é {0}", dolar);

            //ATV 2 projeto8

            float valorzin, tri, dob, sus1, sus2;
            Console.WriteLine("Escreva um valor");
            valorzin = float.Parse(Console.ReadLine());
            tri = valorzin * 3;
            dob = valorzin * 2;
            sus1 = tri + 1;
            sus2 = dob - 1;
            Console.WriteLine("O sucessor do triplo deste valor é {0}, e o antecessor do dobro é {1}", sus1, sus2) ;

            //ATV 3 projeto 9

            float zz;
            Console.WriteLine("Digite um valor");














        }
    }
}
