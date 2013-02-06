using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът RectangleShape реализира  правоъгълник. Той е наследник на Shape и 
 * има следните методи и полета ( не са дописвани нови,използва унаследените).
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class RectangleShape : Shape
    {        
        public RectangleF SetLocation
        {
            set {
                this.Location = value.Location;
                this.ModelSize = value.Size;
            }
        }

        /// <summary>
        /// Конструктор без параметри - създава четириъгълник с координати 0,0 и размер 50,50. В него са зададени цвета на фигурата, дебелината и цвета на контура.
        /// </summary>
        public RectangleShape()
        {
            this.ModelSize = new SizeF(0, 0); //големина на фигурата
            this.Location = new PointF(-1, -1);//позиция
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Правоъгълник";
        }

        /// <summary>
        /// Конструктор, който позволява променянето на характеристиките на фигурата - големина, размер, цвят на запълване, дебелина и цвят на контур.
        /// </summary>
        /// <param name="newFillColor"></param>
        /// <param name="newBorderColor"></param>
        /// <param name="newBorderWidth"></param>
        /// <param name="newModelSize"></param>
        /// <param name="newlocation"></param>
        public RectangleShape(Color newFillColor, Color newBorderColor, int newBorderWidth, SizeF newModelSize, PointF newlocation)
        {
            this.FillColor = newFillColor; //задава изпълващ цвят
            this.BorderColor = newBorderColor; // цвят на контура
            this.BorderWidth = newBorderWidth; //дебелина на контура
            this.ModelSize = newModelSize; //големина на фигурата
            this.Location = newlocation;//позиция
            this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));

            this.Name = "Правоъгълник";
        }

       /// <summary>
       /// Изчертава правоъгълника.
       /// </summary>
       /// <param name="graphics"></param>
        public override void DrawYourSelf(Graphics graphics)
        {
           
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(Location, ModelSize));
            path.Transform(this.TMatrix.TransformationMatrix);
            /**
             * Създава се Pen, който изчертава контура, като използва
             * цвят и дебелина (определят се от конструктора)
             **/
            Pen pen = new Pen(this.BorderColor, this.BorderWidth);
            /*
             * Създава се SolidBrush, която изпълва фигурата, като използва
             * цвят (определя се от конструктора)
             */
            SolidBrush brush = new SolidBrush(this.FillColor);
            /*
           * Функция на namespace System.Drawing.Drawing2D
           * Изпълва контура на елипсата чрез SolidBrush
          */
            if (IS_FILLED)
            {                
                graphics.FillPath(brush, path);
            }
            /*
             * Функция на namespace System.Drawing.Drawing2D
             * Изчертава контура на елипсата чрез Pen
            */
            graphics.DrawPath(pen, path);

            if (this.Selected)
            {
                this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));
                this.selectionUnit.DrawYourSelf(graphics);
            }
        }
        
        /// <summary>
        /// Предефинира базовия клас, за да отогваря на пспбенстите на новата фигура.        
        /// </summary>
        /// <returns></returns>
        public override RectangleF ReturnBounds()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(Location, ModelSize));
            path.Transform(this.TMatrix.TransformationMatrix);

            return  path.GetBounds();
        }
      
    }
}
