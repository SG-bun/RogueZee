using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, string description,
            int amountToHeal) : base(id, name, namePlural, description)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
