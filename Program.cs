using System;

namespace validação
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa pessoa1 = new pessoa();
            pessoa1.Nome = "Aline ";
            Console.WriteLine("Nome: " + pessoa1.Nome);


            professor professor1 = new professor();
            professor1.Docente = "Alex ";
            Console.WriteLine("Docente: " + professor1.Docente);

            funcao funcao1 = new funcao();
            funcao1.Funcao = "Mariana e Juliana ";
            Console.WriteLine("Função: " + funcao1.Funcao);

            coordenacao coord1 = new coordenacao();
            coord1.Coord = "Renata ";
            Console.WriteLine("Coordenadora: " + coord1.Coord);


        }
    }
}
