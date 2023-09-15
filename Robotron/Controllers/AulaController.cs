using Microsoft.AspNetCore.Mvc;
using Robotron.Model;
using Robotron.Repository.Carro;
using Robotron.Repository.Computador;

namespace Robotron.Controllers
{
    [Route("api/v1/aula")]
    [ApiController]
    public class AulaController : ControllerBase
    {

        [Route("alunos")]
        [HttpGet]
        public ActionResult ListAlunos() {

            List<Aluno> alunos = AlunoRepos.lisAluno();
            return Ok(alunos);
        }


        [Route("professores")]
        [HttpGet]
        public ActionResult ListProfessores()
        {

            List<Professor> professores = ProfessorRepos.listProfessores();
            return Ok(professores);
        }

    }
 
}
