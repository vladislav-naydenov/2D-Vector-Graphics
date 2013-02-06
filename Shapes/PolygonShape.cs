using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът PolygonShape реализира многоъгълник. Той е наследник на Shape и 
 * има следните методи и полета( не са дописвани нови,използва унаследените)
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class PolygonShape : Shape
    {

        public ArrayList pointsList;

        public PolygonShape(ArrayList pointsList)
        {
            this.pointsList = new ArrayList(pointsList);
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Многоъгълник";
        }

        public PolygonShape(ArrayList pointsList, Color newFillColor, Color newBorderColor, int newBorderWidth)
        {
            this.FillColor = newFillColor;
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.pointsList = new ArrayList(pointsList);
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Многоъгълник";
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            int i = 0;
            Point[] points = new Point[this.pointsList.Count];//(Point[])pointsList.ToArray(typeof(Point));
            foreach(Point _point in this.pointsList)
            {
                points[i] = _point;
                i++;
            }

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(points);
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

            path.AddPolygon(points);
            path.Transform(this.TMatrix.TransformationMatrix);

            return  path.GetBounds();
        }
    }
}
