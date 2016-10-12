using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();

        public const int ITEM_ID_HUNTING_KNIFE = 1; // dagger_(1)
        public const int ITEM_ID_BUTTER_KNIFE = 2; // dagger_(2)
        public const int ITEM_ID_KNIFECICLE = 3; // dagger_(3)
        public const int ITEM_ID_DAGGER_4 = 4; // dagger_(4)
        public const int ITEM_ID_EARTH_DAGGER = 5; // dagger_(5)
        public const int ITEM_ID_LIGHTNING_DAGGER = 6; // dagger_(6)
        public const int ITEM_ID_DAGGER_7 = 7; // dagger_(7)
        public const int ITEM_ID_DAGGER_8 = 8; // dagger_(8)
        public const int ITEM_ID_DAGGER_9 = 9; // dagger_(9)
        public const int ITEM_ID_DAGGER_10 = 10; // dagger_(10)
        public const int ITEM_ID_DAGGER_11 = 11; // dagger_(11)
        public const int ITEM_ID_DAGGER_12 = 12; // dagger_(12)
        public const int ITEM_ID_DAGGER_13 = 13; // dagger_(13)
        public const int ITEM_ID_DAGGER_14 = 14; // dagger_(14)
        public const int ITEM_ID_DAGGER_15 = 15; // dagger_(15)
        public const int ITEM_ID_DAGGER_16 = 16; // dagger_(16)
        public const int ITEM_ID_DAGGER_17 = 17; // dagger_(17)
        public const int ITEM_ID_DAGGER_18 = 18; // dagger_(18)
        public const int ITEM_ID_DAGGER_19 = 19; // dagger_(19)
        public const int ITEM_ID_DAGGER_20 = 20; // dagger_(20)
        public const int ITEM_ID_DAGGER_21 = 21; // dagger_(21)
        public const int ITEM_ID_DAGGER_22 = 22; // dagger_(22)
        public const int ITEM_ID_DAGGER_23 = 23; // dagger_(23)
        public const int ITEM_ID_DAGGER_24 = 24; // dagger_(24)
        public const int ITEM_ID_DAGGER_25 = 25; // dagger_(25)
        public const int ITEM_ID_DAGGER_26 = 26; // dagger_(26)
        public const int ITEM_ID_DAGGER_27 = 27; // dagger_(27)
        public const int ITEM_ID_DAGGER_28 = 28; // dagger_(28)
        public const int ITEM_ID_DAGGER_29 = 29; // dagger_(29)
        public const int ITEM_ID_DAGGER_30 = 30; // dagger_(30)
        public const int ITEM_ID_DAGGER_31 = 31; // dagger_(31)
        public const int ITEM_ID_DAGGER_32 = 32; // dagger_(32)
        public const int ITEM_ID_DAGGER_33 = 33; // dagger_(33)
        public const int ITEM_ID_DAGGER_34 = 34; // dagger_(34)
        public const int ITEM_ID_DAGGER_35 = 35; // dagger_(35)
        public const int ITEM_ID_DAGGER_36 = 36; // dagger_(36)


        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int MONSTER_ID_RAT = 1; // monster_02
        public const int MONSTER_ID_SNAKE = 2; // monster_08
        public const int MONSTER_ID_GIANT_SPIDER = 3; // monster_11

        static World()
        {
            PopulateItems();
            PopulateMonsters();
        }
        
        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_HUNTING_KNIFE, "Rusty sword", "Rusty swords", "A rusty old sword. Still better than nothing.\nDmg: 0-5", 0, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", "The tail of a rat. Quest item."));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", "A chunk of animal fur. Quest item."));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", "The fang of a snake. Quest item."));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", "Skin from a large snake. Quest item."));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", "A crude, but effective, weapon.\nDmg: 3-10", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION,
                "Healing potion", "Healing potions", "Standard health potion.\nHeals 5 HP", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", "The fang of a very large spider. Quest item."));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", "The silk from very large spider. Quest item."));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS,
                "Adventurer pass", "Adventurers passes", "A legal document that allows its holder to venture into more dangerous lands."));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER,
                "Giant Spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_SPIDER_SILK), 75, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }
    }
}
