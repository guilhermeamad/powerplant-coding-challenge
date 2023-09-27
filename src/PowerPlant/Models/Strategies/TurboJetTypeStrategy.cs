using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Models.Views;

namespace PowerPlant.Models.Strategies
{
    public class TurboJetTypeStrategy : ITurboJetTypeStrategy
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
