using Microsoft.AspNetCore.Mvc;
using PowerPlant.Models.Views;
using PowerPlant.Services.Interfaces;

namespace PowerPlant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerPlantController : ControllerBase
    {
        private readonly IPowerPlantService _powerPlantService;

        public PowerPlantController(IPowerPlantService powerPlantService)
        {
            _powerPlantService = powerPlantService;
        }

        [Route("/productionplan")]
        [HttpPost]
        public List<PowerPlantResponse> Post([FromBody] PowerPlantRequest powerPlants)
        {
            return _powerPlantService.HandlePowerPlantCalculation(powerPlants);
        }
    }
}
