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
    public partial class SelectGametypeDialog : SelectObjectDialog
    {
        private Gametype _SelectdGametype;

        public Gametype SelectdGametype { get => _SelectdGametype; set => _SelectdGametype = value; }

        public SelectGametypeDialog()
        {
            InitializeComponent();
        }

        public override void SelectObjectOKButton_Click(object sender, EventArgs e)
        {
            SelectdGametype = new Gametype(ObjectName, ObjectImage, "");
        }
    }
}