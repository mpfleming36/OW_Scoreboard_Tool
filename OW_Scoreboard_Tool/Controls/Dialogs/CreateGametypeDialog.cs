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
    public partial class CreateGametypeDialog : CreateObjectDialog
    {
        public override string TypePath
        {
            get
            {
                return "\\Gametypes\\";
            }
        }

        private Gametype _createdGametype;

        public Gametype CreatedGametype { get => _createdGametype; set => _createdGametype = value; }

        public CreateGametypeDialog()
        {
            InitializeComponent();
        }

        public override void CreateObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            CreatedGametype = new Gametype(ObjectName, ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
