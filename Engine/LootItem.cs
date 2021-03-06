﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }
        
        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            //Details = new Item(details.ID, details.Name, details.NamePlural);
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
