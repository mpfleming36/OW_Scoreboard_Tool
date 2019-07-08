using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OW_Scoreboard_Tool.Controls
{
    public partial class CreateObjectDialog : Form
    {
        private string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string _objectName = "";
        private Bitmap _objectImage = new Bitmap(Properties.Resources.Icon_none);

        public CreateObjectDialog()
        {
            InitializeComponent();
        }

        public string ObjectName
        {
            get => _objectName;
            set => _objectName = value;
        }

        public Bitmap ObjectImage
        {
            get => _objectImage;
            set => _objectImage = value;
        }

        private void CreateObjectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetObjects()
        {
            ObjectName = CreateObjectNameTextBox.Text.ToString();
            ObjectImage = new Bitmap(CreateObjectIconButton.AccessibleDescription);
        }

        public virtual void CreateObjectOKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreateObjectIconButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; )|*.png";
            open.InitialDirectory = path;
            DialogResult res = open.ShowDialog();
            if (res == DialogResult.OK)
            {
                ((Button)sender).AccessibleDescription = open.FileName;
            }
        }
    }
}
