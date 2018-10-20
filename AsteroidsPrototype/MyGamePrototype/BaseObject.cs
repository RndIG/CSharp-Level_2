using System;
using System.Drawing;

namespace MyGamePrototype
{
    /// <summary>
    /// Клас описывающий базовый объект
    /// </summary>
    class BaseObject
    {
        protected Point Pos;

        
        
        public BaseObject(Point pos)
        {
            Pos = pos;
        }

        public virtual void Draw()
        {
            string TypeImageFile = "TypeIF_Base.bmp";
            Image TypeImage = new Bitmap(TypeImageFile);
            Game.Buffer.Graphics.DrawImage(TypeImage, Pos);            
        }

        public virtual void Update()
        {
            Pos.X = Pos.X - 5;
            if (Pos.X < 0) Pos.X = Scenery.Width;
            else if (Pos.X > Scenery.Width) Pos.X = 0;

        }
    }
}
