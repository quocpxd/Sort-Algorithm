using System.Drawing;
using System.Windows.Forms;

namespace demo_sort
{
    class InsertionSort:ISort
    {
        Form1 parent;
        ListBox listCode;
        Label xLabel, posLabel;
        public InsertionSort(Form1 f1,ListBox listCode)
        {
            this.parent = f1;
            this.listCode = listCode;
        }

        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void InsertionSort(int a[], int n)");
            listCode.Items.Add("{");
            listCode.Items.Add("    int i, pos, x;");
            listCode.Items.Add("    for (i = 1; i < n; i++)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        x = a[i];");
            listCode.Items.Add("        pos = i - 1;");
            if (tang)
                listCode.Items.Add("        while ((pos >= 0) && (a[pos] > x))");
            else
                listCode.Items.Add("        while ((pos >= 0) && (a[pos] < x))");
            listCode.Items.Add("        {");
            listCode.Items.Add("            a[pos + 1] = a[pos];");
            listCode.Items.Add("            pos--;");
            listCode.Items.Add("        }");
            listCode.Items.Add("        a[pos + 1] = x;");
            listCode.Items.Add("    }");
            listCode.Items.Add("}");
        }

        private Label CreateLabel(string text, Color color)
        {
            Label label = new Label();
            label.BorderStyle = BorderStyle.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(50, 50);
            label.Text = text;
            label.BackColor = color;
            label.Font = new Font("Arial", 20, FontStyle.Bold);
            label.Visible = true;
            return label;
        }

        public void Remove_Label()
        {
            parent.Controls.Remove(xLabel);
            parent.Controls.Remove(posLabel);
        }

        private bool SelectLine(int u)
        {
            listCode.SelectedIndex = u;
            return true;
        }

        public void Start(Node[] listNode)
        {

            xLabel = CreateLabel("x: ", Color.Transparent);
            xLabel.Location = new Point(0, 120);
            parent.Controls.Add(xLabel);

            posLabel = CreateLabel("pos", Color.Gray);
            posLabel.Location = new Point(1500, 1500);
            posLabel.Size = new Size(50, 20);
            posLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            parent.Controls.Add(posLabel);

            int x;
            Node temp;
            NodeServices.SetColor(listNode[0], Color.Green);
            SelectLine(2);
            NodeServices.Sleep(NodeServices.timeSleep);

            for (int i = 1; SelectLine(3) && i < listNode.Length; i++)
            {
                NodeServices.SetColor(listNode[i], Color.Orange);
                NodeServices.Sleep(NodeServices.timeSleep);

                Point locationEmpty = new Point(listNode[i].img.Location.X, listNode[i].img.Location.Y);
                while (SelectLine(5) && listNode[i].img.Location.Y > 120)
                {
                    listNode[i].img.Location = new Point(listNode[i].img.Location.X, listNode[i].img.Location.Y - 1);
                    NodeServices.Sleep(NodeServices.delay);
                }
                NodeServices.Sleep(11);
                temp = listNode[i];

                x = i - 1;
                posLabel.Location = new Point(listNode[x].img.Location.X, listNode[x].img.Location.Y - 30);
                listCode.SelectedIndex = 6;
                NodeServices.Sleep(NodeServices.timeSleep);

                while (SelectLine(7) && x >= 0 && listNode[x].n > temp.n )
                {
                    NodeServices.Sleep(NodeServices.timeSleep);

                    Point xLocation = listNode[x].img.Location;
                    SelectLine(9);
                    while (listNode[x].img.Location.X < locationEmpty.X)
                    {
                        listNode[x].img.Location = new Point(listNode[x].img.Location.X + 1, listNode[x].img.Location.Y);
                        NodeServices.Sleep(NodeServices.delay);
                    }
                    NodeServices.Sleep(11);

                    locationEmpty = xLocation;
                    listNode[x + 1] = listNode[x];

                    SelectLine(10);
                    x--;
                    if (x >= 0)
                        posLabel.Location = new Point(listNode[x].img.Location.X, listNode[x].img.Location.Y - 30);
                    else
                        posLabel.Location = new Point(0, NodeServices.Ynode - 30);
                    NodeServices.Sleep(NodeServices.timeSleep);

                }
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(12);
                while (temp.img.Location.X != locationEmpty.X)
                    if (temp.img.Location.X > locationEmpty.X)
                    {
                        temp.img.Location = new Point(temp.img.Location.X - 1, temp.img.Location.Y);
                        NodeServices.Sleep(NodeServices.delay);
                    }
                    else
                    {
                        temp.img.Location = new Point(temp.img.Location.X + 1, temp.img.Location.Y);
                        NodeServices.Sleep(NodeServices.delay);
                    }

                while (temp.img.Location.Y != locationEmpty.Y)
                {
                    temp.img.Location = new Point(temp.img.Location.X, temp.img.Location.Y + 1);
                    NodeServices.Sleep(NodeServices.delay);
                }
                NodeServices.Sleep(11);

                listNode[x + 1] = temp;
                NodeServices.SetColor(listNode[x + 1], Color.Green);
            }
            SelectLine(14);
            NodeServices.Sleep(NodeServices.timeSleep);
        }
    }
}
