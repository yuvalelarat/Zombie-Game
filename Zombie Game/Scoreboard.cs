using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Game
{
    [Serializable]
    internal class Scoreboard
    {
        private int playerScore { get; set; }
        private string playerName { get; set; }
        public Scoreboard()
        {
            playerName = "null";
            playerScore = 0;
        }
        public Scoreboard(int playerScore, string playerName)
        {
            this.playerScore = playerScore;
            this.playerName = playerName;
        }
        public int getplayerScore() 
        {
            return this.playerScore; 
        }
        public string getplayerName() 
        {
            return this.playerName; 
        }
        public void SetPlayerName(string name) 
        {
            this.playerName = name; 
        }

    }
}
