namespace OW_Scoreboard_Tool.Controls
{
    partial class SelectMapDialog
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
            this.SelectMapGametypeComboBox = new System.Windows.Forms.ComboBox();
            this.SelectMapGametypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectMapGametypeComboBox
            // 
            this.SelectMapGametypeComboBox.FormattingEnabled = true;
            this.SelectMapGametypeComboBox.Location = new System.Drawing.Point(69, 63);
            this.SelectMapGametypeComboBox.Name = "SelectMapGametypeComboBox";
            this.SelectMapGametypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.SelectMapGametypeComboBox.TabIndex = 6;
            // 
            // SelectMapGametypeLabel
            // 
            this.SelectMapGametypeLabel.AutoSize = true;
            this.SelectMapGametypeLabel.Location = new System.Drawing.Point(8, 66);
            this.SelectMapGametypeLabel.Name = "SelectMapGametypeLabel";
            this.SelectMapGametypeLabel.Size = new System.Drawing.Size(55, 13);
            this.SelectMapGametypeLabel.TabIndex = 7;
            this.SelectMapGametypeLabel.Text = "Gametype";
            // 
            // SelectMapDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(181, 133);
            this.Controls.Add(this.SelectMapGametypeLabel);
            this.Controls.Add(this.SelectMapGametypeComboBox);
            this.Name = "SelectMapDialog";
            this.Text = "Select Map";
            this.Controls.SetChildIndex(this.SelectMapGametypeComboBox, 0);
            this.Controls.SetChildIndex(this.SelectMapGametypeLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMapGametypeComboBox;
        private System.Windows.Forms.Label SelectMapGametypeLabel;
    }
}
