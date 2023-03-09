using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de Bombillo
            LightBulb lightBulb = new LightBulb();

            // Crear comandos
            ICommand turnOnCommand = new TurnOnCommand(lightBulb);
            ICommand turnOffCommand = new TurnOffCommand(lightBulb);

            // Crear el control remoto y asignar comandos
            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(turnOnCommand);
            remoteControl.PressButton();  // La luz está encendida
            remoteControl.SetCommand(turnOffCommand);
            remoteControl.PressButton();  // La luz está apagada
            
        }
    }
}

