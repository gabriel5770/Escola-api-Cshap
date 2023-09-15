using Robotron.Model;

namespace Robotron.Repository.Computador
{
    public static class ProfessorRepos
    {

        public static List<Professor> listProfessores()
        {
            List<Professor> professores = new List<Professor>();
            professores.Add(new Professor
            {
                Id = 1,
                Nome = "Albert tiririca",
                idade = 50,
                Curso = "Química"
            });

            professores.Add(new Professor
            {
                Id = 2,
                Nome = "Chicano Borges",
                idade = 35,
                Curso = "Matemática"
            });

            professores.Add(new Professor
            {
                Id = 3,
                Nome = "Sérgio Santos",
                idade = 60,
                Curso = "Física"
            });

            return professores;
        }
    }
}
