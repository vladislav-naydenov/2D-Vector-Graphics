namespace _2D_Vector_Graphics.GUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Group = new System.Windows.Forms.ToolStripMenuItem();
            this.Ungroup = new System.Windows.Forms.ToolStripMenuItem();
            this.OnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FillColor = new System.Windows.Forms.ToolStripMenuItem();
            this.BorderColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BorderWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.FigureName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Rotate = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotation180MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotation90CWMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotation90CCWMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotationArbitraryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Point = new System.Windows.Forms.ToolStripMenuItem();
            this.Line = new System.Windows.Forms.ToolStripMenuItem();
            this.Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.Square = new System.Windows.Forms.ToolStripMenuItem();
            this.Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.Polygon = new System.Windows.Forms.ToolStripMenuItem();
            this.Curve = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosedCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.BezierCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UngroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OnTopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FillColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorderColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DrawingToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.DrawingToolsToolBar = new System.Windows.Forms.ToolBar();
            this.CursorButton = new System.Windows.Forms.ToolBarButton();
            this.PointButton = new System.Windows.Forms.ToolBarButton();
            this.LineButton = new System.Windows.Forms.ToolBarButton();
            this.CircleButton = new System.Windows.Forms.ToolBarButton();
            this.EllipseButton = new System.Windows.Forms.ToolBarButton();
            this.TriangleButton = new System.Windows.Forms.ToolBarButton();
            this.SquareButton = new System.Windows.Forms.ToolBarButton();
            this.RectangleButton = new System.Windows.Forms.ToolBarButton();
            this.PolygonButton = new System.Windows.Forms.ToolBarButton();
            this.CurveButton = new System.Windows.Forms.ToolBarButton();
            this.ClosedCurveButton = new System.Windows.Forms.ToolBarButton();
            this.BezierButton = new System.Windows.Forms.ToolBarButton();
            this.DrawingToolsImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.New_Project = new System.Windows.Forms.TabPage();
            this.DrawArea = new Draw.DoubleBufferedPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.BorderWidthStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoordinatesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MessageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WidthButton = new System.Windows.Forms.Button();
            this.OtherToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RotateGroupBox = new System.Windows.Forms.GroupBox();
            this.RotateUpDown = new System.Windows.Forms.TextBox();
            this.RotateButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.DrawingToolsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.New_Project.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.OtherToolsGroupBox.SuspendLayout();
            this.RotateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.View,
            this.Tools,
            this.HelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProject,
            this.toolStripSeparator1,
            this.Open,
            this.Save,
            this.SaveAs,
            this.toolStripSeparator2,
            this.Print,
            this.toolStripSeparator3,
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "&Файл";
            // 
            // NewProject
            // 
            this.NewProject.Image = ((System.Drawing.Image)(resources.GetObject("NewProject.Image")));
            this.NewProject.Name = "NewProject";
            this.NewProject.ShortcutKeyDisplayString = "Ctrl+N";
            this.NewProject.Size = new System.Drawing.Size(220, 22);
            this.NewProject.Text = "Нов проект";
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // Open
            // 
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.Name = "Open";
            this.Open.ShortcutKeyDisplayString = "Ctrl+O";
            this.Open.Size = new System.Drawing.Size(220, 22);
            this.Open.Text = "Отвори";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Name = "Save";
            this.Save.ShortcutKeyDisplayString = "Ctrl+S";
            this.Save.Size = new System.Drawing.Size(220, 22);
            this.Save.Text = "Запази";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.SaveAs.Size = new System.Drawing.Size(220, 22);
            this.SaveAs.Text = "Запази като...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // Print
            // 
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.Name = "Print";
            this.Print.ShortcutKeyDisplayString = "Ctrl+P";
            this.Print.Size = new System.Drawing.Size(220, 22);
            this.Print.Text = "Принтирай";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeyDisplayString = "Alt+F4";
            this.Exit.Size = new System.Drawing.Size(220, 22);
            this.Exit.Text = "Изход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.toolStripSeparator4,
            this.Group,
            this.Ungroup,
            this.OnTop,
            this.toolStripSeparator5,
            this.FillColor,
            this.BorderColor,
            this.toolStripSeparator6,
            this.BorderWidth,
            this.FigureName,
            this.toolStripSeparator7,
            this.Rotate});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(88, 20);
            this.Edit.Text = "&Редактиране";
            // 
            // Cut
            // 
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeyDisplayString = "Ctrl+X";
            this.Cut.Size = new System.Drawing.Size(294, 22);
            this.Cut.Text = "Изрежи";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeyDisplayString = "Ctrl+C";
            this.Copy.Size = new System.Drawing.Size(294, 22);
            this.Copy.Text = "Копирай";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.Name = "Paste";
            this.Paste.ShortcutKeyDisplayString = "Ctrl+V";
            this.Paste.Size = new System.Drawing.Size(294, 22);
            this.Paste.Text = "Постави";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeyDisplayString = "Del";
            this.Delete.Size = new System.Drawing.Size(294, 22);
            this.Delete.Text = "Изтрий";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(291, 6);
            // 
            // Group
            // 
            this.Group.Image = ((System.Drawing.Image)(resources.GetObject("Group.Image")));
            this.Group.Name = "Group";
            this.Group.ShortcutKeyDisplayString = "Ctrl+G";
            this.Group.Size = new System.Drawing.Size(294, 22);
            this.Group.Text = "Групирай";
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // Ungroup
            // 
            this.Ungroup.Image = ((System.Drawing.Image)(resources.GetObject("Ungroup.Image")));
            this.Ungroup.Name = "Ungroup";
            this.Ungroup.ShortcutKeyDisplayString = "Ctrl+U";
            this.Ungroup.Size = new System.Drawing.Size(294, 22);
            this.Ungroup.Text = "Разгрупирай";
            this.Ungroup.Click += new System.EventHandler(this.Ungroup_Click);
            // 
            // OnTop
            // 
            this.OnTop.Image = ((System.Drawing.Image)(resources.GetObject("OnTop.Image")));
            this.OnTop.Name = "OnTop";
            this.OnTop.ShortcutKeyDisplayString = "Ctrl+T";
            this.OnTop.Size = new System.Drawing.Size(294, 22);
            this.OnTop.Text = "Най-отгоре";
            this.OnTop.Click += new System.EventHandler(this.OnTop_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(291, 6);
            // 
            // FillColor
            // 
            this.FillColor.Image = ((System.Drawing.Image)(resources.GetObject("FillColor.Image")));
            this.FillColor.Name = "FillColor";
            this.FillColor.ShortcutKeyDisplayString = "Ctrl+Shift+F";
            this.FillColor.Size = new System.Drawing.Size(294, 22);
            this.FillColor.Text = "Цвят на запълване";
            this.FillColor.Click += new System.EventHandler(this.FillColor_Click);
            // 
            // BorderColor
            // 
            this.BorderColor.Image = ((System.Drawing.Image)(resources.GetObject("BorderColor.Image")));
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.ShortcutKeyDisplayString = "Ctrl+Shift+B";
            this.BorderColor.Size = new System.Drawing.Size(294, 22);
            this.BorderColor.Text = "Цвят на контура";
            this.BorderColor.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(291, 6);
            // 
            // BorderWidth
            // 
            this.BorderWidth.Name = "BorderWidth";
            this.BorderWidth.ShortcutKeyDisplayString = "Ctrl+Shift+W";
            this.BorderWidth.Size = new System.Drawing.Size(294, 22);
            this.BorderWidth.Text = "Задай ширина на контура";
            this.BorderWidth.Click += new System.EventHandler(this.BorderWidth_Click);
            // 
            // FigureName
            // 
            this.FigureName.Name = "FigureName";
            this.FigureName.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            this.FigureName.Size = new System.Drawing.Size(294, 22);
            this.FigureName.Text = "Задай име на фигурата";
            this.FigureName.Click += new System.EventHandler(this.FigureName_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(291, 6);
            // 
            // Rotate
            // 
            this.Rotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotation180MenuItem,
            this.Rotation90CWMenuItem,
            this.Rotation90CCWMenuItem,
            this.RotationArbitraryMenuItem});
            this.Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Rotate.Image")));
            this.Rotate.Name = "Rotate";
            this.Rotate.ShortcutKeyDisplayString = "";
            this.Rotate.Size = new System.Drawing.Size(294, 22);
            this.Rotate.Text = "Завърти";
            // 
            // Rotation180MenuItem
            // 
            this.Rotation180MenuItem.Name = "Rotation180MenuItem";
            this.Rotation180MenuItem.Size = new System.Drawing.Size(212, 22);
            this.Rotation180MenuItem.Text = "180°";
            this.Rotation180MenuItem.Click += new System.EventHandler(this.Rotation180MenuItem_Click);
            // 
            // Rotation90CWMenuItem
            // 
            this.Rotation90CWMenuItem.Name = "Rotation90CWMenuItem";
            this.Rotation90CWMenuItem.Size = new System.Drawing.Size(212, 22);
            this.Rotation90CWMenuItem.Text = "90° CW";
            this.Rotation90CWMenuItem.Click += new System.EventHandler(this.Rotation90CWMenuItem_Click);
            // 
            // Rotation90CCWMenuItem
            // 
            this.Rotation90CCWMenuItem.Name = "Rotation90CCWMenuItem";
            this.Rotation90CCWMenuItem.Size = new System.Drawing.Size(212, 22);
            this.Rotation90CCWMenuItem.Text = "90° CCW";
            this.Rotation90CCWMenuItem.Click += new System.EventHandler(this.Rotation90CCWMenuItem_Click);
            // 
            // RotationArbitraryMenuItem
            // 
            this.RotationArbitraryMenuItem.Name = "RotationArbitraryMenuItem";
            this.RotationArbitraryMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.RotationArbitraryMenuItem.Size = new System.Drawing.Size(212, 22);
            this.RotationArbitraryMenuItem.Text = "Произволен ъгъл";
            this.RotationArbitraryMenuItem.Click += new System.EventHandler(this.RotationArbitraryMenuItem_Click);
            // 
            // View
            // 
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(57, 20);
            this.View.Text = "&Изглед";
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Point,
            this.Line,
            this.Circle,
            this.Ellipse,
            this.Triangle,
            this.Square,
            this.Rectangle,
            this.Polygon,
            this.Curve,
            this.ClosedCurve,
            this.BezierCurve});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(93, 20);
            this.Tools.Text = "И&нструменти";
            // 
            // Point
            // 
            this.Point.Image = ((System.Drawing.Image)(resources.GetObject("Point.Image")));
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(166, 22);
            this.Point.Text = "Точка";
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Line
            // 
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(166, 22);
            this.Line.Text = "Права";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Circle
            // 
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(166, 22);
            this.Circle.Text = "Окръжност";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(166, 22);
            this.Ellipse.Text = "Елипса";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Triangle
            // 
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(166, 22);
            this.Triangle.Text = "Триъгълник";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(166, 22);
            this.Square.Text = "Квадрат";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(166, 22);
            this.Rectangle.Text = "Правоъгълник";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.Image = ((System.Drawing.Image)(resources.GetObject("Polygon.Image")));
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(166, 22);
            this.Polygon.Text = "Многоъгълник";
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Curve
            // 
            this.Curve.Image = ((System.Drawing.Image)(resources.GetObject("Curve.Image")));
            this.Curve.Name = "Curve";
            this.Curve.Size = new System.Drawing.Size(166, 22);
            this.Curve.Text = "Крива";
            this.Curve.Click += new System.EventHandler(this.Curve_Click);
            // 
            // ClosedCurve
            // 
            this.ClosedCurve.Image = ((System.Drawing.Image)(resources.GetObject("ClosedCurve.Image")));
            this.ClosedCurve.Name = "ClosedCurve";
            this.ClosedCurve.Size = new System.Drawing.Size(166, 22);
            this.ClosedCurve.Text = "Затворена крива";
            this.ClosedCurve.Click += new System.EventHandler(this.ClosedCurve_Click);
            // 
            // BezierCurve
            // 
            this.BezierCurve.Image = ((System.Drawing.Image)(resources.GetObject("BezierCurve.Image")));
            this.BezierCurve.Name = "BezierCurve";
            this.BezierCurve.Size = new System.Drawing.Size(166, 22);
            this.BezierCurve.Text = "Крива на Безие";
            this.BezierCurve.Click += new System.EventHandler(this.BezierCurve_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help,
            this.About});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(62, 20);
            this.HelpMenu.Text = "&Помощ";
            // 
            // Help
            // 
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(152, 22);
            this.Help.Text = "Помощ";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // About
            // 
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(152, 22);
            this.About.Text = "Относно";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.MainToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.SaveAsToolStripButton,
            this.PrintToolStripButton,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.PasteToolStripButton,
            this.DeleteToolStripButton,
            this.GroupToolStripButton,
            this.UngroupToolStripButton,
            this.OnTopToolStripButton,
            this.FillColorToolStripButton,
            this.BorderColorToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1264, 39);
            this.MainToolStrip.TabIndex = 1;
            // 
            // NewProjectToolStripButton
            // 
            this.NewProjectToolStripButton.AutoSize = false;
            this.NewProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewProjectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectToolStripButton.Image")));
            this.NewProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewProjectToolStripButton.Name = "NewProjectToolStripButton";
            this.NewProjectToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.NewProjectToolStripButton.ToolTipText = "Нов проект (Ctrl+N)";
            this.NewProjectToolStripButton.Click += new System.EventHandler(this.NewProjectToolStripButton_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.AutoSize = false;
            this.OpenToolStripButton.CheckOnClick = true;
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.OpenToolStripButton.ToolTipText = "Отвори (Ctrl+O)";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.SaveToolStripButton.ToolTipText = "Запази (Ctrl+S)";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // SaveAsToolStripButton
            // 
            this.SaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsToolStripButton.Image")));
            this.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStripButton.Name = "SaveAsToolStripButton";
            this.SaveAsToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.SaveAsToolStripButton.Text = "toolStripButton2";
            this.SaveAsToolStripButton.ToolTipText = "Запази като... (Ctrl+Shift+S)";
            this.SaveAsToolStripButton.Click += new System.EventHandler(this.SaveAsToolStripButton_Click);
            // 
            // PrintToolStripButton
            // 
            this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripButton.Image")));
            this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripButton.Name = "PrintToolStripButton";
            this.PrintToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.PrintToolStripButton.ToolTipText = "Принтиране (Ctrl+P)";
            this.PrintToolStripButton.Click += new System.EventHandler(this.PrintToolStripButton_Click);
            // 
            // CutToolStripButton
            // 
            this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStripButton.Enabled = false;
            this.CutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripButton.Image")));
            this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripButton.Name = "CutToolStripButton";
            this.CutToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.CutToolStripButton.ToolTipText = "Изрежи (Ctrl+X)";
            this.CutToolStripButton.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Enabled = false;
            this.CopyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripButton.Image")));
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.CopyToolStripButton.ToolTipText = "Копирай (Ctrl+C)";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // PasteToolStripButton
            // 
            this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteToolStripButton.Enabled = false;
            this.PasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripButton.Image")));
            this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripButton.Name = "PasteToolStripButton";
            this.PasteToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.PasteToolStripButton.ToolTipText = "Постави (Ctrl+V)";
            this.PasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Enabled = false;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.DeleteToolStripButton.ToolTipText = "Изтрий (Del)";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // GroupToolStripButton
            // 
            this.GroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupToolStripButton.Enabled = false;
            this.GroupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupToolStripButton.Image")));
            this.GroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupToolStripButton.Name = "GroupToolStripButton";
            this.GroupToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.GroupToolStripButton.ToolTipText = "Групирай (Ctrl+G)";
            this.GroupToolStripButton.Click += new System.EventHandler(this.GroupToolStripButton_Click);
            // 
            // UngroupToolStripButton
            // 
            this.UngroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupToolStripButton.Enabled = false;
            this.UngroupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UngroupToolStripButton.Image")));
            this.UngroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupToolStripButton.Name = "UngroupToolStripButton";
            this.UngroupToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.UngroupToolStripButton.ToolTipText = "Разгрупирай (Ctrl+U)";
            this.UngroupToolStripButton.Click += new System.EventHandler(this.UngroupToolStripButton_Click);
            // 
            // OnTopToolStripButton
            // 
            this.OnTopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OnTopToolStripButton.Enabled = false;
            this.OnTopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OnTopToolStripButton.Image")));
            this.OnTopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OnTopToolStripButton.Name = "OnTopToolStripButton";
            this.OnTopToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.OnTopToolStripButton.ToolTipText = "Най-отгоре (Ctl+T)";
            this.OnTopToolStripButton.Click += new System.EventHandler(this.OnTopToolStripButton_Click);
            // 
            // FillColorToolStripButton
            // 
            this.FillColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorToolStripButton.Enabled = false;
            this.FillColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FillColorToolStripButton.Image")));
            this.FillColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorToolStripButton.Name = "FillColorToolStripButton";
            this.FillColorToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.FillColorToolStripButton.ToolTipText = "Цвят на запълване (Ctrl+Shift+F)";
            this.FillColorToolStripButton.Click += new System.EventHandler(this.FillColorToolStripButton_Click);
            // 
            // BorderColorToolStripButton
            // 
            this.BorderColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderColorToolStripButton.Enabled = false;
            this.BorderColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorderColorToolStripButton.Image")));
            this.BorderColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderColorToolStripButton.Name = "BorderColorToolStripButton";
            this.BorderColorToolStripButton.Size = new System.Drawing.Size(33, 36);
            this.BorderColorToolStripButton.ToolTipText = "Цвят на контура (Ctrl+Shift+B)";
            this.BorderColorToolStripButton.Click += new System.EventHandler(this.BorderColorToolStripButton_Click);
            // 
            // DrawingToolsGroupBox
            // 
            this.DrawingToolsGroupBox.Controls.Add(this.DrawingToolsToolBar);
            this.DrawingToolsGroupBox.Location = new System.Drawing.Point(0, 66);
            this.DrawingToolsGroupBox.Name = "DrawingToolsGroupBox";
            this.DrawingToolsGroupBox.Size = new System.Drawing.Size(105, 143);
            this.DrawingToolsGroupBox.TabIndex = 2;
            this.DrawingToolsGroupBox.TabStop = false;
            this.DrawingToolsGroupBox.Text = "Инструменти";
            // 
            // DrawingToolsToolBar
            // 
            this.DrawingToolsToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingToolsToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.CursorButton,
            this.PointButton,
            this.LineButton,
            this.CircleButton,
            this.EllipseButton,
            this.TriangleButton,
            this.SquareButton,
            this.RectangleButton,
            this.PolygonButton,
            this.CurveButton,
            this.ClosedCurveButton,
            this.BezierButton});
            this.DrawingToolsToolBar.ButtonSize = new System.Drawing.Size(30, 29);
            this.DrawingToolsToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.DrawingToolsToolBar.DropDownArrows = true;
            this.DrawingToolsToolBar.ImageList = this.DrawingToolsImageList;
            this.DrawingToolsToolBar.Location = new System.Drawing.Point(5, 15);
            this.DrawingToolsToolBar.Name = "DrawingToolsToolBar";
            this.DrawingToolsToolBar.ShowToolTips = true;
            this.DrawingToolsToolBar.Size = new System.Drawing.Size(95, 123);
            this.DrawingToolsToolBar.TabIndex = 0;
            this.DrawingToolsToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.DrawingToolsToolBar_ButtonClick);
            // 
            // CursorButton
            // 
            this.CursorButton.ImageIndex = 0;
            this.CursorButton.Name = "CursorButton";
            this.CursorButton.ToolTipText = "Курсор";
            // 
            // PointButton
            // 
            this.PointButton.ImageIndex = 1;
            this.PointButton.Name = "PointButton";
            this.PointButton.ToolTipText = "Точка";
            // 
            // LineButton
            // 
            this.LineButton.ImageIndex = 2;
            this.LineButton.Name = "LineButton";
            this.LineButton.ToolTipText = "Права";
            // 
            // CircleButton
            // 
            this.CircleButton.ImageIndex = 3;
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.ToolTipText = "Окръжност";
            // 
            // EllipseButton
            // 
            this.EllipseButton.ImageIndex = 4;
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.ToolTipText = "Елипса";
            // 
            // TriangleButton
            // 
            this.TriangleButton.ImageIndex = 5;
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.ToolTipText = "Триъгълник";
            // 
            // SquareButton
            // 
            this.SquareButton.ImageIndex = 6;
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.ToolTipText = "Квадрат";
            // 
            // RectangleButton
            // 
            this.RectangleButton.ImageIndex = 7;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.ToolTipText = "Правоъгълник";
            // 
            // PolygonButton
            // 
            this.PolygonButton.ImageIndex = 8;
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.ToolTipText = "Многоъгълник";
            // 
            // CurveButton
            // 
            this.CurveButton.ImageIndex = 9;
            this.CurveButton.Name = "CurveButton";
            this.CurveButton.ToolTipText = "Крива";
            // 
            // ClosedCurveButton
            // 
            this.ClosedCurveButton.ImageIndex = 10;
            this.ClosedCurveButton.Name = "ClosedCurveButton";
            this.ClosedCurveButton.ToolTipText = "Затворена крива";
            // 
            // BezierButton
            // 
            this.BezierButton.ImageIndex = 11;
            this.BezierButton.Name = "BezierButton";
            this.BezierButton.ToolTipText = "Крива на Безие";
            // 
            // DrawingToolsImageList
            // 
            this.DrawingToolsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DrawingToolsImageList.ImageStream")));
            this.DrawingToolsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DrawingToolsImageList.Images.SetKeyName(0, "Cursor.png");
            this.DrawingToolsImageList.Images.SetKeyName(1, "Dot.png");
            this.DrawingToolsImageList.Images.SetKeyName(2, "Line.png");
            this.DrawingToolsImageList.Images.SetKeyName(3, "Circle.png");
            this.DrawingToolsImageList.Images.SetKeyName(4, "Ellipse.png");
            this.DrawingToolsImageList.Images.SetKeyName(5, "Triangle.png");
            this.DrawingToolsImageList.Images.SetKeyName(6, "Square.png");
            this.DrawingToolsImageList.Images.SetKeyName(7, "Rectangle.png");
            this.DrawingToolsImageList.Images.SetKeyName(8, "Polygon.png");
            this.DrawingToolsImageList.Images.SetKeyName(9, "Curve.png");
            this.DrawingToolsImageList.Images.SetKeyName(10, "ClosedCurve.png");
            this.DrawingToolsImageList.Images.SetKeyName(11, "Bezier-Curve.png");
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.New_Project);
            this.tabControl.Location = new System.Drawing.Point(106, 66);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1155, 517);
            this.tabControl.TabIndex = 3;
            // 
            // New_Project
            // 
            this.New_Project.Controls.Add(this.DrawArea);
            this.New_Project.Location = new System.Drawing.Point(4, 22);
            this.New_Project.Name = "New_Project";
            this.New_Project.Padding = new System.Windows.Forms.Padding(3);
            this.New_Project.Size = new System.Drawing.Size(1147, 491);
            this.New_Project.TabIndex = 1;
            this.New_Project.Text = "Нов проект";
            this.New_Project.UseVisualStyleBackColor = true;
            // 
            // DrawArea
            // 
            this.DrawArea.AllowDrop = true;
            this.DrawArea.AutoSize = true;
            this.DrawArea.BackColor = System.Drawing.SystemColors.Window;
            this.DrawArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawArea.Location = new System.Drawing.Point(3, 3);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(1141, 485);
            this.DrawArea.TabIndex = 5;
            this.DrawArea.Load += new System.EventHandler(this.DrawArea_Load);
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            this.DrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseDown);
            this.DrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseMove);
            this.DrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BorderWidthStatusLabel,
            this.NameStatusLabel,
            this.CoordinatesStatusLabel,
            this.ActionStatusLabel,
            this.MessageStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 586);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.TabIndex = 4;
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
            // WidthButton
            // 
            this.WidthButton.Location = new System.Drawing.Point(7, 93);
            this.WidthButton.Name = "WidthButton";
            this.WidthButton.Size = new System.Drawing.Size(87, 23);
            this.WidthButton.TabIndex = 2;
            this.WidthButton.Text = "Ширина";
            this.WidthButton.UseVisualStyleBackColor = true;
            this.WidthButton.Click += new System.EventHandler(this.WidthButton_Click);
            // 
            // OtherToolsGroupBox
            // 
            this.OtherToolsGroupBox.Controls.Add(this.WidthTextBox);
            this.OtherToolsGroupBox.Controls.Add(this.WidthButton);
            this.OtherToolsGroupBox.Controls.Add(this.NameButton);
            this.OtherToolsGroupBox.Controls.Add(this.NameTextBox);
            this.OtherToolsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherToolsGroupBox.Location = new System.Drawing.Point(2, 215);
            this.OtherToolsGroupBox.Name = "OtherToolsGroupBox";
            this.OtherToolsGroupBox.Size = new System.Drawing.Size(100, 144);
            this.OtherToolsGroupBox.TabIndex = 6;
            this.OtherToolsGroupBox.TabStop = false;
            this.OtherToolsGroupBox.Text = "Фигура";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Enabled = false;
            this.WidthTextBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(7, 70);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(87, 20);
            this.WidthTextBox.TabIndex = 3;
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(7, 39);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(87, 23);
            this.NameButton.TabIndex = 1;
            this.NameButton.Text = "Име";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(7, 17);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(87, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // RotateGroupBox
            // 
            this.RotateGroupBox.Controls.Add(this.RotateUpDown);
            this.RotateGroupBox.Controls.Add(this.RotateButton);
            this.RotateGroupBox.Location = new System.Drawing.Point(2, 365);
            this.RotateGroupBox.Name = "RotateGroupBox";
            this.RotateGroupBox.Size = new System.Drawing.Size(100, 100);
            this.RotateGroupBox.TabIndex = 7;
            this.RotateGroupBox.TabStop = false;
            this.RotateGroupBox.Text = "Въртене";
            // 
            // RotateUpDown
            // 
            this.RotateUpDown.Enabled = false;
            this.RotateUpDown.Location = new System.Drawing.Point(7, 28);
            this.RotateUpDown.Name = "RotateUpDown";
            this.RotateUpDown.Size = new System.Drawing.Size(87, 20);
            this.RotateUpDown.TabIndex = 2;
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(7, 60);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(87, 23);
            this.RotateButton.TabIndex = 1;
            this.RotateButton.Text = "Завърти";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 608);
            this.Controls.Add(this.RotateGroupBox);
            this.Controls.Add(this.OtherToolsGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.DrawingToolsGroupBox);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Vector Graphics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.DrawingToolsGroupBox.ResumeLayout(false);
            this.DrawingToolsGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.New_Project.ResumeLayout(false);
            this.New_Project.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.OtherToolsGroupBox.ResumeLayout(false);
            this.OtherToolsGroupBox.PerformLayout();
            this.RotateGroupBox.ResumeLayout(false);
            this.RotateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem NewProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Group;
        private System.Windows.Forms.ToolStripMenuItem Ungroup;
        private System.Windows.Forms.ToolStripMenuItem OnTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem FillColor;
        private System.Windows.Forms.ToolStripMenuItem BorderColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem BorderWidth;
        private System.Windows.Forms.ToolStripMenuItem FigureName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Rotate;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem Point;
        private System.Windows.Forms.ToolStripMenuItem Line;
        private System.Windows.Forms.ToolStripMenuItem Circle;
        private System.Windows.Forms.ToolStripMenuItem Ellipse;
        private System.Windows.Forms.ToolStripMenuItem Triangle;
        private System.Windows.Forms.ToolStripMenuItem Square;
        private System.Windows.Forms.ToolStripMenuItem Rectangle;
        private System.Windows.Forms.ToolStripMenuItem Polygon;
        private System.Windows.Forms.ToolStripMenuItem Curve;
        private System.Windows.Forms.ToolStripMenuItem ClosedCurve;
        private System.Windows.Forms.ToolStripMenuItem BezierCurve;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton NewProjectToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.GroupBox DrawingToolsGroupBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage New_Project;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button WidthButton;
        private System.Windows.Forms.GroupBox OtherToolsGroupBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolStripStatusLabel BorderWidthStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CoordinatesStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MessageStatusLabel;
        private Draw.DoubleBufferedPanel DrawArea;
        private System.Windows.Forms.ToolBar DrawingToolsToolBar;
        private System.Windows.Forms.ImageList DrawingToolsImageList;
        private System.Windows.Forms.ToolBarButton CursorButton;
        private System.Windows.Forms.ToolBarButton PointButton;
        private System.Windows.Forms.ToolBarButton LineButton;
        private System.Windows.Forms.ToolBarButton CircleButton;
        private System.Windows.Forms.ToolBarButton EllipseButton;
        private System.Windows.Forms.ToolBarButton TriangleButton;
        private System.Windows.Forms.ToolBarButton SquareButton;
        private System.Windows.Forms.ToolBarButton RectangleButton;
        private System.Windows.Forms.ToolBarButton PolygonButton;
        private System.Windows.Forms.ToolBarButton CurveButton;
        private System.Windows.Forms.ToolBarButton ClosedCurveButton;
        private System.Windows.Forms.ToolBarButton BezierButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveAsToolStripButton;
        private System.Windows.Forms.ToolStripButton PrintToolStripButton;
        private System.Windows.Forms.ToolStripButton CutToolStripButton;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripButton PasteToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton GroupToolStripButton;
        private System.Windows.Forms.ToolStripButton UngroupToolStripButton;
        private System.Windows.Forms.ToolStripButton OnTopToolStripButton;
        private System.Windows.Forms.ToolStripButton FillColorToolStripButton;
        private System.Windows.Forms.ToolStripButton BorderColorToolStripButton;
        private System.Windows.Forms.GroupBox RotateGroupBox;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.ToolStripMenuItem Rotation180MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotation90CWMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotation90CCWMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RotationArbitraryMenuItem;
        private System.Windows.Forms.TextBox RotateUpDown;
    }
}