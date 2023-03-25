using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        float lineThickness { get; set; }
        float dotSize { get; set; }
        bool periodsClicked { get; set; } = false;
        bool curlyLineClicked { get; set; } = false;
        bool brokenLineClicked { get; set; } = false;
        bool basersLineClicked { get; set; } = false;
        bool ShadedLineClicked { get; set; } = false;
        bool moveClicked { get; set; } = false;
        bool bDrag { get; set; } = false;
        int speed { get; set; } = 5;
        int poinIndex { get; set; } = 0;
        Color dotColor;
        Color lineColor;
        Pen penForPeriods;
        Pen penForLines;
        Brush Brush;
        Graphics G;
        List<MyPoint> listOfPoints;
        Point[] points;
        Timer moveTimer;
        Point draggedPont;
        List<Button> buttons;

        public class MyPoint
        {
            public bool XInvert { get; set; }
            public bool YInvert { get; set; }
            public Point Pos { get; set; }

            public void Move(int speed)
            {
                int x, y;

                if (XInvert)
                    x = Pos.X + speed * -1;
                else
                    x = Pos.X + speed;

                if (YInvert)
                    y = Pos.Y + speed * -1;
                else
                    y = Pos.Y + speed;

                Pos = new Point(x, y);
            }
        }

        public Form1()
        {
            InitializeComponent();
            Brush = Brushes.Black;
            lineThickness = 1;
            dotSize = 2;
            dotColor = Color.Black;
            lineColor = Color.Black;
            penForPeriods = new Pen(dotColor, dotSize);
            penForLines = new Pen(lineColor, lineThickness);
            listOfPoints = new List<MyPoint>();
            Paint += Form1_Paint;
            moveTimer = new Timer();
            moveTimer.Interval = 30;
            moveTimer.Tick += MoveTimer_Tick;
            KeyDown += Form1_KeyDown;
            DoubleBuffered = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                // верх
                if (this.Height - 70 <= listOfPoints[i].Pos.Y)
                    listOfPoints[i].YInvert = true;
                //право
                if (this.Width - 40 <= listOfPoints[i].Pos.X)
                    listOfPoints[i].XInvert = true;
                //низ
                if (listOfPoints[i].Pos.Y <= 0)
                    listOfPoints[i].YInvert = false;
                // лево
                if (listOfPoints[i].Pos.X <= 150)
                    listOfPoints[i].XInvert = false;

                listOfPoints[i].Move(speed);
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            G = e.Graphics;

            foreach (var item in listOfPoints)
            {
                G.DrawEllipse(penForPeriods, new RectangleF(item.Pos.X - dotSize, item.Pos.Y - dotSize, dotSize, dotSize));
            }

            if (curlyLineClicked)
                DrawCurlyLine();

            if (brokenLineClicked)
                DrawBrokneLine();

            if (basersLineClicked)
                DrawBasers();

            if (ShadedLineClicked)
                DrawShadeFigure();
        }

        private void DrawCurlyLine()
        {
            FillArray();
            if (points?.Length > 2)
                G.DrawClosedCurve(penForLines, points);
        }
        private void DrawBrokneLine()
        {
            FillArray();
            if (points?.Length > 1)
                G.DrawPolygon(penForLines, points);
        }
        private void DrawBasers()
        {
            FillArray();
            if (points?.Length == 4 || (points?.Length - 4) % 3 == 0)
                G.DrawBeziers(penForLines, points);
        }
        private void DrawShadeFigure()
        {
            FillArray();
            if (points?.Length > 2)
                G.FillClosedCurve(Brush, points);
        }

        private void FillArray()
        {
            if (listOfPoints.Count == 0)
                return;

            points = new Point[listOfPoints.Count];
            for (int i = 0; i < points.Length; i++)
                points[i] = listOfPoints[i].Pos;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyPreview = true;

            switch (keyData)
            {
                case Keys.Space:
                    moveClicked = !moveClicked;
                    if (moveClicked)
                        moveTimer.Start();
                    else
                        moveTimer.Stop();
                    return true;

                case Keys.Oemplus:
                    speed++;
                    return true;

                case Keys.OemMinus:
                    speed -= 1;
                    if (speed < 0)
                        speed = 0;
                    return true;

                case Keys.Left:
                    for (int i = 0; i < listOfPoints.Count; i++)
                        listOfPoints[i].Pos = new Point(listOfPoints[i].Pos.X - speed, listOfPoints[i].Pos.Y);
                    Refresh();
                    return true;

                case Keys.Right:
                    for (int i = 0; i < listOfPoints.Count; i++)
                        listOfPoints[i].Pos = new Point(listOfPoints[i].Pos.X + speed, listOfPoints[i].Pos.Y);
                    Refresh();
                    return true;

                case Keys.Up:
                    for (int i = 0; i < listOfPoints.Count; i++)
                        listOfPoints[i].Pos = new Point(listOfPoints[i].Pos.X, listOfPoints[i].Pos.Y - speed);
                    Refresh();
                    return true;

                case Keys.Down:
                    for (int i = 0; i < listOfPoints.Count; i++)
                        listOfPoints[i].Pos = new Point(listOfPoints[i].Pos.X, listOfPoints[i].Pos.Y + speed);
                    Refresh();
                    return true;
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ParametersBtn_Click(object sender, EventArgs e)
        {
            Parametrs parametrs = new Parametrs();
            parametrs.ShowDialog();

            lineThickness = parametrs.LineThickness;
            dotSize = parametrs.DotSize;
            dotColor = parametrs.DotColor;
            lineColor = parametrs.LineColor;
            ChangeParemeters();
            Refresh();
        }

        private void ChangeParemeters()
        {
            penForPeriods.Color = dotColor;
            penForPeriods.Width = dotSize;
            penForLines.Color = lineColor;
            penForLines.Width = lineThickness;
        }

        private void MovementBtn_Click(object sender, EventArgs e)
        {
            moveClicked = !moveClicked;
            if (moveClicked)
                moveTimer.Start();
            else
                moveTimer.Stop();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listOfPoints.Clear();
            speed = 1;
            points = null;

            Buttons();
            foreach (var button in buttons)
            {
                button.BackColor = Color.WhiteSmoke;
            }
            periodsClicked = false;
            curlyLineClicked = false;
            brokenLineClicked = false;
            basersLineClicked = false;
            ShadedLineClicked = false;
            moveClicked = false;

            Refresh();
        }

        private void Buttons()
        {
            buttons = new List<Button>(6)
            {
                periodsBtn,
                movementBtn,
                curlyLineBtn,
                brokenLineBnt,
                basersBtn,
                ShadedLineBtn
            };
        }

        private void PeriodsBtn_Click(object sender, EventArgs e)
        {
            periodsClicked = !periodsClicked;
            ChangeColor(periodsClicked, sender);
        }

        private void CurlyLineBtn_Click(object sender, EventArgs e)
        {
            curlyLineClicked = !curlyLineClicked;
            ChangeColor(curlyLineClicked, sender);
            Refresh();
        }

        private void BrokenLineBnt_Click(object sender, EventArgs e)
        {
            brokenLineClicked = !brokenLineClicked;
            ChangeColor(brokenLineClicked, sender);
            Refresh();
        }

        private void BasersBtn_Click(object sender, EventArgs e)
        {
            basersLineClicked = !basersLineClicked;
            ChangeColor(basersLineClicked, sender);
            Refresh();
        }

        private void ShadedLineBtn_Click(object sender, EventArgs e)
        {
            ShadedLineClicked = !ShadedLineClicked;
            ChangeColor(ShadedLineClicked, sender);
            Refresh();
        }

        private void ChangeColor(bool clicked, object sender)
        {
            if (clicked)
                (sender as Button).BackColor = Color.Gray;
            else
                (sender as Button).BackColor = Color.WhiteSmoke;
        }

        private void Form1_MouseClick(object sender, EventArgs e)
        {
            if (periodsClicked)
            {
                if (e is MouseEventArgs args)
                {
                    if (args.Button == MouseButtons.Left)
                    {
                        MyPoint p = new MyPoint()
                        {
                            Pos = args.Location
                        };
                        listOfPoints.Add(p);
                        Refresh();
                    }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int threshold = 10;

            for (int i = 0; i < listOfPoints.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(e.X - listOfPoints[i].Pos.X, 2)
                    + Math.Pow(e.Y - listOfPoints[i].Pos.Y, 2));
                if (distance <= threshold)
                {
                    bDrag = true;
                    draggedPont = listOfPoints[i].Pos;
                    poinIndex = i;
                    break;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrag)
            {
                draggedPont.X = e.X;
                draggedPont.Y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (bDrag)
            {
                listOfPoints.RemoveAt(poinIndex);
                listOfPoints.Add(new MyPoint() { Pos = draggedPont });
                Refresh();
                bDrag = false;
            }
        }
    }
}
