using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    internal class FigureSaveLoad
    {
        List<MyFigure> figures;
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        private int i;

        public FigureSaveLoad(List <MyFigure> figures) 
        {
            this.figures = figures;
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
        }
        public void FigureSave()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter sw = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    //пройтися по всьому списку figures
                    sw.Write(figures.Count);
                    foreach (var figure in figures)
                    {
                        string line = "";

                        //визначити фігуру
                        switch (figure)
                        {
                            case Rctngl rctngl:
                                line = "Rctngl";
                                break;
                            case Romb romb:
                                line = "Romb";
                                break;
                            case Trapeze trapeze:
                                line = "Trapeze";
                                break;
                            case RectTriangle rectTriangle:
                                line = "RectTriangle";
                                break;
                            case EquilTriangle equilTriangle:
                                line = "EquilTriangle";
                                break;
                            case CommonTriangle commonTriangle:
                                line = "CommonTriangle";
                                break;
                            case Ellipse ellipse:
                                line = "Ellipse";
                                break;
                            case Cube cube:
                                line = "Cube";
                                break;
                            case Paralelogram paralelogram:
                                line = "Paralelogram";
                                break;
                        }
                        //записати в файл
                        sw.Write(line);
                        sw.Write(figure.location.X);
                        sw.Write(figure.location.Y);
                        sw.Write(figure.color.ToArgb());
                        sw.Write(figure.size.Width);
                        sw.Write(figure.size.Height);
                        

                    }
                }
            }
        }
        public void FigureLoad()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader sr = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                {
                    figures.Clear();
                    int count = sr.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        string line = sr.ReadString();
                        MyFigure figure = null;
                        switch (line)
                        {
                            case "Rctngl":
                                figure = new Rctngl();
                                break;
                            case "Romb":
                                figure = new Romb();
                                break;
                            case "Trapeze":
                                figure = new Trapeze();
                                break;
                            case "RectTriangle":
                                figure = new RectTriangle();
                                break;
                            case "EquilTriangle":
                                figure = new EquilTriangle();
                                break;
                            case "CommonTriangle":
                                figure = new CommonTriangle();
                                break;
                            case "Ellipse":
                                figure = new Ellipse();
                                break;
                            case "Cube":
                                figure = new Cube();
                                break;
                            case "Paralelogram":
                                figure = new Paralelogram();
                                break;
                            default:
                                // Пропускаємо невідомий тип або викидаємо виняток
                                throw new InvalidDataException($"Невідомий тип фігури: {line}");
                                // Або просто пропустити:
                                // continue;
                        }

                        if (figure != null) // Перевіряємо, чи фігура створена
                        {
                            figure.location.X = sr.ReadInt32();
                            figure.location.Y = sr.ReadInt32();
                            figure.color = Color.FromArgb(sr.ReadInt32());
                            figure.size.Width = sr.ReadInt32();
                            figure.size.Height = sr.ReadInt32();
                            figures.Add(figure);
                        }
                    }
                }
            }
        }
    }
}




