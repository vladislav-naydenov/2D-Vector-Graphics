using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов
 * SemanticProcessor променя храктеристики на елементите.
 */

namespace _2D_Vector_Graphics
{
    class SemanticProcessor : StructuralProcessor
    {
        /*
         * ВНИМАНИЕ!!!
         * тази секция е за указани елемнти, не за селектирани
         * **/
     
        //добавя име на елемента
        public void SetSelectedItemName(string name)
        {
            if (SelectedItem != null)
            {
                SelectedItem.Name = name;
            }
        }
      
        /*
         * 
         * тази секция е за елементи селектирани чрез множествената селекция или указване
         * 
         * */
       
        //задава цвят на изпълване
        public void SetSelectedItemFillColor(Color color)
        {
            foreach (Shape item in ObjectsDrawn)
            {
                if (item.Selected)
                {
                    item.FillColor = color;
                }
            }
        }
        // цвят на контура
        public void SetSelectedItemBorderColor(Color color)
        {
            foreach (Shape item in ObjectsDrawn)
            {
                if (item.Selected)
                {
                    item.BorderColor = color;
                }
            }
        }
        // дебелина на контура
        public void SetSelectedItemBorderWidth(int width)
        {
            foreach (Shape item in ObjectsDrawn)
            {
                if (item.Selected)
                {
                    item.BorderWidth = width;
                }
            }
        }
    }
}
