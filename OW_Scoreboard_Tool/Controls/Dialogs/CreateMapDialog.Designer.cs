namespace OW_Scoreboard_Tool.Controls
{
    partial class CreateMapDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateMapGametypeComboBox = new System.Windows.Forms.ComboBox();
            this.CreateMapGametypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateMapGametypeComboBox
            // 
            this.CreateMapGametypeComboBox.FormattingEnabled = true;
            this.CreateMapGametypeComboBox.Location = new System.Drawing.Point(69, 63);
            this.CreateMapGametypeComboBox.Name = "CreateMapGametypeComboBox";
            this.CreateMapGametypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.CreateMapGametypeComboBox.TabIndex = 6;
            // 
            // CreateMapGametypeLabel
            // 
            this.CreateMapGametypeLabel.AutoSize = true;
            this.CreateMapGametypeLabel.Location = new System.Drawing.Point(8, 66);
            this.CreateMapGametypeLabel.Name = "CreateMapGametypeLabel";
            this.CreateMapGametypeLabel.Size = new System.Drawing.Size(55, 13);
            this.CreateMapGametypeLabel.TabIndex = 7;
            this.CreateMapGametypeLabel.Text = "Gametype";
            // 
            // CreateMapDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(181, 133);
            this.Controls.Add(this.CreateMapGametypeLabel);
            this.Controls.Add(this.CreateMapGametypeComboBox);
            this.Name = "CreateMapDialog";
            this.Text = "Create Map";
            this.Controls.SetChildIndex(this.CreateMapGametypeComboBox, 0);
            this.Controls.SetChildIndex(this.CreateMapGametypeLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CreateMapGametypeComboBox;
        private System.Windows.Forms.Label CreateMapGametypeLabel;
    }
}
