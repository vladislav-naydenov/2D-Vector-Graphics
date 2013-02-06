using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2D_Vector_Graphics.GUI
{
    public partial class SetBorderWidthForm : Form
    {
        private MainWindow mainWindow;

        public SetBorderWidthForm(string WidthTextBox, MainWindow mWindow)
        {
            InitializeComponent();
            this.SetWidthTextBox.Text = WidthTextBox;
            this.mainWindow = mWindow;
        }
        
        private void SetWidthButton_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = (MainWindow)this.Owner;
            mainWindow.SetContourWidth(this.SetWidthTextBox.Text);
            this.Dispose();
        }

        private void SetBorderWidthForm_Load(object sender, EventArgs e)
        {
            this.SetWidthTextBox.Select();
        }
    }
}
