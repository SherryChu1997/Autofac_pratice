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
            throw new NotImplementedException();
        }

        public void On()
        {
            throw new NotImplementedException();
        }
    }

    internal class Light
    {
        internal void pull()
        {
            var lightButton = new Button();
            lightButton.On();
        }

        internal void pullTwice()
        {
            var lightButton = new Button();
            lightButton.Off();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}