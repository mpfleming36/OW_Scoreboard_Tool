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
    public partial class SelectMapDialog : SelectObjectDialog
    {
        private Map _SelectdMap;
        private BindingList<Gametype> _availableGametypes;

        public Map SelectdMap{ get => _SelectdMap; set => _SelectdMap = value; }
        public BindingList<Gametype> AvailableGametypes { get => _availableGametypes; set => _availableGametypes = value; }

        public SelectMapDialog()
        {
            InitializeComponent();
        }

        public void SetGametypeList(BindingList<Gametype> gametypes)
        {
            AvailableGametypes = gametypes;

            SelectMapGametypeComboBox.Items.Clear();
            SelectMapGametypeComboBox.DataSource = new BindingSource { DataSource = AvailableGametypes };
            SelectMapGametypeComboBox.DisplayMember = "Name";
        }

        public override void SelectObjectOKButton_Click(object sender, EventArgs e)
        {
            SetObjects();
            SelectdMap = new Map(ObjectName, ((Gametype)SelectMapGametypeComboBox.SelectedItem), ObjectImage, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
