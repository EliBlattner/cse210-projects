using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        EnemyRaider enemyRadier1 = new EnemyRaider();
        string name = enemyRadier1.GetName();
        int health = enemyRadier1.GetHitpoints();
        int damage = enemyRadier1.GetDamage();
        int aggroRange = enemyRadier1.GetAggroRadius();
        bool canFly = enemyRadier1.GetCanFlyBool();
        Console.WriteLine($"Name: {name}\nTotal Health: {health}\nDamage: {damage}\n");
        Console.WriteLine($"Name: {name}\nTotal Health: {health}\nDamage: {damage}\nAggro Radius: {aggroRange}\nFlying: {canFly}\n");

    }
}