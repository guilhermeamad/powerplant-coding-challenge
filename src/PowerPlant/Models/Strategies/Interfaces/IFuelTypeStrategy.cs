using PowerPlant.Models.Views;

namespace PowerPlant.Models.Strategies.Interfaces
{
    public interface IFuelTypeStrategy
    {
        PowerPlantResponse CalculatePowerPlantProduced(PowerPlantRequest powerPlantList, PowerPlant powerPlant);
    }
}
