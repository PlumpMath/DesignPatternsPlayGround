﻿using DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Fly;
using DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks.SubClasses
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
