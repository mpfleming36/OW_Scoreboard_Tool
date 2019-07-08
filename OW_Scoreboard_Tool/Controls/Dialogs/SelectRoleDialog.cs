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
    public partial class SelectRoleDialog : SelectObjectDialog
    {
        private Role _SelectdRole;

        public Role SelectdRole { get => _SelectdRole; set => _SelectdRole = value; }

        public SelectRoleDialog()
        {
            InitializeComponent();
        }

        public override void SelectObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            SelectdRole = new Role(ObjectName, ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
