using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyGamePrototype
{
    
    class Game : Scenery
    {     
        static Game()
        {
        }
        
        public static void Init(Form form)
        {
            
            Graphics g; 
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            LoadObjects();
            Refresh();
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            
        }

        

        
    }
}
