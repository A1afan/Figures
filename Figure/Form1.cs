using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    public partial class Form1 : Form
    {
        Point Location_;
        bool isMouseDown = false;
        MyFigure figure;
        MyFigure current;
        string figureType = "";
        List<MyFigure> figures;
        FigureSaveLoad figureSaveLoad;
        public Form1()
        {
            InitializeComponent();
            MyFigure.device = pictureBox1.CreateGraphics();
            Location = new Point();
            pictureBox1.BackColor = Color.White;
            figures = new List<MyFigure>();

            figureSaveLoad = new FigureSaveLoad(figures);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Location_ = e.Location;
            if (figureType != "")
            {
                isMouseDown = true;
                switch (figureType)
                {
                    case "pictureBoxRctngl":
                        figure = new Rctngl();
                        break;
                    case "pictureBoxRomb":
                        figure = new Romb();
                        break;
                    case "pictureBoxTrapeze":
                        figure = new Trapeze();
                        break;
                    case "pictureBoxRectTriangle":
                        figure = new RectTriangle();
                        break;
                    case "pictureBoxEquilTriangle":
                        figure = new EquilTriangle();
                        break;
                    case "pictureBoxCommonTriangle":
                        figure = new CommonTriangle();
                        break;
                    case "pictureBoxEllipse":
                        figure = new Ellipse();
                        break;
                    case "pictureBoxCube":
                        figure = new Cube();
                        break;
                    case "pictureBoxParalelogram":
                        figure = new Paralelogram();
                        break;

                }
                figure.location = Location_;
                figure.color = Color.Black;
                figure.size = (Size)Location_;
                this.Text = "pictureBox1_MouseDown";
            }

            current = null;
            foreach (MyFigure findFigure in figures)
            {
                if (findFigure.IsInside(Location_))
                {
                    findFigure.Select();
                    current = findFigure;
                    continue;
                }
                findFigure.color = Color.Black;
                findFigure.Show();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Text = "pictureBox1_MouseMove";
                figure.Hide();
                figure.size = new Size(e.Location.X - Location_.X, e.Location.Y - Location_.Y);
                figure.Show();

                if (figures.Count > 0)
                {
                    foreach (MyFigure f in figures)
                    {
                        f.Show();
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                isMouseDown = false;
                this.Text = "pictureBox1_MouseUp";
                figures.Add(figure);
                figureType = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            figureType = ((PictureBox)sender).Name;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Move(0, -10);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Move(0, -10);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Move(0, 10);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Move(0, 10);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Move(-10, 0);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Move(-10, 0);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }

        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Move(10, 0);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Move(10, 0);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }
        }

        private void BtnSizePlus_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Resize(10, 10);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Resize(10, 10);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }
        }

        private void BtnSizeMinus_Click(object sender, EventArgs e)
        {

            if (figures.Count > 0)
            {
                if (current != null)
                {
                    current.Resize(-10, -10);
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        figures[i].Resize(-10, -10);
                    }
                }
                foreach (MyFigure f in figures)
                {
                    f.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 0;
            if (figures.Count > 0)
            {
                if (current != null)
                {
                    MessageBox.Show("Площадь фігури: " + current.Square());
                }
                else
                {
                    for (int i = 0; i < figures.Count; i++)
                    {
                        s += figures[i].Square();

                        MessageBox.Show("Площадь усіх фігур: " + s);
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                figureSaveLoad.FigureSave();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            figureSaveLoad.FigureLoad();
            foreach (MyFigure f in figures)
            {
                f.Show();
            }
            
        }
    }
}
