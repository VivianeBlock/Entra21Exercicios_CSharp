using System;
using System.Collections.Generic;

namespace Aula13._07
{
    class Program
    {
        static void Main(string[] args)
        {

         

            //Ex 01:

            {

                //Console.WriteLine("\tInforme o indice:\n\t (De 1 a 5) ");
                //int x = Convert.ToInt32(Console.ReadLine());
                //x = x--;
                //Console.WriteLine((nomes)x);

            }

            //Ex 02:

            {
                //Console.WriteLine("\tInforme um valor:");
                //int n = Convert.ToInt32(Console.ReadLine());

                //if (n < 10)
                //{
                //    Console.WriteLine("Programa encerrado, o valor é menor que 10.");

                //}
                //else
                //{
                //    Func<int, int> quadrado = x => x * x;

                //    Console.WriteLine(quadrado(n));

                //}


            }

            //Ex 03:

            {
                //Console.WriteLine("\tPotencias");


                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine("{0}", (potencia)i);
                //}

            }

            //Ex 04:

            {

                //Console.WriteLine("\tInforme o indice do cargo desejado para atribuição:");
                //for (int i = 0; i < 4; i++)
                //{
                //    Console.WriteLine("{0}: {1}", i + 1, (Cargo)i);

                //}
                //Console.WriteLine();

                //int x = Convert.ToInt32(Console.ReadLine());
                //switch (x)
                //{

                //    case 1:
                //        Console.WriteLine("{0}: {1}",(Cargo)x, 1000);

                //        break;
                //    case 2:
                //        Console.WriteLine("{0}: {1}", (Cargo)x, 2500);
                //        break;
                //    case 3:
                //        Console.WriteLine("{0}: {1}", (Cargo)x, 3000);
                //        break;
                //    case 4:
                //        Console.WriteLine("{0}: {1}", (Cargo)x, 4000);
                //        break;

                //}

            }

            /* lista de  Interfaces*/

            //Ex 01:

            {



                //    List<Pessoa> people = new List<Pessoa>();

                //    while (true)
                //    {
                //        Console.WriteLine("Insira uma pessoa ou apenas aperte enter para encerrar");
                //        Pessoa pes = new Pessoa();
                //        pes.Nome = Console.ReadLine();
                //        if (pes.Nome == "")
                //        {
                //            Console.WriteLine("Agradeçemos pelo uso, volte sempre");
                //            break;
                //        }
                //        pes.Idade = int.Parse(Console.ReadLine());
                //        pes.Cpf = Console.ReadLine();
                //        bool insere = true;
                //        foreach (var item in people)
                //        {
                //            if (item.Cpf == pes.Cpf)
                //            {
                //                insere = false;
                //                break;
                //            }
                //        }
                //        if (insere)
                //        {
                //            Console.WriteLine("Pessoa Adicionada");
                //            people.Add(pes);
                //        }
                //        else
                //        {
                //            Console.WriteLine("CPF ja existente, pessoa nao adicionada");
                //        }
                //        MostraPessoas(people);
                //    }
                //}



            }

            //Ex 02:

            {

                //List<Hotel> hoteis = new List<Hotel>();

                //hoteis = Gerador(hoteis);

                //while (true)
                //{


                //    Console.WriteLine("\tLista de Hoteis:\n\n");

                //    foreach (var item in hoteis)
                //    {
                //        Console.WriteLine("\tNome do Hotel: {0}", item.Nome);
                //        Console.WriteLine("\tQuantidade de quatos: {0}", item.QtdQuartos);
                //        Console.WriteLine("\tQuartos ocupados: {0}", item.QtdQuartosOcupados);
                //        Console.WriteLine("\t..  ..  ..  ..  ..\n");
                //    }

                //    Console.WriteLine("\t.....................\n");

                //    Console.WriteLine("\tInforme o Nome do Hotem em que deseja se hospedar:");
                //    string n = Console.ReadLine();

                //    Console.WriteLine("\n\tHotel selecionado:\n");


                //    foreach (var item in hoteis)
                //    {
                //        if (n == item.Nome)
                //        {
                //            Console.WriteLine("\tNome do Hotel: {0}", item.Nome);
                //            Console.WriteLine("\tQuantidade de quatos: {0}", item.QtdQuartos);
                //            Console.WriteLine("\tQuartos ocupados: {0}\n\n", item.QtdQuartosOcupados);

                //            if ((item.QtdQuartos - item.QtdQuartosOcupados) != 0)
                //            {
                //                item.QtdQuartosOcupados -= 1;



                //                Console.WriteLine("Você está hosbedado no Hotel : {0}\n\n", item.Nome);

                //                Console.WriteLine("\tDados atuais do Hotel selecionado:\n");
                //                Console.WriteLine("\tNome do Hotel: {0}", item.Nome);
                //                Console.WriteLine("\tQuantidade de quatos: {0}", item.QtdQuartos);
                //                Console.WriteLine("\tQuartos ocupados: {0}\n\n", item.QtdQuartosOcupados);
                //            }
                //            else
                //            {
                //                Console.WriteLine("\tSentimos muito mas o hotel já está cheio. Sugrimos este:.\n");

                //                int maior = hoteis[0].QtdQuartos;
                //                string maiorH = hoteis[0].Nome;

                //                foreach (var item2 in hoteis)
                //                {

                //                    if (item2.Nome != maiorH && item2.QtdQuartos > maior)
                //                    {
                //                        maior = item2.QtdQuartos;
                //                        maiorH = item2.Nome;
                //                    }
                //                }
                //                Console.WriteLine("\tHotel: {0}\n\n",maiorH);
                //            }
                //        }
                //    }

            }

            //Ex 03:









        }




        public static List<Hotel> Gerador(List<Hotel> hoteis)
        {

            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                Hotel temp = new Hotel();
                temp.Nome = Convert.ToString(i);
                temp.QtdQuartos = ran.Next(0, (5 * (i + 2)));
                temp.QtdQuartosOcupados = ran.Next(0, (5 * (i + 1)));

                while (temp.QtdQuartosOcupados > temp.QtdQuartos)
                {
                    temp.QtdQuartosOcupados = ran.Next(0, (5 * (i + 1)));
                }

                hoteis.Add(temp);

            }


            return hoteis;
        }

        public static void MostraPessoas(List<Pessoa> p)
        {
            foreach (var item in p)
            {
                Console.WriteLine("Nome  : {0}", item.Nome);
                Console.WriteLine("Idade : {0}", item.Idade);
                Console.WriteLine(@"CPF   : {0:000\.000\.000\-00}", Convert.ToInt64(item.Cpf));
                Console.WriteLine("-----------//--------------®");
            }
        }

        enum Cargo
        {
            Estagiario,
            Junior,
            Gerente,
            CEO
        }

        enum nomes
        {
            Amanda,
            Ana,
            Renata,
            Marcia,
            Roberto
        }

        enum potencia
        {

            x1 = 2,
            x2 = 4,
            x3 = 6,
            x4 = 8,
            x5 = 10

        }


    }

}