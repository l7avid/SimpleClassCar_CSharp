using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;
        public Car(string name, int hp, string color = "black") 
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine($"{name} was created");
        }

        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped!");
        }

        public void Details()
        {
            Console.WriteLine($"Your {_color} car is {_name} and has {_hp} HP");
        }
    }
}
