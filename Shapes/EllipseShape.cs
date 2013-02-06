using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът EllipseShape реализира елипса. Той е наследник на Shape и 
 * има следните методи и полета( не са дописвани нови,използва унаследените)
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class EllipseShape : Shape
    {
        public RectangleF SetLocation
        {
            set
            {
                this.Location = value.Location;
                this.ModelSize = value.Size;
            }
        }

        /// <summary>
        /// Празен конструктор - създава елипса с координати (0,0) и размер 50 на 50. В него са зададени цвета на фигурата, дебелината и цвета на контура.
        /// </summary>
        public EllipseShape()
        {
            this.ModelSize = new SizeF(0, 0); //големина на фигурата
            this.Location = new PointF(-10, -10);//позиция
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Елипса";
        }

        /// <summary>
        /// Конструктор, който позволява променяне на характеристиките на фигурата - големина, размер, цвят на запълване, дебелина и цвят на контур.
        /// </summary>
        /// <param name="newFillColor"></param>
        /// <param name="newBorderColor"></param>
        /// <param name="newBorderWidth"></param>
        /// <param name="newModelSize"></param>
        /// <param name="newLocation"></param>
        public EllipseShape(Color newFillColor, Color newBorderColor, int newBorderWidth, SizeF newModelSize, PointF newLocation)
        {
            this.FillColor = newFillColor; //задава изпълващ цвят
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.ModelSize = newModelSize; //големина на фигурата
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Елипса";
        }

        /// <summary>
        /// Изчетава елипсата.
        /// </summary>
        /// <param name="graphics"></param>
        public override void DrawYourSelf(Graphics graphics)
        {
           
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(Location.X + ModelSize.Width / 3, Location.Y + ModelSize.Height / 3, ModelSize.Width / 3, ModelSize.Height / 3);
            path.CloseFigure();
            path.StartFigure();
            path.AddLine(Location.X + (ModelSize.Width * 2) / 3, Location.Y + ModelSize.Height / 2, Location.X + ModelSize.Width, Location.Y + ModelSize.Height / 2);
            path.CloseFigure();
            path.AddEllipse(new RectangleF(Location, ModelSize));
            path.CloseFigure();
            path.Transform(this.TMatrix.TransformationMatrix);
         
            /*
             * Създава се Pen, който изчертава контура, като използва
             * цвят и дебелина (определят се от конструктора)
             */
            Pen pen = new Pen(this.BorderColor, this.BorderWidth);
            // Правим същото, но за запълването
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
        /*
         * Предефиниране на базовия клас за да отговаря на особенностите на 
         * новата фигура
         */
        public override RectangleF ReturnBounds()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(Location.X + ModelSize.Width / 3, Location.Y + ModelSize.Height / 3, ModelSize.Width / 3, ModelSize.Height / 3);
            path.CloseFigure();
            path.StartFigure();
            path.AddLine(Location.X + (ModelSize.Width * 2) / 3, Location.Y + ModelSize.Height / 2, Location.X + ModelSize.Width, Location.Y + ModelSize.Height / 2);
            path.CloseFigure();
            path.AddEllipse(new RectangleF(Location, ModelSize));
            path.CloseFigure();
            path.Transform(this.TMatrix.TransformationMatrix);
            return  path.GetBounds();
        }
    }
}
