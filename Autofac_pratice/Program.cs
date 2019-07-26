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
            //Console.WriteLine("TURN OFF!!!");
            throw new NotImplementedException();
        }

        public void On()
        {
            //Console.WriteLine("TURN ON!!!");
            throw new NotImplementedException();
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