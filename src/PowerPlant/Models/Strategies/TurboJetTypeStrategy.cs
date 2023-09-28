using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Models.Views;

namespace PowerPlant.Models.Strategies
{
    public class TurboJetTypeStrategy : ITurboJetTypeStrategy
    {
        public PowerPlantResponse CalculatePowerPlantProduced(PowerPlantRequest powerPlantList, PowerPlant powerPlant)
        {
            if (powerPlantList.Load < powerPlant.Pmin) return new PowerPlantResponse { Name = powerPlant.Name, Power = powerPlantList.Load };

            return new PowerPlantResponse { Name = powerPlant.Name, Power = powerPlant.Pmax > powerPlantList.Load ? powerPlantList.Load : powerPlant.Pmax };
        }
    }
}
