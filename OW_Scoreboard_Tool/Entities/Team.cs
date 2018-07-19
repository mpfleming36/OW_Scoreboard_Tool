using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Team
    {
        #region Properties
        private string _name;
        private string _sr;
        private string _logoPath;
        private List<Player> _players;

        public string Name { get => _name; set => _name = value; }
        public string Sr { get => _sr; set => _sr = value; }
        public string LogoPath { get => _logoPath; set => _logoPath = value; }
        public List<Player> Players { get => _players; set => _players = value; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Team()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sr"></param>
        /// <param name="logoPath"></param>
        /// <param name="players"></param>
        public Team(string name, string sr, string logoPath, List<Player> players)
        {
            _name = name;
            _sr = sr;
            _logoPath = logoPath;
            _players = players;
        }
        #endregion
    }
}
