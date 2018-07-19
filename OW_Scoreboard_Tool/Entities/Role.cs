using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Role
    {
        #region Properties
        private string _name;
        private Bitmap _icon;

        public string Name { get => _name; set => _name = value; }
        public Bitmap Icon { get => _icon; set => _icon = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Role()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        public Role(string name, Bitmap icon)
        {
            _name = name;
            _icon = icon;
        }
        #endregion
    }
}
