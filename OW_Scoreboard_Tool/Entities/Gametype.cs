using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OW_Scoreboard_Tool.Entities
{
    public class Gametype
    {
        #region Properties
        private string _name = "";
        private Bitmap _icon = Properties.Resources.Icon_none;
        private string _iconPath = "";

        public string Name { get => _name; set => _name = value; }
        [XmlIgnore]
        public Bitmap Icon { get => _icon; set => _icon = value; }
        public string IconPath { get => _iconPath; set => _iconPath = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Gametype()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <param name="iconPath"></param>
        public Gametype(string name, Bitmap icon, string iconPath)
        {
            _name = name;
            _icon = icon;
            _iconPath = iconPath;
        }
        #endregion
    }
}
