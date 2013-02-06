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
    public partial class Rotation : Form
    {        
        private MainWindow mainWindow = new MainWindow();
        private EventHandler eHandler;

        public Rotation()
        {
            InitializeComponent();
            //eHandler = new EventHandler(ref mainWindow.dialogProcessor);
        }

        private void RotatingButton_Click(object sender, EventArgs e)
        {
            float angle = 0.0F;
            float.TryParse(RotationAngleTextBox.Text, out angle);
            //if (mainWindow.dialogProcessor.SelectedItem != null)
            //{
            //    eHandler.RotateFigure(angle);
            //    this.Dispose();
            //}
            //else
            //{
            //    MessageBox.Show("Не сте селектирали фигура!");
            //}
        }

        private void CancelRotate_Click(object sender, EventArgs e)
        {
            Rotation.ActiveForm.Close();
        }
    }
}
