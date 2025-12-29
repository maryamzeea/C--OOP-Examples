// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.ComponentModel.DataAnnotations;

public abstract class Car 
{
    public string Name {  get; set; }
    public int Model {  get; set; }
    public string Description;
    public abstract void Display();


}
public class Sedan : Car
{
    
    public Sedan(string name, int model, string description)
    { 
        Name = name;
        Model = model;
        Description = description;
       
    }
  
    public override void Display()
    {
             Console.WriteLine("Car Name: " + Name + "\nModel: " + Model + "\nDescription:\n" + Description);
    }
}

public class Honda : Sedan
{
    public bool IsLuxury { get; set; }
    public string FuelEffeiciency { get; set; }
    public Honda(string name, int model, string description, bool IsLuxury, string FuelEffeiciency) : base(name, model, description)
    {
        this.IsLuxury = IsLuxury;
        this.FuelEffeiciency = FuelEffeiciency;
    }
    public override void Display()
    {
        Console.WriteLine("Car Name: " + Name + "\nModel: " + Model + "\nDescription:\n" + Description +
            "\nFuelEffeiciency: " + FuelEffeiciency + "\nIsLuxury: " + IsLuxury);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Honda honda = new Honda("Civic",2025, "The 2025 Honda Civic comes with updated features compared to older models," +
            "including hybrid engines for better fuel efficiency and a sporty feel, modern safety and tech features " +
            "depending on the trim, and sleek styling that keeps it looking fresh on the road.",true,"36 mpg");
        honda.Display();
    }
}