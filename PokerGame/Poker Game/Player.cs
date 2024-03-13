﻿using System;

namespace Poker_Game
{
    public class Player
    {
        public int id;
        public int balance;
        public bool isActive;
        public Label balanceField;
        public Label bidField;
        public int combinationValue;
        public string combination;
        public string[] hand = new string[2];

        public Player()
        {
            isActive = true;
            balance = 1000;
        }
    }
}
