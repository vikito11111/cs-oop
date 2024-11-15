using _05._Composite_Component.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Composite_Component.Models
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private ICollection<GiftBase> gifts;

        public CompositeGift(string name, decimal price) 
            : base(name, price)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            gifts.Remove(gift);
        }

        public override decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            Console.WriteLine($"{Name} contains the following products with prices:");

            foreach (var gift in gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }

            return totalPrice;
        }
    }
}