namespace _2D_Vector_Graphics.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.BorderWidthStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoordinatesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MessageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.File = new System.Windows.Forms.MenuItem();
            this.NewProject = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem5 = new System.Windows.Forms.MenuItem();
            this.Open = new System.Windows.Forms.MenuItem();
            this.Save = new System.Windows.Forms.MenuItem();
            this.SaveAs = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem6 = new System.Windows.Forms.MenuItem();
            this.Print = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem7 = new System.Windows.Forms.MenuItem();
            this.Exit = new System.Windows.Forms.MenuItem();
            this.Edit = new System.Windows.Forms.MenuItem();
            this.Cut = new System.Windows.Forms.MenuItem();
            this.Copy = new System.Windows.Forms.MenuItem();
            this.Paste = new System.Windows.Forms.MenuItem();
            this.Delete = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem1 = new System.Windows.Forms.MenuItem();
            this.Group = new System.Windows.Forms.MenuItem();
            this.Ungroup = new System.Windows.Forms.MenuItem();
            this.OnTop = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem2 = new System.Windows.Forms.MenuItem();
            this.FillColor = new System.Windows.Forms.MenuItem();
            this.BorderColor = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem3 = new System.Windows.Forms.MenuItem();
            this.SetBorderWidth = new System.Windows.Forms.MenuItem();
            this.SetFigureName = new System.Windows.Forms.MenuItem();
            this.SeparatorMenuItem4 = new System.Windows.Forms.MenuItem();
            this.Rotate = new System.Windows.Forms.MenuItem();
            this.View = new System.Windows.Forms.MenuItem();
            this.Tools = new System.Windows.Forms.MenuItem();
            this.Point = new System.Windows.Forms.MenuItem();
            this.Line = new System.Windows.Forms.MenuItem();
            this.Circle = new System.Windows.Forms.MenuItem();
            this.Ellipse = new System.Windows.Forms.MenuItem();
            this.Triangle = new System.Windows.Forms.MenuItem();
            this.Square = new System.Windows.Forms.MenuItem();
            this.Rectangle = new System.Windows.Forms.MenuItem();
            this.Polygon = new System.Windows.Forms.MenuItem();
            this.Curve = new System.Windows.Forms.MenuItem();
            this.CLosedCurve = new System.Windows.Forms.MenuItem();
            this.Bezier = new System.Windows.Forms.MenuItem();
            this.MainHelp = new System.Windows.Forms.MenuItem();
            this.Help = new System.Windows.Forms.MenuItem();
            this.About = new System.Windows.Forms.MenuItem();
            this.MainToolBar = new System.Windows.Forms.ToolBar();
            this.NewProjectButton = new System.Windows.Forms.ToolBarButton();
            this.OpenButton = new System.Windows.Forms.ToolBarButton();
            this.SaveButton = new System.Windows.Forms.ToolBarButton();
            this.Separator1 = new System.Windows.Forms.ToolBarButton();
            this.PrintButton = new System.Windows.Forms.ToolBarButton();
            this.Separator2 = new System.Windows.Forms.ToolBarButton();
            this.CutButton = new System.Windows.Forms.ToolBarButton();
            this.CopyButton = new System.Windows.Forms.ToolBarButton();
            this.PasteButton = new System.Windows.Forms.ToolBarButton();
            this.DeleteButton = new System.Windows.Forms.ToolBarButton();
            this.Separator3 = new System.Windows.Forms.ToolBarButton();
            this.GroupButton = new System.Windows.Forms.ToolBarButton();
            this.UngroupButton = new System.Windows.Forms.ToolBarButton();
            this.OnTopButton = new System.Windows.Forms.ToolBarButton();
            this.FillColorButton = new System.Windows.Forms.ToolBarButton();
            this.BorderColorButton = new System.Windows.Forms.ToolBarButton();
            this.Separator4 = new System.Windows.Forms.ToolBarButton();
            this.MainToolBarImageList = new System.Windows.Forms.ImageList(this.components);
            this.DrawingToolsImageList = new System.Windows.Forms.ImageList(this.components);
            this.NewDrawArea = new Draw.DoubleBufferedPanel();
            this.ToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.DrawingToolsToolBar = new System.Windows.Forms.ToolBar();
            this.DrawPointButton = new System.Windows.Forms.ToolBarButton();
            this.DrawLineButton = new System.Windows.Forms.ToolBarButton();
            this.DrawCircleButton = new System.Windows.Forms.ToolBarButton();
            this.DrawEllipseButton = new System.Windows.Forms.ToolBarButton();
            this.DrawTriangleButton = new System.Windows.Forms.ToolBarButton();
            this.DrawSquareButton = new System.Windows.Forms.ToolBarButton();
            this.DrawRectangleButton = new System.Windows.Forms.ToolBarButton();
            this.DrawPolygonButton = new System.Windows.Forms.ToolBarButton();
            this.DrawCurveButton = new System.Windows.Forms.ToolBarButton();
            this.DrawCLosedCurveButton = new System.Windows.Forms.ToolBarButton();
            this.DrawBezierButton = new System.Windows.Forms.ToolBarButton();
            this.OtherToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.New_Project = new System.Windows.Forms.TabPage();
            this.DrawArea = new Draw.DoubleBufferedPanel();
            this.ToolsGroupBox.SuspendLayout();
            this.OtherToolsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.New_Project.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 575);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1274, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // BorderWidthStatusLabel
            // 
            this.BorderWidthStatusLabel.Name = "BorderWidthStatusLabel";
            this.BorderWidthStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // NameStatusLabel
            // 
            this.NameStatusLabel.Name = "NameStatusLabel";
            this.NameStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // CoordinatesStatusLabel
            // 
            this.CoordinatesStatusLabel.Name = "CoordinatesStatusLabel";
            this.CoordinatesStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ActionStatusLabel
            // 
            this.ActionStatusLabel.Name = "ActionStatusLabel";
            this.ActionStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MessageStatusLabel
            // 
            this.MessageStatusLabel.Name = "MessageStatusLabel";
            this.MessageStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.File,
            this.Edit,
            this.View,
            this.Tools,
            this.MainHelp});
            // 
            // File
            // 
            this.File.Index = 0;
            this.File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewProject,
            this.SeparatorMenuItem5,
            this.Open,
            this.Save,
            this.SaveAs,
            this.SeparatorMenuItem6,
            this.Print,
            this.SeparatorMenuItem7,
            this.Exit});
            this.File.Text = "File";
            // 
            // NewProject
            // 
            this.NewProject.Index = 0;
            this.NewProject.Text = "New Project       Ctrl+N";
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // SeparatorMenuItem5
            // 
            this.SeparatorMenuItem5.Index = 1;
            this.SeparatorMenuItem5.Text = "-";
            // 
            // Open
            // 
            this.Open.Index = 2;
            this.Open.Text = "Open                  Ctrl+O";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Index = 3;
            this.Save.Text = "Save                   Ctrl+S";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Index = 4;
            this.SaveAs.Text = "Save As             Ctrl+Shift+S";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // SeparatorMenuItem6
            // 
            this.SeparatorMenuItem6.Index = 5;
            this.SeparatorMenuItem6.Text = "-";
            // 
            // Print
            // 
            this.Print.Index = 6;
            this.Print.Text = "Print                  Ctrl+P";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // SeparatorMenuItem7
            // 
            this.SeparatorMenuItem7.Index = 7;
            this.SeparatorMenuItem7.Text = "-";
            // 
            // Exit
            // 
            this.Exit.Index = 8;
            this.Exit.Text = "Exit                   Alt+F4";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit
            // 
            this.Edit.Index = 1;
            this.Edit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.SeparatorMenuItem1,
            this.Group,
            this.Ungroup,
            this.OnTop,
            this.SeparatorMenuItem2,
            this.FillColor,
            this.BorderColor,
            this.SeparatorMenuItem3,
            this.SetBorderWidth,
            this.SetFigureName,
            this.SeparatorMenuItem4,
            this.Rotate});
            this.Edit.Text = "Edit";
            // 
            // Cut
            // 
            this.Cut.Index = 0;
            this.Cut.Text = "Cut                         Ctrl+X";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Index = 1;
            this.Copy.Text = "Copy                      Ctrl+C";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Index = 2;
            this.Paste.Text = "Paste                      Ctrl+V";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Delete
            // 
            this.Delete.Index = 3;
            this.Delete.Text = "Delete                     Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SeparatorMenuItem1
            // 
            this.SeparatorMenuItem1.Index = 4;
            this.SeparatorMenuItem1.Text = "-";
            // 
            // Group
            // 
            this.Group.Index = 5;
            this.Group.Text = "Group                     Ctrl+G";
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // Ungroup
            // 
            this.Ungroup.Index = 6;
            this.Ungroup.Text = "Ungroup                 Ctrl+U";
            this.Ungroup.Click += new System.EventHandler(this.Ungroup_Click);
            // 
            // OnTop
            // 
            this.OnTop.Index = 7;
            this.OnTop.Text = "On top                    Ctrl+T";
            this.OnTop.Click += new System.EventHandler(this.OnTop_Click);
            // 
            // SeparatorMenuItem2
            // 
            this.SeparatorMenuItem2.Index = 8;
            this.SeparatorMenuItem2.Text = "-";
            // 
            // FillColor
            // 
            this.FillColor.Index = 9;
            this.FillColor.Text = "Fill color                  Ctrl+Shift+F";
            this.FillColor.Click += new System.EventHandler(this.FillColor_Click);
            // 
            // BorderColor
            // 
            this.BorderColor.Index = 10;
            this.BorderColor.Text = "Border color            Ctrl+Shift+B";
            this.BorderColor.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // SeparatorMenuItem3
            // 
            this.SeparatorMenuItem3.Index = 11;
            this.SeparatorMenuItem3.Text = "-";
            // 
            // SetBorderWidth
            // 
            this.SetBorderWidth.Index = 12;
            this.SetBorderWidth.Text = "Set border width     Ctrl+Shift+W";
            this.SetBorderWidth.Click += new System.EventHandler(this.SetBorderWidth_Click);
            // 
            // SetFigureName
            // 
            this.SetFigureName.Index = 13;
            this.SetFigureName.Text = "Ser figure name      Ctrl+Shift+A";
            this.SetFigureName.Click += new System.EventHandler(this.SetFigureName_Click);
            // 
            // SeparatorMenuItem4
            // 
            this.SeparatorMenuItem4.Index = 14;
            this.SeparatorMenuItem4.Text = "-";
            // 
            // Rotate
            // 
            this.Rotate.Index = 15;
            this.Rotate.Text = "Rotate                      Ctrl+R";
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // View
            // 
            this.View.Index = 2;
            this.View.Text = "View";
            // 
            // Tools
            // 
            this.Tools.Index = 3;
            this.Tools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Point,
            this.Line,
            this.Circle,
            this.Ellipse,
            this.Triangle,
            this.Square,
            this.Rectangle,
            this.Polygon,
            this.Curve,
            this.CLosedCurve,
            this.Bezier});
            this.Tools.Text = "Tools";
            // 
            // Point
            // 
            this.Point.Index = 0;
            this.Point.Text = "Point";
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Line
            // 
            this.Line.Index = 1;
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Circle
            // 
            this.Circle.Index = 2;
            this.Circle.Text = "Circle";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Index = 3;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Triangle
            // 
            this.Triangle.Index = 4;
            this.Triangle.Text = "Triangle";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.Index = 5;
            this.Square.Text = "Square";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Index = 6;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.Index = 7;
            this.Polygon.Text = "Polygon";
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Curve
            // 
            this.Curve.Index = 8;
            this.Curve.Text = "Curve";
            this.Curve.Click += new System.EventHandler(this.Curve_Click);
            // 
            // CLosedCurve
            // 
            this.CLosedCurve.Index = 9;
            this.CLosedCurve.Text = "Closed curve";
            this.CLosedCurve.Click += new System.EventHandler(this.CLosedCurve_Click);
            // 
            // Bezier
            // 
            this.Bezier.Index = 10;
            this.Bezier.Text = "Bezier curve";
            this.Bezier.Click += new System.EventHandler(this.Bezier_Click);
            // 
            // MainHelp
            // 
            this.MainHelp.Index = 4;
            this.MainHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Help,
            this.About});
            this.MainHelp.Text = "Help";
            // 
            // Help
            // 
            this.Help.Index = 0;
            this.Help.Text = "Help      F1";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // About
            // 
            this.About.Index = 1;
            this.About.Text = "About 2D Vector Graphics";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // MainToolBar
            // 
            this.MainToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.NewProjectButton,
            this.OpenButton,
            this.SaveButton,
            this.Separator1,
            this.PrintButton,
            this.Separator2,
            this.CutButton,
            this.CopyButton,
            this.PasteButton,
            this.DeleteButton,
            this.Separator3,
            this.GroupButton,
            this.UngroupButton,
            this.OnTopButton,
            this.FillColorButton,
            this.BorderColorButton,
            this.Separator4});
            this.MainToolBar.DropDownArrows = true;
            this.MainToolBar.ImageList = this.MainToolBarImageList;
            this.MainToolBar.Location = new System.Drawing.Point(0, 0);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.ShowToolTips = true;
            this.MainToolBar.Size = new System.Drawing.Size(1274, 36);
            this.MainToolBar.TabIndex = 2;
            this.MainToolBar.TabStop = true;
            this.MainToolBar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.MainToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.MainToolBar_ButtonClick);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.ImageIndex = 0;
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.NewProjectButton.ToolTipText = "Нов проект (Ctr+N)";
            // 
            // OpenButton
            // 
            this.OpenButton.ImageIndex = 1;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.OpenButton.ToolTipText = "Отвори (Ctrl+O)";
            // 
            // SaveButton
            // 
            this.SaveButton.ImageIndex = 2;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.SaveButton.ToolTipText = "Запази (Ctrl+S)";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // PrintButton
            // 
            this.PrintButton.ImageIndex = 3;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.PrintButton.ToolTipText = "Принтирай (Ctrl+P)";
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // CutButton
            // 
            this.CutButton.ImageIndex = 5;
            this.CutButton.Name = "CutButton";
            this.CutButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.CutButton.ToolTipText = "Изрежи (Ctrl+X)";
            // 
            // CopyButton
            // 
            this.CopyButton.ImageIndex = 4;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.CopyButton.ToolTipText = "Копирай (Ctrl+C)";
            // 
            // PasteButton
            // 
            this.PasteButton.ImageIndex = 6;
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.PasteButton.ToolTipText = "Постави (Ctrl+V)";
            // 
            // DeleteButton
            // 
            this.DeleteButton.ImageIndex = 7;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ToolTipText = "Изтрий избрания елемент";
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // GroupButton
            // 
            this.GroupButton.ImageIndex = 8;
            this.GroupButton.Name = "GroupButton";
            this.GroupButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.GroupButton.ToolTipText = "Групирай (Ctrl+G)";
            // 
            // UngroupButton
            // 
            this.UngroupButton.ImageIndex = 9;
            this.UngroupButton.Name = "UngroupButton";
            this.UngroupButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.UngroupButton.ToolTipText = "Разгрупирай (Ctrl+U)";
            // 
            // OnTopButton
            // 
            this.OnTopButton.ImageIndex = 10;
            this.OnTopButton.Name = "OnTopButton";
            this.OnTopButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.OnTopButton.ToolTipText = "Най-отгоре (Ctrl+T)";
            // 
            // FillColorButton
            // 
            this.FillColorButton.ImageIndex = 11;
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.FillColorButton.ToolTipText = "Цвят на запълване (Ctrl+Shift+F)";
            // 
            // BorderColorButton
            // 
            this.BorderColorButton.ImageIndex = 12;
            this.BorderColorButton.Name = "BorderColorButton";
            this.BorderColorButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.BorderColorButton.ToolTipText = "Цвят на контура (Ctrl+Shift+B)";
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // MainToolBarImageList
            // 
            this.MainToolBarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainToolBarImageList.ImageStream")));
            this.MainToolBarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainToolBarImageList.Images.SetKeyName(0, "NewProject.ico");
            this.MainToolBarImageList.Images.SetKeyName(1, "Open.ico");
            this.MainToolBarImageList.Images.SetKeyName(2, "Save.ico");
            this.MainToolBarImageList.Images.SetKeyName(3, "Print.ico");
            this.MainToolBarImageList.Images.SetKeyName(4, "Copy.ico");
            this.MainToolBarImageList.Images.SetKeyName(5, "Cut.ico");
            this.MainToolBarImageList.Images.SetKeyName(6, "Paste.ico");
            this.MainToolBarImageList.Images.SetKeyName(7, "Delete.ico");
            this.MainToolBarImageList.Images.SetKeyName(8, "Group.ico");
            this.MainToolBarImageList.Images.SetKeyName(9, "Ungroup.ico");
            this.MainToolBarImageList.Images.SetKeyName(10, "OnTop.ico");
            this.MainToolBarImageList.Images.SetKeyName(11, "FillColor.ico");
            this.MainToolBarImageList.Images.SetKeyName(12, "BorderColor.ico");
            // 
            // DrawingToolsImageList
            // 
            this.DrawingToolsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DrawingToolsImageList.ImageStream")));
            this.DrawingToolsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DrawingToolsImageList.Images.SetKeyName(0, "Point.ico");
            this.DrawingToolsImageList.Images.SetKeyName(1, "Line.ico");
            this.DrawingToolsImageList.Images.SetKeyName(2, "Ellipse.ico");
            this.DrawingToolsImageList.Images.SetKeyName(3, "Circle.ico");
            this.DrawingToolsImageList.Images.SetKeyName(4, "Triangle.ico");
            this.DrawingToolsImageList.Images.SetKeyName(5, "Rectangle.ico");
            this.DrawingToolsImageList.Images.SetKeyName(6, "Square.ico");
            this.DrawingToolsImageList.Images.SetKeyName(7, "Polygon.ico");
            this.DrawingToolsImageList.Images.SetKeyName(8, "Curve.ico");
            this.DrawingToolsImageList.Images.SetKeyName(9, "ClosedCurve.png");
            this.DrawingToolsImageList.Images.SetKeyName(10, "Bezier.ico");
            // 
            // NewDrawArea
            // 
            this.NewDrawArea.Location = new System.Drawing.Point(0, 0);
            this.NewDrawArea.Name = "NewDrawArea";
            this.NewDrawArea.Size = new System.Drawing.Size(150, 150);
            this.NewDrawArea.TabIndex = 0;
            // 
            // ToolsGroupBox
            // 
            this.ToolsGroupBox.Controls.Add(this.DrawingToolsToolBar);
            this.ToolsGroupBox.Font = new System.Drawing.Font("Georgia", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsGroupBox.Location = new System.Drawing.Point(0, 47);
            this.ToolsGroupBox.Name = "ToolsGroupBox";
            this.ToolsGroupBox.Size = new System.Drawing.Size(105, 143);
            this.ToolsGroupBox.TabIndex = 4;
            this.ToolsGroupBox.TabStop = false;
            this.ToolsGroupBox.Text = "Tools";
            // 
            // DrawingToolsToolBar
            // 
            this.DrawingToolsToolBar.AutoSize = false;
            this.DrawingToolsToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingToolsToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.DrawPointButton,
            this.DrawLineButton,
            this.DrawCircleButton,
            this.DrawEllipseButton,
            this.DrawTriangleButton,
            this.DrawSquareButton,
            this.DrawRectangleButton,
            this.DrawPolygonButton,
            this.DrawCurveButton,
            this.DrawCLosedCurveButton,
            this.DrawBezierButton});
            this.DrawingToolsToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.DrawingToolsToolBar.DropDownArrows = true;
            this.DrawingToolsToolBar.ImageList = this.DrawingToolsImageList;
            this.DrawingToolsToolBar.Location = new System.Drawing.Point(5, 15);
            this.DrawingToolsToolBar.Name = "DrawingToolsToolBar";
            this.DrawingToolsToolBar.ShowToolTips = true;
            this.DrawingToolsToolBar.Size = new System.Drawing.Size(95, 124);
            this.DrawingToolsToolBar.TabIndex = 0;
            this.DrawingToolsToolBar.TabStop = true;
            this.DrawingToolsToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.DrawingToolsToolBar_ButtonClick);
            // 
            // DrawPointButton
            // 
            this.DrawPointButton.ImageIndex = 0;
            this.DrawPointButton.Name = "DrawPointButton";
            this.DrawPointButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawPointButton.ToolTipText = "Точка";
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.ImageIndex = 1;
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawLineButton.ToolTipText = "Права";
            // 
            // DrawCircleButton
            // 
            this.DrawCircleButton.ImageIndex = 3;
            this.DrawCircleButton.Name = "DrawCircleButton";
            this.DrawCircleButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawCircleButton.ToolTipText = "Окръжност";
            // 
            // DrawEllipseButton
            // 
            this.DrawEllipseButton.ImageIndex = 2;
            this.DrawEllipseButton.Name = "DrawEllipseButton";
            this.DrawEllipseButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawEllipseButton.ToolTipText = "Елипса";
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.ImageIndex = 4;
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.ToolTipText = "Триъгълник";
            // 
            // DrawSquareButton
            // 
            this.DrawSquareButton.ImageIndex = 6;
            this.DrawSquareButton.Name = "DrawSquareButton";
            this.DrawSquareButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawSquareButton.ToolTipText = "Квадрат";
            // 
            // DrawRectangleButton
            // 
            this.DrawRectangleButton.ImageIndex = 5;
            this.DrawRectangleButton.Name = "DrawRectangleButton";
            this.DrawRectangleButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawRectangleButton.ToolTipText = "Правоъгълник";
            // 
            // DrawPolygonButton
            // 
            this.DrawPolygonButton.ImageIndex = 7;
            this.DrawPolygonButton.Name = "DrawPolygonButton";
            this.DrawPolygonButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawPolygonButton.ToolTipText = "Многоъгълник";
            // 
            // DrawCurveButton
            // 
            this.DrawCurveButton.ImageIndex = 8;
            this.DrawCurveButton.Name = "DrawCurveButton";
            this.DrawCurveButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawCurveButton.ToolTipText = "Крива";
            // 
            // DrawCLosedCurveButton
            // 
            this.DrawCLosedCurveButton.ImageIndex = 9;
            this.DrawCLosedCurveButton.Name = "DrawCLosedCurveButton";
            this.DrawCLosedCurveButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawCLosedCurveButton.ToolTipText = "Затворена крива";
            // 
            // DrawBezierButton
            // 
            this.DrawBezierButton.ImageIndex = 10;
            this.DrawBezierButton.Name = "DrawBezierButton";
            this.DrawBezierButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.DrawBezierButton.ToolTipText = "Крива на Безие";
            // 
            // OtherToolsGroupBox
            // 
            this.OtherToolsGroupBox.Controls.Add(this.WidthTextBox);
            this.OtherToolsGroupBox.Controls.Add(this.WidthButton);
            this.OtherToolsGroupBox.Controls.Add(this.NameButton);
            this.OtherToolsGroupBox.Controls.Add(this.NameTextBox);
            this.OtherToolsGroupBox.Font = new System.Drawing.Font("Georgia", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherToolsGroupBox.Location = new System.Drawing.Point(4, 205);
            this.OtherToolsGroupBox.Name = "OtherToolsGroupBox";
            this.OtherToolsGroupBox.Size = new System.Drawing.Size(100, 144);
            this.OtherToolsGroupBox.TabIndex = 5;
            this.OtherToolsGroupBox.TabStop = false;
            this.OtherToolsGroupBox.Text = "Figure";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(7, 70);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(87, 20);
            this.WidthTextBox.TabIndex = 3;
            // 
            // WidthButton
            // 
            this.WidthButton.Location = new System.Drawing.Point(7, 93);
            this.WidthButton.Name = "WidthButton";
            this.WidthButton.Size = new System.Drawing.Size(87, 23);
            this.WidthButton.TabIndex = 2;
            this.WidthButton.Text = "Width";
            this.WidthButton.UseVisualStyleBackColor = true;
            this.WidthButton.Click += new System.EventHandler(this.WidthButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(7, 39);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(87, 23);
            this.NameButton.TabIndex = 1;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(7, 17);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(87, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.New_Project);
            this.tabControl.Location = new System.Drawing.Point(106, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1168, 532);
            this.tabControl.TabIndex = 3;
            // 
            // New_Project
            // 
            this.New_Project.Controls.Add(this.DrawArea);
            this.New_Project.Location = new System.Drawing.Point(4, 22);
            this.New_Project.Name = "New_Project";
            this.New_Project.Padding = new System.Windows.Forms.Padding(3);
            this.New_Project.Size = new System.Drawing.Size(1160, 506);
            this.New_Project.TabIndex = 1;
            this.New_Project.Text = "Нов Проект ";
            this.New_Project.UseVisualStyleBackColor = true;
            // 
            // DrawArea
            // 
            this.DrawArea.BackColor = System.Drawing.SystemColors.Window;
            this.DrawArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawArea.Location = new System.Drawing.Point(3, 3);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(1154, 500);
            this.DrawArea.TabIndex = 4;
            this.DrawArea.Load += new System.EventHandler(this.DrawArea_Load);
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            this.DrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseDown);
            this.DrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseMove);
            this.DrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 597);
            this.Controls.Add(this.OtherToolsGroupBox);
            this.Controls.Add(this.ToolsGroupBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MainToolBar);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Vector Graphics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ToolsGroupBox.ResumeLayout(false);
            this.OtherToolsGroupBox.ResumeLayout(false);
            this.OtherToolsGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.New_Project.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem File;
        private System.Windows.Forms.MenuItem Edit;
        private System.Windows.Forms.MenuItem View;
        private System.Windows.Forms.MenuItem Tools;
        private System.Windows.Forms.MenuItem MainHelp;
        private System.Windows.Forms.MenuItem NewProject;
        private System.Windows.Forms.MenuItem Open;
        private System.Windows.Forms.MenuItem Save;
        private System.Windows.Forms.MenuItem SaveAs;
        private System.Windows.Forms.MenuItem Print;
        private System.Windows.Forms.MenuItem Cut;
        private System.Windows.Forms.MenuItem Paste;
        private System.Windows.Forms.MenuItem Group;
        private System.Windows.Forms.MenuItem Ungroup;
        private System.Windows.Forms.ToolBar MainToolBar;
        private System.Windows.Forms.MenuItem Point;
        private System.Windows.Forms.MenuItem Line;
        private System.Windows.Forms.MenuItem Circle;
        private System.Windows.Forms.MenuItem Ellipse;
        private System.Windows.Forms.MenuItem Triangle;
        private System.Windows.Forms.MenuItem Square;
        private System.Windows.Forms.MenuItem Rectangle;
        private System.Windows.Forms.MenuItem Polygon;
        private System.Windows.Forms.MenuItem Help;
        private System.Windows.Forms.MenuItem About;        
        private System.Windows.Forms.MenuItem FillColor;
        private System.Windows.Forms.MenuItem BorderColor;
        private System.Windows.Forms.MenuItem SetBorderWidth;
        private System.Windows.Forms.MenuItem SetFigureName;
        private System.Windows.Forms.MenuItem Rotate;
        private System.Windows.Forms.ImageList DrawingToolsImageList;
        private Draw.DoubleBufferedPanel NewDrawArea;
        private System.Windows.Forms.MenuItem Exit;        
        private System.Windows.Forms.GroupBox ToolsGroupBox;
        private System.Windows.Forms.ToolBar DrawingToolsToolBar;
        private System.Windows.Forms.ToolBarButton DrawPointButton;
        private System.Windows.Forms.ToolBarButton DrawLineButton;
        private System.Windows.Forms.ToolBarButton DrawEllipseButton;
        private System.Windows.Forms.ToolBarButton DrawCircleButton;
        private System.Windows.Forms.ToolBarButton DrawRectangleButton;
        private System.Windows.Forms.ToolBarButton DrawSquareButton;
        private System.Windows.Forms.ToolBarButton DrawPolygonButton;
        private System.Windows.Forms.ToolBarButton DrawCurveButton;
        private System.Windows.Forms.ToolBarButton DrawCLosedCurveButton;
        private System.Windows.Forms.ToolBarButton DrawBezierButton;
        private System.Windows.Forms.MenuItem Curve;
        private System.Windows.Forms.MenuItem CLosedCurve;
        private System.Windows.Forms.MenuItem Bezier;
        private System.Windows.Forms.ToolBarButton NewProjectButton;
        private System.Windows.Forms.ToolBarButton OpenButton;
        private System.Windows.Forms.ToolBarButton SaveButton;
        private System.Windows.Forms.ToolBarButton PrintButton;
        private System.Windows.Forms.ToolBarButton CopyButton;
        private System.Windows.Forms.ToolBarButton PasteButton;
        private System.Windows.Forms.ToolBarButton GroupButton;
        private System.Windows.Forms.ToolBarButton UngroupButton;
        private System.Windows.Forms.ToolBarButton FillColorButton;
        private System.Windows.Forms.ToolBarButton BorderColorButton;
        private System.Windows.Forms.GroupBox OtherToolsGroupBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button WidthButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolBarButton DrawTriangleButton;
        private System.Windows.Forms.MenuItem SeparatorMenuItem5;
        private System.Windows.Forms.MenuItem SeparatorMenuItem6;
        private System.Windows.Forms.MenuItem SeparatorMenuItem1;
        private System.Windows.Forms.MenuItem SeparatorMenuItem2;
        private System.Windows.Forms.MenuItem SeparatorMenuItem3;
        private System.Windows.Forms.MenuItem SeparatorMenuItem4;
        private System.Windows.Forms.ImageList MainToolBarImageList;
        private System.Windows.Forms.MenuItem Copy;
        private System.Windows.Forms.ToolBarButton CutButton;
        private System.Windows.Forms.ToolBarButton Separator1;
        private System.Windows.Forms.ToolBarButton Separator2;
        private System.Windows.Forms.ToolBarButton Separator3;
        private System.Windows.Forms.ToolBarButton Separator4;
        private System.Windows.Forms.MenuItem SeparatorMenuItem7;
        private System.Windows.Forms.ToolStripStatusLabel BorderWidthStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CoordinatesStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MessageStatusLabel;
        private System.Windows.Forms.ToolBarButton OnTopButton;
        private System.Windows.Forms.MenuItem OnTop;
        private System.Windows.Forms.MenuItem Delete;
        private System.Windows.Forms.Button NameButton;
        public System.Windows.Forms.ToolStripStatusLabel NameStatusLabel;
        private System.Windows.Forms.ToolBarButton DeleteButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage New_Project;
        private Draw.DoubleBufferedPanel DrawArea;


    }
}