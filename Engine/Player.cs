using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int XP { get; private set; }
        public int Lvl
        {
            get { return ((XP / 100) + 1); }
        }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<InventoryItem> Inventory { get; private set; }

        public Player(int currentHP, int maximumHP,
            int gold, int xp) : base(currentHP, maximumHP)
        {
            Gold = gold;
            XP = xp;

            Attack = 2;
            Defense = 2;

            Inventory = new List<InventoryItem>();
        }
        public void AddXP(int addedXP)
        {
            XP += addedXP;
            MaximumHP = (Lvl * 10);
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            InventoryItem item = Inventory.SingleOrDefault(
                ii => ii.Details.ID == itemToAdd.ID);
            
            if (item == null)
            {
                // They don't have the item so add it
                // with quantity of 1
                Inventory.Add(new InventoryItem(itemToAdd, 1));
            }
            else
            {
                // They ahve the item so increase the quantity by 1
                item.Quantity++;
            }
        }
        
        public string ToXMLString()
        {
            XmlDocument playerData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            // Create the child nodes for the "Stats" node
            XmlNode currentHP = playerData.CreateElement("CurrentHP");
            currentHP.AppendChild(playerData.CreateTextNode(
                this.CurrentHP.ToString()));
            stats.AppendChild(currentHP);

            XmlNode maximumHP = playerData.CreateElement("MaximumHP");
            maximumHP.AppendChild(playerData.CreateTextNode(
                this.MaximumHP.ToString()));
            stats.AppendChild(maximumHP);
            
            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(
                this.Gold.ToString()));
            stats.AppendChild(gold);
            
            XmlNode xp = playerData.CreateElement("XP");
            xp.AppendChild(playerData.CreateTextNode(
                this.XP.ToString()));
            stats.AppendChild(xp);

            // Create the "InventoryItems" child node to hold each InventoryItem node
            XmlNode inventoryItems = playerData.CreateElement("InventoryItems");
            player.AppendChild(inventoryItems);

            // Create an "InventoryItem" node for each item in the player's inventory
            foreach (InventoryItem item in this.Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            return playerData.InnerXml; // The XML document as a string so we can
                                        // save the data to disk

        }

    }
}
