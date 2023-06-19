using Microsoft.AspNetCore.Mvc;
using CadastroTCC.models;

namespace CadastroTCC.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class usuarioCpntroller : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario() {Cpf=23476512378,Nome = "Godofredo",Apelido = "god", DataDeNascimento= new DateTime(1999, 6, 19), Email = "godBon13@gmail.com", Senha ="godsupremo345",Nivel=NivelEnuns.Nivel2}
        }


    }
}