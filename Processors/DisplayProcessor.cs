using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * Класът DisplayProcessor реализира списък от фигури и методи за изчертаването им. 
 * Независим от класът на фигурата реализра и указване.
 */

namespace _2D_Vector_Graphics
{
    
    class DisplayProcessor
    {
        public DisplayProcessor()
        {

        }

        /*
        * Списък със изчертаните елементи.
        */
        private List<Shape> objectsDrawn = new List<Shape>();
        public List<Shape> ObjectsDrawn 
        {
            get { return objectsDrawn; }
            set { objectsDrawn = value; }
        }

        private Size drawAreaSize;
        public Size DrawAreaSize
        {
            get { return drawAreaSize; }
            set { drawAreaSize = value; }
        }
       
        /*
         * съдържа начина на рендериране на изображението
         * 
         * 
         */
        private SmoothingMode renderMode = SmoothingMode.AntiAlias;
        public SmoothingMode RenderMode
        {
            get { return renderMode; }
            set { renderMode = value; }
        }

        // селектирания елемент -null aко няма такъв
        private Shape selectedItem;
        public Shape SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }

        // Брои колко елемента са селектирани
        private int countSelectedItems = 0;
        public int CountSelectedItems
        {
            get { return countSelectedItems; }
            set
            {
                if (SelectedItem.Selected == true)
                {
                    countSelectedItems++;
                }
            }
        }

        // селектирания елемент -null aко няма такъв
   
        /* проверява дали дадена точка е във фигурата 
      * извиква си метода на фигурата - независи от класа на фигурата
      */
        public void ContainsPoint(Point point)
        {
            // прави всички фигури неселектирани
            ResetDrawnObjects();
            //цикъл за обхождане - в обратен ред понеже последните фигури,които са 
            // изчертани са най-отгоре
            for (int i = ObjectsDrawn.Count - 1; i >= 0; i--)
            {
                if (ObjectsDrawn[i].ContainsPoint(point))
                {
                    SelectedItem = ObjectsDrawn[i]; // селектирания обект е този с точката       
                    selectedItem.Selected = true;                    
                    return  ;
                }
            }
            // изчистваме селектирания елемент иначе използва последния селектиран
            selectedItem = null;
            return ; 
        }

        /*
       *  Обхожда списъкът с елементите и ги изрисува
         *  извиква се от пространството за чертане (DrawArea) при Paint
         *  изпълнява се при извикване на DrawArea.Invalidate();
       * **/
        virtual protected void ReDraw(Graphics grafics)
        {
            this.DrawElementByElement(grafics);// изчертаване
        }

        /*
         * Обхожда всички елементи, които са в структурата
         * **/
        virtual protected void DrawElementByElement(Graphics grafics)
        { 
            foreach(Shape model in ObjectsDrawn)
            {
                DrawElement(model, grafics);
            }
        }

        /*
         * Иавиква метода самоизчертаване на фигурата
         * **/
        protected virtual void DrawElement(Shape Element, Graphics Grafics)
        {
            Element.DrawYourSelf(Grafics);
        }

        public void ResetDrawnObjects()
        {
            for (int i = ObjectsDrawn.Count - 1; i >= 0; i--)
            {
               ObjectsDrawn[i].Selected = false;
            }
            return;
        }

        /*
         * методът се извиква при действие от страна на потребителя за да се изчертаят наново елементите
         */
        public virtual void HandleDrawing(PaintEventArgs arg)
        {
            // определя начина на рендериране на фигурите
            arg.Graphics.SmoothingMode = this.renderMode;
            // изчертаване на всичко
            this.ReDraw(arg.Graphics);
        }
    }
}
