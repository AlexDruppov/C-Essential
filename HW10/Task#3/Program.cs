using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MagicBox<ICreature> magicBox = new MagicBox<ICreature>();

            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine(magicBox.GetGift(cat));
            Console.WriteLine(magicBox.GetGift(dog));

            Console.ReadKey();
        }
    }
}
