namespace PowerPlant.Models.Strategies.Interfaces
{
    public interface IFuelTypeFactory
    {
        IFuelTypeStrategy Create(PowerPlantType type);
    }
}
