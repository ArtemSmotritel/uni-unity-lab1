using UnityEngine;

namespace MyOOP
{
    public abstract class Enemy : ISpecialSceneObject
    {
        public int MaxHealth { get; protected set; }
        public int Health { get; set; }
        public bool IsAlive { get; }

        public void Accept(Visitor visitor)
        {
            visitor.VisitEnemy(this);
        }

        public abstract string Roar();
    }

    class JungleEnemy : Enemy
    {
        public override string Roar()
        {
            return "Raar";
        }

        public void SpecialJungleAction()
        {
            int k = MaxHealth - Health;
            Debug.Log(new string('j', k));
        }
    }

    public class DesertEnemy : Enemy
    {
        public override string Roar()
        {
            return "Hhhh";
        }

        public void SpecialDesertAction()
        {
            int k = MaxHealth - Health;
            Debug.Log(new string('d', k));
        }
    }

    abstract class EnemyBoss : Enemy
    {
        // implementation
    }

    class JungleEnemyBoss : EnemyBoss
    {
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
