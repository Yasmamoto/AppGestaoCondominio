using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoCondominio.RegrasDeNegocio
{
    public class Casa
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public string Veiculo1 { get; set; }
        public string Veiculo2 { get; set; }
        public double ValorCasa { get; set; }
        public double ValorCondominio { get; set; }
        public List<Pessoa> Moradores { get; set; }
        string titular = null;

        public Casa(int numeroIndic, double valorIndic)
        {
            this.Numero = numeroIndic;
            this.ValorCasa = valorIndic;
            Moradores = new List<Pessoa>();

        }
        public double DefinirValorCasa(double ValorCasa)
        {
            Console.WriteLine("\t  _______________");
            Console.WriteLine("\t | Tipos de Casa |");
            Console.WriteLine("\t |_______________|");
            Console.WriteLine("\t | Basica        |");
            Console.WriteLine("\t | Padrão        |");
            Console.WriteLine("\t | alto Padrão   |");
            Console.WriteLine("\t  ---------------");
            Console.WriteLine("Digite o Tipo Da Casa:");
            Tipo = Console.ReadLine();

            if (Tipo.ToLower().Replace("´", "") == "basica")
            {
                ValorCasa = 300.000;
            }
            else if (Tipo.ToLower().Replace("~", "") == "padrao")
            {
                ValorCasa = 500.000;
            }
            else if(Tipo.ToLower().Replace("~", "").Replace(" ", "") == "altopadrao")
            {
                ValorCasa = 700.000;
            }
            return ValorCasa;
        }//metodo definir valores da casa
        public void CadastrarMoradores()
        {
            int opc = 1;
            while (opc != 0)
            {
                Console.Clear();
                for (int i = 1; i <= 7; i++)
                {

                    Console.WriteLine("------------- Cadastrar Moradores  --------------\n");
                    Pessoa moradores = new Pessoa();

                    Console.Write("Nome:");
                    moradores.Nome = Console.ReadLine();
                    Console.WriteLine("Você é o titular da propriedade:");
                    moradores.Titular(titular);
                    Console.Write("Digite seu CPF:");
                    moradores.CPF = Console.ReadLine();
                    Console.Write("Digite sua Data de Nascimento:");
                    moradores.DataNascimento = Console.ReadLine();

                    //adiciona moradores na lista
                    Moradores.Add(moradores);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Morador cadastrado com sucesso!!!!\n");
                    Moradores.Count();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Deseja continuar cadastrando???(S/n)");
                    var resp = Console.ReadLine().ToUpper();
                    if (resp == "N") opc = 0;
                }

            }


        }
        //    public string[] Veiculo(int quantV, string placa,string placa2, string modelo,string modelo2, string[] cadastroV1)
        //    {
        //        while(quantV < 2)
        //        {
        //            if(quantV == 1)
        //            {
        //                cadastroV1[0] = placa;
        //                cadastroV1[1] = modelo;
        //            }
        //            else if(quantV == 2)
        //            {
        //                cadastroV1[0] = placa;
        //                cadastroV1[1] = modelo;
        //                cadastroV1[2] = placa2;
        //                cadastroV1[3] = modelo2;
        //            }
        //            break;

        //        }
        //        return cadastroV1;
        //    }
    }
}
