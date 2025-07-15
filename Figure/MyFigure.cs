using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    abstract class MyFigure
    {
        public Point location; //x and y
        public Size size; //Height and Width
        public Color color; //Color of the figure
        public Color deSelect;
        public static Graphics device; //Device to draw the figure
        public abstract void Draw(Color clr); //Draw the figure  

        public void Show() //Show the figure
        {
            Draw(color);
        }
        public void Hide() //Hide the figure
        {
            Draw(Color.White);
        }
        public void Move(int dx, int dy = 0) //Move the figure
        {
            Hide();
            location.X += dx;
            location.Y += dy;
            Show();
        }
        public void Resize(int dHeight, int dWidth = 0) //Resize the figure
        {
            Hide();
            size.Height += dHeight;
            size.Width += dWidth;
            Show();
        }

        public bool IsInside(Point p) //Check if the point is inside the figure
        {
            return p.X >= location.X && p.X <= location.X + size.Width && p.Y >= location.Y && p.Y <= location.Y + size.Height;
        }

        public void Select() //Select the figure
        {
            this.color = Color.Red;
            Draw(Color.Red);
        }

        public abstract double Square(); //Calculate the square of the figure



    }
}
