using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът LineShape реализира права. Той е наследник на Shape и 
 * има следните методи и полета ( не са дописвани нови,използва унаследените).
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class LineShape : Shape
    {
        protected Point begin,end;
        public Point SetBegin
        {
            set
            {
               begin= value  ;
            }
        }
        public Point SetEnd
        {
            set
            {
                end = value;
            }
        }
        public LineShape()
        {
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));
            this.Name = "Права";
        }
        
        public LineShape(Point begin, Point end)
        {           
            this.begin = begin;
            this.end = end;
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Права";
        }

        public LineShape(Point begin, Point end, Color newBorderColor, int newBorderWidth)
        {
            this.begin = begin;
            this.end = end;
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));
        }

        public override void DrawYourSelf(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(begin,end);
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
            path.AddLine(begin, end);
            path.Transform(this.TMatrix.TransformationMatrix);
            
            return  path.GetBounds();
        }
    }
}
