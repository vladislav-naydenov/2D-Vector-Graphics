using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2D_Vector_Graphics.Shapes
{
    [Serializable]
    class EllipseLineIntersectionShape : EllipseShape
    {
        public EllipseLineIntersectionShape()
        {
            this.Name = "Елипса пресечена от прави";
        }        

        public EllipseLineIntersectionShape(Color newFillColor, Color newBorderColor, int newBorderWidth, SizeF newModelSize, PointF newLocation)
        {
            this.FillColor = newFillColor;
            this.BorderColor = newBorderColor;
            this.BorderWidth = newBorderWidth;
            this.ModelSize = newModelSize;
            this.Location = newLocation;
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Елипса пресечена от прави";
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(Location.X, Location.Y + ModelSize.Height / 3, Location.X + ModelSize.Width, Location.Y + ModelSize.Height / 3);
            path.CloseFigure();
            path.StartFigure();
            path.AddLine(Location.X, Location.Y + (ModelSize.Height / 3) * 2, Location.X + ModelSize.Width, Location.Y + (ModelSize.Height * 2) / 3);
            path.CloseFigure();
            path.AddEllipse(new RectangleF(Location, ModelSize));
            path.CloseFigure();
            path.Transform(this.TMatrix.TransformationMatrix);

            Pen pen = new Pen(this.BorderColor, this.BorderWidth);
            if (IS_FILLED)
            {
                SolidBrush brush = new SolidBrush(this.FillColor);
                graphics.FillPath(brush, path);
            }
            graphics.DrawPath(pen, path);
            if (this.Selected)
            {
                this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));
                this.selectionUnit.DrawYourSelf(graphics);
            }
        }

        public override RectangleF ReturnBounds()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(Location.X, Location.Y + ModelSize.Height / 3, Location.X + ModelSize.Width, Location.Y + ModelSize.Height / 3);
            path.CloseFigure();
            path.StartFigure();
            path.AddLine(Location.X, Location.Y + (ModelSize.Height / 3) * 2, Location.X + ModelSize.Width, Location.Y + (ModelSize.Height * 2) / 3);
            path.CloseFigure();
            path.AddEllipse(new RectangleF(Location, ModelSize));
            path.CloseFigure();
            path.Transform(this.TMatrix.TransformationMatrix);
            
            return path.GetBounds();
        }
    }
}
