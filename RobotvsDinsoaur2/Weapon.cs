using System;
namespace RobotVsDinosaurUpdated;



public class Weapon
{
    string type;
    public int AttackPower;

    public Weapon(string type, int AttackPower)
    {
        this.type = type;
        this.AttackPower = AttackPower;
    }
}
