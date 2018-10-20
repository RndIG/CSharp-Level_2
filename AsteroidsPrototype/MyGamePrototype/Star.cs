using System;
using System.Drawing;

namespace MyGamePrototype
{
    /// <summary>
    /// Клас описывающий объект "звезда"
    /// </summary>
    class Star : BaseObject
    {
        int speed { get; set; }


        /// <summary>
        /// Тип звезды, на данный момент их три : 1, 2 и 3.
        /// </summary>
        int starType { get; set; }


        /// <summary>
        /// Путь к файлу изображения для звезды.
        /// </summary>
        string TypeImageFile { get; set; }


        /// <summary>
        /// Звезда
        /// </summary>
        /// <param name="pos">Координаты появления</param>
        /// <param name="speed">Скорость передвижения справа налево</param>
        public Star(Point pos,int speed) : base(pos)
        {
            TypeImageFile = "TypeIF_Base.bmp";
            this.speed = speed;
        }

        /// <summary>
        /// Звезда
        /// </summary>
        /// <param name="pos">Координаты появления</param>
        /// <param name="speed">Скорость передвижения справа налево</param>
        /// <param name="starType">Тип звезды</param>
        public Star(Point pos, int speed,int starType) : base(pos)
        {
            this.speed = speed;
            this.starType = starType;            
        }


        /// <summary>
        /// НЕ РАБОТАЕТ!!!
        /// </summary>
        /// <returns></returns>
        public static Star Create()
        {
            Random rnd = new Random();
            Point pos=new Point(0,0);
            int speed;
            pos.X = rnd.Next(0, Game.Width);
            pos.Y = rnd.Next(0, Game.Height);
            speed = rnd.Next(1, 9);
            Star result = new Star(pos, speed);
            return result;
        }

        /// <summary>
        /// Возвращает объект "Звезда" с заданными параметрами
        /// </summary>
        /// <param name="X">Коородинаты появления</param>
        /// <param name="Y">Коородинаты появления</param>
        /// <param name="speed">Скорость движения</param>
        /// <param name="starType">Тип звезды</param>
        /// <returns></returns>
        public static Star Create(int X, int Y, int speed , int starType)
        {            
            Point pos = new Point(0, 0);            
            pos.X = X;
            pos.Y = Y;
            Star result = new Star(pos, speed,starType);
            return result;
        }

        public override void Draw()        
        {
            switch (starType)
            {
                case 1: TypeImageFile = "TypeIF_1.bmp"; break;
                case 2: TypeImageFile = "TypeIF_2.bmp"; break;
                case 3: TypeImageFile = "TypeIF_3.bmp"; break;
                default: TypeImageFile = "TypeIF_Base.bmp"; break;

            }            
            Image TypeImage = new Bitmap(TypeImageFile);
            Game.Buffer.Graphics.DrawImage(TypeImage, Pos);            
        }

        public override void Update()
        {
            Pos.X = Pos.X - speed;
            if (Pos.X < 0) Pos.X = Scenery.Width;
            else if (Pos.X > Scenery.Width) Pos.X = 0;
        }
    }
}
