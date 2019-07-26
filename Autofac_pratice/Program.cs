using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac_pratice
{
    internal interface IButton
    {
        void Off();

        void On();
    }

    internal class Button : IButton
    {
        public void Off()
        {
            throw new NotImplementedException();
        }

        public void On()
        {
            throw new NotImplementedException();
        }
    }

    internal class DecideButton : IButton
    {
        public void Off()
        {
            Console.WriteLine("Turn Off");
        }

        public void On()
        {
            Console.WriteLine("Turn On");
        }
    }

    internal class Light
    {
        private readonly IButton _lightButton;

        public Light(IButton lightButton)
        {
            _lightButton = lightButton;
        }

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
            var newLight = new Light(new Button());
            newLight.Pull();//then turn on
            newLight.PullTwice();//then turn off
        }
    }
}