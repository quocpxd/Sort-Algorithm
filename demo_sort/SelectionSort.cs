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
    class SelectionSort:ISort
    {

        ListBox listCode;
        Form1 parent;
        Label iLabel, jLabel, xLabel;
        public SelectionSort(Form1 f1, ListBox listCode)
        {
            this.parent = f1;
            this.listCode = listCode;
        }

        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void SelectionSort(int a[], int n) ");
            listCode.Items.Add("{");
            listCode.Items.Add("    for (int i = 0; i < n; i++) ");
            listCode.Items.Add("    {");
            listCode.Items.Add("        int x = i;");
            listCode.Items.Add("        for (int j = i + 1; j < n; j++)");
            if (tang)
                listCode.Items.Add("            if (a[x] > a[j])");
            else
                listCode.Items.Add("            if (a[x] < a[j])");
            listCode.Items.Add("                x = j;");
            listCode.Items.Add("        if (x != i) ");
            listCode.Items.Add("            Swap(a[i], a[x])");
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

        public void Remove_Label()
        {
            parent.Controls.Remove(iLabel);
            parent.Controls.Remove(jLabel);
            parent.Controls.Remove(xLabel);
        }

        public void Clear_Label()
        {
            iLabel.Location = jLabel.Location = xLabel.Location = new Point(1500, 1500);
        }

        private bool SelectLine(int u)
        {
            listCode.SelectedIndex = u;
            return true;
        }
        public void Start(Node[] listNode)
        {
            iLabel = CreateLabel("i", Color.Orange);
            jLabel = CreateLabel("j", Color.Pink);
            xLabel = CreateLabel("x", Color.Blue);
            parent.Controls.Add(iLabel);
            parent.Controls.Add(jLabel);
            parent.Controls.Add(xLabel);
            Clear_Label();

            for (int i = 0; SelectLine(2) && i < listNode.Length; i++)
            {
                NodeServices.SetColor(listNode[i], Color.Orange);
                iLabel.Location = new Point(listNode[i].img.Location.X, listNode[i].img.Location.Y - 30);
                iLabel.Text = "i = " + i;
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(4);
                int x = i;
                xLabel.Location = new Point(listNode[x].img.Location.X, listNode[x].img.Location.Y + 50 + 10);
                xLabel.Text = "x = " + x;
                NodeServices.Sleep(NodeServices.timeSleep);

                for (int j = i + 1; SelectLine(5) && j < listNode.Length; j++)
                {
                    NodeServices.SetColor(listNode[j], Color.Pink);
                    jLabel.Location = new Point(listNode[j].img.Location.X, listNode[j].img.Location.Y - 30);
                    jLabel.Text = "j = " + j;
                    NodeServices.Sleep(NodeServices.timeSleep);

                    SelectLine(6);
                    NodeServices.Sleep(NodeServices.timeSleep);
                    if (listNode[x].n > listNode[j].n)
                    {
                        if (x != i)
                            NodeServices.SetColor(listNode[x], NodeServices.DefaultColor);

                        SelectLine(7);
                        x = j;
                        NodeServices.SetColor(listNode[x], Color.Blue);
                        xLabel.Location = new Point(listNode[x].img.Location.X, listNode[x].img.Location.Y + 50 + 10);
                        xLabel.Text = "x = " + x;
                        NodeServices.Sleep(NodeServices.timeSleep);
                    }
                    else
                        NodeServices.SetColor(listNode[j], NodeServices.DefaultColor);
                }
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(8);
                NodeServices.Sleep(NodeServices.timeSleep);
                if (x != i)
                {
                    SelectLine(9);
                    NodeServices.Swap(ref listNode[i], ref listNode[x]);
                    NodeServices.SetColor(listNode[x], NodeServices.DefaultColor);
                }

                NodeServices.SetColor(listNode[i], Color.Green);
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(11);
            NodeServices.Sleep(NodeServices.timeSleep);
        }

        
    }
}
