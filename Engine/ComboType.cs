using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public enum ComboType
    {
        Aces = 1,
        Twos = 2,
        Threes = 3,
        Fours = 4,
        Fives = 5,
        Sixes = 6,
        //Pair,
        ThreeOfAKind,
        FourOfAKind,
        Straight,
        FullHouse,
        Yahtzee
    }
}
