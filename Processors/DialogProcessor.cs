using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Collections;

/*
 * @autor Владислав Найденов
 * Класът DialogProcessor доразвива DisplayProcessor и реализира методи
 */

namespace _2D_Vector_Graphics
{
    class DialogProcessor : SemanticProcessor
    {
        public string messageToStrip = "";
        public List<Shape> controlPolygon = new List<Shape>();
        public List<Shape> toCutCopyPasteDel = new List<Shape>();

        /// <summary>
        /// Използва се за запазване на промените в последния отварян файл
        /// </summary>
        private string fileName; 
        
        public DialogProcessor()
        {
           
        }

        public void AddEllipseShape()
        {
            ObjectsDrawn.Add(new EllipseShape());
        }

        public void AddRectangleShape()
        {
            ObjectsDrawn.Add(new RectangleShape());
        }

        public void AddLineShape()
        {
            ObjectsDrawn.Add(new LineShape(new Point(10, 10), new Point(20, 20)));
        } 

        /// <summary>
        /// Създава файл за запис на данните и ги запазва в него.
        /// </summary>
        public void SaveInFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Въведете име на файл за запис...";
            saveFileDialog.Filter = "2D Vector Graphics Project Files(*.vg)|*.vg|JPEG(*.jpg)|*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true ;
             if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileName = saveFileDialog.FileName;
                Stream stream = File.Open(this.fileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, ObjectsDrawn);
                stream.Close();
             }
        }

        /// <summary>
        /// Прави запис на данните ако има предварително създаден файл.
        /// </summary>
        public void Save()
        {
            if (this.fileName == null )
            {
                SaveInFile();
            }
            else
            {
                Stream stream = File.Open(this.fileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, ObjectsDrawn);
                stream.Close();
            }
        }

        /// <summary>
        /// Отваря файл създаден с 2D Vector Graphics.
        /// </summary>
        public void OpenFile()
        { 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Изберете файл...";            
            openFileDialog.Filter = "2D Vector Graphics Project Files(*.vg)|*.vg";
            openFileDialog.RestoreDirectory = true ;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileName = openFileDialog.FileName;
                Stream stream = File.Open(this.fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                this.ObjectsDrawn = (List<Shape>)bFormatter.Deserialize(stream);
                stream.Close();
            }
        }

        /// <summary>
        /// Създава нов проект.
        /// </summary>
        public void NewProject()
        {            
            this.ObjectsDrawn.Clear();        
        }
        
        /// <summary>
        /// Изтрива избраните елементи.
        /// </summary>
        public void DeleteSelected()
        {
            //if (SelectedItem != null)
            //{
            //    ObjectsDrawn.Remove(SelectedItem);
            //}
           
            foreach (Shape figure in ObjectsDrawn)
            {
                if (figure.Selected)
                {
                    toCutCopyPasteDel.Add(figure);
                }
            }

            foreach (Shape figureT in toCutCopyPasteDel)
            {
                ObjectsDrawn.Remove(figureT);                
            }
            toCutCopyPasteDel.Clear();
        }

        /// <summary>
        /// Изрязва избраните елементи.
        /// </summary>
        public void CutSelected()
        {
            toCutCopyPasteDel.Clear();
            foreach (Shape figure in ObjectsDrawn)
            {
                if (figure.Selected)
                {
                    toCutCopyPasteDel.Add(figure);
                }
            }

            foreach (Shape figureT in toCutCopyPasteDel)
            {
                ObjectsDrawn.Remove(figureT);
            }   
        }

        /// <summary>
        /// Копира избраните елементи.
        /// </summary>
        public void CopySelected()
        {
            toCutCopyPasteDel.Clear();
            foreach(Shape figure in ObjectsDrawn)
            {
                if(figure.Selected)
                {                 
                    toCutCopyPasteDel.Add(figure);
                }
            }           
        }

        /// <summary>
        /// Поставя избраните елементи.
        /// </summary>
        public void PasteSelected()
        {
            //SelectedItem.Selected = false;
            if (toCutCopyPasteDel.Count > 0)
            {
                foreach (Shape figure in toCutCopyPasteDel)
                {
                    ObjectsDrawn.Add(figure);                    
                }
            }
            ResetDrawnObjects();
            SelectedItem = null;
        }

        public void Rotate(float angle)
        {
            SelectedItem.TMatrix.Rotate(angle, CalculateCenter());
        }

        public void SelectItem()
        { 
            
             ActionT = "TranslateElementTo";
        }

        /// <summary>
        /// Променя цвета на запълване на избран елемент.
        /// </summary>
        public void ChangeFillColor()
        {
               ColorDialog palete = new ColorDialog();

               if (palete.ShowDialog() == DialogResult.OK)
               {
                   if (SelectedItem != null && SelectedItem.isGroup == false)
                   {
                       SelectedItem.FillColor = palete.Color;
                   }

                   if (SelectedItem != null && SelectedItem.isGroup == true)
                   {
                       ChangeCascadeFillColor(SelectedItem, palete.Color);
                   }
                  
                   foreach (Shape figure in ObjectsDrawn)
                   {
                       if (figure.Selected)
                       {
                           ObjectsDrawn[ObjectsDrawn.IndexOf(figure)].FillColor = palete.Color; ;
                       }
                       if (figure.isGroup)
                       {
                           ChangeCascadeFillColor(figure, palete.Color);
                       }
                   }
               }
        }

        /// <summary>
        /// Използва се в методът ChangeFillColor за промяна на цвета на запълване на селектиран елемент, ако той е част от група от елементи.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="color"></param>
        private void ChangeCascadeFillColor(Shape group, Color color)
        {
            foreach (Shape item in ((Grouping)group).GroupedElements)
            {
                if (item.isGroup == true)
                {
                    ChangeCascadeFillColor(item, color);
                }
                else
                {
                    item.FillColor = color;
                }
            }
        
        }

        /// <summary>
        /// Променя ширината на контура на селектиран елемент.
        /// </summary>
        /// <param name="border"></param>
        public void SetBorderWidth(int border)
        {
            if (border < 0)
                return;

            if ((SelectedItem != null) && (SelectedItem.isGroup == false))
            {
                SelectedItem.BorderWidth = border;
            }

            if ((SelectedItem != null) && (SelectedItem.isGroup == true))
            {

                ChangeCascadeBorderWidth(SelectedItem, border);
            }

            foreach (Shape figure in ObjectsDrawn)
            {
                if (figure.Selected)
                {
                    ObjectsDrawn[ObjectsDrawn.IndexOf(figure)].BorderWidth = border;
                }

                if (figure.isGroup)
                {
                    ChangeCascadeBorderWidth(figure, border);
                }
            }
        }

        /// <summary>
        /// Използва се в методът ChangeBorderWidth за промяна на ширината на контура, ако селектираният елемент е част от група.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="width"></param>
        private void ChangeCascadeBorderWidth(Shape group, int width)
        {
            foreach (Shape item in ((Grouping)group).GroupedElements)
            {
                if (item.isGroup == true)
                {
                    ChangeCascadeBorderWidth(item, width);
                }
                else
                {
                    item.BorderWidth = width;
                }
            }
        }

        /// <summary>
        /// Променя цвета на контура на селектиран елемент.
        /// </summary>
        public void ChangeBorderColor()
        {
            ColorDialog palete = new ColorDialog();

            if (palete.ShowDialog() == DialogResult.OK)
            {
                if (SelectedItem != null && SelectedItem.isGroup == false)
                {
                    SelectedItem.BorderColor = palete.Color;
                }

                if (SelectedItem != null && SelectedItem.isGroup == true)
                {
                    ChangeCascadeBorderColor(SelectedItem, palete.Color);
                }

                foreach (Shape figure in ObjectsDrawn)
                {
                    if (figure.Selected)
                    {
                        ObjectsDrawn[ObjectsDrawn.IndexOf(figure)].BorderColor = palete.Color; ;
                    }
                    if (figure.isGroup)
                    {
                        ChangeCascadeBorderColor(figure, palete.Color);
                    }
                }
            }
        }

        /// <summary>
        /// Използва се в методът ChangeBorderColor за промяна на цвета на контура на селектиран елемент, ако той е част от група от елементи.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="color"></param>
        private void ChangeCascadeBorderColor(Shape group, Color color)
        {
            foreach (Shape item in ((Grouping)group).GroupedElements)
            {
                if (item.isGroup == true)
                {
                    ChangeCascadeFillColor(item, color);
                }
                else
                {
                    item.BorderColor = color;
                }
            }

        }              

        /// <summary>
        /// Премества елемент над друг.
        /// </summary>
        public void SetItemsOnTop()
        {
            if (SelectedItem != null)
            {
                ObjectsDrawn.Remove(SelectedItem);
                ObjectsDrawn.Add(SelectedItem);
            }
          
        }
        
        /// <summary>
        /// Изчертава ограждащият правоъгълник.
        /// </summary>
        /// <param name="grafics"></param>
        override protected void ReDraw(Graphics grafics)
        {
            base.ReDraw(grafics);
            foreach (Shape polygon in controlPolygon)
            {
                DrawElement(polygon, grafics);
            }
        }
    }

}
 