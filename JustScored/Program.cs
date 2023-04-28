using System;

namespace JustScored
{
    public class Program
    {
        private static void Main()
        {
            PlayerInfo[] playerInfos = {
                new PlayerInfo("Ana"),
                new PlayerInfo("Zé"),
                new PlayerInfo("Doesn't play")
            };

            playerInfos[0].AddGame(false);
            playerInfos[0].AddGame(true);
            playerInfos[0].AddGame(true);
            playerInfos[0].AddGame(false);
            playerInfos[0].AddGame(false);
            playerInfos[0].AddGame(true);
            playerInfos[0].MaxScore = 123;
            playerInfos[0].MaxScore = 40;

            playerInfos[1].AddGame(true);
            playerInfos[1].AddGame(true);
            playerInfos[1].MaxScore = 12;
            playerInfos[1].MaxScore = 67;
            playerInfos[1].MaxScore = 91;
            playerInfos[1].MaxScore = 32;

            foreach (PlayerInfo playerInfo in playerInfos)
            {
                Console.WriteLine($" Player name : {playerInfo.Name}");
                Console.WriteLine($"    Win rate : {playerInfo.RateOfSuccess}");
                Console.WriteLine($"  High score : {playerInfo.MaxScore}");
                Console.WriteLine("--------------------------------");
            }

            // Output deve ser:
            //
            //  Player name : Ana
            //     Win rate : 0.5
            //   High score : 123
            // --------------------------------
            //  Player name : Zé
            //     Win rate : 1
            //   High score : 91
            // --------------------------------
            //  Player name : Doesn't play
            //     Win rate : 0
            //   High score : 0
            // --------------------------------

        }
    }
}
