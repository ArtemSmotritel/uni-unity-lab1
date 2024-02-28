using UnityEngine;

namespace MyOOP
{
    public class InheritedEnemyFactory : MonoBehaviour
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
            if (!this.enemy.IsAlive && !this.flyingShit.IsAlive && this.boss is null)
            {
                this.boss = factory.CreateEnemyBoss();
            }

            if ((bool)(this.boss?.IsAlive))
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
    }

}
