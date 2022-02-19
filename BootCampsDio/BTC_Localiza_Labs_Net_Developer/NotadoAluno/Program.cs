// See https://aka.ms/new-console-template for more information
using System;

namespace Revisao
{
    class Program
    {
        static void Main(String[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1" :
                    Console.Write("Informe o nome do ALuno: ");
                    var aluno = new Aluno();
                    aluno.Nome= Console.ReadLine();

                    Console.Write("Informe a nota do ALuno: ");
                    if (decimal.TryParse(Console.ReadLine(),out decimal nota))
                    {
                    aluno.Nota= nota;
                    }
                    else {
                        throw new ArgumentOutOfRangeException(" Valor de nota deve ser decimal" );
                    }
                alunos[indiceAluno]= aluno; 
                indiceAluno++; 

                    break; 
                
                case "2" :
                foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;
                case "3" :
                    var nrAlunos=0;
                    decimal notaTotal=0;
                    for(int i=0;i<alunos.Length;i++){
                         if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal= notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }

                    }
                    var MediaGeral= notaTotal/nrAlunos;
                    Console.WriteLine($"Média Geral é: {MediaGeral} ");
                    break;
                        default:
                    throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}