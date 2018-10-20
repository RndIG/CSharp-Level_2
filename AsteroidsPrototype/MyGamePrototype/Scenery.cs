using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyGamePrototype
{
    /// <summary>
    /// Класс для работы с элементами графики
    /// </summary>
    class Scenery
    {
        protected static List <Star> _objs;

        protected static BufferedGraphicsContext _context;

        public static BufferedGraphics Buffer;

        public static int Width { get; set; }
        public static int Height { get; set; }

        /// <summary>
        /// Количество движущихся объектов фона.
        /// </summary>
        static int OQ= 150;
        



        /// <summary>
        /// Метод для отрисовки в форме
        /// </summary>
        public static void Draw()
        {
            Point edge = new Point(0, 0);
            Image scene = new Bitmap("Scene.bmp");
            Buffer.Graphics.DrawImage(scene, edge);            
            foreach (BaseObject obj in _objs)
                obj.Draw();
            Buffer.Render();
        }
        /// <summary>
        /// Метод для загрузки движущихся объектов фона.
        /// </summary>
        public static void LoadObjects()
        {
            Random random = new Random();                  
            _objs = new List <Star>();
            for (int i = 0; i < OQ; i++)
            {               
                _objs.Add(  Star.Create(  random.Next(0,Width), random.Next(0, Height), random.Next(0, 9),random.Next(1,3)  )  );
            }
        }


        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Refresh()
        {
            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        public static void Update()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
        }


    }
}
