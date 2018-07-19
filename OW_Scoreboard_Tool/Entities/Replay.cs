using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Replay
    {
        #region Properties
        private string _name;
        private string _replayPath;
        private Series _series;
        private Team _team;
        private List<Player> _Players;

        public string Name { get => _name; set => _name = value; }
        public string ReplayPath { get => _replayPath; set => _replayPath = value; }
        public Series Series { get => _series; set => _series = value; }
        public Team Team { get => _team; set => _team = value; }
        public List<Player> Players { get => _Players; set => _Players = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Replay()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replayPath"></param>
        /// <param name="series"></param>
        public Replay(string name, string replayPath, Series series)
        {
            _name = name;
            _replayPath = replayPath;
            _series = series;
        }
        #endregion
    }
}
