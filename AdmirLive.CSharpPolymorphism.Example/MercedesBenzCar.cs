namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Example of using the interface ICar for the class MercedesBenzCar.
/// </summary>
public sealed class MercedesBenzCar : ICar
{
    public void StartEngine()
    {
        Console.WriteLine(value: "Turning on the ignition and starting the Mercedes-Benz S Class...");
    }

    public void StopEngine()
    {
        Console.WriteLine(value: "Turning off the ignition and stopping the Mercedes-Benz S Class...");
    }
}
