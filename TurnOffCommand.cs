using System;
namespace CommandPattern
{
    public class TurnOffCommand : ICommand
    {
        private LightBulb _light;

        public TurnOffCommand(LightBulb light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

}

