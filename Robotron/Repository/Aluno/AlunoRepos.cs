using Robotron.Model;

namespace Robotron.Repository.Carro
{
    public static class AlunoRepos
    {
        public static List<Aluno> lisAluno()
        {
            List<Aluno> alunos = new List<Aluno>();
            
            alunos.Add(new Aluno {
                Id = 1,
                Nome = "Gabriel dos Santos Vieira",
                Idade = 22
                });

            alunos.Add(new Aluno
            {
                Id = 2,
                Nome = "João messi souza",
                Idade = 22
            });

            alunos.Add(new Aluno
            {
                Id = 3,
                Nome = "Cristiano ronaldo",
                Idade = 3
            });

            alunos.Add(new Aluno
            {
                Id = 4,
                Nome = "Luva de pedreiro",
                Idade = 20
            });

            alunos.Add(new Aluno
            {
                Id = 5,
                Nome = "Alan Jesus",
                Idade = 36
            });

            return alunos;
        }
    }
}
