namespace _2D_Vector_Graphics.GUI
{
    partial class SetNameForm
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
            this.SetName = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.SetNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(38, 78);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(75, 23);
            this.SetName.TabIndex = 0;
            this.SetName.Text = "Запази";
            this.SetName.UseVisualStyleBackColor = true;
            this.SetName.Click += new System.EventHandler(this.SetName_Click);
            // 
            // Decline
            // 
            this.Decline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Decline.Location = new System.Drawing.Point(173, 78);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(75, 23);
            this.Decline.TabIndex = 1;
            this.Decline.Text = "Откажи";
            this.Decline.UseVisualStyleBackColor = true;
            // 
            // SetNameTextBox
            // 
            this.SetNameTextBox.Location = new System.Drawing.Point(38, 32);
            this.SetNameTextBox.Name = "SetNameTextBox";
            this.SetNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.SetNameTextBox.TabIndex = 2;
            // 
            // SetNameForm
            // 
            this.AcceptButton = this.SetName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Decline;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.SetNameTextBox);
            this.Controls.Add(this.Decline);
            this.Controls.Add(this.SetName);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Име на фигурата";
            this.Load += new System.EventHandler(this.SetNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetName;
        private System.Windows.Forms.Button Decline;
        private System.Windows.Forms.TextBox SetNameTextBox;
    }
}