using AppGestaoCondominio.RegrasDeNegocio;

int opcao = 1;
int contador = 1;

while (opcao != 0)
{

    Console.Clear();
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- + *");
    Console.WriteLine("\t\t* +                                      JAVA                                       * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* +                               IZIANY E MARIA EDUARDA                            * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* +                      1 - Cadastrar uma casa nova                                * +");
    Console.WriteLine("\t\t* +                      2 - Cadastrar moradores em uma casa                        * +");
    Console.WriteLine("\t\t* +                      3 - Consultar moradores de uma casa                        * +");
    Console.WriteLine("\t\t* +                      4 - Consultar morador pelo nome                            * +");
    Console.WriteLine("\t\t* +                      5 - Filtrar moradores por nome                             * +");
    Console.WriteLine("\t\t* +                      6 - Filtrar moradores por salário                          * +");
    Console.WriteLine("\t\t* +                      7 - Filtrar moradores por tipo de casa                     * +");
    Console.WriteLine("\t\t* +                      8 - Mostrar o percentual de moradores por tipo de casa     * +");
    Console.WriteLine("\t\t* +                      9 - Listar todos os moradores titulares                    * +");
    Console.WriteLine("\t\t* +                      0 - Sair do sistema                                        * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.Write("                Opção N°..............");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.ReadKey();
}