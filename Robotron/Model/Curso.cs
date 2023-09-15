namespace Robotron.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Materia> Materias;
        public DateTime Duracao { get;set; }
        public List<Professor> Professores {  get; set; }
        public List<Aluno> Alunos { get; set; }


    }
}
