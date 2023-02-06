using ESH_ValidacaoComAnnot.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESH_ValidacaoComAnnot.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public IActionResult Salvar(AlunoView view)
        {
            try
            {
                return Ok(view);
            }            
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}
