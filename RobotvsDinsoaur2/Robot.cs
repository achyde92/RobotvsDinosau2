namespace RobotVsDinosaurUpdated;

public class Robot

{
    public string Name;
    public int Health;
    public Weapon ActiveWeapon;

    public Robot(string Name, int Health)
    {
        this.Name = Name;
        this.Health = Health;
        this.ActiveWeapon = new Weapon("sword", 25);
    }
    public void ReceiveDamage(int attackpower)
    {
        this.Health -= attackpower;
    }
}
