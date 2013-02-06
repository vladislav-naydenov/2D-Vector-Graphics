namespace _2D_Vector_Graphics.GUI
{
    partial class Rotation
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
            this.RotationAngleTextBox = new System.Windows.Forms.TextBox();
            this.CWRadioButton = new System.Windows.Forms.RadioButton();
            this.CCWRadioButton = new System.Windows.Forms.RadioButton();
            this.RotatingButton = new System.Windows.Forms.Button();
            this.CancelRotate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RotationAngleTextBox
            // 
            this.RotationAngleTextBox.Location = new System.Drawing.Point(12, 23);
            this.RotationAngleTextBox.Name = "RotationAngleTextBox";
            this.RotationAngleTextBox.Size = new System.Drawing.Size(100, 20);
            this.RotationAngleTextBox.TabIndex = 0;
            // 
            // CWRadioButton
            // 
            this.CWRadioButton.AutoSize = true;
            this.CWRadioButton.Checked = true;
            this.CWRadioButton.Location = new System.Drawing.Point(129, 9);
            this.CWRadioButton.Name = "CWRadioButton";
            this.CWRadioButton.Size = new System.Drawing.Size(43, 17);
            this.CWRadioButton.TabIndex = 1;
            this.CWRadioButton.TabStop = true;
            this.CWRadioButton.Text = "CW";
            this.CWRadioButton.UseVisualStyleBackColor = true;
            // 
            // CCWRadioButton
            // 
            this.CCWRadioButton.AutoSize = true;
            this.CCWRadioButton.Location = new System.Drawing.Point(129, 37);
            this.CCWRadioButton.Name = "CCWRadioButton";
            this.CCWRadioButton.Size = new System.Drawing.Size(50, 17);
            this.CCWRadioButton.TabIndex = 2;
            this.CCWRadioButton.TabStop = true;
            this.CCWRadioButton.Text = "CCW";
            this.CCWRadioButton.UseVisualStyleBackColor = true;
            // 
            // RotatingButton
            // 
            this.RotatingButton.Location = new System.Drawing.Point(197, 5);
            this.RotatingButton.Name = "RotatingButton";
            this.RotatingButton.Size = new System.Drawing.Size(75, 23);
            this.RotatingButton.TabIndex = 3;
            this.RotatingButton.Text = "Завърти";
            this.RotatingButton.UseVisualStyleBackColor = true;
            this.RotatingButton.Click += new System.EventHandler(this.RotatingButton_Click);
            // 
            // CancelRotate
            // 
            this.CancelRotate.Location = new System.Drawing.Point(197, 38);
            this.CancelRotate.Name = "CancelRotate";
            this.CancelRotate.Size = new System.Drawing.Size(75, 23);
            this.CancelRotate.TabIndex = 4;
            this.CancelRotate.Text = "Отказ";
            this.CancelRotate.UseVisualStyleBackColor = true;
            this.CancelRotate.Click += new System.EventHandler(this.CancelRotate_Click);
            // 
            // Rotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 66);
            this.Controls.Add(this.CancelRotate);
            this.Controls.Add(this.RotatingButton);
            this.Controls.Add(this.CCWRadioButton);
            this.Controls.Add(this.CWRadioButton);
            this.Controls.Add(this.RotationAngleTextBox);
            this.Name = "Rotation";
            this.Text = "Въртене";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RotationAngleTextBox;
        private System.Windows.Forms.RadioButton CWRadioButton;
        private System.Windows.Forms.RadioButton CCWRadioButton;
        private System.Windows.Forms.Button RotatingButton;
        private System.Windows.Forms.Button CancelRotate;
    }
}