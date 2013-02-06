using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

/*
 * @autor Владислав Найденов
 * 
 */

namespace _2D_Vector_Graphics
{
    /// <summary>
    ///Класът CoveringRectangle създава ограждащия правоъгълник при селекцията на фигура, добавя 8 квадратчета - бутони за променяне на размера и 1 бутон за ротация.
    /// </summary>
    [Serializable]
    class CoveringRectangle
    {
       /// <summary>
       /// Списък с бутоните на ограждащия правоъгълник.
       /// </summary>
       protected ArrayList selectionElements;
       
        /// <summary>
        /// Правоъгълникът, който минава през бутоните.
        /// </summary>
       protected Rectangle lines;        
     
       /// <summary>
       /// Цвят на ограждащия правоъгълник.
       /// </summary>
       protected Color selectionColor = Color.Black;
       
       /// <summary>
       /// Дебелина на контура на ограждащия правоъгълник.
       /// </summary>
       protected int borderWidth = 1; 

       /// <summary>
       ///  Големината на бутоните
       /// </summary>
       protected Size selUnit = new Size(8,8);
       
       /// <summary>
       /// Отстояние на бутоните от фигурата.
       /// </summary>
       public int sUOfset = 4;

        /// <summary>
       /// Конструктор приемащ описващия четириъгълник на фигурата, която се селектира като параметър.
        /// </summary>
        /// <param name="OuterRect"></param>
        public CoveringRectangle(Rectangle OuterRect)
        {             
            Pen pen=new Pen(selectionColor, borderWidth);
            /*
             * Отдолу са описани координатите на бутоните.
             * Всички координати са относителни , така че би трябвало да няма проблеми при промяна на някои свойства на обекти 
             * или горните свойства.
             * 
             * САМО СА ЗАДАДЕНИ ТУК, ИЗЧЕРТАВАТ СЕ ПОСЛЕ
             * 
             * **/
            selectionElements = new ArrayList();
            selectionElements.Add(new Rectangle(OuterRect.X - selUnit.Width - sUOfset, OuterRect.Y - selUnit.Height - sUOfset, selUnit.Width, selUnit.Height));//goren lqv
            selectionElements.Add(new Rectangle(OuterRect.X + OuterRect.Width + sUOfset, OuterRect.Y - selUnit.Height - sUOfset, selUnit.Width, selUnit.Height));//goren dsen
            selectionElements.Add(new Rectangle(OuterRect.X + (OuterRect.Width - selUnit.Width) / 2, OuterRect.Y - selUnit.Height - sUOfset, selUnit.Width, selUnit.Height));//goren centyr
            selectionElements.Add(new Rectangle(OuterRect.X + OuterRect.Width + sUOfset, OuterRect.Y + (OuterRect.Height - selUnit.Height) / 2, selUnit.Width, selUnit.Height));//desen centyr
            selectionElements.Add(new Rectangle(OuterRect.X + OuterRect.Width + sUOfset, OuterRect.Y + OuterRect.Height + sUOfset, selUnit.Width, selUnit.Height));//dolen desen       
            selectionElements.Add(new Rectangle(OuterRect.X - selUnit.Width - sUOfset, OuterRect.Y + OuterRect.Height + sUOfset, selUnit.Width, selUnit.Height));//dolen lqv       
            selectionElements.Add(new Rectangle(OuterRect.X + (OuterRect.Width - selUnit.Width) / 2, OuterRect.Y + OuterRect.Height + sUOfset, selUnit.Width, selUnit.Height));//dolen centyr       
            selectionElements.Add(new Rectangle(OuterRect.X - selUnit.Width - sUOfset, OuterRect.Y + (OuterRect.Height - selUnit.Height) / 2, selUnit.Width, selUnit.Height));//lqv centyr      
           
            // размерите и координатите на четириъгълника
            lines = (new Rectangle(OuterRect.X - selUnit.Width/2 - sUOfset, OuterRect.Y - selUnit.Height/2 - sUOfset, selUnit.Width+OuterRect.Width+2*sUOfset, selUnit.Height+OuterRect.Height+2*sUOfset));
                               
            // координати за бутона за ротацията
            selectionElements.Add(new Rectangle((int)(OuterRect.X + OuterRect.Width + sUOfset + selUnit.Width * (float)(1.6)), (int)(OuterRect.Y - sUOfset - selUnit.Height * (float)(1.6)), (int)(selUnit.Width * (float)(1.5)), (int)(selUnit.Height * (float)(1.5))));//goren dsen
            // кръгчето в бутона
            selectionElements.Add(new Rectangle((int)(OuterRect.X + sUOfset + OuterRect.Width + selUnit.Width * (float)(1.8)), (int)(OuterRect.Y - sUOfset - selUnit.Height * (float)(1.3)), (int)(selUnit.Width), (int)(selUnit.Height)));                
        }
        
        /// <summary>
        /// Проверява дали сме кликнали в бутон и ако сме ни връща индекса му
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public int ContainsPoint(Point point)
        {            
            foreach (Rectangle unit in selectionElements)
            { 
                if(unit.Contains(point))
                {
                    return selectionElements.IndexOf(unit);
                }
            }
            
         //   if(path.GetBounds().Contains(point))
         ////   {
         ///       return 8;
         //   }
            return -2;
        }
        
       /// <summary>
       /// Метод, който изчертава ограждащия правоъгълник
       /// </summary>
       /// <param name="grafics"></param>
        public void DrawYourSelf(Graphics grafics)
        {
            foreach (Rectangle unit in selectionElements)
            {
                if (selectionElements.IndexOf(unit) == 9)
                {                    
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(unit);
                    grafics.DrawPath(new Pen(Color.Blue), path);
                }
                grafics.DrawRectangle(new Pen(Color.Blue), unit);
            }
            grafics.DrawRectangle(new Pen(Color.Blue), lines);            
        }
    }
}
