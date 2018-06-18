using System;
using System.Drawing;
using System.Windows.Forms;

namespace demo_sort
{
    static class NodeServices
    {
        public static Color DefaultColor = Color.Crimson;
        public static int timeSleep = 1000;
        public static int delay = 0;
        public static int Ynode = 220;

        public static Node CreateNode(int x, Point location)
        {
            Node a = new Node();
            a.img = new Label();
            a.img.BorderStyle = BorderStyle.None;
            a.img.TextAlign = ContentAlignment.MiddleCenter;
            a.n = x;
            a.img.Location = location;
            a.img.Text = a.n.ToString();
            a.img.Size = new Size(50, 50);
            a.img.BackColor = NodeServices.DefaultColor;
            a.img.Font = new Font("Arial", 15, FontStyle.Bold);
            a.img.Visible = true;

            a.index = new Label();
            a.index.BorderStyle = BorderStyle.None;
            a.index.TextAlign = ContentAlignment.MiddleCenter;
            a.index.Location = new Point(location.X, NodeServices.Ynode + 50 + 125);
            a.index.Size = new Size(50, 50);
            a.index.BackColor = Color.Transparent;
            a.index.Font = new Font("Arial", 15, FontStyle.Bold);
            a.index.Visible = true;

            return a;
        }
        public static void SetColor(Node t, Color color)
        {
            t.img.BackColor = color;
            NodeServices.DoEvent();
        }

        #region Swap Node
        public static void Swap(ref Node t1, ref Node t2)
        {
            bool isSwap = false;

            Node t;
            if (t1.img.Location.X > t2.img.Location.X)
            {
                t = t1;
                t1 = t2;
                t2 = t;
                isSwap = true;
            }

            Point NewLocation1 = new Point(t2.img.Location.X, t2.img.Location.Y);
            Point NewLocation2 = new Point(t1.img.Location.X, t1.img.Location.Y);

            while (t1.img.Location.Y > 120)
            {
                t1.img.Location = new Point(t1.img.Location.X, t1.img.Location.Y - 1);
                t2.img.Location = new Point(t2.img.Location.X, t2.img.Location.Y + 1);

                NodeServices.Sleep(delay);
            }

            while (t1.img.Location.X != NewLocation1.X)
            {
                t1.img.Location = new Point(t1.img.Location.X + 1, t1.img.Location.Y);
                t2.img.Location = new Point(t2.img.Location.X - 1, t2.img.Location.Y);

                NodeServices.Sleep(delay);
            }


            while (t1.img.Location.Y != NewLocation1.Y)
            {
                t1.img.Location = new Point(t1.img.Location.X, t1.img.Location.Y + 1);
                t2.img.Location = new Point(t2.img.Location.X, t2.img.Location.Y - 1);

                NodeServices.Sleep(delay);
            }

            if (!isSwap)
            {
                t = t1;
                t1 = t2;
                t2 = t;
            }
            while (Form1.debug && Form1.isDebug)
            {
                DoEvent();
            }
            Form1.debug = true;
        }
        #endregion

        public static void DoEvent()
        {
            Application.DoEvents();
            if (Form1.stop)
                throw new ArgumentOutOfRangeException();
        }

        public static void Sleep(int time)
        {
            DoEvent();
            if (time == 0) return;
            if (time > 10)
            {
                DateTime time1 = DateTime.Now;
                while ((DateTime.Now - time1).TotalMilliseconds < time || (Form1.debug && Form1.isDebug))
                {
                    DoEvent();
                }
            }
            else
            {
                int u = time * 2000;
                while (u-- > 0) { DoEvent(); }
            }
            Form1.debug = true;
        }
    }
}
