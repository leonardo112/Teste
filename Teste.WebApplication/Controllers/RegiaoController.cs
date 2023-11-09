using Microsoft.AspNetCore.Mvc;
using Teste.Core.Domain.Entity;
using Teste.Core.Domain.Interfaces.Service;
using Teste.Core.Domain.Model;

namespace Teste.WebApplication.Controllers
{
    [Route("api/v1/Regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpPost]
        public Task<bool> Insert(List<RegiaoDeInteresseModel> input)
        {
            return _regiaoService.Insert(input);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _regiaoService.GetAll());
        }
    }
}
