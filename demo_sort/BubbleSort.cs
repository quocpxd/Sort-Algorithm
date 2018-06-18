using System.Drawing;
using System.Windows.Forms;

namespace demo_sort
{
    class BubbleSort:ISort
    {

        ListBox listCode;
        Form1 parent;
        Label iLabel, jLabel, j_Label;
        public BubbleSort(Form1 f1, ListBox listCode)
        {
            this.parent = f1;
            this.listCode = listCode;
        }
        public void LoadCode(bool tang)
        {
            listCode.Items.Add("void BubbleSort(int a[], int n) ");
            listCode.Items.Add("{");
            listCode.Items.Add("    for (int i = 0; i < n; i++) ");
            listCode.Items.Add("        for (int j = n-1; j > i; j--)");
            if (tang)
                listCode.Items.Add("            if(a[j - 1] > a[j]) ");
            else
                listCode.Items.Add("            if(a[j - 1] < a[j]) ");
            listCode.Items.Add("                Swap(a[j-1], a[j]);");
            listCode.Items.Add("}");
        }


        public void Remove_Label()
        {
            parent.Controls.Remove(iLabel);
            parent.Controls.Remove(jLabel);
            parent.Controls.Remove(j_Label);
        }

        private void Clear_Label()
        {
            iLabel.Location = jLabel.Location = j_Label.Location = new Point(1500, 1500);

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
            iLabel = CreateLabel("i", Color.Orange);
            jLabel = CreateLabel("j", Color.Pink);
            j_Label = CreateLabel("j-1", Color.Blue);
            parent.Controls.Add(iLabel);
            parent.Controls.Add(jLabel);
            parent.Controls.Add(j_Label);
            Clear_Label();

            for (int i = 0; SelectLine(2) && i < listNode.Length; i++)
            {
                NodeServices.SetColor(listNode[i], Color.Orange);
                iLabel.Location = new Point(listNode[i].img.Location.X, listNode[i].img.Location.Y - 30);
                iLabel.Text = "i = " + i;
                NodeServices.Sleep(NodeServices.timeSleep);

                for (int j = listNode.Length - 1; SelectLine(3) && j > i; j--)
                {
                    NodeServices.SetColor(listNode[j], Color.Pink);
                    jLabel.Location = new Point(listNode[j].img.Location.X, listNode[j].img.Location.Y - 30);
                    jLabel.Text = "j = " + j;
                    NodeServices.SetColor(listNode[j - 1], Color.Blue);
                    j_Label.Location = new Point(listNode[j - 1].img.Location.X, listNode[j - 1].img.Location.Y + 50 + 10);
                    j_Label.Text = "j-1 = " + (j - 1);
                    NodeServices.Sleep(NodeServices.timeSleep);

                    listCode.SelectedIndex = 4;
                    NodeServices.Sleep(NodeServices.timeSleep);
                    if (listNode[j].n < listNode[j - 1].n)
                    {
                        listCode.SelectedIndex = 5;
                        NodeServices.Swap(ref listNode[j], ref listNode[j - 1]);
                        NodeServices.SetColor(listNode[j], NodeServices.DefaultColor);
                    }
                    else
                    {
                        NodeServices.SetColor(listNode[j], NodeServices.DefaultColor);
                    }
                }
                NodeServices.Sleep(NodeServices.timeSleep);

                NodeServices.SetColor(listNode[i], Color.Green);
                if (i != listNode.Length - 1)
                    NodeServices.SetColor(listNode[i + 1], NodeServices.DefaultColor);
            }
            NodeServices.Sleep(NodeServices.timeSleep);

            SelectLine(6);
            NodeServices.Sleep(NodeServices.timeSleep);
        }
    }
}
