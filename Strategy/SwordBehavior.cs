using System;

namespace DesignPattern.Strategy
{
    internal class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("검으로 공격");
        }
    }
}
