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

        private string Name { get; }

        public float MaxScore
        {
            get => maxScore;
            set
            {
                if (value > maxScore)
                    maxScore = value;
            }
        }
    }
}