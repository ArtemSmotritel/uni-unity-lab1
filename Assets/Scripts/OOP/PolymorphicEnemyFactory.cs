using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphic : MonoBehaviour
{
    EnemyFactory GetEnemyFactory()
    {
        return new DesertEnemyFactory();
    }

    private Enemy enemy;
    private EnemyBoss boss;
    private FlyingEnemy flyingShit;
    private EnemyFactory factory;

    // Start is called before the first frame update
    void Start()
    {
        // should be a call to an external resource that decides which factory to instantiate
        factory = GetEnemyFactory();

        enemy = factory.CreateEnemy();
        flyingShit = factory.CreateFlyingEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.enemy.IsAlive && !this.flyingShit.IsAlive)
        {
            this.boss = factory.CreateEnemyBoss();
        }

        if (this.boss.IsAlive)
        {
            Debug.Log(boss.Roar());
        }

        if (this.enemy.IsAlive)
        {
            Debug.Log(enemy.Roar());
        }

        if (this.flyingShit.IsAlive)
        {
            Debug.Log(flyingShit.Roar());
        }
    }

    abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy();
        public abstract EnemyBoss CreateEnemyBoss();
        public abstract FlyingEnemy CreateFlyingEnemy();
    }

    class JungleEnemyFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new JungleEnemy();
        }

        public override EnemyBoss CreateEnemyBoss()
        {
            return new JungleEnemyBoss();
        }

        public override FlyingEnemy CreateFlyingEnemy()
        {
            return new FlyingJungleEnemy();
        }
    }

    class DesertEnemyFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new DesertEnemy();
        }

        public override EnemyBoss CreateEnemyBoss()
        {
            return new DesertEnemyBoss();
        }

        public override FlyingEnemy CreateFlyingEnemy()
        {
            return new FlyingDesertEnemy();
        }
    }

    abstract class Enemy
    {
        public bool IsAlive { get; }
        public abstract string Roar();
    }

    class JungleEnemy : Enemy
    {
        public override string Roar()
        {
            return "Raar";
        }
    }

    class DesertEnemy : Enemy
    {
        public override string Roar()
        {
            return "Hhhh";
        }
    }

    abstract class EnemyBoss : Enemy
    {
        // implementation
    }

    class JungleEnemyBoss : EnemyBoss
    {
        // implementation
        public override string Roar()
        {
            return "RAAaaaAAArrR";
        }
    }

    class DesertEnemyBoss : EnemyBoss
    {
        public override string Roar()
        {
            return "HHhhhHHHhhhh";
        }
    }

    abstract class FlyingEnemy : Enemy
    {
        // implementation
    }

    class FlyingJungleEnemy : FlyingEnemy
    {
        public override string Roar()
        {
            return "Bzzz";
        }
    }

    class FlyingDesertEnemy : FlyingEnemy
    {
        public override string Roar()
        {
            return "Ssss";
        }
    }
}
