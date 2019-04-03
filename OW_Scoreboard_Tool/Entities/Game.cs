using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Game
    {
        #region Properties
        private Map _map = new Map();
        private bool _completed = false;
        private bool _selected = false;
        private string _homeScore = "";
        private string _awayScore = "";
        private Team _winner = new Team();

        public Map Map { get => _map; set => _map = value; }
        public bool Completed { get => _completed; set => _completed = value; }
        public bool Selected { get => _selected; set => _selected = value; }
        public string HomeScore { get => _homeScore; set => _homeScore = value; }
        public string AwayScore { get => _awayScore; set => _awayScore = value; }
        public Team Winner { get => _winner; set => _winner = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Game()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="completed"></param>
        /// <param name="selected"></param>
        /// <param name="homeScore"></param>
        /// <param name="awayScore"></param>
        /// <param name="winner"></param>
        public Game(Map map, bool completed, bool selected, string homeScore, string awayScore, Team winner)
        {
            _map = map;
            _completed = completed;
            _selected = selected;
            _homeScore = homeScore;
            _awayScore = awayScore;
            _winner = winner;
        }
        #endregion
    }
}
