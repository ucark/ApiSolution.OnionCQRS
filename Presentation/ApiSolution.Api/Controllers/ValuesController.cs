using ApiSolution.Application.Interfaces.UnitOfWorks;
using ApiSolution.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiSolution.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await unitOfWork.GetReadRepository<Product>().GetAllAsync());
        }
    }
}
