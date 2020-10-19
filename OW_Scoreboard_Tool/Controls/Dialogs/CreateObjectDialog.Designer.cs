namespace OW_Scoreboard_Tool.Controls
{
    abstract partial class CreateObjectDialog
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
            this.CreateObjectOKButton = new System.Windows.Forms.Button();
            this.CreateObjectCancelButton = new System.Windows.Forms.Button();
            this.CreateObjectNameLabel = new System.Windows.Forms.Label();
            this.CreateObjectNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateObjectIconButton = new System.Windows.Forms.Button();
            this.CreateObjectIconLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateObjectOKButton
            // 
            this.CreateObjectOKButton.Location = new System.Drawing.Point(13, 98);
            this.CreateObjectOKButton.Name = "CreateObjectOKButton";
            this.CreateObjectOKButton.Size = new System.Drawing.Size(75, 23);
            this.CreateObjectOKButton.TabIndex = 0;
            this.CreateObjectOKButton.Text = "OK";
            this.CreateObjectOKButton.UseVisualStyleBackColor = true;
            this.CreateObjectOKButton.Click += new System.EventHandler(this.CreateObjectOKButton_Click);
            // 
            // CreateObjectCancelButton
            // 
            this.CreateObjectCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreateObjectCancelButton.Location = new System.Drawing.Point(94, 98);
            this.CreateObjectCancelButton.Name = "CreateObjectCancelButton";
            this.CreateObjectCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CreateObjectCancelButton.TabIndex = 1;
            this.CreateObjectCancelButton.Text = "Cancel";
            this.CreateObjectCancelButton.UseVisualStyleBackColor = true;
            this.CreateObjectCancelButton.Click += new System.EventHandler(this.CreateObjectCancelButton_Click);
            // 
            // CreateObjectNameLabel
            // 
            this.CreateObjectNameLabel.AutoSize = true;
            this.CreateObjectNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateObjectNameLabel.Name = "CreateObjectNameLabel";
            this.CreateObjectNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CreateObjectNameLabel.TabIndex = 2;
            this.CreateObjectNameLabel.Text = "Name";
            // 
            // CreateObjectNameTextBox
            // 
            this.CreateObjectNameTextBox.Location = new System.Drawing.Point(69, 6);
            this.CreateObjectNameTextBox.Name = "CreateObjectNameTextBox";
            this.CreateObjectNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreateObjectNameTextBox.TabIndex = 3;
            // 
            // CreateObjectIconButton
            // 
            this.CreateObjectIconButton.Location = new System.Drawing.Point(69, 33);
            this.CreateObjectIconButton.Name = "CreateObjectIconButton";
            this.CreateObjectIconButton.Size = new System.Drawing.Size(100, 23);
            this.CreateObjectIconButton.TabIndex = 4;
            this.CreateObjectIconButton.Text = "...";
            this.CreateObjectIconButton.UseVisualStyleBackColor = true;
            this.CreateObjectIconButton.Click += new System.EventHandler(this.CreateObjectIconButton_Click);
            // 
            // CreateObjectIconLabel
            // 
            this.CreateObjectIconLabel.AutoSize = true;
            this.CreateObjectIconLabel.Location = new System.Drawing.Point(12, 38);
            this.CreateObjectIconLabel.Name = "CreateObjectIconLabel";
            this.CreateObjectIconLabel.Size = new System.Drawing.Size(28, 13);
            this.CreateObjectIconLabel.TabIndex = 5;
            this.CreateObjectIconLabel.Text = "Icon";
            // 
            // CreateObjectDialog
            // 
            this.AcceptButton = this.CreateObjectOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CreateObjectCancelButton;
            this.ClientSize = new System.Drawing.Size(181, 133);
            this.Controls.Add(this.CreateObjectIconLabel);
            this.Controls.Add(this.CreateObjectIconButton);
            this.Controls.Add(this.CreateObjectNameTextBox);
            this.Controls.Add(this.CreateObjectNameLabel);
            this.Controls.Add(this.CreateObjectCancelButton);
            this.Controls.Add(this.CreateObjectOKButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 172);
            this.Name = "CreateObjectDialog";
            this.Text = "CreateObjectDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateObjectOKButton;
        private System.Windows.Forms.Button CreateObjectCancelButton;
        private System.Windows.Forms.Label CreateObjectNameLabel;
        private System.Windows.Forms.TextBox CreateObjectNameTextBox;
        private System.Windows.Forms.Button CreateObjectIconButton;
        private System.Windows.Forms.Label CreateObjectIconLabel;
    }
}