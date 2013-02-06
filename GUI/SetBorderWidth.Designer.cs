namespace _2D_Vector_Graphics.GUI
{
    partial class SetBorderWidthForm
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
            this.SetWidthButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SetWidthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetWidthButton
            // 
            this.SetWidthButton.Location = new System.Drawing.Point(24, 76);
            this.SetWidthButton.Name = "SetWidthButton";
            this.SetWidthButton.Size = new System.Drawing.Size(75, 23);
            this.SetWidthButton.TabIndex = 0;
            this.SetWidthButton.Text = "Задай";
            this.SetWidthButton.UseVisualStyleBackColor = true;
            this.SetWidthButton.Click += new System.EventHandler(this.SetWidthButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(168, 76);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Отказ";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // SetWidthTextBox
            // 
            this.SetWidthTextBox.Location = new System.Drawing.Point(69, 31);
            this.SetWidthTextBox.Name = "SetWidthTextBox";
            this.SetWidthTextBox.Size = new System.Drawing.Size(123, 20);
            this.SetWidthTextBox.TabIndex = 2;
            // 
            // SetBorderWidthForm
            // 
            this.AcceptButton = this.SetWidthButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(262, 111);
            this.Controls.Add(this.SetWidthTextBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.SetWidthButton);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetBorderWidthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ширина на контура";
            this.Load += new System.EventHandler(this.SetBorderWidthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetWidthButton;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox SetWidthTextBox;
    }
}