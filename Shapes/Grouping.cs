using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

/*
 * @author Владислав Найденов
 * Класът Grouping реализира групиране на изчертаните фигури. 
 * Наследник е на Shape и има следните методи и полета.
 */

namespace _2D_Vector_Graphics
{
    [Serializable]
    class Grouping : Shape
    {
       private  ArrayList groupedElements;
       public ArrayList GroupedElements 
        {
            get { return groupedElements; }
            set { groupedElements = value; }
        }
       

        public Grouping(ArrayList SelectedItems)
        {
            this.isGroup = true;
            GroupedElements = SelectedItems;
            this.Selected = true;

        }

        public override void DrawYourSelf(Graphics grafics)
        {
            foreach (Shape item in GroupedElements)
            {
                item.DrawYourSelf(grafics);
            }
            if (this.Selected)
            {
                this.selectionUnit = new CoveringRectangle(Rectangle.Round(ReturnBounds()));
                this.selectionUnit.DrawYourSelf(grafics);
            }
        }

        public override RectangleF ReturnBounds()
        {
            Shape item2 = (Shape)GroupedElements[1];
            RectangleF unionRectangleF  = Rectangle.Round( item2.ReturnBounds());
            foreach (Shape item in GroupedElements)
            {
                unionRectangleF = RectangleF.Union(unionRectangleF, item.ReturnBounds());
            }
             return unionRectangleF;
        }

        public void UnGroup(List<Shape> drownObjects)
        {
            foreach (Shape item in groupedElements)
            {
                item.Selected = true;
                drownObjects.Add(item);     
            }
            drownObjects.Remove(this);
        }     
    }
}
