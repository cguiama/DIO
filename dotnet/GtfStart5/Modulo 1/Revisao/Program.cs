﻿namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        { aluno.Nota = nota; }
                        else { Console.WriteLine("O valor da nota deve ser decimal!"); }
                        Console.WriteLine("\nO aluno foi inserido com sucesso!\n");

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)) { notaTotal = notaTotal + alunos[i].Nota; nrAlunos++; }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!\n");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a Opção desejada\n");
            Console.WriteLine("1 - Inserir Alunos");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média final");
            Console.WriteLine("X - Sair\n");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}