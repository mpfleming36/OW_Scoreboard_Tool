namespace OW_Scoreboard_Tool.Controls
{
    partial class SelectObjectDialog
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
            this.SelectObjectOKButton = new System.Windows.Forms.Button();
            this.SelectObjectCancelButton = new System.Windows.Forms.Button();
            this.SelectObjectNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectObjectOKButton
            // 
            this.SelectObjectOKButton.Location = new System.Drawing.Point(12, 26);
            this.SelectObjectOKButton.Name = "SelectObjectOKButton";
            this.SelectObjectOKButton.Size = new System.Drawing.Size(75, 23);
            this.SelectObjectOKButton.TabIndex = 0;
            this.SelectObjectOKButton.Text = "OK";
            this.SelectObjectOKButton.UseVisualStyleBackColor = true;
            this.SelectObjectOKButton.Click += new System.EventHandler(this.SelectObjectOKButton_Click);
            // 
            // SelectObjectCancelButton
            // 
            this.SelectObjectCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SelectObjectCancelButton.Location = new System.Drawing.Point(93, 26);
            this.SelectObjectCancelButton.Name = "SelectObjectCancelButton";
            this.SelectObjectCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SelectObjectCancelButton.TabIndex = 1;
            this.SelectObjectCancelButton.Text = "Cancel";
            this.SelectObjectCancelButton.UseVisualStyleBackColor = true;
            this.SelectObjectCancelButton.Click += new System.EventHandler(this.SelectObjectCancelButton_Click);
            // 
            // SelectObjectNameLabel
            // 
            this.SelectObjectNameLabel.AutoSize = true;
            this.SelectObjectNameLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectObjectNameLabel.Name = "SelectObjectNameLabel";
            this.SelectObjectNameLabel.Size = new System.Drawing.Size(35, 13);
            this.SelectObjectNameLabel.TabIndex = 2;
            this.SelectObjectNameLabel.Text = "Name";
            // 
            // SelectObjectDialog
            // 
            this.AcceptButton = this.SelectObjectOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SelectObjectCancelButton;
            this.ClientSize = new System.Drawing.Size(181, 61);
            this.Controls.Add(this.SelectObjectNameLabel);
            this.Controls.Add(this.SelectObjectCancelButton);
            this.Controls.Add(this.SelectObjectOKButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 100);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 100);
            this.Name = "SelectObjectDialog";
            this.Text = "SelectObjectDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectObjectOKButton;
        private System.Windows.Forms.Button SelectObjectCancelButton;
        private System.Windows.Forms.Label SelectObjectNameLabel;
    }
}