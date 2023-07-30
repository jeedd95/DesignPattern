using System;

namespace DesignPattern.Strategy
{
    internal abstract class Character
    {
        private WeaponBehavior weapon;

        public void SetWeapon(WeaponBehavior weapon)
        {
            this.weapon = weapon;
        }

        public void Attack()
        {
            weapon.UseWeapon();
        }

    }
}
