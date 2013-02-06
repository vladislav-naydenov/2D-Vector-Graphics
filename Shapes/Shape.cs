using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът Shape реализира абстракцията фигура. За да бъде създадена
 * каквато и да е фигура, този клас трябва да бъде наследен от новата фигура.
 * Съдържа следните методи и полета:
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    abstract class Shape
    {
        public static bool IS_FILLED = true;
        public Shape()
        {

        }
       //указва дали елемента е група
       public bool isGroup = false;
       public bool canUnGroup = true;
        // име на елемeнта с цел именуване
       private string name = "Unknown name";
       public string Name
       {
           set {name = value; }
           get { return name; }
       }
        //това е за селектора при указване
        public  CoveringRectangle selectionUnit;
        /*
         * Матрицата на транслация на фигурата 
         * ясно е за какво се използва 
      */
        private MatrixHandler tMatrix = new MatrixHandler();
        virtual public MatrixHandler TMatrix
        {
            get { return tMatrix; }
            set { tMatrix = value; }
        }
        /*
         *Съдържа координатите на фигурата - горен ляв ъгъл.
         *Позволява четене и запис но да се има предвид, че е от тип PointF
         */
        private PointF location = new PointF(0,0);
        public PointF Location
        {
            get { return location; }
            set { location = value; }
        }
      
        /*
         * дали фигурата е селектирана (ползва се за изчертаване на селекцията)
         * **/
        private bool selected = false;
        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
  
        /*
       *Съдържа изпълващия цвят на фигурата .
       *Позволява четене и запис но да се има в предвид,че е от тип Color
       */
        private Color fillColor = Color.Transparent;
        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }
        /*
       *Съдържа цвета на контура на фигурата .
       *Позволява четене и запис но да се има в предвид,че е от тип Color
       */
        private Color borderColor = Color.Black;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }
        /*
      *Съдържа дебелината на контура на фигурата .
      *Позволява четене и запис но да се има в предвид,че е от тип Int
      */
        private int borderWidth;
        public int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; }
        }
        /*
        *Съдържа размерите на фигурата - широчина и височина .
        *Позволява четене и запис но да се има предвид, че е от тип SizeF
        */
        private SizeF modelSize = new SizeF((float)0.002, (float)0.002);
        public SizeF ModelSize
        {
            get { return modelSize; }
            set { modelSize = value; }
        }      
        /*
         *Функцията DrawYourSelf изрисува текущата фигура.
         *Тя трябва да бъде написана за всеки клас фигури.
         */
        abstract public void DrawYourSelf(Graphics graphics);
        /*
       *Функцията ContainsPoint проверява дали дадена точка е вътрешна
       *за фигурата.
       */
        virtual public bool ContainsPoint(Point point)
        {
            if (selectionUnit.ContainsPoint(point) > -1)
            {
                return true;
            }
            else
            {
                return ReturnBounds().Contains(point);
            }
        }
        /*
       *Функцията ReturnBounds връща границите на фигурата
       */
        abstract public RectangleF ReturnBounds();
        
    }
}
