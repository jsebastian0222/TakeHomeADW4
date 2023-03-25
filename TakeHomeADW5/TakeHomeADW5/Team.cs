using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeADW5
{
    public class Team
    {
        public string teamname
        {
            get;
            set;
        }
        public string teamcountry
        {
            get;
            set;
        }
        public string teamcity
        {
            get;
            set;
        }

        private List<Player> players = new List<Player>();

        public void addplayer(string playernum, string playername, string playerpos)
        {
            Player add = new Player();
            add.playernum = playernum;
            add.playername = playername;
            add.playerpos = playerpos;
            players.Add(add);
        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
    }
}
