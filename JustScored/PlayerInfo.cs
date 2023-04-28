using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustScored
{
    public class PlayerInfo
    {
        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;

        public string Name { get; }

        public PlayerInfo(string name)
        {
            Name = name;
            gamesPlayed = 0;
            gamesWon = 0;
            maxScore = 0;
        }

        public float MaxScore
        {
            get => maxScore;
            set
            {
                if (value > maxScore)
                    maxScore = value;
            }
        }

        public float RateOfSuccess
        {
            get
            {
                if (gamesPlayed > 0)
                    return (float)gamesWon / (float)gamesPlayed;
                else
                    return 0;
            }
        }

        public void AddGame(bool win)
        {
            gamesPlayed += 1;
            if (win)
                gamesWon += 1;
        }
    }
}