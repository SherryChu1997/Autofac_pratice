using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

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
        private readonly IButton _circleButton;
        private readonly IButton _lightButton;

        public Light(IButton lightButton, IButton circleButton)
        {
            _lightButton = lightButton;
            _circleButton = circleButton;
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
            //這是版本三，使用autofac

            //(步驟1:建立ContainerBuilder)
            ContainerBuilder builder = new ContainerBuilder();

            //(步驟2:註冊型別)
            builder.RegisterType<DecideButton>().As<IButton>();
            builder.RegisterType<Light>();//key!!!也要註冊!

            //(步驟3:建立容器)
            var container = builder.Build();

            //(步驟4:使用容器取得所需物件)
            container.Resolve<Light>().Pull();
            container.Resolve<Light>().PullTwice();

            var light2 = container.Resolve<Light>();
            light2.PullTwice();
            Console.ReadKey();

            ////PS:覺得奇怪xDD，雖然沒有作用，卻也沒出錯////
            //IButton button = container.Resolve<IButton>();
            //button.Off();

            //這是版本二，我的燈要有兩個按鈕(參數)，每生出幾盞燈，燈就要有那些參數
            //var button = new Button();
            //var light = new Light(button,button);
            //var light1 = new Light(button,button);

            //這是版本一，要使用new
            //newLight.Pull();//then turn on
            //newLight.PullTwice();//then turn off
        }
    }
}