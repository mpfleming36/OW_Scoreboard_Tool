using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Player
    {
        #region Properties
        private string _name;
        private List<Hero> _heroes;
        private Role _role;
        private string _info;
        private string _imagePath;

        public string Name { get => _name; set => _name = value; }
        public List<Hero> Heroes { get => _heroes; set => _heroes = value; }
        public Role Role { get => _role; set => _role = value; }
        public string Info { get => _info; set => _info = value; }
        public string ImagePath { get => _imagePath; set => _imagePath = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="heroes"></param>
        /// <param name="role"></param>
        public Player(string name, List<Hero> heroes, Role role)
        {
            _name = name;
            _heroes = heroes;
            _role = role;
        }
        #endregion

    }
}
