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
    public partial class CreateHeroDialog : CreateObjectDialog
    {
        private Hero _createdHero;

        public Hero CreatedHero { get => _createdHero; set => _createdHero = value; }

        public CreateHeroDialog()
        {
            InitializeComponent();
        }

        public override void CreateObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            CreatedHero = new Hero(ObjectName, ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
