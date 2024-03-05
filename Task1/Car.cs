namespace Task1;

public class Car:IVehacle
{ 
    private int _startFuel;
    public Car(int startFuel)
    {
        _startFuel=startFuel;
    }
    public void Drive()
    {
        if (_startFuel>0)
        {
          System.Console.WriteLine("Driving");  
        }  
        else 
        {
            System.Console.WriteLine("No fuel please refuel car"); 
            System.Console.WriteLine();
        }
    }

    public bool Refuel(int gallon)
    {
        _startFuel+=gallon; 
        System.Console.WriteLine($"Refuled for {gallon} gallon");
        return true;
    }
}
