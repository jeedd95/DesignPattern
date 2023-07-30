namespace DesignPattern.Strategy
{
    internal class World
    {
        public static void Main(string[] args)
        {
            Character king = new King();
            WeaponBehavior weapon = new KnifeBehavior();
            king.SetWeapon(weapon);
            king.Attack();
        }
    }
}
