using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2D_Vector_Graphics.Shapes
{
    [Serializable]
    class SquareShape : RectangleShape
    {
        public SquareShape()
        {
            this.ModelSize = new SizeF(0, 0); //големина на фигурата
            this.Location = new PointF(-1, -1);//позиция
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Квадрат";
        }

        public SquareShape(Color newFillColor, Color newBorderColor, int newBorderWidth, SizeF newModelSize, PointF newlocation)
        {
            this.FillColor = newFillColor; //задава изпълващ цвят
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.ModelSize = newModelSize; //големина на фигурата
            this.Location = newlocation;//позиция
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Квадрат";
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(Location.X, Location.Y, ModelSize.Width, ModelSize.Width));
            path.Transform(this.TMatrix.TransformationMatrix);

            Pen pen = new Pen(this.BorderColor, this.BorderWidth);

            SolidBrush brush = new SolidBrush(this.FillColor);

            if (IS_FILLED)
            {
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
            path.AddRectangle(new RectangleF(Location.X, Location.Y, ModelSize.Width, ModelSize.Width));
            path.Transform(this.TMatrix.TransformationMatrix);

            return path.GetBounds();
        }
    }
}
