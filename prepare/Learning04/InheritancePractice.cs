using System.Collections.Concurrent;

public class Npc
{
    private string _name = "Dave";

    private int _hitpoints = 200;

    private int _damage = 40;


    //Passing each encapsulated instance field
    public string GetName()
    {
        return _name;
    }
    public int GetHitpoints()
    {
        return _hitpoints;
    }
    public int GetDamage()
    {
        return _damage;
    }

}

public class EnemyRaider : Npc
{
    private int _aggroRadius = 450;

    private bool _canFly = true;

    //Passing each encapsulated instance field
    public int GetAggroRadius()
    {
        return _aggroRadius;
    }
    public bool GetCanFlyBool()
    {
        return _canFly;
    }

}