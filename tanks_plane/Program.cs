using System;
class Tank
{
    public string Name { get; private set; }
    public int Ammo { get; private set; }
    public int Armor { get; private set; }
    public int Maneuverability { get; private set; }
    public int Range { get; private set; }

    public Tank(string name)
    {
        Name = name;
        Random random = new Random();
        Ammo = random.Next(0, 101);
        Armor = random.Next(0, 101);
        Maneuverability = random.Next(0, 101);
        Range = random.Next(0, 101);
    }

    public int GetTotalScore()
    {
        return Ammo + Armor + Maneuverability + Range;
    }
}

class Drone
{
    public string Name { get; private set; }
    public int Ammo { get; private set; }
    public int Armor { get; private set; }
    public int Maneuverability { get; private set; }
    public int Range { get; private set; }
    public int Altitude { get; private set; }

    public Drone(string name)
    {
        Name = name;
        Random random = new Random();
        Ammo = random.Next(0, 101);
        Armor = random.Next(0, 101);
        Maneuverability = random.Next(0, 101);
        Range = random.Next(0, 101);
        Altitude = random.Next(0, 1001); // Висота від 0 до 1000 метрів.
    }

    public int GetTotalScore()
    {
        return Ammo + Armor + Maneuverability + Range;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tank tank1 = new Tank("Т-84");
        Tank tank2 = new Tank("Т-90");
        Drone drone = new Drone("Байрактар ТБ2");

        Console.WriteLine("Бій танків:");
        Console.WriteLine($"{tank1.Name} ({tank1.GetTotalScore()}) проти {tank2.Name} ({tank2.GetTotalScore()})");

        if (tank1.GetTotalScore() > tank2.GetTotalScore())
            Console.WriteLine($"{tank1.Name} переміг {tank2.Name}");
        else if (tank2.GetTotalScore() > tank1.GetTotalScore())
            Console.WriteLine($"{tank2.Name} переміг {tank1.Name}");
        else
            Console.WriteLine("Нічия");

        Console.WriteLine("\nБій безпілотника та танків:");
        Console.WriteLine($"{drone.Name} ({drone.GetTotalScore()}) проти {tank1.Name} ({tank1.GetTotalScore()}) і {tank2.Name} ({tank2.GetTotalScore()})");

        int droneScore = drone.GetTotalScore();
        int tanksScore = tank1.GetTotalScore() + tank2.GetTotalScore();

        if (droneScore > tanksScore)
            Console.WriteLine($"{drone.Name} завдав значні ушкодження танкам.");
        else if (droneScore < tanksScore)
            Console.WriteLine($"{drone.Name} був знищений танками.");
        else
            Console.WriteLine("Нічия");
    }
}