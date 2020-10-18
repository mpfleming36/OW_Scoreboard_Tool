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
    public partial class CreateRoleDialog : CreateObjectDialog
    {
        public override string TypePath
        {
            get
            {
                return "\\Roles\\";
            }
        }

        private Role _createdRole;

        public Role CreatedRole { get => _createdRole; set => _createdRole = value; }

        public CreateRoleDialog()
        {
            InitializeComponent();
        }

        public override void CreateObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            CreatedRole = new Role(ObjectName, ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
