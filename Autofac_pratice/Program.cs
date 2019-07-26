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
            //Console.WriteLine("TURN OFF!!!");
            throw NotImplementedException;
        }

        public void On()
        {
            //Console.WriteLine("TURN ON!!!");
            throw NotImplementedException;
        }
    }

    internal class Light
    {
        private readonly Button _lightButton = new Button();

        internal void Pull()
        {
            _lightButton.On();
        }

        internal void PullTwice()
        {
            _lightButton.Off();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var newLight = new Light();
            newLight.Pull();//then turn on
            newLight.PullTwice();//then turn off
        }
    }
}