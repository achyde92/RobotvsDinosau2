namespace RobotVsDinosaurUpdated;

public class Dinosaur

{
    public string Name;
    public int Health;
    public int AttackPower;

    public Dinosaur(string Name, int Health, int AttackPower)
    {
        this.Name = Name;
        this.Health = Health;
        this.AttackPower = AttackPower;
    }
    public void RecieveDamage(int Damage)
    {
        this.Health -= Damage;
    }
}
