namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Base class for car objects
/// </summary>
public abstract class Car
{
    public virtual void StartEngine()
    {
        Console.WriteLine(value: "Car engine has been started.");
    }

    public virtual void StopEngine()
    {
        Console.WriteLine(value: "Car engine has been stopped.");
    }
}