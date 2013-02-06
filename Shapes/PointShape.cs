using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2D_Vector_Graphics.Shapes
{
    [Serializable]
    class PointShape : CircleShape
    {
        public PointShape()
        {
            this.ModelSize = new SizeF(0, 0);
            this.Location = new PointF(-10, -10);
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Точка";
        }

        public PointShape(Color newFillColor, Color newBorderColor, int newBorderWidth, SizeF newModelSize, PointF newLocation)
        {
            this.FillColor = newFillColor;
            this.BorderColor = newBorderColor;
            this.BorderWidth = newBorderWidth;
            this.ModelSize = newModelSize;
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Точка";
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(Location.X, Location.Y, 5, 5);
            path.Transform(this.TMatrix.TransformationMatrix);

            Pen pen = new Pen(this.BorderColor, this.BorderWidth);
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
            path.AddEllipse(Location.X, Location.Y, 5, 5);
            path.Transform(this.TMatrix.TransformationMatrix);

            return path.GetBounds();
        }
    }
}
