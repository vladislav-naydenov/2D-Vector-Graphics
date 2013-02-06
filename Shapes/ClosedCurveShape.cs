using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов 
 * Класът CurveShape реализира крива. Той е наследник на Shape и 
 * има следните методи и полета ( не са дописвани нови,използва унаследените).
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class ClosedCurveShape : Shape
    {

        public ArrayList pointsList;

        public ClosedCurveShape(ArrayList pointsList)
        {
            this.pointsList = new ArrayList(pointsList);
            this.selectionUnit = new CoveringRectangle(new Rectangle());

            this.Name = "Затворена крива";
        }

        public ClosedCurveShape(ArrayList pointsList, Color newBorderColor, int newBorderWidth)
        {
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.pointsList = new ArrayList(pointsList);
            this.selectionUnit = new CoveringRectangle(new Rectangle());

            this.Name = "Затворена крива";
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            if (pointsList.Count < 4) return;
            Point[] points = (Point[])pointsList.ToArray(typeof(Point));

            GraphicsPath path = new GraphicsPath();
            path.AddClosedCurve(points, 1);
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
            Point[] points = (Point[])pointsList.ToArray(typeof(Point));
            GraphicsPath path = new GraphicsPath();
            path.AddClosedCurve(points, 1);

            path.Transform(this.TMatrix.TransformationMatrix);
            return path.GetBounds();
        }
    }
}
