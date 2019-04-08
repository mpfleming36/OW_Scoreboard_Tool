using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Bitmap _thumbnail;
        private string _description;
        private Map _map;
        private Team _team;
        private List<Player> _Players;
        private DateTime _created;

        public string Name { get => _name; set => _name = value; }
        public string ReplayPath { get => _replayPath; set => _replayPath = value; }
        public Bitmap Thumbnail { get => _thumbnail; set => _thumbnail = value; }
        public string Description { get => _description; set => _description = value; }
        public Map Map { get => _map; set => _map = value; }
        public Team Team { get => _team; set => _team = value; }
        public List<Player> Players { get => _Players; set => _Players = value; }
        public DateTime Created { get => _created; set => _created = value; }

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
        public Replay(string name, string replayPath)
        {
            _name = name;
            _replayPath = replayPath;
        }
        #endregion
    }
}
