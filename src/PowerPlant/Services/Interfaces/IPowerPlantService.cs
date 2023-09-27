using PowerPlant.Models.Views;

namespace PowerPlant.Services.Interfaces
{
    public interface IPowerPlantService
    {
        List<PowerPlantResponse> HandlePowerPlant(PowerPlantRequest powerPlantResponse);
    }
}
