using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class DiceCombo
    {
        private static StringBuilder _description = new StringBuilder();
        public static string Description(ComboType comboType)
        {
            _description.Clear();

            if (comboType == ComboType.Aces ||
                comboType == ComboType.Twos ||
                comboType == ComboType.Threes ||
                comboType == ComboType.Fours ||
                comboType == ComboType.Fives ||
                comboType == ComboType.Sixes)
            {
                _description.Append("Sum up all ");
                _description.Append(comboType.ToString());
                _description.Append(" then add to base damage.");
            }
            //else if (comboType == ComboType.Pair)
            //{
            //    _description.Append("Unused");
            //}
            else if (comboType == ComboType.ThreeOfAKind)
            {
                _description.Append("Add die value to base damage then multiply by 3.");
            }
            else if (comboType == ComboType.FourOfAKind)
            {
                _description.Append("Add die value to base damage then multiply by 4.");
            }
            else if (comboType == ComboType.Straight)
            {
                _description.Append("Add base damage to each die then add them all together.");
            }
            else if (comboType == ComboType.FullHouse)
            {
                _description.Append("Add 3x die value to base damage and multiply by 3 then add 2x die value and multiply by 2.");
            }
            else if (comboType == ComboType.Yahtzee)
            {
                _description.Append("Add die value to base damage then multiply by 5.");
            }

            return _description.ToString();
        }
        private static StringBuilder _name = new StringBuilder();
        public static string Name(ComboType comboType)
        {
            _name.Clear();

            if (comboType == ComboType.Aces ||
                comboType == ComboType.Twos ||
                comboType == ComboType.Threes ||
                comboType == ComboType.Fours ||
                comboType == ComboType.Fives ||
                comboType == ComboType.Sixes ||
                comboType == ComboType.Straight ||
                comboType == ComboType.Yahtzee)
            {
                _name.Append(comboType.ToString());
            }
            //else if (comboType == ComboType.Pair)
            //{
            //    _name.Append("Unused");
            //}
            else if (comboType == ComboType.ThreeOfAKind)
            {
                _name.Append("Three of a Kind");
            }
            else if (comboType == ComboType.FourOfAKind)
            {
                _name.Append("Four of a Kind");
            }
            else if (comboType == ComboType.FullHouse)
            {
                _name.Append("Full House");
            }

            return _name.ToString();
        }
        public static int Damage(ComboType comboType, List<int> diceValues)
        {
            int dmg = 0;

            diceValues.Sort();

            if (comboType == ComboType.Aces ||
                comboType == ComboType.Twos ||
                comboType == ComboType.Threes ||
                comboType == ComboType.Fours ||
                comboType == ComboType.Fives ||
                comboType == ComboType.Sixes)
            {
                foreach (int value in diceValues)
                {
                    if (value == (int)comboType)
                    {
                        dmg += (int)comboType;
                    }
                }
            }
            //else if (comboType == ComboType.Pair)
            //{
            //    foreach (int value in diceValues)
            //    {
            //        if (diceValues.Count(i => i == value) == 2)
            //        {
            //            dmg += ((dmg + value) * 2);
            //            break;
            //        }
            //    }
            //}
            else if (comboType == ComboType.ThreeOfAKind)
            {
                foreach (int value in diceValues)
                {
                    if (diceValues.Count(i => i == value) == 3)
                    {
                        dmg += ((dmg + value) * 3);
                        break;
                    }
                }
            }
            else if (comboType == ComboType.FourOfAKind)
            {
                foreach (int value in diceValues)
                {
                    if (diceValues.Count(i => i == value) == 4)
                    {
                        dmg += ((dmg + value) * 4);
                        break;
                    }
                }
            }
            else if (comboType == ComboType.Straight)
            {
                if ((diceValues[0] + 1) == diceValues[1] &&
                    (diceValues[1] + 1) == diceValues[2] &&
                    (diceValues[2] + 1) == diceValues[3] &&
                    (diceValues[3] + 1) == diceValues[4])
                {
                    foreach (int value in diceValues)
                    {
                        dmg += (dmg + value);
                    }
                }
            }
            else if (comboType == ComboType.FullHouse)
            {
                int valMin = diceValues.Min();
                int valMax = diceValues.Max();
                if ((diceValues.Count(i => i == valMin) == 3 &&
                     diceValues.Count(i => i == valMax) == 2))
                {
                    dmg += ((dmg + valMin) * 3);
                    dmg += ((dmg + valMax) * 2);
                }
                else if ((diceValues.Count(i => i == valMin) == 2 &&
                          diceValues.Count(i => i == valMax) == 3))
                {
                    dmg += ((dmg + valMin) * 2);
                    dmg += ((dmg + valMax) * 3);
                }
            }
            else if (comboType == ComboType.Yahtzee)
            {
                if (diceValues.Count(i => i == diceValues[0]) == 5)
                {
                    dmg += (((dmg + diceValues[0]) * 5) * 5);
                }
            }

            return dmg;
        }
    }
}
