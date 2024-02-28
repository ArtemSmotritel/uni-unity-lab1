using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyOOP
{
    // entry point
    public class Interface
    {
        static List<ISpecialSceneObject> GetSpecialSceneObjects()
        {
            return new List<ISpecialSceneObject>();
        }

        public static void main(string[] args)
        {
            var visitor = new ExplosionVisitor();

            var specialObjects = GetSpecialSceneObjects();
            for (int i = 0; i < specialObjects.Count; i++)
            {
                specialObjects[i].Accept(visitor);
            }
        }
    }

    interface ISpecialSceneObject
    {
        public void Accept(Visitor visitor);
    }

    public abstract class Visitor
    {
        public abstract void VisitStructure(Structure structure);
        public abstract void VisitEnemy(Enemy enemy);
    }

    class ExplosionVisitor : Visitor
    {
        public override void VisitEnemy(Enemy enemy)
        {
            enemy.Health -= 1;
        }

        public override void VisitStructure(Structure structure)
        {
            structure.Health -= 1;
        }
    }

    public class Structure : ISpecialSceneObject
    {
        public int Health { get; set; }
        public void Accept(Visitor visitor)
        {
            visitor.VisitStructure(this);
        }
    }

}
