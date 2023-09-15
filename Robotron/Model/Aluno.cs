namespace Robotron.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Nota> Notas { get; set; }
        public Curso Curso { get; set; }

    }
}
