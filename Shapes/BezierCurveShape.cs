using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът CurveShape реализира крива. Той е наследник на Shape и 
 * има следните методи и полета ( не са дописвани нови,използва унаследените)
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class BezierCurveShape : Shape
    {
        public Point pointOne;
        public Point pointTwo;
        public Point pointTree;
        public Point pointFour;

        public BezierCurveShape()
        {
            pointOne = new Point(-10,-10);
            pointTwo = new Point(-10, -10);
            pointTree = new Point(-10, -10);
            pointFour = new Point(-10, -10);
            this.Name = "Крива на Безие";

            this.selectionUnit = new CoveringRectangle(new Rectangle());
        }

        public BezierCurveShape(ArrayList pointsList, Color newBorderColor, int newBorderWidth)
        {

            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.Name = "Крива на Безие";
         
            this.selectionUnit = new CoveringRectangle(new Rectangle());
        }

        public override void DrawYourSelf(Graphics graphics)
        {         
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(pointOne, pointTwo, pointTree, pointFour);
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
            path.AddBezier(pointOne, pointTwo, pointTree, pointFour);

            path.Transform(this.TMatrix.TransformationMatrix);
            return path.GetBounds();
        }
    }
}
