namespace Robotron.Model
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor professor { get; set; }
        public List<Aluno> alunos { get; set; }
        public Nota NotaMinima { get; set; }

    }
}
