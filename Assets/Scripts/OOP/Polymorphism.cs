using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyOOP
{
    public class Polymorphism : MonoBehaviour
    {
        public static List<Enemy> GetEnemies()
        {
            // implementaion
            return new List<Enemy>();
        }

        public static void Main(string[] args)
        {
            var enemies = GetEnemies();

            for (int i = 0; i < enemies.Count; i++)
            {
                var e = enemies[i];

                if (e is JungleEnemy)
                {
                    ((JungleEnemy)e).SpecialJungleAction();
                }

                if (e is DesertEnemy)
                {
                    ((DesertEnemy)e).SpecialDesertAction();
                }
            }

        }
    }
}
