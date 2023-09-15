namespace Robotron.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Professor> Professores { get; set; }

    }
}
