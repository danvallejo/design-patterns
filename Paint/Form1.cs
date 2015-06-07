using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShape(ShapeType.Circle);
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShape(ShapeType.Square);
        }

        private void CreateShape(ShapeType type)
        {
            var pos = PointToClient(Cursor.Position);

            shapes.Add(new Shape
            {
                Position = new Point { X = pos.X, Y = pos.Y },
                Size = new Size { Height = 50, Width = 100 },
                Type = type
            });

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                foreach (var shape in shapes)
                {
                    var color = Color.Peru;

                    foreach (var draggingShape in selectedShapes)
                    {
                        if (draggingShape == shape)
                        {
                            color = Color.PaleVioletRed;
                            break;
                        }
                    }

                    using (var pen = new Pen(color, 2))
                    {
                        switch (shape.Type)
                        {
                            case ShapeType.Circle:
                                {
                                    g.DrawEllipse(pen, shape.Position.X, shape.Position.Y, shape.Size.Width,
                                        shape.Size.Height);
                                    break;
                                }
                            case ShapeType.Square:
                                {
                                    g.DrawRectangle(pen, shape.Position.X, shape.Position.Y, shape.Size.Width,
                                        shape.Size.Height);
                                    break;
                                }
                        }
                    }
                }
            }
        }

        private List<Shape> selectedShapes = new List<Shape>();
        private Point currentPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            foreach (var shape in shapes)
            {
                var rect = new Rectangle(shape.Position, shape.Size);
                if (rect.Contains(e.Location))
                {
                    if (selectedShapes.Contains(shape))
                    {
                        selectedShapes.Remove(shape);
                        Invalidate(rect);
                        continue;
                    }
                    selectedShapes.Add(shape);
                    Invalidate(rect);
                    break;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var shape in selectedShapes)
                {
                    shape.Position = new Point(shape.Position.X + e.Location.X - +currentPoint.X, shape.Position.Y + e.Location.Y - +currentPoint.Y);

                    Invalidate();
                }
            }
            currentPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

    }
}
