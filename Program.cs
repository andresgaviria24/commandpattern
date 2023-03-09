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

            // Crear el invocador y asignar comandos
            Invoker invoker = new Invoker();
            invoker.SetCommand(turnOnCommand);
            invoker.PressButton();  // La luz está encendida
            invoker.SetCommand(turnOffCommand);
            invoker.PressButton();  // La luz está apagada

        }
    }
}

