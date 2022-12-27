using AdmirLive.CSharpPolymorphism.Example;

var carsInGarage = new ICar[2] { new TeslaModelSCar(), new MercedesBenzCar() };

foreach (var car in carsInGarage)
{
    car.StartEngine();
}

Console.WriteLine(value: "Press any key to stop engines...");
Console.ReadLine();

foreach (var car in carsInGarage)
{
    car.StopEngine();
}

await Task.Delay(delay: TimeSpan.FromSeconds(value: 3)); // Wait for 3 seconds in order to see the output