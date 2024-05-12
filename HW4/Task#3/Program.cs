using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable play = player as IPlayable;
            IRecodable recodable = player as IRecodable;
            
            play.Play();
            recodable.Record();
            play.Pause();
            recodable.Stop();

            Console.ReadKey();
        }
    }
}
