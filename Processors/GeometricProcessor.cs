using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

/*
 * @autor Владислав Найденов   
 * Класът GeometricProcessor за работа с изчертаните обекти,
 * за изчертаване на различни примитиви, за указване на  елемент.
 */
namespace _2D_Vector_Graphics
{
   
    class GeometricProcessor : DisplayProcessor
    {
      
        public GeometricProcessor()
        {

        }
 
        // дали в момента се извършва влачене на елемент
        private bool isDraging;
        public bool IsDraging
        {
            get { return isDraging; }
            set { isDraging = value; }
        }
        /*
         * полето message съдържа някакъв текст , който да се принтира
         * използва се понеже нямам достъп до контролите на формата
         * **/
        public string message;
        /*
       * initialLocation
       * Указва началните координати на влачен или  уголемяван/умаляван обект
       * **/
        private PointF initialLocation;
        public PointF InitialLocation
        {
            get { return initialLocation; }
            set { initialLocation = value; }
        }
        /*
         * ActionT е поле съдържащо действието, което се изпълнява върху указания обект
         * **/
        public String ActionT = "TranslateElementTo";
 
        /*
        * транслация на елемент
        * използва полето начална позиция
        * не зависи от класа на елемента (за сега :D)
        * 
        * **/
        public virtual void TranslateElementTo(PointF point)
        {
            this.SelectedItem.TMatrix.Translate(point.X - initialLocation.X, point.Y - initialLocation.Y);
            
        }

        /*
         * selectionUnitIndex е поле, което указва кое квадратче от описващия четириъгълник
         * е избрано -
         *          0 горен ляв ъгъл
         *          1 горен централно
         *          2 горен десен ъгъл
         *          3 дясна страна център
         *          4 долен десен ъгъл
         *          5 долу център
         *          6 долен ляв ъгъл
         *          7 ляво център
         *          
         *          8 ротация
         *          
         *          -2 не е кликнато в зоната на селектора
    
         * **/
        public int selectionUnitIndex = -2;
       
        /*
         * Scale(param1,param2)
         * функцията се използва за уголемяване/умаляване НЕ ВРЪЩА РЕЗУЛТАТ!!!
         * параметър 1: кординатите на мишката 
         * параметър 2: типа на склаирането
         *          0 горен ляв ъгъл
         *          1 горен централно
         *          2 горен десен ъгъл
         *          3 дясна страна център
         *          4 долен десен ъгъл
         *          5 долу център
         *          6 долен ляв ъгъл
         *          7 ляво център
         * 
         * **/
        public virtual void Scale(PointF point, int type)
        {
            RectangleF initialBounds = (SelectedItem.ReturnBounds());
            MatchType(point, type, initialBounds, this.SelectedItem, this.initialLocation);
        }

        /*              КАК РАБОТИ СКАЛИРАНЕТО!!!
         *           този коментар е обхваща функционалността на 3 функции
         *              1)MatchType
         *              2)ScaleItem
         *              3)TranslateScaledItem
         *           
            * Написаното тук е валидно за всички 7 случая (коментара де не кода)!
         * 1)
            * Първо проверяваме дали (ширината на обекта - разтоянието) е положително число.
            * Правим същото и за височината.
            * Сравнявам с 2 понеже всичките ми координати са float (с цел мащабиране*),
            * ако се вземе по малка стойност има опасност в даден случай да получиме
            * initialBounds.Width/(X - initialBounds.Width),
            * където initialBounds.Width е число >0 а (X - initialBounds.Width) да клони към 0
            * или x/n при n клонящо към 0 - демек неопределеност.
         * 2)
            * След това се изчисляват Х и Y , които всъщност указват изменеието на размера 
            * спрямо текущия размер.
            * Правим си матрица и записваме Х и Y,скалираме е и след това е умноваваме по
            * матрицата на трансформация на обекта.
         * 3)
            * Приравняваме получената матрица на матрицата на трансформация на обекта.
            * Накрая изчисляваме координатите, на които да транслираме обекта-
            *  това го правиме за да не се мести фигурата при склаирането.
            *  има 7 случая - по 1 за всяко квадратче от указващия четириъгъллник.
            * **/

        /*
         * По подадения тип на скалиране определя дали е възможно чрез серия от проверки 
         * и ако е извиква метода Action, който всъщност извиква методите за скалиране и транслиране.
         * Направено е с толкоз много методи, не за кеф, а понеже при следващия клас, който наследява този 
         * и добая скалиране на групи се предифинра само 1 малък метод, а не се пренаписва сичко
         * **/
        protected virtual void MatchType(PointF point, int type, RectangleF initialBounds ,Shape item,PointF iniLocation)
        {
                float X ,Y;
                //изчисляваме разтоянието м/у началната позиция и текущата
                X = point.X - iniLocation.X;
                Y = point.Y - iniLocation.Y;
                bool flag=false;
               // спрямо бутона(случая) определяме вида на скалирането
                switch (type)
                {
              
                        
                    case 0:
                        {
                            if (((initialBounds.Width - X) > 2) && ((initialBounds.Height - Y) > 2))
                            {
                                flag = true;
                            }
                        }; break;
                 
                    case 1:
                        {
                            if (((initialBounds.Width + X) > 2) && ((initialBounds.Height -Y) > 2))
                            {
                                flag = true;
                            }
                        }; break;
                    case 2:
                        {
                            if ( ((initialBounds.Height - Y) > 2))
                            {
                                flag = true;
                            }
                        }; break;
                    case 3:
                        {

                            if ((initialBounds.Width + X) > 2)
                            {
                                flag = true;
                            }

                        } break;
                    case 4:
                        {

                            if (((initialBounds.Width + X) > 2) && (initialBounds.Height+ Y) > 2)
                            {
                                flag = true;
                            }
                        
                        } break;
                    case 5:
                        {
                            if (((initialBounds.Width - X) > 2) && ((initialBounds.Height + Y) > 2))
                            {
                                flag = true;
                            }
                        }; break;
                    case 6:
                        {
                            if ((initialBounds.Height + Y) > 2)
                            {
                                flag = true;
                            }
                        } break;
           
                    case 7:
                        {
                            if (((initialBounds.Width - X) > 2))
                            {
                                flag = true;
                            }
                        }; break;
                }
                if (flag == true)
                {
                    this.Action(point, type, initialBounds, item, iniLocation);
                }    
            //слага в полето с колко е скалиран обекта по ширина и височина
                message = "Оразмеряване: " + "X: " + X + "%; Y: " + Y + "%;";
                return;     
        }
        /*функцията се извиква от MatchType и извиква ScaleItem и TranslateScaledItem*/
        protected virtual void Action(PointF point, int type, RectangleF initialBounds, Shape item, PointF iniLocation)
        {
            this.ScaleItem(point, type, initialBounds, item, iniLocation);
            this.TranslateScaledItem(type, initialBounds, item.ReturnBounds(), item);//tuka 6te imam qdove
        }
       /*склаиране на елемент*/
        protected virtual void ScaleItem(PointF point, int type, RectangleF initialBounds, Shape item, PointF iniLocation)
        {
            // взема границите на фигурата

            Matrix tempMatrix = new Matrix();
            float X, Y;
            X = point.X - iniLocation.X;
            Y = point.Y - iniLocation.Y;
            // спрямо бутона(случая) определяме вида на скалирането
            switch (type)
            {
                case 0:
                    {
                            X = initialBounds.Width / (X + initialBounds.Width);
                            Y = initialBounds.Height / (Y + initialBounds.Height);      
                    }; break;

                case 1:
                    {
                            X = (X + initialBounds.Width) / initialBounds.Width;
                            Y = initialBounds.Height / (Y + initialBounds.Height);
                    }; break;
                case 2:
                    {
                            X = 1;
                            Y = initialBounds.Height / (Y + initialBounds.Height);
                    }; break;
                case 3:
                    {
                            X = (initialBounds.Width + X) / (initialBounds.Size.Width);
                            Y = 1;
                    } break;
                case 4:
                    {
                            X = (initialBounds.Width + X) / (initialBounds.Size.Width);
                            Y = (initialBounds.Height + Y) / (initialBounds.Size.Height);
                    } break;
                case 5:
                    {
                            X = initialBounds.Width / (X + initialBounds.Width);
                            Y = (Y + initialBounds.Height) / initialBounds.Height;
                    }; break;
                case 6:
                    {
                            X = 1;
                            Y = (initialBounds.Height + Y) / (initialBounds.Size.Height);
                    } break;

                case 7:
                    {
                            X = initialBounds.Width / (X + initialBounds.Width);
                            Y = 1;                                       
                    }; break;
            }        
            item.TMatrix.Scale(X, Y);
            //слага в полето с колко е скалиран обекта по ширина и височина
            message = "Оразмеряване: " + "X: " + X + "%; Y: " + Y + "%;";
            return;
        }
        /*транслиране на скалиран елемент*/
        protected virtual void TranslateScaledItem(int type, RectangleF initialBounds, RectangleF curBounds, Shape item)
        {
            //има само 4 различни вида другите са им производни
            float tY=1, tX=1;      
                                    
            if ( type == 7)
            {
                type = 0;
            }
            if ( type == 2)
            {
                type = 1;
            }
            if ( type == 4 || type == 6)
            {
                type = 3;
            }
            switch (type)
            {
                case 0:
                    {
                            tX = (initialBounds.X + initialBounds.Width) - (curBounds.X + curBounds.Width);
                            tY = (initialBounds.Y + initialBounds.Height) - (curBounds.Y + curBounds.Height); 
                    }; break;

                case 1:
                    {
                            tX = initialBounds.X - curBounds.X;
                            tY = (initialBounds.Y + initialBounds.Height) - (curBounds.Y + curBounds.Height);                 
                    }; break;
              
                case 3:
                    {
                            tX = (initialBounds.Location.X - curBounds.Location.X);
                            tY = (initialBounds.Location.Y - curBounds.Location.Y);
                    } break;
             
                case 5:
                    {
                            tX = (initialBounds.X + initialBounds.Width) - (curBounds.X + curBounds.Width);
                            tY = initialBounds.Y - curBounds.Y;
                    }; break;   
            }

            item.TMatrix.Translate(tX, tY); 
        }
        
        /*
         * функцията извършва ротация на фигура
         * като използва кооординатите на мишката
         * 
         * **/

        virtual public void RotateAt(PointF mLocation, PointF center)
        {
            Rotate(mLocation, CalculateCenter());
        }
       
        virtual protected void Rotate(PointF mLocation, PointF center)
        {
         //променлива за ъгъла дефаулт 0
           float angle = 0;

            //изчисляваме ъгъла спрямо текущата позиция на мишката
           float curAngle = CalculateRotationAngle(mLocation, new PointF(mLocation.X, center.Y), center);
            //изчисляваме ъгъла спрямо предишната позиция на мишката
           float prevAngle = CalculateRotationAngle(new PointF(initialLocation.X, initialLocation.Y), new PointF(mLocation.X, center.Y), center);
            /*
             * Спрямо големината на ъглите и позицията на мишката определяме дали ротираме 
             * по часовниковата стрелка или обратно
             * предишния ъгъл се използва за да определяме ориентацията на ротация
             * **/
           if ((prevAngle >= 0) && (curAngle >= 0))
           {    //за лявата секция на фигурата
               if (center.X > mLocation.X)
               {    // определя ориентацията на ротация
                   if (center.Y > mLocation.Y) 
                   { 
                     angle = curAngle - prevAngle;
                   }
                   else
                   {
                     angle = prevAngle - curAngle;
                   }
                }//дясната секция на фигурата
               else
               {    // определя ориентацията на ротация
                   if (center.Y > mLocation.Y)
                   {
                     angle = prevAngle - curAngle;
                   }
                   else
                   {    
                     angle = curAngle - prevAngle; 
                   }
               }
           }
            // самата ротация 
           this.SelectedItem.TMatrix.Rotate(angle, center);
           this.message ="Ъгъл на завъртане : " + angle + " градуса";
        }
      
        /*
         * CalculateCenter
         * Изчислява центъра на фигурата
         * Това е точката на пресичане на диагоналите на описания правоъгълник
         * **/
        public PointF CalculateCenter()
        {
            // описания правоъгълник има float координати и за това ги претипизираме във int
            RectangleF itemBounds = SelectedItem.ReturnBounds();
            // Изчислява центъра на фигурата и връщаме точката
            return  new Point((int)(itemBounds.X + itemBounds.Width / 2), (int)(itemBounds.Y + itemBounds.Height / 2));
        }
        /*
         * CalculateRotationAngle(Point pointA, Point pointB)
         * 
         * Изчислява ъгълът м/у отсечките (center,pointA) и (center,pointB)
         * **/
        private float CalculateRotationAngle(PointF pointA, PointF pointB,PointF center)
      {
          /*
           * тъй като няма тип вектор(в геометричен смисъл) или аз не знам за него
           * в тип PointF запазвам векторите, които получавам от 2-те отсечки
           * 
           * **/
          PointF vecA, vecB;
          double cosAB;
          /*
           * Вектор vecA - с начало центъра на фигурата и направление pointA
           * Вектор vecB - с начало центъра на фигурата и направление pointB
           * 
           * Координатите на вектора се получават като от координатите на втората точка се извадят координатите 
           * на първата
           * **/
          vecA = new Point((int)Math.Pow(pointA.X - center.X, 1), (int)Math.Pow(pointA.Y - center.Y, 1));
          vecB = new Point((int)Math.Pow(pointB.X - center.X, 1), (int)Math.Pow(pointB.Y - center.Y, 1));
          /*
           * Скаларното произведение на двата вектора,разделено на дължините на векторите
           * дава косинуса между векторите
           * 0 =< cosAB =< П
           * **/
          cosAB = (vecA.X * vecB.X + vecA.Y * vecB.Y) / (Math.Sqrt(vecA.X * vecA.X + vecA.Y * vecA.Y) * Math.Sqrt(vecB.X * vecB.X + vecB.Y * vecB.Y));
          /*
           * След като знаем косиуса на ъгъла чрез обратната му функция (аркускосинус) получаваме и ъгъла
           * обаче ъгъла е в радиани и за това го трансформираме в градуси
           * **/
          return (float)(Math.Acos(cosAB) * 180 / Math.PI); 
      }
    }
}
