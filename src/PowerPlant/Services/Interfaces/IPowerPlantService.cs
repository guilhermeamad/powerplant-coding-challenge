using PowerPlant.Models.Views;

namespace PowerPlant.Services.Interfaces
{
    public interface IPowerPlantService
    {
        List<PowerPlantResponse> HandlePowerPlantCalculation(PowerPlantRequest powerPlantResponse);
    }
}
