namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Example of polymorphism in C# using abstract classes on Mercedes Benz cars
/// </summary>
public class MercedesBenzCar : Car
{
    public override void StartEngine()
    {
        Console.WriteLine(value: "Turning on the ignition and starting the Mercedes-Benz S Class...");
    }

    public override void StopEngine()
    {
        Console.WriteLine(value: "Turning off the ignition and stopping the Mercedes-Benz S Class...");
    }
}