namespace DesignPattern.Command
{
    internal class Tester
    {
        public static void Main()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl(); //인보커
            Light light = new Light(); //리시버
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
        }
    }
}
