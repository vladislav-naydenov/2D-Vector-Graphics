using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _2D_Vector_Graphics.GUI

{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();
        private EventHandler eHandler;        

        public MainForm()
        {
            InitializeComponent();
            eHandler = new EventHandler(ref dialogProcessor);
        }

        #region Methods

        public void NewProject1()
        {
            TabPage tabPage = new TabPage("Нов проект " + (tabControl.TabCount + 1));
            Draw.DoubleBufferedPanel NewDrawArea = new Draw.DoubleBufferedPanel();

            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1160, 506);
            tabPage.UseVisualStyleBackColor = true;            

            NewDrawArea.BackColor = System.Drawing.SystemColors.Window;
            NewDrawArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            NewDrawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            NewDrawArea.Location = new System.Drawing.Point(3, 3);
            NewDrawArea.Name = "NewDrawArea";
            NewDrawArea.Size = new System.Drawing.Size(1154, 500);
            NewDrawArea.TabIndex = 4;
            NewDrawArea.Load += new System.EventHandler(NewDrawArea_Load);
            NewDrawArea.Paint += new PaintEventHandler(NewDrawArea_Paint);
            NewDrawArea.MouseDown += new MouseEventHandler(NewDrawArea_MouseDown);
            NewDrawArea.MouseMove += new MouseEventHandler(NewDrawArea_MouseMove);
            NewDrawArea.MouseUp += new MouseEventHandler(NewDrawArea_MouseUp);

            tabPage.Controls.Add(NewDrawArea);
            tabControl.Controls.Add(tabPage);
            tabControl.SelectedTab = tabPage;         
        }

        /*
         * Метод чрез, който променяме ширината на контура на фигурата
         */
        public void SetContourWidth(string FigureContourWidth)
        {          
            int border = 1;
            int.TryParse(FigureContourWidth, out border);
            dialogProcessor.SetBorderWidth(border);            
        }

        /*
         * Метод чрез, който променяме името на селектираната фигура от 
         * формата SetNameForm      
         */
        public void SetLabelFigureName(string NameTextBoxContent)
        {
            eHandler.SetName(NameTextBoxContent);
            DrawArea.Invalidate();
        }               

        /*
         * Метод, който връща индексите на всички бутони съдържащи се в DrawingToolsToolBar контрола
         */
        public int DrawingToolsToolBarGetButtonNo()
        {
            int ButtonNo = 0;

            foreach (ToolBarButton _button in DrawingToolsToolBar.Buttons)
            {
                if (_button.Pushed)
                {
                    ButtonNo = DrawingToolsToolBar.Buttons.IndexOf(_button);
                }
            }

            return ButtonNo;
        }

        /*
         * Метод, който връща индексите на всички бутони съдържащи се в MainToolBar контрола
         */
        public int MainToolBarGetButtonNo()
        {
            int ButtonNo = 0;

            foreach (ToolBarButton _button in MainToolBar.Buttons)
            {
                if (_button.Pushed)
                {
                    ButtonNo = MainToolBar.Buttons.IndexOf(_button);
                }
            }

            return ButtonNo;
        }

        #endregion

        #region Events

        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            eHandler.drawer = e.Graphics;
            dialogProcessor.HandleDrawing(e);
        }        

        private void DrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            eHandler.MouseDown(e.Location);
            DrawArea.Invalidate();
            
            this.NameTextBox.Text = dialogProcessor.messageToStrip;

            if (dialogProcessor.SelectedItem != null)
            {
                this.WidthTextBox.Text = dialogProcessor.SelectedItem.BorderWidth.ToString();
                this.BorderWidthStatusLabel.Text = "Ширина на контура на фигурата: " + dialogProcessor.SelectedItem.BorderWidth.ToString();
            }

            this.NameStatusLabel.Text = "Име на фигурата: " + dialogProcessor.messageToStrip;
        }

        private void DrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            eHandler.MouseUp(e.Location);
        }

        private void DrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            eHandler.MouseMove(e.Location);
            CoordinatesStatusLabel.Text = "Курсор X: " + e.X + ", Y: " + e.Y;
            ActionStatusLabel.Text = "Действие: " + dialogProcessor.ActionT;
            MessageStatusLabel.Text = dialogProcessor.message;
            DrawArea.Invalidate();
        }

        private void DrawArea_Load(object sender, EventArgs e)
        {
            DrawArea.Width = MainForm.ActiveForm.Width - 10;
            DrawArea.Height = MainForm.ActiveForm.Height -10;
        }

        protected void NewDrawArea_Paint(object sender, PaintEventArgs e)
        {
            Draw.DoubleBufferedPanel currentDrawArea = (Draw.DoubleBufferedPanel)sender;
            eHandler.drawer = e.Graphics;
            dialogProcessor.HandleDrawing(e);         
        }

        private void NewDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            Draw.DoubleBufferedPanel currentDrawArea = (Draw.DoubleBufferedPanel)sender;
            eHandler.MouseDown(e.Location);
            currentDrawArea.Invalidate();

            this.NameTextBox.Text = dialogProcessor.messageToStrip;

            if (dialogProcessor.SelectedItem != null)
            {
                this.WidthTextBox.Text = dialogProcessor.SelectedItem.BorderWidth.ToString();
                this.BorderWidthStatusLabel.Text = "Ширина на контура на фигурата: " + dialogProcessor.SelectedItem.BorderWidth.ToString();
            }

            this.NameStatusLabel.Text = "Име на фигурата: " + dialogProcessor.messageToStrip;
        }

        private void NewDrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            Draw.DoubleBufferedPanel currentDrawArea = (Draw.DoubleBufferedPanel)sender;
            eHandler.MouseUp(e.Location);
        }

        private void NewDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            Draw.DoubleBufferedPanel currentDrawArea = (Draw.DoubleBufferedPanel)sender;
            eHandler.MouseMove(e.Location);
            CoordinatesStatusLabel.Text = "Курсор X: " + e.X + ", Y: " + e.Y;
            ActionStatusLabel.Text = "Действие: " + dialogProcessor.ActionT;
            MessageStatusLabel.Text = dialogProcessor.message;
            currentDrawArea.Invalidate();
        }

        private void NewDrawArea_Load(object sender, EventArgs e)
        {
            Draw.DoubleBufferedPanel currentDrawArea = (Draw.DoubleBufferedPanel)sender;
            currentDrawArea.Width = MainForm.ActiveForm.Width - 10;
            currentDrawArea.Height = MainForm.ActiveForm.Height - 10;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (NameTextBox.Focused || WidthTextBox.Focused)
            {
                return;
            }

            switch (e.KeyData.ToString())
            {
                case "N, Control":
                    {
                        this.NewProject_Click(sender, e);
                        break;
                    }

                case "O, Control":
                    {
                        this.Open_Click(sender, e);
                        break;
                    }

                case "S, Control":
                    {
                        this.Save_Click(sender, e);
                        break;
                    }

                case "S, Shift, Control":
                    {
                        this.SaveAs_Click(sender, e);
                        break;
                    }

                case "P, Control":
                    {
                        this.Print_Click(sender, e);
                        break;
                    }

                case "X, Control":
                    {
                        this.Cut_Click(sender, e);
                        return;
                    }

                case "C, Control":
                    {
                        this.Copy_Click(sender, e);
                        return;
                    }

                case "V, Control":
                    {
                        this.Paste_Click(sender, e);
                        return;
                    }

                case "Delete":
                    {
                        this.Delete_Click(sender, e);
                        break;
                    }

                case "G, Control":
                    {
                        this.Group_Click(sender, e);
                        break;
                    }

                case "U, Control":
                    {
                        this.Ungroup_Click(sender, e);
                        break;
                    }

                case "T, Control":
                    {
                        this.OnTop_Click(sender, e);
                        break;
                    }

                case "F, Shift, Control":
                    {
                        this.FillColor_Click(sender, e);
                        break;
                    }

                case "B, Shift, Control":
                    {
                        this.BorderColor_Click(sender, e);
                        break;
                    }

                case "W, Shift, Control":
                    {
                        this.SetBorderWidth_Click(sender, e);
                        break;
                    }

                case "A, Shift, Control":
                    {
                        this.SetFigureName_Click(sender, e);
                        break;
                    }

                case "R, Control":
                    {
                        this.Rotate_Click(sender, e);
                        break;
                    }

                case "F1":
                    {
                        this.Help_Click(sender, e);
                        break;
                    }
            }
        }

        #endregion        

        #region DrawingToolsToolBarButtons

        private void DrawPointButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPointShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawLineButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawLineShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }        

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCircleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawEllipseShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawTriangleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawSquareButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawSquareShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawRectangleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawRectangleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawPolygonButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPolygonShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawCurveButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCurveShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawClosedCurveButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawClosedCurveShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawBezierButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawBezierShape";            
            dialogProcessor.controlPolygon.Clear();
            DrawArea.Invalidate();
        }

        #endregion

        private void DrawingToolsToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            foreach(ToolBarButton _button in DrawingToolsToolBar.Buttons)
            {
                _button.Pushed = false;
            }
            e.Button.Pushed = true;

            switch (DrawingToolsToolBarGetButtonNo())
            {
                case 0:
                    {
                        this.DrawPointButton_Click(sender, e);
                        return;
                    }

                case 1:
                    {
                        this.DrawLineButton_Click(sender, e);
                        return;
                    }

                case 2:
                    {
                        this.DrawCircleButton_Click(sender, e);
                        return;
                    }

                case 3:
                    {
                        this.DrawEllipseButton_Click(sender, e);
                        return;                        
                    }

                case 4:
                    {
                        this.DrawTriangleButton_Click(sender, e);
                        return;
                    }

                case 5:
                    {
                        this.DrawSquareButton_Click(sender, e);
                        return;
                    }

                case 6:
                    {
                        this.DrawRectangleButton_Click(sender, e);
                        return;
                    }

                case 7:
                    {
                        this.DrawPolygonButton_Click(sender, e);
                        return;
                    }

                case 8:
                    {
                        this.DrawCurveButton_Click(sender, e);
                        return;
                    }

                case 9:
                    {
                        this.DrawClosedCurveButton_Click(sender, e);
                        return;
                    }

                case 10:
                    {
                        this.DrawBezierButton_Click(sender, e);
                        return;
                    }
            }
        }

        #region MainToolBarButtons

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            eHandler.NewProject();
            DrawArea.Invalidate();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            eHandler.OpenFile();
            DrawArea.Invalidate();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            eHandler.Save();
            DrawArea.Invalidate();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CutButton_Click(object sender, EventArgs e)
        {

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {

        }

        private void PasteButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            eHandler.DeleteSelected();
            DrawArea.Invalidate();
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            eHandler.GroupElements();
            DrawArea.Invalidate();
        }

        private void UngroupButton_Click(object sender, EventArgs e)
        {
            eHandler.UnGroup();
            DrawArea.Invalidate();
        }

        private void OnTopButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetItemsOnTop();
            DrawArea.Invalidate();
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            eHandler.ChangeFillColor();
            DrawArea.Invalidate();
        }

        private void BorderColorButton_Click(object sender, EventArgs e)
        {
            eHandler.ChangeBorderColor();
            DrawArea.Invalidate();
        }

        #endregion

        private void MainToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            foreach (ToolBarButton _button in MainToolBar.Buttons)
            {
                _button.Pushed = false;
            }
            e.Button.Pushed = true;

            switch (MainToolBarGetButtonNo())
            {
                case 0:
                    {
                        this.NewProjectButton_Click(sender, e);
                        return;
                    }

                case 1:
                    {
                        this.OpenButton_Click(sender, e);
                        return;
                    }

                case 2:
                    {
                        this.SaveButton_Click(sender, e);
                        return;
                    }

                case 4:
                    {
                        this.PrintButton_Click(sender, e);
                        return;
                    }

                case 6:
                    {
                        this.CutButton_Click(sender, e);
                        return;
                    }

                case 7:
                    {
                        this.CopyButton_Click(sender, e);
                        return;
                    }

                case 8:
                    {
                        this.PasteButton_Click(sender, e);
                        return;
                    }

                case 9:
                    {
                        this.DeleteButton_Click(sender, e);
                        return;
                    }

                case 11:
                    {
                        this.GroupButton_Click(sender, e);
                        return;
                    }

                case 12:
                    {
                        this.UngroupButton_Click(sender, e);
                        return;
                    }

                case 13:
                    {
                        this.OnTopButton_Click(sender, e);
                        return;
                    }

                case 14:
                    {
                        this.FillColorButton_Click(sender, e);
                        return;
                    }

                case 15:
                    {
                        this.BorderColorButton_Click(sender, e);
                        return;
                    }
            }
        }

        #region FileMenuButtons

        private void NewProject_Click(object sender, EventArgs e)
        {
            this.NewProject1();
            //eHandler.NewProject();
            DrawArea.Invalidate();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            eHandler.OpenFile();
            DrawArea.Invalidate();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            eHandler.Save();
            DrawArea.Invalidate();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            eHandler.SaveAs();
            DrawArea.Invalidate();
        }

        private void Print_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        #endregion

        #region EditMenuButtons

        private void Cut_Click(object sender, EventArgs e)
        {

        }

        private void Copy_Click(object sender, EventArgs e)
        {

        }

        private void Paste_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            eHandler.DeleteSelected();
            DrawArea.Invalidate();
        }

        private void Group_Click(object sender, EventArgs e)
        {
            eHandler.GroupElements();
            DrawArea.Invalidate();
        }

        private void Ungroup_Click(object sender, EventArgs e)
        {
            eHandler.UnGroup();
            DrawArea.Invalidate();
        }

        private void OnTop_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetItemsOnTop();
            DrawArea.Invalidate();
        }

        private void FillColor_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.ChangeFillColor();
                DrawArea.Invalidate();
            }
        }

        private void BorderColor_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.ChangeBorderColor();
                DrawArea.Invalidate();
            }
        }

        private void SetBorderWidth_Click(object sender, EventArgs e)
        {
            //if (dialogProcessor.SelectedItem != null)
            //{
            //    SetBorderWidthForm setBorderWidth = new SetBorderWidthForm(this.WidthTextBox.Text, this);
            //    setBorderWidth.ShowDialog(this);
            //}
        }

        private void SetFigureName_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                //SetNameForm setName = new SetNameForm(this.NameTextBox.Text);
                //setName.ShowDialog();
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {

        }

        #endregion        

        #region ViewMenuButtons



        #endregion

        #region ToolMenuButtons

        private void Point_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPointShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawLineShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCircleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawEllipseShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawTriangleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawSquareShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawRectangleShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPolygonShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCurveShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void CLosedCurve_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawClosedCurveShape";
            DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Bezier_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawBezierShape";
            dialogProcessor.controlPolygon.Clear();
            DrawArea.Invalidate();
        }
        
        #endregion

        #region HelpMenuButtons

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        #endregion

        #region OtherToolsGroupBox

        private void NameButton_Click(object sender, EventArgs e)
        {
            eHandler.SetName(NameTextBox.Text);
            DrawArea.Invalidate();
        }

        private void WidthButton_Click(object sender, EventArgs e)
        {
            this.SetContourWidth(this.WidthTextBox.Text);
        }

        #endregion        
    }
}
