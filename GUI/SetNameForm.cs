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
    public partial class SetNameForm : Form
    {
        private MainWindow mainWindow;

        public SetNameForm(string NameTextBox, MainWindow mWindow)
        {
            InitializeComponent();            
            this.SetNameTextBox.Text = NameTextBox;
            this.mainWindow = mWindow;
        }        

        private void SetName_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = (MainWindow)this.Owner;
            mainWindow.SetLabelFigureName(SetNameTextBox.Text);
            this.Dispose();            
        }

        private void SetNameForm_Load(object sender, EventArgs e)
        {
            this.SetNameTextBox.Select();
        }        
    }
}
