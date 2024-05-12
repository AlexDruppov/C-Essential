using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Play music");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause the music");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop music");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Start record");
        }
        void IRecodable.Pause() 
        {
            Console.WriteLine("Pause record");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop record");
        }

    }
}
