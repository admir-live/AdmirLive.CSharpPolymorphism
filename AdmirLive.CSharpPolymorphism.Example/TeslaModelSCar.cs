namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Example of polymorphism in C# using abstract classes on Tesla Electric Cars
/// </summary>
public sealed class TeslaModelSCar : Car
{
    public override void StartEngine()
    {
        Console.WriteLine(value: "The electric motor in the Tesla Model S car was activated...");
    }

    public override void StopEngine()
    {
        Console.WriteLine(value: "The electric motor in the Tesla Model S car was deactivated...");
    }
}