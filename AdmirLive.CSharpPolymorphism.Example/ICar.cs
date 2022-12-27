namespace AdmirLive.CSharpPolymorphism.Example;

/// <summary>
///     Base interface for all car types.
/// </summary>
public interface ICar
{
    /// <summary>
    ///     Use this method to turn on the car engine.
    /// </summary>
    void StartEngine();

    /// <summary>
    ///     Use this method to turn off the car engine.
    /// </summary>
    void StopEngine();
}