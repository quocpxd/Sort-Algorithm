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
    class HeapSort:ISort
    {
        ListBox listCode;
        Form1 parent;

        Label lbLeft, lbRight, lbPos, lbIndex, lbHeapSize;
        public HeapSort(Form1 f1, ListBox listCode)
        {
            this.parent = f1;
            this.listCode = listCode;
        }

        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void HeapSort(int[] input)");
            listCode.Items.Add("{");
            listCode.Items.Add("    int heapSize = input.Length;");
            listCode.Items.Add("    for (int p = (heapSize - 1) / 2; p >= 0; p--)");
            listCode.Items.Add("        MaxHeapify(input, heapSize, p);");
            listCode.Items.Add("    for (int i = input.Length - 1; i > 0; i--)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        Swap(input[0], input[i]);");
            listCode.Items.Add("        heapSize--;");
            listCode.Items.Add("        MaxHeapify(input, heapSize, 0);");
            listCode.Items.Add("    }");
            listCode.Items.Add("}");

            listCode.Items.Add("void MaxHeapify(int[] input, int heapSize, int index)");
            listCode.Items.Add("{");
            listCode.Items.Add("    int left = (index + 1) * 2 - 1;");
            listCode.Items.Add("    int right = (index + 1) * 2;");
            listCode.Items.Add("    int pos = index;");
            listCode.Items.Add("    if (left < heapSize && input[left] > input[pos])");
            listCode.Items.Add("        pos = left;");
            listCode.Items.Add("    if (right < heapSize && input[right] > input[pos])");
            listCode.Items.Add("        pos = right;");
            listCode.Items.Add("    if (pos != index)");
            listCode.Items.Add("    {");
            listCode.Items.Add("        Swap(input[index], input[pos]);");
            listCode.Items.Add("        MaxHeapify(input, heapSize, pos);");
            listCode.Items.Add("    }");
            listCode.Items.Add("}");
        }

        private bool SelectLine(int u)
        {
            listCode.SelectedIndex = u;
            return true;
        }

        public void Start(Node[] listNode)
        {
            lbHeapSize = CreateLabel("heapSize", Color.Gray);
            lbIndex = CreateLabel("index", Color.Blue);
            lbLeft = CreateLabel("left", Color.Gold);
            lbRight = CreateLabel("right", Color.Pink);
            lbPos = CreateLabel("pos", Color.Pink);
            Add_Label();

            HeapSort_(listNode);
        }

        private void HeapSort_(Node[] input)
        {
            SelectLine(2);
            int heapSize = input.Length;
            NodeServices.Sleep(NodeServices.timeSleep);

            for (int p = (heapSize - 1) / 2; p >= 0 && SelectLine(3); p--)
            {
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(4);
                NodeServices.Sleep(NodeServices.timeSleep);
                MaxHeapify(input, heapSize, p);
                Clear_Label();
                
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(5);
            for (int i = input.Length - 1; i > 0; i--)
            {
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(7);
                NodeServices.Swap(ref input[0], ref input[i]);

                NodeServices.SetColor(input[i], Color.Green);
                NodeServices.DoEvent();

                SelectLine(8);
                heapSize--;
                NodeServices.Sleep(NodeServices.timeSleep);

                SelectLine(9);
                NodeServices.Sleep(NodeServices.timeSleep);
                MaxHeapify(input, heapSize, 0);
                Clear_Label();
            }
        }

        private void MaxHeapify(Node[] input, int heapSize, int index)
        {
            Clear_Label();
            SelectLine(12);
            lbHeapSize.Location = new Point(input[heapSize - 1].img.Location.X, input[heapSize - 1].img.Location.Y - 50);
            lbIndex.Location = new Point(input[index].img.Location.X, input[index].img.Location.Y - 50);
            NodeServices.DoEvent();
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(14);
            int left = (index + 1) * 2 - 1;
            if (left < input.Length)
            {
                lbLeft.Location = new Point(input[left].img.Location.X, input[left].img.Location.Y + 80);
                NodeServices.DoEvent();
            }
            else
            {
                lbLeft.Location = new Point(input[input.Length - 1].img.Location.X + 100, input[input.Length - 1].img.Location.Y + 80);
                NodeServices.DoEvent();
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(15);
            int right = (index + 1) * 2;
            if (right < input.Length)
            { 
                lbRight.Location = new Point(input[right].img.Location.X, input[right].img.Location.Y + 80);
                NodeServices.DoEvent();
            }
            else
            {
                lbRight.Location = new Point(lbLeft.Location.X + 100, lbLeft.Location.Y);
                NodeServices.DoEvent();
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(16);
            int pos = index;
            lbPos.Location = new Point(input[pos].img.Location.X, input[pos].img.Location.Y - 20);
            NodeServices.DoEvent();
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(17);
            NodeServices.Sleep(NodeServices.timeSleep);
            if (left < heapSize && input[left].n > input[pos].n)
            {

                SelectLine(18);
                pos = left;
                lbPos.Location = new Point(input[pos].img.Location.X, input[pos].img.Location.Y - 20);
                NodeServices.DoEvent();
                NodeServices.Sleep(NodeServices.timeSleep);
            }

            SelectLine(19);
            NodeServices.Sleep(NodeServices.timeSleep);
            if (right < heapSize && input[right].n > input[pos].n)
            {

                SelectLine(20);
                pos = right;
                lbPos.Location = new Point(input[pos].img.Location.X, input[pos].img.Location.Y - 20);
                NodeServices.DoEvent();
                NodeServices.Sleep(NodeServices.timeSleep);
            }

            SelectLine(21);
            NodeServices.Sleep(NodeServices.timeSleep);
            if (pos != index)
            {

                SelectLine(23);
                NodeServices.Swap(ref input[index], ref input[pos]);


                SelectLine(24);
                NodeServices.Sleep(NodeServices.timeSleep);
                MaxHeapify(input, heapSize, pos);
            }
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
            parent.Controls.Remove(lbLeft);
            parent.Controls.Remove(lbRight);
            parent.Controls.Remove(lbPos);
            parent.Controls.Remove(lbIndex);
            parent.Controls.Remove(lbHeapSize);
        }

        private void Add_Label()
        {
            parent.Controls.Add(lbLeft);
            parent.Controls.Add(lbRight);
            parent.Controls.Add(lbPos);
            parent.Controls.Add(lbIndex);
            parent.Controls.Add(lbHeapSize);
        }

        private void Clear_Label()
        {
            lbHeapSize.Location = lbIndex.Location = lbPos.Location = lbRight.Location = lbLeft.Location = new Point(1500, 1500);
            
        }
    }
}
