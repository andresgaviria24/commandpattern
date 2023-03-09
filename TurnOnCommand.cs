using System;
namespace CommandPattern
{
    public class TurnOnCommand : ICommand
    {
        private LightBulb _light;

        public TurnOnCommand(LightBulb light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

}

