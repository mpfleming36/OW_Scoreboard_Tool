using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Hero
    {
        #region Properties
        private string _name;
        private Bitmap _icon;
        private Bitmap _portrait;
        private Bitmap _threeD;

        public string Name { get => _name; set => _name = value; }
        public Bitmap Icon { get => _icon; set => _icon = value; }
        public Bitmap Portrait { get => _portrait; set => _portrait = value; }
        public Bitmap ThreeD { get => _threeD; set => _threeD = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Hero()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <param name="portrait"></param>
        /// <param name="threeD"></param>
        public Hero(string name, Bitmap icon, Bitmap portrait, Bitmap threeD)
        {
            _name = name;
            _icon = icon;
            _portrait = portrait;
            _threeD = threeD;
        }
        #endregion
    }
}
