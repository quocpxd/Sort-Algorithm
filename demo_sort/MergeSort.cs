using System;
using System.Drawing;
using System.Windows.Forms;

namespace demo_sort
{
    class MergeSort:ISort
    {
        Random rad = new Random();
        Graphics g;
        Label lowLabel, highLabel, midLabel;

        ListBox listCode;
        Form1 parent;


        public MergeSort(Form1 f1, ListBox listCode)
        {
            this.listCode = listCode;
            this.parent = f1;
        }

        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void MergeSort(int[] input, int low, int high)");
            listCode.Items.Add("{");
            listCode.Items.Add("    if (low < high)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        int mid = (low / 2) + (high / 2);");
            listCode.Items.Add("        MergeSort(input, low, mid);");
            listCode.Items.Add("        MergeSort(input, mid + 1, high);");
            listCode.Items.Add("        Merge(input, low, mid, high);");
            listCode.Items.Add("    }");
            listCode.Items.Add("}");

            listCode.Items.Add("void Merge(int[] input, int low, int middle, int high)");
            listCode.Items.Add("{");
            listCode.Items.Add("    int left = low;");
            listCode.Items.Add("    int right = middle + 1;");
            listCode.Items.Add("    int[] tmp = new int[(high - low) + 1];");
            listCode.Items.Add("    int tmpIndex = 0;");
            listCode.Items.Add("    while ((left <= middle) && (right <= high))");
            listCode.Items.Add("    {");
            if (tang)
                listCode.Items.Add("        if (input[left] < input[right])");
            else
                listCode.Items.Add("        if (input[left] > input[right])");
            listCode.Items.Add("        {");
            listCode.Items.Add("            tmp[tmpIndex] = input[left];");
            listCode.Items.Add("            left = left + 1;");
            listCode.Items.Add("        }");
            listCode.Items.Add("        else");
            listCode.Items.Add("        {");
            listCode.Items.Add("            tmp[tmpIndex] = input[right];");
            listCode.Items.Add("            right = right + 1;");
            listCode.Items.Add("        }");
            listCode.Items.Add("        tmpIndex = tmpIndex + 1;");
            listCode.Items.Add("    }");
            listCode.Items.Add("    if (left <= middle)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        while (left <= middle)");
            listCode.Items.Add("        {");
            listCode.Items.Add("            tmp[tmpIndex] = input[left];");
            listCode.Items.Add("            left = left + 1;");
            listCode.Items.Add("            tmpIndex = tmpIndex + 1;");
            listCode.Items.Add("        }");
            listCode.Items.Add("    }");
            listCode.Items.Add("    if (right <= high)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        while (right <= high)");
            listCode.Items.Add("        {");
            listCode.Items.Add("            tmp[tmpIndex] = input[right];");
            listCode.Items.Add("            right = right + 1;");
            listCode.Items.Add("            tmpIndex = tmpIndex + 1;");
            listCode.Items.Add("        }");
            listCode.Items.Add("    }");
            listCode.Items.Add("    for (int i = 0; i < tmp.Length; i++)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        input[low + i] = tmp[i];");
            listCode.Items.Add("    }");
            listCode.Items.Add("}");
        }

        private Label CreateLabel(string text, Color color)
        {
            Label label = new Label();
            label.BorderStyle = BorderStyle.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(50, 20);
            label.Text = text;
            label.BackColor = color;
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Visible = true;
            return label;
        }

        private bool SelectLine(int u)
        {
            listCode.SelectedIndex = u;
            return true;
        }

        public void Start(Node[] listNode)
        {
            g = parent.CreateGraphics();

            lowLabel = CreateLabel("low",Color.Gray);
            parent.Controls.Add(lowLabel);

            highLabel = CreateLabel("high", Color.Pink);
            parent.Controls.Add(highLabel);

            midLabel = CreateLabel("mid", Color.Gold);
            parent.Controls.Add(midLabel);


            MergeSort_(listNode, 0, listNode.Length - 1);
        }
        private void MergeSort_(Node[] input, int low, int high)
        {
            Clear_Label();
            lowLabel.Location = new Point(input[low].img.Location.X, input[low].img.Location.Y - 50);
            highLabel.Location = new Point(input[high].img.Location.X, input[high].img.Location.Y + 30 + 50);
            SelectLine(2);
            NodeServices.Sleep(NodeServices.timeSleep);
            if (low < high)
            {
                SelectLine(4);
                int middle = (low / 2) + (high / 2);
                midLabel.Location = new Point(input[middle].img.Location.X, input[middle].img.Location.Y + 30 + 50);
                NodeServices.Sleep(NodeServices.timeSleep);

                Color color1 = Color.FromArgb(rad.Next(0, 256), rad.Next(0, 256), rad.Next(0, 256));
                Color color2 = Color.FromArgb(rad.Next(0, 256), rad.Next(0, 256), rad.Next(0, 256));

                SelectLine(5);
                NodeServices.Sleep(NodeServices.timeSleep);

                Pen penclear = new Pen(Color.White, 2);

                Pen pen1 = new Pen(color1, 2);
                g.DrawLine(pen1, input[low].img.Location.X - (middle - low + 1) * 2, NodeServices.Ynode - (middle - low + 1) * 2, input[low].img.Location.X - (middle - low + 1) * 2, NodeServices.Ynode + 50 + (middle - low + 1) * 2);
                g.DrawLine(pen1, input[middle].img.Location.X + (middle - low + 1) * 2 + 50, NodeServices.Ynode - (middle - low + 1) * 2, input[middle].img.Location.X + (middle - low + 1) * 2 + 50, NodeServices.Ynode + 50 + (middle - low + 1) * 2);

                Pen pen2 = new Pen(color2, 2);
                g.DrawLine(pen2, input[middle + 1].img.Location.X - (high - (middle + 1) + 1) * 2, NodeServices.Ynode - (high - (middle + 1) + 1) * 2, input[middle + 1].img.Location.X - (high - (middle + 1) + 1) * 2, NodeServices.Ynode + 50 + (high - (middle + 1) + 1) * 2);
                g.DrawLine(pen2, input[high].img.Location.X + (high - (middle + 1) + 1) * 2 + 50, NodeServices.Ynode - (high - (middle + 1) + 1) * 2, input[high].img.Location.X + (high - (middle + 1) + 1) * 2 + 50, NodeServices.Ynode + 50 + (high - (middle + 1) + 1) * 2);

                MergeSort_(input, low, middle);

                g.DrawLine(penclear, input[low].img.Location.X - (middle - low + 1) * 2, NodeServices.Ynode - (middle - low + 1) * 2, input[low].img.Location.X - (middle - low + 1) * 2, NodeServices.Ynode + 50 + (middle - low + 1) * 2);
                g.DrawLine(penclear, input[middle].img.Location.X + (middle - low + 1) * 2 + 50, NodeServices.Ynode - (middle - low + 1) * 2, input[middle].img.Location.X + (middle - low + 1) * 2 + 50, NodeServices.Ynode + 50 + (middle - low + 1) * 2);

                SelectLine(6);
                NodeServices.Sleep(NodeServices.timeSleep);
                MergeSort_(input, middle + 1, high);
                g.DrawLine(penclear, input[middle + 1].img.Location.X - (high - (middle + 1) + 1) * 2, NodeServices.Ynode - (high - (middle + 1) + 1) * 2, input[middle + 1].img.Location.X - (high - (middle + 1) + 1) * 2, NodeServices.Ynode + 50 + (high - (middle + 1) + 1) * 2);
                g.DrawLine(penclear, input[high].img.Location.X + (high - (middle + 1) + 1) * 2 + 50, NodeServices.Ynode - (high - (middle + 1) + 1) * 2, input[high].img.Location.X + (high - (middle + 1) + 1) * 2 + 50, NodeServices.Ynode + 50 + (high - (middle + 1) + 1) * 2);

                SelectLine(7);
                lowLabel.Location = new Point(input[low].img.Location.X, input[low].img.Location.Y - 50);
                highLabel.Location = new Point(input[high].img.Location.X, input[high].img.Location.Y + 30 + 50);
                midLabel.Location = new Point(input[middle].img.Location.X, input[middle].img.Location.Y + 30 + 50);
                NodeServices.Sleep(NodeServices.timeSleep);
                Merge(input, low, middle, high);

                SelectLine(9);
                NodeServices.Sleep(NodeServices.timeSleep);

            }
        }

        private void Merge(Node[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            Node[] tmp = new Node[(high - low) + 1];
            int tmpIndex = 0;

            for (int i = left; i <= middle; i++)
            {
                int u = 0;
                while (u < 120)
                {
                    input[i].img.Location = new Point(input[i].img.Location.X, input[i].img.Location.Y - 1);
                    NodeServices.Sleep(NodeServices.delay);
                    u++;
                }
            }

            for (int i = right; i <= high; i++)
            {
                int u = 0;
                while (u < 120)
                {
                    input[i].img.Location = new Point(input[i].img.Location.X, input[i].img.Location.Y + 1);
                    NodeServices.Sleep(NodeServices.delay);
                    u++;
                }

            }

            while ((left <= middle) && (right <= high))
            {
                if (input[left].n < input[right].n)
                {
                    Move_A(input[left], (tmpIndex + low) * 100 + 50, NodeServices.Ynode);
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    Move_B(input[right], (tmpIndex + low) * 100 + 50, NodeServices.Ynode);
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    Move_A(input[left], (tmpIndex + low) * 100 + 50, NodeServices.Ynode);
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    Move_B(input[right], (tmpIndex + low) * 100 + 50, NodeServices.Ynode);
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }

        private void Move_B(Node t, int X, int Y)
        {
            int u = 0;
            while (u <= 60)
            {
                t.img.Location = new Point(t.img.Location.X, t.img.Location.Y - 1);
                NodeServices.Sleep(NodeServices.delay);
                u++;
            }
            while (t.img.Location.X != X)
            {
                if (t.img.Location.X > X)
                    t.img.Location = new Point(t.img.Location.X - 1, t.img.Location.Y);
                else
                    t.img.Location = new Point(t.img.Location.X + 1, t.img.Location.Y);
                NodeServices.Sleep(NodeServices.delay);
            }
            while (t.img.Location.Y > Y)
            {
                t.img.Location = new Point(t.img.Location.X, t.img.Location.Y - 1);
                NodeServices.Sleep(NodeServices.delay);
            }
        }

        private void Move_A(Node t, int X, int Y)
        {
            int u = 0;
            while (u <= 60)
            {
                t.img.Location = new Point(t.img.Location.X, t.img.Location.Y + 1);
                NodeServices.Sleep(NodeServices.delay);
                u++;
            }
            while (t.img.Location.X != X)
            {
                if (t.img.Location.X > X)
                    t.img.Location = new Point(t.img.Location.X - 1, t.img.Location.Y);
                else
                    t.img.Location = new Point(t.img.Location.X + 1, t.img.Location.Y);
                NodeServices.Sleep(NodeServices.delay);
            }
            while (t.img.Location.Y < NodeServices.Ynode)
            {
                t.img.Location = new Point(t.img.Location.X, t.img.Location.Y + 1);
                NodeServices.Sleep(NodeServices.delay);
            }
        }


        public void Remove_Label()
        {
            parent.Controls.Remove(highLabel);
            parent.Controls.Remove(lowLabel);
            parent.Controls.Remove(midLabel);
            g.Clear(Color.White);
        }


        private void Clear_Label()
        {
            lowLabel.Location = midLabel.Location = highLabel.Location = new Point(1500, 1500);
        }
    }
}
