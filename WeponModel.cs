// See https://aka.ms/new-console-template for more information
public abstract class Weapons
{
    public string name { get; set; }
    public string damage { get; set; }
    public abstract void Display();
}

public class RangedWepon : Weapons
{
    public int range;
    public int Range
    {
        get {  return range; }
        set {

            if (value > 0)
            {
                range = value;
            }
            
        }
    }
    public RangedWepon(string name,string damage,int range) 
    {
        this.name = name;
        this.damage = damage;
        Range = range;
    }
    public override void Display()
    {
        Console.WriteLine("Name: " + name + "\nDamage: " + damage + "\nRange: " + Range);
    }
}

public class Gun : RangedWepon
{
    public int AmmoCount;

    public Gun(string name, string damage, int range, int ammoCount):base(name,damage,range)
    {
        AmmoCount = ammoCount;
    }

    public override void Display()
    {
        Console.WriteLine("Name: " + name + "\nDamage: " + damage + "\nRange: " + Range + "\nAmmocount: " + AmmoCount);
    }
}

class WeponModel
{
    static void Main(string[] args)
    {
        Weapons[] weapons = new Weapons[3];
        weapons[0] = new Gun("Pistol", "20", 50, 10);
        weapons[1] = new Gun("Rifle", "40", 200, 30);
        weapons[2] = new Gun("SMG", "30", 100, 25);

        for (int i = 0; i < weapons.Length; i++)
        {
            Console.WriteLine("\n----- GUN " + (i + 1) + " -----");
            weapons[i].Display();
        }

    }
}