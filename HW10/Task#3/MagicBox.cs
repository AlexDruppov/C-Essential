using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class MagicBox<T> where T : ICreature
    {
        private Dictionary<string, DateTime> lastGift;
        private Random random;

        public MagicBox()
        {
            lastGift = new Dictionary<string, DateTime>();
            random = new Random();
        }

        private string GenerateGift(string type)
        {
            string[] gifts = { "book", "candy", "cup", "cake" };
            return gifts[random.Next(gifts.Length)];
        }

        public string GetGift(T creature)
        {
            string type = creature.Type;

            if (lastGift.ContainsKey(type) && lastGift[type].Date == DateTime.Now.Date)
            {
                return $"Today {type} get present";
            }

            lastGift[type] = DateTime.Now;
            string gift = GenerateGift(type);
            return $"{type} get {gift}";
        }

       
    }
}
