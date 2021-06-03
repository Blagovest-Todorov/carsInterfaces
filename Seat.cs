﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Hi";  
        }

        public string Stop()
        {
            return "Bye";
        }
    }
}
