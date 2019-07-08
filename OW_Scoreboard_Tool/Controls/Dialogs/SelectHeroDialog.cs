using OW_Scoreboard_Tool.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OW_Scoreboard_Tool.Controls
{
    public partial class SelectHeroDialog : SelectObjectDialog
    {
        private Hero _SelectdHero;

        public Hero SelectdHero { get => _SelectdHero; set => _SelectdHero = value; }

        public SelectHeroDialog()
        {
            InitializeComponent();
        }

        public override void SelectObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            SelectdHero = new Hero(ObjectName, ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
