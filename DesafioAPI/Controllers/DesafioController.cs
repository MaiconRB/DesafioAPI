using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesafioController : Controller
    {
        // GET
        [HttpGet]
        public ActionResult GetNumero()
        {
            Random randNum = new Random();

            return Ok(randNum.Next());
        }

        // POST
        [HttpPost]
        public ActionResult PostOperacao(string data, string nome, int primeiroValor, int segundoValor, string operadorMatematico)
        {
            var resultado = 0;

            if (operadorMatematico.Equals("+"))
            {
                resultado = primeiroValor + segundoValor;
            }else if(operadorMatematico.Equals("-"))
                {
                resultado = primeiroValor - segundoValor;
            }else if (operadorMatematico.Equals("*"))
            {
                resultado = primeiroValor * segundoValor;
            }
            else if (operadorMatematico.Equals("/"))
            {
                resultado = primeiroValor / segundoValor;
            }

            return Ok(resultado);
        }

    }
}
