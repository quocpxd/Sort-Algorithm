using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_sort
{
    class QuickSort:ISort
    {
        Label iLabel, jLabel, rLabel, lLabel, privotLabel;
        Random rad = new Random();
        Form parent;

        ListBox listCode;
        public QuickSort(Form1 f, ListBox listCode)
        {
            this.parent = f;
            this.listCode = listCode;
        }

        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void Quicksort(int[] a, int left, int right)");
            listCode.Items.Add("{");
            listCode.Items.Add("    if (left >= right) return;");
            listCode.Items.Add("    int i = left, j = right;");
            listCode.Items.Add("    int privot = a[(left + right) / 2];");
            listCode.Items.Add("    while (i <= j)");
            listCode.Items.Add("    {");
            if (tang)
                listCode.Items.Add("        while (a[i] < privot)                   ");
            else
                listCode.Items.Add("        while (a[i] > privot)                   ");
            listCode.Items.Add("            i++;");
            if (tang)
                listCode.Items.Add("        while (a[j] > privot)                   ");
            else
                listCode.Items.Add("        while (a[j] < privot)                   ");
            listCode.Items.Add("            j--;");
            listCode.Items.Add("        if (i <= j)");
            listCode.Items.Add("        {");
            listCode.Items.Add("            if (i < j)");
            listCode.Items.Add("                Swap(a[i], a[j]);");
            listCode.Items.Add("            i++;");
            listCode.Items.Add("            j--; ");
            listCode.Items.Add("        }");
            listCode.Items.Add("    }");
            listCode.Items.Add("    Quicksort(a, left, j);");
            listCode.Items.Add("    Quicksort(a, i, right);");
            listCode.Items.Add("}");
        }

        public QuickSort(Form form1)
        {
            parent = form1;
        }

        public void Remove_Label()
        {
            parent.Controls.Remove(iLabel);
            parent.Controls.Remove(jLabel);
            parent.Controls.Remove(rLabel);
            parent.Controls.Remove(lLabel);
            parent.Controls.Remove(privotLabel);
        }

        private void Clear_Label()
        {
            iLabel.Location = jLabel.Location = rLabel.Location = lLabel.Location = new Point(1500, 1500);

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

        public void Start(Node[] listNode)
        {
            iLabel = CreateLabel("i", Color.Orange);
            parent.Controls.Add(iLabel);

            jLabel = CreateLabel("j", Color.Pink);
            parent.Controls.Add(jLabel);

            lLabel = CreateLabel("left", Color.Gray);
            parent.Controls.Add(lLabel);

            rLabel = CreateLabel("right", Color.Peru);
            parent.Controls.Add(rLabel);

            privotLabel = CreateLabel("privot", Color.Gold);
            privotLabel.Size = new Size(100, 20);
            privotLabel.Location = new Point(0, 70);
            parent.Controls.Add(privotLabel);

            Quicksort_(listNode, 0, listNode.Length - 1);
        }

        private bool SelectLine(int u)
        {
            listCode.SelectedIndex = u;
            return true;
        }
        private void Quicksort_(Node[] input, int left, int right)
        {
            Clear_Label();
            if (left >=0 && left < input.Length)
                lLabel.Location = new Point(input[left].img.Location.X, NodeServices.Ynode + 50 + 30);
            else
            {
                if (left < 0)
                    lLabel.Location = new Point(input[0].img.Location.X - 100, NodeServices.Ynode + 50 + 30);
                else
                    lLabel.Location = new Point(input[input.Length - 1].img.Location.X + 100, NodeServices.Ynode + 50 + 30);

            }
            if (right >= 0 && right < input.Length)
                rLabel.Location = new Point(input[right].img.Location.X, NodeServices.Ynode - 50);
            else
            {
                if (right < 0)
                    rLabel.Location = new Point(input[0].img.Location.X - 100, NodeServices.Ynode + 50 + 30);
                else
                    rLabel.Location = new Point(input[input.Length - 1].img.Location.X + 100, NodeServices.Ynode + 50 + 30);
            }

            SelectLine(2);
            NodeServices.Sleep(NodeServices.timeSleep);
            if (left >= right) return;

            Color color = Color.FromArgb(rad.Next(0, 256), rad.Next(0, 256), rad.Next(0, 256));
            for (int u = left; u <= right; u++)
                input[u].img.BackColor = color;
            NodeServices.DoEvent();

            SelectLine(3);
            int i = left, j = right;
            iLabel.Location = new Point(input[i].img.Location.X, NodeServices.Ynode - 30);
            iLabel.Text = "i = " + i;
            jLabel.Location = new Point(input[j].img.Location.X, NodeServices.Ynode + 50 + 10);
            jLabel.Text = "j = " + j;

            NodeServices.SetColor(input[i], Color.Orange);
            NodeServices.SetColor(input[j], Color.Pink);
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(4);
            int privot = input[(left + right) / 2].n;
            privotLabel.Text = "privot = " + input[(left + right)/2].img.Text;
            NodeServices.DoEvent();
            NodeServices.Sleep(NodeServices.timeSleep);

            while (SelectLine(5) && i <= j)
            {
                NodeServices.Sleep(NodeServices.timeSleep);
                while (SelectLine(7) && input[i].n < privot)
                {
                    NodeServices.SetColor(input[i], color);
                    NodeServices.Sleep(NodeServices.timeSleep);

                    SelectLine(8);
                    i++;
                    iLabel.Location = new Point(input[i].img.Location.X, iLabel.Location.Y);
                    iLabel.Text = "i = " + i;
                    NodeServices.SetColor(input[i], Color.Orange);
                    NodeServices.Sleep(NodeServices.timeSleep);
                }
                NodeServices.SetColor(input[i], Color.Blue);
                NodeServices.DoEvent();
                NodeServices.Sleep(NodeServices.timeSleep);

                while (SelectLine(9) && input[j].n > privot)
                {
                    NodeServices.SetColor(input[j], color);
                    NodeServices.Sleep(NodeServices.timeSleep);
                    SelectLine(10);
                    j--;
                    jLabel.Location = new Point(input[j].img.Location.X, jLabel.Location.Y);
                    jLabel.Text = "j = " + j;
                    NodeServices.SetColor(input[j], Color.Pink);
                    NodeServices.Sleep(NodeServices.timeSleep);
                }

                NodeServices.SetColor(input[j], Color.Blue);
                NodeServices.DoEvent();
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(11);
                NodeServices.Sleep(NodeServices.timeSleep);
                if (i <= j)
                {
                    SelectLine(13);
                    NodeServices.Sleep(NodeServices.timeSleep);
                    if (i < j)
                    {
                        SelectLine(14);
                        NodeServices.Swap(ref input[i], ref input[j]);
                    }
                    NodeServices.SetColor(input[i], color);
                    NodeServices.SetColor(input[j], color);

                    SelectLine(15);
                    i++;
                    if (i < input.Length)
                    {
                        iLabel.Location = new Point(input[i].img.Location.X, iLabel.Location.Y);
                        iLabel.Text = "i = " + i;
                        NodeServices.SetColor(input[i], Color.Orange);
                    }
                    NodeServices.Sleep(NodeServices.timeSleep);

                    SelectLine(16);
                    j--;

                    if (j >= 0)
                    {
                        jLabel.Location = new Point(input[j].img.Location.X, jLabel.Location.Y);
                        jLabel.Text = "j = " + j;
                        NodeServices.SetColor(input[j], Color.Pink);
                    }
                    NodeServices.Sleep(NodeServices.timeSleep);
                }
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            for (int u = left; u <= right; u++)
                input[u].img.BackColor = color;
            SelectLine(19);
            NodeServices.Sleep(NodeServices.timeSleep);
            Quicksort_(input, left, j);

            SelectLine(20);
            NodeServices.Sleep(NodeServices.timeSleep);
            Quicksort_(input, i, right);

            SelectLine(21);
            NodeServices.Sleep(NodeServices.timeSleep);
        }
    }
}
