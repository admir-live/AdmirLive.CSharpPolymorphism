namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Example of using the interface ICar for the class TeslaModelSCar.
/// </summary>
public sealed class TeslaModelSCar : ICar
{
    public void StartEngine()
    {
        Console.WriteLine(value: "The electric motor in the Tesla Model S car was activated...");
    }

    public void StopEngine()
    {
        Console.WriteLine(value: "The electric motor in the Tesla Model S car was deactivated...");
    }
}