using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Models.Views;

namespace PowerPlant.Models.Strategies
{
    public class GasfiredTypeStrategy : IGasfiredTypeStrategy
    {
        public PowerPlantResponse CalculatePowerPlantProduced(PowerPlant powerPlant)
        {
            var rnd = new Random();

            return new PowerPlantResponse
            {
                Name = powerPlant.Name,
                Power = rnd.Next(1000)
            };
        }
    }
}
