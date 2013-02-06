
using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


/*
 * @autor Владислав Найденов
 * Класът StructuralProcessor предифинира методите на геометричния процесор и добавя рекурсивни
 * с цел прилагането им на групи от фигури с неопределена дълбочина.
 * Добавя и метод множествена селекция (с правоъгълник), групиране и разгрупиране.
 */

namespace _2D_Vector_Graphics
{
    class StructuralProcessor : GeometricProcessor
    {
        /*
         * true ако са селектирани няколко обекта
         */
        public bool multySelect = false;
        /*
         * използва се за изчертаване на множествената селекция (правоъгълника)
         */
        public PointF mCurentLocation = new PointF();
        /*
         * цвета на правоъгълника за множествена селекция
         */
        public Color mSelectRectangleColor = Color.Black;

        /*допълнение на гункцията за изчертаване на елементите
         * добавено е :
         * изчертаване на правоъгълника за мулти селекция
         * 
         */
        public override void HandleDrawing(PaintEventArgs arg)
        {   //извиква метода на предшественика си за да изчертае фигурите
            base.HandleDrawing(arg);
            //за изчертаване на правоъгълника за мулти селекция
            if (this.multySelect)
            {

                arg.Graphics.DrawRectangle(new Pen(Color.FromArgb(100, Color.Blue), 1), MultySelectRectangleBounds());
                arg.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.CornflowerBlue)), MultySelectRectangleBounds());
            }
        }
        /*
         * Връща границите на мулти селектиращия правоъгълник
         * 
         */
        protected Rectangle MultySelectRectangleBounds()
        {
            // тука ясно - смята му началната точка, ширина и височина 
            // напраено е така щото четириъгълника може да се праи по различни начини 
            // тва сигурно не е ясно - питай да обясна
            Point inital, curent;
            inital = new Point((int)this.InitialLocation.X, (int)this.InitialLocation.Y);
            curent = new Point((int)this.mCurentLocation.X, (int)this.mCurentLocation.Y);
            return new Rectangle(Math.Min(inital.X, curent.X)-1, Math.Min(inital.Y, curent.Y)-1, Math.Max(inital.X, curent.X) - Math.Min(inital.X, curent.X), Math.Max(inital.Y, curent.Y) - Math.Min(inital.Y, curent.Y));
        }
        /*
         * HandleMultySelecting
         * проверява дали има някакви фигури в правоъгълника за мулти селектиране
         * ако има им казва че са селектирани
         * ВАЖНО!!!
         * казва им че са селектирани а не прави никой елемент SelectedItem
         */
        public void HandleMultySelecting()
        {
            Rectangle boundries= MultySelectRectangleBounds();
            foreach (Shape item in ObjectsDrawn)
            {   //intersectWith е мн яка функция за определяне дали има общи точки м/у 2 четириъгълника
                if (item.ReturnBounds().IntersectsWith(boundries))
                {
                    // ако има казва на елемента че е селектнат
                    item.Selected = true;
                }
            }
        
        }
   
        /*
         * създава група от всички селектирани елементи
         * 
         * **/
        public void GroupSelectedElements()
        {   // създава списък 
            ArrayList selectedElements = new ArrayList();
            // обхожда всички изчертани елементи за да види кои са селектирани
            foreach (Shape item in ObjectsDrawn)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                    // добавя ги в списъка
                    selectedElements.Add(item);
                }
            }
            if (selectedElements.Count > 1)
            {
                // добавя нова група в списъка на изчертаните елементи
                // и в нея добавя списъка на селектираните елементи
                SelectedItem = new Grouping(selectedElements);
                ObjectsDrawn.Add(SelectedItem);
                // премахва селектираните елементи от списъка с изчертани елементи
                foreach (Shape itemToRemove in selectedElements)
                {
                    ObjectsDrawn.Remove(itemToRemove);
                }
            }
        }
        /*
        *Разгрупиране на селектирана групи с 1 ниво надолу
         *групата трябва да се укаже
         * **/
        public void UnGroup()
        {
            //ако елемента е указан и е група го разгрупира
            if (SelectedItem != null && SelectedItem.isGroup == true &&SelectedItem.canUnGroup==true)
            {
                Grouping temp;
                temp = (Grouping)SelectedItem;
                temp.UnGroup(ObjectsDrawn);
            }
        }
        /*
        *Разгрупиране на селектирани групи с 1 ниво надолу
         *групата/групите трябва да попадне в селектирания четириъгълник
         * **/
        public void UnGroupeSelected()
        {
            //временене списък с изчертани елементи 
            // неможе да се ползва текущия понеже му правиме промени 
            List<Shape> tempList;
            tempList = new List<Shape>(ObjectsDrawn);
            foreach (Shape item in tempList)
            {
                if (item.isGroup == true)
                {
                    Grouping temp;
                    temp = (Grouping)item;
                    temp.UnGroup(ObjectsDrawn);
                }
            }
        }
         
        /*
        *допълва метода на предшественика си с цел транслиране на групи (неопределена дълбочина)
         * **/
        public override void TranslateElementTo(PointF point)
        {
            //ако елемента не е група си ползва метода на предшественика
            if (SelectedItem.isGroup == false)
            {
                base.TranslateElementTo(point);
            }
            else
            {
                //ако елемента е група ползва рекурсивен алгоритъм за пеместване на 
                // всички съдържани елементи
                Grouping temp;
                temp = (Grouping)SelectedItem;
                foreach(Shape item in temp.GroupedElements)
                {
                    RecursiveTranslate(item, point);
                }
            }
        }

        /*
        *Рекурсивен метод за транслиране на всички елемнти на група един по един 
         * **/
        private void RecursiveTranslate(Shape element,PointF point)
        {  
            if (element.isGroup)
            {
                Grouping groupe = (Grouping)element;
                foreach (Shape item in groupe.GroupedElements)
                {
                    RecursiveTranslate(item,point);
                }
            }
            else
            {
                this.SelectedItem.TMatrix.TransformationMatrix = element.TMatrix.TransformationMatrix;
                base.TranslateElementTo(point);
                element.TMatrix.TransformationMatrix = this.SelectedItem.TMatrix.TransformationMatrix; 
            }
        
        }
        
        /*
         *Предефиниране на метода за да подържа и ротация на групи
         */
        protected override void Rotate(PointF mLocation, PointF center)
        {
            //ако елемента не е група си ползва метода на предяшественика
            if (SelectedItem.isGroup == false)
            {
                base.Rotate(mLocation, center);
            }
            else
            {   // ако е група използва рекурсивен метод за ротация на всички елемнти около 1 точка с определен ъгъл
                Grouping temp;
                temp = (Grouping)SelectedItem;
                foreach (Shape item in temp.GroupedElements)
                {
                    RecursiveRotate(item, mLocation,center);
                }
            }
        }
       /*
        * Рекурсивен метод, който натрупва ротацията върху матриците на трансформация
        * на всички поделементи на групата
        * използва центъра на групата (около него се въртят сички елементи)
        */
        private void RecursiveRotate(Shape element, PointF mLocation,PointF center)
        {
            if (element.isGroup)
            {
                Grouping groupe = (Grouping)element;
                foreach (Shape item in groupe.GroupedElements)
                {
                    RecursiveRotate(item, mLocation,center);
                }
            }
            else
            {   // същинската ротация на елемент
                // приравнявам матрицата на групата с тази на елемента защото
                // методът Rotate работи с матрицата на групата
                // и после запазвам промените в матрицата на елемента
                this.SelectedItem.TMatrix.TransformationMatrix = element.TMatrix.TransformationMatrix;
                base.Rotate(mLocation,center);
                element.TMatrix.TransformationMatrix = this.SelectedItem.TMatrix.TransformationMatrix;
            }

        }
        
        /*
         * Секция Скалиране
         * тук има 2 рекурсивни метода, защото скалирането на групи се свежда до скалиране(което се извършва спрямо
         * центъра на координатната система и след това транслиране, за да противодейства на възникналите промени.
         * Методът предефинира предщественика си с цел подържане на скалиране на групи. 
         */
        protected override void Action(PointF point, int type, RectangleF initialBounds, Shape item, PointF iniLocation)
        {
            //ако елемента не е група ползва метода на предшественика си
            if (item.isGroup != true)
            {
                base.Action(point, type, initialBounds, item, iniLocation);
            }
            else
            {
                // ако е група първо скалира всички поелемти на групата
                RecursiveScale(point, type, initialBounds, item, iniLocation);
                // след това един по един ги транслира
                RecursiveScaleTranslate(type, initialBounds, item.ReturnBounds(), item);
            }
        }
        /*
         * рекурсивното скалиране на всички елементи на подадена група
         */
        private void RecursiveScale(PointF point, int type, RectangleF initialBounds, Shape item, PointF iniLocation)
        {
            if (item.isGroup)
            {
                Grouping groupe = (Grouping)item;
                foreach (Shape item2 in groupe.GroupedElements)
                {
                    RecursiveScale(point,type, initialBounds,item2,iniLocation);
                }
            }
            else
            {
                this.SelectedItem.TMatrix.TransformationMatrix = item.TMatrix.TransformationMatrix;          
                base.ScaleItem(point, type, initialBounds, item, iniLocation);
            }

        }
        /*
         * рекурсивното транслиране на всички елементи на подадена група
         */
        private void RecursiveScaleTranslate(int type, RectangleF initialBounds, RectangleF curBounds, Shape item)
        {
            if (item.isGroup)
            {
                Grouping groupe = (Grouping)item;
                foreach (Shape element in groupe.GroupedElements)
                {
                    RecursiveScaleTranslate(type,initialBounds,curBounds,element);
                }
            }
            else
            {
                this.SelectedItem.TMatrix.TransformationMatrix = item.TMatrix.TransformationMatrix;
                base.TranslateScaledItem(type, initialBounds, curBounds, item);
            }

        }
    }
}
