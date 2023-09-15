namespace Robotron.Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int idade { get; set; }
        public List<Aluno> Aluno { get; set; }
        public Materia materia { get; set; }
    }
}
