using System;

namespace DesignPattern.Strategy
{
    internal class KnifeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("칼로 공격");
        }
    }
}
