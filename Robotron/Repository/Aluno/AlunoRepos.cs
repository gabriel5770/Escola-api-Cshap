using Robotron.Model;
using Robotron.Repository.Computador;

namespace Robotron.Repository.Carro
{
    public static class AlunoRepos
    {
        public static List<Aluno> lisAluno()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno
            {
                Id = 1,
                Nome = "Gabriel dos Santos Vieira",
                Idade = 22,
                Professores = ProfessorRepos.listProfessores().Where(x => x.Curso == "Química").ToList()
            });

            alunos.Add(new Aluno
            {
                Id = 2,
                Nome = "João messi souza",
                Idade = 22,
                Professores = ProfessorRepos.listProfessores().Where(x => x.Curso == "Matemática").ToList()

            });

            alunos.Add(new Aluno
            {
                Id = 3,
                Nome = "Cristiano ronaldo",
                Professores = ProfessorRepos.listProfessores().Where(x => x.Curso == "Física").ToList()
            });

            alunos.Add(new Aluno
            {
                Id = 4,
                Nome = "Luva de pedreiro",
                Idade = 20,
                Professores = ProfessorRepos.listProfessores().Where(x => x.Curso == "Matemática").ToList()

            });

            alunos.Add(new Aluno
            {
                Id = 5,
                Nome = "Alan Jesus",
                Idade = 36,
                Professores = ProfessorRepos.listProfessores().Where(x => x.Curso == "Química").ToList()
            });

            return alunos;
        }
    }
}
