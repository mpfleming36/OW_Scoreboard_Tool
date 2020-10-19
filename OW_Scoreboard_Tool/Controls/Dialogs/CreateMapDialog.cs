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
    public partial class CreateMapDialog : CreateObjectDialog
    {
        public override string TypePath
        {
            get
            {
                return "\\Maps\\";
            }
        }

        private Map _createdMap;
        private BindingList<Gametype> _availableGametypes;

        public Map CreatedMap{ get => _createdMap; set => _createdMap = value; }
        public BindingList<Gametype> AvailableGametypes { get => _availableGametypes; set => _availableGametypes = value; }

        public CreateMapDialog()
        {
            InitializeComponent();
        }

        public void SetGametypeList(BindingList<Gametype> gametypes)
        {
            AvailableGametypes = gametypes;

            CreateMapGametypeComboBox.Items.Clear();
            CreateMapGametypeComboBox.DataSource = new BindingSource { DataSource = AvailableGametypes };
            CreateMapGametypeComboBox.DisplayMember = "Name";
        }

        public override void CreateObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            CreatedMap = new Map(ObjectName, ((Gametype)CreateMapGametypeComboBox.SelectedItem), ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
