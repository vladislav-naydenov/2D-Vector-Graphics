using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using _2D_Vector_Graphics.Shapes;
using _2D_Vector_Graphics.GUI;

/*
 * @autor Владислав Найденов
 * Класът EventHandler 
 * създаден за обработка на събития възникнали непосредствено при работата на потребителя с
 * графичния интерфейс
 */

namespace _2D_Vector_Graphics
{
    /// <summary>
    /// Грижи се за обработка на събития възникнали непосредствено при работата на потребителя с графичния интерфейс.
    /// </summary>
    class EventHandler
    {
        public Cursor RotationCursor = new Cursor("../../Resources/RotateCursor.cur");               
        private DialogProcessor diProcessor;
        public Graphics drawer;
        public string Event;
        private ArrayList sDots = new ArrayList();
        public Shape itemPointer;
        
        //конструктора всъщност създава refеrence към диалоговия процесор на програмата
        // цел - по лесна работа
        public EventHandler(ref DialogProcessor di_Processor)
        {
            this.diProcessor = di_Processor;  
        }              

        /// <summary>
        /// При кликване в пространството за рисуване приeма координатите.
        /// </summary>
        /// <param name="mLocation"></param>
        public void MouseDown(Point mLocation)
        {            
            switch(Event)
            {
                case "DrawPointShape":
                    {
                        Event = "DrawPointShape-go";
                        itemPointer = new PointShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    }break;

                case "DrawLineShape":
                    {
                        Event = "DrawLineShape-go";
                        itemPointer = new LineShape(new Point(-1, -1), new Point(-1, -1));
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    } break;

                case "DrawSquareShape":
                    {
                        Event = "DrawSquareShape-go";
                        itemPointer = new SquareShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    }break;

                case "DrawRectangleShape":
                    {
                        Event = "DrawRectangleShape-go";
                        itemPointer = new RectangleShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    } break;

                case "DrawEllipseShape":
                    {
                        Event = "DrawEllipseShape-go";
                        itemPointer = new EllipseShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                        
                    } break;

                case "DrawEllipseLineIntersectionShape":
                    {
                        Event = "DrawEllipseLineIntersectionShape-go";
                        itemPointer = new EllipseLineIntersectionShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    } break;

                case "DrawConnectedEllipses":
                    {
                        Event = "DrawConnectedEllipses-go";
                        itemPointer = new ConnectedEllipses();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    } break;

                case "DrawCircleShape":
                    {
                        Event = "DrawCircleShape-go";
                        itemPointer = new CircleShape();
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                        sDots.Clear();
                        sDots.Add(mLocation);
                    }break;

                case "DrawCurveShape":
                    {
                        sDots = new ArrayList();
                        sDots.Add(mLocation);
                        Event = "DrawCurveShape-go";
                        itemPointer = new CurveShape(sDots);
                        diProcessor.ObjectsDrawn.Add(itemPointer);
                       

                    } break;

                case "DrawClosedCurveShape":
                    {
                        sDots = new ArrayList();
                        sDots.Add(mLocation);
                        Event = "DrawClosedCurveShape-go";
                        itemPointer = new ClosedCurveShape(sDots);
                        diProcessor.ObjectsDrawn.Add(itemPointer);


                    } break;

                case "DrawPolygonShape":
                    {
                        Event = "DrawPolygonShape-go";
                        diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));
                        sDots.Clear();
                        sDots.Add(mLocation);

                    } break;

                case "DrawBezierShape":
                    {
                        Event = "DrawBezierShape-go";
                        sDots.Clear();
                        sDots.Add(mLocation);
                        diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));
                    } break;

                case "DrawTriangleShape":
                    {
                        Event = "DrawTriangleShape-go";
                        sDots.Clear();
                        sDots.Add(mLocation);
                        diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));

                    } break;                

                case "DrawTriangleShape-go":
                    {                 
                        sDots.Add(mLocation);
                        diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));
                    } break;

                case "DrawPolygonShape-go":
                    {
                       sDots.Add(mLocation);
                       diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));
                    } break;

                case "DrawBezierShape-go":
                    {
                        sDots.Add(mLocation);
                        diProcessor.controlPolygon.Add(new LineShape(mLocation, mLocation));
                    } break;
                
                default:
                    {
                        // проверка дали е кликнато в някоя фигура 
                        diProcessor.ContainsPoint(mLocation);
                        //ако е 
                        if (diProcessor.SelectedItem != null)
                        {
                            diProcessor.messageToStrip = diProcessor.SelectedItem.Name; 
                            //ако е кликнато на бутон от селектора
                            if (diProcessor.SelectedItem.selectionUnit.ContainsPoint(mLocation) > -1)
                            {
                                //задаваме действие оразмеряване
                                this.Event = "Scale";

                                //елемента може да се влачи
                                diProcessor.IsDraging = true;

                                //записваме индекса на операцията в процесора
                                diProcessor.selectionUnitIndex = diProcessor.SelectedItem.selectionUnit.ContainsPoint(mLocation);

                                // определяме типа на курсора на мишката
                                switch (diProcessor.selectionUnitIndex)
                                {
                                    case 0: // горен десен
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNWSE;
                                        } break;

                                    case 1: // горен ляв
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNESW; 
                                        } break;

                                    case 2: // горе център
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNS;  
                                        }break;

                                    case 3: // десен център
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeWE;  
                                        }break;

                                    case 4: // долен десен
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNWSE;  
                                        }break;

                                    case 5: // долен ляв
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNESW;  
                                        }break;

                                    case 6: // горен десен
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeNS; 
                                        }break;

                                    case 7: // ляв център
                                        {
                                            MainWindow.ActiveForm.Cursor = Cursors.SizeWE; 
                                        }break;

                                    case 8: // тук ѝ задавaме действие ротация
                                        {                                                                                        
                                            MainWindow.ActiveForm.Cursor = RotationCursor; 
                                            this.Event = "RotateAt"; 
                                        }break;
                                }
                            }
                            else
                            {
                                //в случай, че сме кликнали в някой елемент го подготвяме за транслация
                                diProcessor.IsDraging = true;
                                this.Event = "TranslateElementTo";
                                
                                // Променяме и курсора
                                MainWindow.ActiveForm.Cursor = Cursors.SizeAll;
                            }
                        }
                        else
                        {
                            diProcessor.multySelect = true;
                            MainWindow.ActiveForm.Cursor = Cursors.Cross;
                        }

                        // задаваме начална позиция
                        diProcessor.InitialLocation = mLocation;
                        diProcessor.mCurentLocation = mLocation;
                    } break;
        }
        }

        /// <summary>
        /// При движение на мишката в областта за чертане връща координатите.
        /// </summary>
        /// <param name="mLocation"></param>
        public void MouseMove(Point mLocation)
        {
            //ако има влачене, т.е. сме селектирали обект
            switch (Event)
            {                
                case "DrawLineShape-go":
                    {
                        ((LineShape)itemPointer).SetBegin = (Point)sDots.ToArray()[0];
                        ((LineShape)itemPointer).SetEnd = mLocation;
                    } break;

                case "DrawCurveShape-go":
                    {
                        sDots.Add(mLocation);
                        if(itemPointer!=null)
                        ((CurveShape)itemPointer).pointsList =new ArrayList( sDots);
                       
                    } break;

                case "DrawClosedCurveShape-go":
                    {
                        sDots.Add(mLocation);
                        if (itemPointer != null)
                            ((ClosedCurveShape)itemPointer).pointsList = new ArrayList(sDots);

                    } break;

                case "DrawSquareShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((RectangleShape)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y)); 
                    }break;

                case "DrawRectangleShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((RectangleShape)itemPointer).SetLocation  = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));
                    
                    } break;

                case "DrawEllipseShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((EllipseShape)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));

                    } break;

                case "DrawCircleShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((CircleShape)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));
                    }break;

                case "DrawEllipseLineIntersectionShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((EllipseLineIntersectionShape)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));
                    } break;

                case "DrawConnectedEllipse-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mLocation;
                        ((ConnectedEllipses)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));
                    } break;

                case "DrawPolygonShape-go":
                    {
                        ((LineShape)diProcessor.controlPolygon[diProcessor.controlPolygon.Count - 1]).SetEnd = mLocation;
                    } break;

                case "DrawBezierShape-go":
                    {
                        ((LineShape)diProcessor.controlPolygon[diProcessor.controlPolygon.Count - 1]).SetEnd = mLocation;
                    } break;

                case "DrawTriangleShape-go":
                    {
                        ((LineShape)diProcessor.controlPolygon[diProcessor.controlPolygon.Count - 1]).SetEnd = mLocation;
                    } break;
               
                default:
                    {
                        if (diProcessor.IsDraging)
                        {
                            //указваме действие
                            switch (this.Event)
                            {
                                case "TranslateElementTo":
                                    //транслация
                                    diProcessor.TranslateElementTo(mLocation);
                                    diProcessor.InitialLocation = mLocation;
                                    break;
                                case "Scale":
                                    //скалиране
                                    diProcessor.Scale(mLocation, diProcessor.selectionUnitIndex);
                                    diProcessor.InitialLocation = mLocation;
                                    break;
                                case "RotateAt":
                                    //ротация
                                    diProcessor.RotateAt(mLocation, new Point());
                                    diProcessor.InitialLocation = mLocation;
                                    break;
                            }
                        }
                        else
                        {
                            if (diProcessor.multySelect)
                            {
                                diProcessor.mCurentLocation = mLocation;
                                MainWindow.ActiveForm.Cursor = Cursors.Cross;
                            }
                        }
                    } break;
            }
        }

        public void MouseUp(Point mlocation)
        {
            switch (Event)
            {                
                case "DrawPointShape-go":
                    {
                        Point initial = (Point)sDots.ToArray()[0];
                        Point current = mlocation;
                        ((PointShape)itemPointer).SetLocation = new RectangleF(Math.Min(initial.X, current.X) - 1, Math.Min(initial.Y, current.Y) - 1, Math.Max(initial.X, current.X) - Math.Min(initial.X, current.X), Math.Max(initial.Y, current.Y) - Math.Min(initial.Y, current.Y));
                        Event = "";
                        itemPointer = null;
                    }break;

                case "DrawLineShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawCurveShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawClosedCurveShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawSquareShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    }break;

                case "DrawRectangleShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawEllipseShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawCircleShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    }break;

                case "DrawEllipseLineIntersectionShape-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawConnectedEllipses-go":
                    {
                        Event = "";
                        itemPointer = null;
                    } break;

                case "DrawPolygonShape-go":
                    {
                        if (sDots.Count == 4)
                        {
                            diProcessor.ObjectsDrawn.Add(new PolygonShape(sDots));
                            Event = "";
                            diProcessor.controlPolygon.Clear();
                        }
                       
                        itemPointer = null;
                    } break;

                case "DrawBezierShape-go":
                    {
                        if (sDots.Count == 4)
                        {
                            itemPointer = new BezierCurveShape();
                            ((BezierCurveShape)itemPointer).pointOne = (Point)sDots.ToArray()[0];
                            ((BezierCurveShape)itemPointer).pointTwo = (Point)sDots.ToArray()[1];
                            ((BezierCurveShape)itemPointer).pointTree = (Point)sDots.ToArray()[2];
                            ((BezierCurveShape)itemPointer).pointFour = (Point)sDots.ToArray()[3];
                            diProcessor.ObjectsDrawn.Add(itemPointer);
                            itemPointer = null;
                            Event = "";
                            diProcessor.controlPolygon.Clear();
                        }

                        itemPointer = null;
                    } break;

                case "DrawTriangleShape-go":
                    {
                        if (sDots.Count == 3)
                        {
                            diProcessor.ObjectsDrawn.Add(new PolygonShape(sDots));
                            Event = "";
                            diProcessor.controlPolygon.Clear();
                        }

                        itemPointer = null;
                    } break;

                default:
                    {
                        if (diProcessor.IsDraging)
                        {
                            diProcessor.IsDraging = false;
                            diProcessor.InitialLocation = mlocation;
                            MainWindow.ActiveForm.Cursor = System.Windows.Forms.Cursors.Default;
                        }
                        else
                        {
                            if (diProcessor.multySelect)
                            {
                                diProcessor.HandleMultySelecting();
                                MainWindow.ActiveForm.Cursor = System.Windows.Forms.Cursors.Default;
                                diProcessor.multySelect = false;

                            }
                        }
                    } break;
            }
        }

        /// <summary>
        /// Извиква методът GroupElements от класа Dialogprocessor, за да групира начертаните елементи в един.
        /// </summary>
        public void GroupElements()
        {
            diProcessor.GroupSelectedElements();
        }

        /// <summary>
        /// Извиква методът UnGroup от класа Dialogprocessor, за да разгрупира групирани елементи.
        /// </summary>
        public void UnGroup()
        {
            diProcessor.UnGroup();
        }

        /// <summary>
        /// Извиква методът SaveInFile от класа Dialogprocessor, за да запише данните във файл с разширение различно от .vg.
        /// </summary>
        public void SaveAs()
        {
            diProcessor.SaveInFile();
        }

        /// <summary>
        /// Извиква методът Save от класа Dialogprocessor, за да запише данните във файл с разширение .vg.
        /// </summary>
        public void Save()
        {
            diProcessor.Save();
        }

        /// <summary>
        /// Извиква методът OpenFile от класа Dialogprocessor, за да отвори файл.
        /// </summary>
        public void OpenFile()
        {
            diProcessor.OpenFile();
        }        

        /// <summary>
        /// Извиква методът NewProject от класа Dialogprocessor, за да създаде нов проект.
        /// </summary>
        public void NewProject()
        {
            diProcessor.NewProject();
        }

        /// <summary>
        /// Извиква методът SelectItem  от класа Dialogprocessor.
        /// </summary>
        public void SelectItem()
        {
            diProcessor.SelectItem();
        }

        //public void SetDrawAction(String actionIdent)
        //{
        //    switch (actionIdent)
        //    { 
        //        default:break; 
        //    }
        //}

        /// <summary>
        /// Извиква методът DeleteSelected от класа Dialogprocessor, за да изтрие избраните елементи.
        /// </summary>
        public void DeleteSelected()
        {
            diProcessor.DeleteSelected();
        }

        /// <summary>
        /// Извиква методът CutSelected от класа Dialogprocessor, за да изреже избраните елементи.
        /// </summary>
        public void CutSelected()
        {
            diProcessor.CutSelected();
        }

        /// <summary>
        /// Извиква методът CopySelected от класа Dialogprocessor, за да копира избраните елементи.
        /// </summary>
        public void CopySelected()
        {
            diProcessor.CopySelected();
        }

        /// <summary>
        /// Извиква методът PasteSelected от класа Dialogprocessor, за да постави копираните елементи.
        /// </summary>
        public void PasteSelected()
        {
            diProcessor.PasteSelected();
        }

        public void RotateFigure(float angle)
        {
            diProcessor.Rotate(angle);
        }

        /// <summary>
        /// Извиква методът ChangeFillColor от класа Dialogprocessor, за да промени цвета на запълване на избраният лемент. 
        /// </summary>
        public void ChangeFillColor()
        {
            diProcessor.ChangeFillColor();
        }

        /// <summary>
        /// Извиква методът ChangeBorderColor от класа Dialogprocessor, за да промени цвета на контура на избраният лемент. 
        /// </summary>
        public void ChangeBorderColor()
        {
            diProcessor.ChangeBorderColor();
        }

        /// <summary>
        /// Задава име на селектираната фигура.
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            if (diProcessor.SelectedItem != null)
            {
                diProcessor.SelectedItem.Name = name;
            }
        }
    }
}
