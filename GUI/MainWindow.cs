using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2D_Vector_Graphics.GUI
{
    public partial class MainWindow : Form
    {
        #region Fields

        private DialogProcessor dialogProcessor = new DialogProcessor();
        private EventHandler eHandler;
        private MatrixHandler mHandler;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            eHandler = new EventHandler(ref dialogProcessor);
            mHandler = new MatrixHandler();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Метод чрез, който
        /// </summary>
        public void DrawAreaRefresh()
        {
            DrawArea.Invalidate();

            if (dialogProcessor.SelectedItem != null)
            {
                // Текстовите кутии в дясното меню
                NameTextBox.Text = dialogProcessor.SelectedItem.Name;
                NameTextBox.Enabled = true;
                WidthTextBox.Text = dialogProcessor.SelectedItem.BorderWidth.ToString();
                WidthTextBox.Enabled = true;
                RotateUpDown.Enabled = true;

                // Бутоните, които са на преден план
                CutToolStripButton.Enabled = true;
                CopyToolStripButton.Enabled = true;
                DeleteToolStripButton.Enabled = true;
                GroupToolStripButton.Enabled = true;
                UngroupToolStripButton.Enabled = true;
                OnTopToolStripButton.Enabled = true;
                FillColorToolStripButton.Enabled = true;
                BorderColorToolStripButton.Enabled = true;

                //Бутоните от Main-менюто
                Cut.Enabled = true;
                Copy.Enabled = true;
                Delete.Enabled = true;
                Group.Enabled = true;
                Ungroup.Enabled = true;
                OnTop.Enabled = true;
                FillColor.Enabled = true;
                BorderColor.Enabled = true;
                BorderWidth.Enabled = true;
                FigureName.Enabled = true;
                Rotate.Enabled = true;
            }
            else
            {
                // Текстовите кутии в дясното меню
                NameTextBox.Text = "";
                NameTextBox.Enabled = false;
                WidthTextBox.Text = "";
                WidthTextBox.Enabled = false;
                RotateUpDown.Enabled = false;

                // Бутоните, които са на преден план
                CutToolStripButton.Enabled = false;
                CopyToolStripButton.Enabled = false;
                DeleteToolStripButton.Enabled = false;
                GroupToolStripButton.Enabled = false;
                UngroupToolStripButton.Enabled = false;
                OnTopToolStripButton.Enabled = false;
                FillColorToolStripButton.Enabled = false;
                BorderColorToolStripButton.Enabled = false;

                //Бутоните от Main-менюто
                Cut.Enabled = false;
                Copy.Enabled = false;
                Delete.Enabled = false;
                Group.Enabled = false;
                Ungroup.Enabled = false;
                OnTop.Enabled = false;
                FillColor.Enabled = false;
                BorderColor.Enabled = false;
                BorderWidth.Enabled = false;
                FigureName.Enabled = false;
                Rotate.Enabled = false;
            }

            if (dialogProcessor.toCutCopyPasteDel.Count > 0)
            {
                PasteToolStripButton.Enabled = true;
                Paste.Enabled = true;
            }
            else
            {
                PasteToolStripButton.Enabled = false;
                Paste.Enabled = false;
            }

            DrawArea.Focus();
        }

        /// <summary>
        /// Метод чрез, който променяме ширината на контура на фигурата
        /// </summary>
        /// <param name="FigureContourWidth"></param>
        public void SetContourWidth(string FigureContourWidth)
        {
            int border = 1;
            int.TryParse(FigureContourWidth, out border);
            dialogProcessor.SetBorderWidth(border);
        }

        /// <summary>
        /// Метод чрез, който променяме името на селектираната фигура от формата SetNameForm
        /// </summary>
        /// <param name="NameTextBoxContent"></param>
        public void SetLabelFigureName(string NameTextBoxContent)
        {
            eHandler.SetName(NameTextBoxContent);
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

       /// <summary>
        /// Метод, който връща индексите на всички бутони съдържащи се в DrawingToolsToolBar контрола
       /// </summary>
       /// <returns></returns>
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

        #endregion

        #region MainWindow Form Events

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MainWindow.ActiveForm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            MainWindow.ActiveForm.Height = Screen.PrimaryScreen.WorkingArea.Height;

            tabControl.Width = MainWindow.ActiveForm.Width - 111;
            tabControl.Height = MainWindow.ActiveForm.Height - 115;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
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
                        this.BorderWidth_Click(sender, e);
                        break;
                    }

                case "A, Shift, Control":
                    {
                        this.FigureName_Click(sender, e);
                        break;
                    }

                case "R, Control":
                    {
                        this.RotationArbitraryMenuItem_Click(sender, e);
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

        #region DrawArea Events

        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            eHandler.drawer = e.Graphics;
            dialogProcessor.HandleDrawing(e);
        }

        private void DrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            eHandler.MouseDown(e.Location);
            DrawAreaRefresh();
            //DrawArea.Invalidate();

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
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void DrawArea_Load(object sender, EventArgs e)
        {
            DrawArea.Width = MainWindow.ActiveForm.Width - 10;
            DrawArea.Height = MainWindow.ActiveForm.Height - 10;             
        }

        #endregion

        #region DrawingToolsToolBar Buttons

        private void CursorButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPointShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawLineShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCircleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawEllipseShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawTriangleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawSquareShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawRectangleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPolygonShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void CurveButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCurveShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void ClosedCurveButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawClosedCurveShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void BezierButton_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawBezierShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void DrawingToolsToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            foreach (ToolBarButton _button in DrawingToolsToolBar.Buttons)
            {
                _button.Pushed = false;
            }
            e.Button.Pushed = true;

            switch (DrawingToolsToolBarGetButtonNo())
            {
                case 0:
                    {
                        this.CursorButton_Click(sender, e);
                        return;
                    }

                case 1:
                    {
                        this.PointButton_Click(sender, e);
                        return;
                    }

                case 2:
                    {
                        this.LineButton_Click(sender, e);
                        return;
                    }

                case 3:
                    {
                        this.CircleButton_Click(sender, e);
                        return;
                    }

                case 4:
                    {
                        this.EllipseButton_Click(sender, e);
                        return;
                    }

                case 5:
                    {
                        this.TriangleButton_Click(sender, e);
                        return;
                    }

                case 6:
                    {
                        this.SquareButton_Click(sender, e);
                        return;
                    }

                case 7:
                    {
                        this.RectangleButton_Click(sender, e);
                        return;
                    }

                case 8:
                    {
                        this.PolygonButton_Click(sender, e);
                        return;
                    }

                case 9:
                    {
                        this.CurveButton_Click(sender, e);
                        return;
                    }

                case 10:
                    {
                        this.ClosedCurveButton_Click(sender, e);
                        return;
                    }

                case 11:
                    {
                        this.BezierButton_Click(sender, e);
                        return;
                    }
            }
        }

        #endregion 

        #region MainToolStrip Menu

        private void NewProjectToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.NewProject();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.OpenFile();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.Save();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void SaveAsToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.SaveAs();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.CutSelected();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.CopySelected();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {            
            eHandler.PasteSelected();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.DeleteSelected();
            dialogProcessor.SelectedItem = null;
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void GroupToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.GroupElements();
            DrawAreaRefresh();
            //DrawArea.Invalidate();           
        }

        private void UngroupToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.UnGroup();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void OnTopToolStripButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetItemsOnTop();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void FillColorToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.ChangeFillColor();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void BorderColorToolStripButton_Click(object sender, EventArgs e)
        {
            eHandler.ChangeBorderColor();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

#endregion

        #region File Menu Buttons

        private void NewProject_Click(object sender, EventArgs e)
        {
            eHandler.NewProject();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            eHandler.OpenFile();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            eHandler.Save();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            eHandler.SaveAs();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void Print_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainWindow.ActiveForm.Close();
        }

        #endregion

        #region Edit Menu Buttons

        private void Cut_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.CutSelected();
                DrawAreaRefresh();
                //DrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Не сте селектирали фигура!");
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.CopySelected();
                DrawAreaRefresh();
                //DrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Не сте селектирали фигура!");
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            eHandler.PasteSelected();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.DeleteSelected();
                DrawAreaRefresh();
                //DrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Не сте селектирали фигура!");
            }
        }

        private void Group_Click(object sender, EventArgs e)
        {            
            eHandler.GroupElements();
            DrawAreaRefresh();
            //DrawArea.Invalidate();
        }

        private void Ungroup_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                eHandler.UnGroup();
                DrawAreaRefresh();
                //DrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Не сте селектирали група!");
            }
        }

        private void OnTop_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItem != null)
            {
                dialogProcessor.SetItemsOnTop();
                DrawAreaRefresh();
                //DrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Не сте селектирали фигура!");
            }
        }

        private void FillColor_Click(object sender, EventArgs e)
        {
            eHandler.ChangeFillColor();
            DrawAreaRefresh();
            //DrawArea.Invalidate();           
        }

        private void BorderColor_Click(object sender, EventArgs e)
        {
            eHandler.ChangeBorderColor();
            DrawAreaRefresh();
            //DrawArea.Invalidate();            
        }

        private void BorderWidth_Click(object sender, EventArgs e)
        {            
            SetBorderWidthForm setBorderWidth = new SetBorderWidthForm(this.WidthTextBox.Text, this);
            setBorderWidth.ShowDialog(this);         
        }

        private void FigureName_Click(object sender, EventArgs e)
        {
            SetNameForm setName = new SetNameForm(this.NameTextBox.Text, this);
            setName.ShowDialog(this);            
        }

        private void Rotation180MenuItem_Click(object sender, EventArgs e)
        {
            eHandler.RotateFigure(180F);
            DrawAreaRefresh();
            //DrawArea.Invalidate();            
        }

        private void Rotation90CWMenuItem_Click(object sender, EventArgs e)
        {
            eHandler.RotateFigure(-90F);
            DrawAreaRefresh();
            //DrawArea.Invalidate();           
        }

        private void Rotation90CCWMenuItem_Click(object sender, EventArgs e)
        {
            eHandler.RotateFigure(90F);
            DrawAreaRefresh();
            //DrawArea.Invalidate();          
        }

        private void RotationArbitraryMenuItem_Click(object sender, EventArgs e)
        {
            Rotation rotaion = new Rotation();
            rotaion.ShowDialog();
        }

        #endregion

        #region ViewMenuButtons



        #endregion

        #region Tool Menu Buttons

        private void Point_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPointShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawLineShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCircleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawEllipseShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawTriangleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawSquareShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawRectangleShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawPolygonShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawCurveShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void ClosedCurve_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawClosedCurveShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();
        }

        private void BezierCurve_Click(object sender, EventArgs e)
        {
            eHandler.Event = "DrawBezierShape";
            DrawAreaRefresh();
            //DrawArea.Invalidate();
            dialogProcessor.controlPolygon.Clear();            
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

        #region OtherToolsGroupBox Buttons

        private void NameButton_Click(object sender, EventArgs e)
        {
            eHandler.SetName(NameTextBox.Text);
            DrawAreaRefresh();
            //DrawArea.Invalidate();          
        }

        private void WidthButton_Click(object sender, EventArgs e)
        {
            this.SetContourWidth(this.WidthTextBox.Text);            
        }

        #endregion  
        
        #region RotateGroupBox Buttons

        private void RotateButton_Click(object sender, EventArgs e)
        {
            float angle = 0;
            float.TryParse(RotateUpDown.Text, out angle);
            eHandler.RotateFigure(angle);
            DrawAreaRefresh();
            //DrawArea.Invalidate();           
        }

        #endregion
    }
}
