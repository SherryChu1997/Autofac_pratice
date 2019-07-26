using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac_pratice
{
    internal class Button
    {
        public void Off()
        {
            Console.WriteLine("TURN OFF!!!");
        }

        public void On()
        {
            Console.WriteLine("TURN ON!!!");
        }
    }

    internal class Light
    {
        private Button _lightButton = new Button();

        internal void pull()
        {
            var lightButton = _lightButton;
            lightButton.On();
        }

        internal void pullTwice()
        {
            var lightButton = _lightButton;
            lightButton.Off();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var newLight = new Light();
            newLight.pull();//then turn on
            newLight.pullTwice();//then turn off
        }
    }
}