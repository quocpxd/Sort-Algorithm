
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace demo_sort
{
    public partial class Form1 : Form
    {

        Node[] listNode;
        Node[] listNodeOld;
        TextBox[] listTextbox = null;
        Random rand = new Random();
        int SoNode = 7;
        Random rad = new Random();
        bool isSort;
        public static bool stop, cont, pause, debug, isDebug;
        Timer time;
        DateTime startTime;

        dynamic Sort = null;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            listCode.MouseWheel += listCode_MouseWheel;
            trbSpeedCode.ValueChanged += new System.EventHandler(trbSpeedCode_ValueChanged);
            trbDelayImage.ValueChanged += new System.EventHandler(trbDelayImage_ValueChanged);

            NodeServices.timeSleep = 2500 - trbSpeedCode.Value;
            NodeServices.delay = 10 - trbDelayImage.Value;

            groupBox1.ForeColor = this.ForeColor;
            groupBox2.ForeColor = groupBox1.ForeColor;
            groupBox3.ForeColor = groupBox1.ForeColor;
            groupBox4.ForeColor = groupBox1.ForeColor;

            cont = false;
            isDebug = false;
            isSort = false;
            debug = false;

            time = new Timer();
            time.Enabled = false;
            time.Interval = 1000;
            time.Tick += new EventHandler(time_Tick);

            this.Icon = new Icon(@"icon/sort.ico");
        }

        private void listCode_MouseWheel(object sender, MouseEventArgs e)
        {
            bool IsGoUp = e.Delta > 0 ? true : false;
            if (IsGoUp && listCode.Font.Size < 100 && Control.ModifierKeys == Keys.Control) 
            {
                listCode.Font = new Font(listCode.Font.Name, listCode.Font.Size + 2);
            }
            else if (listCode.Font.Size > 3 && Control.ModifierKeys == Keys.Control)
            {
                listCode.Font = new Font(listCode.Font.Name, listCode.Font.Size - 2);
            }
        }

        private void btnCreateListNode_Click(object sender, EventArgs e)
        {
            if (listNode != null)
                for (int i = 0; i < SoNode; i++)
                {
                    this.Controls.Remove(listNode[i].img);
                    this.Controls.Remove(listNode[i].index);
                }
            if (listTextbox != null)
                listTextbox = null;

            btnRandom.Enabled = true;
            btnManual.Enabled = true;
            SoNode = Int32.Parse(this.numNodeNumber.Value.ToString());
            listNode = new Node[SoNode];
            for (int i = 0; i < SoNode; i++)
            {
                Node a = NodeServices.CreateNode(0, new Point(i * 100 + 50, NodeServices.Ynode));
                a.img.Text = "";
                a.index.Text = "[" + i + "]";
                this.Controls.Add(a.img);
                this.Controls.Add(a.index);
                listNode[i] = a;
            }
            Application.DoEvents();

            btnSort.Enabled = false;
            btnPause.Enabled = false;
            btnContinue.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            listTextbox = null;
            for (int i = 0; i < SoNode; i++)
            {
                this.Controls.Remove(listNode[i].img);
                this.Controls.Remove(listNode[i].index);
                Node a = NodeServices.CreateNode(rad.Next(0,100), new Point(i * 100 + 50, NodeServices.Ynode));
                a.index.Text = "[" + i + "]";
                this.Controls.Add(a.img);
                this.Controls.Add(a.index);
                listNode[i] = a;
            }

            Application.DoEvents();
            btnSort.Enabled = true;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            listTextbox = new TextBox[SoNode];
            for (int i = 0; i < SoNode; i++)
            {
                TextBox t = new TextBox();
                t.BorderStyle = BorderStyle.None;
                t.TextAlign = HorizontalAlignment.Center;
                t.Location = new Point(0,13);
                t.Size = new Size(50, 50);
                t.BackColor = NodeServices.DefaultColor;
                t.Font = new Font("Arial", 15, FontStyle.Bold);
                t.Visible = true;

                listTextbox[i] = t;
                listNode[i].img.Controls.Add(t);
            }
            Application.DoEvents();
            btnSort.Enabled = true;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path.Equals(""))
                return;

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(path);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] listString = line.Split(' ');
                    int[] a = new int[listString.Length];

                    for (int i = 0; i < listString.Length; i++)
                        a[i] = Int32.Parse(listString[i]);

                    if (listNode != null)
                        for (int i = 0; i < SoNode; i++)
                        {
                            this.Controls.Remove(listNode[i].img);
                            this.Controls.Remove(listNode[i].index);
                        }
                    listTextbox = null;

                    SoNode = listString.Length;
                    if (SoNode > 10) SoNode = 10;
                    listNode = new Node[SoNode];

                    for (int i = 0; i < SoNode; i++)
                    {
                        Node node = NodeServices.CreateNode(a[i], new Point(i * 100 + 50, NodeServices.Ynode));
                        listNode[i] = node;
                        this.Controls.Add(node.img);
                        this.Controls.Add(node.index);
                    }

                    NodeServices.DoEvent();
                    break;
                }

            }
            catch (Exception)
            {
                string st = "Khong the doc du lieu tu file da cho";
                string caption = "Error";
                MessageBox.Show(st, caption, MessageBoxButtons.OK);
            }
            finally
            {
                sr.Close();
            }

            btnManual.Enabled = false;
            btnRandom.Enabled = false;
            btnSort.Enabled = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Start_Sort();

        }

        private void Start_Sort()
        {
            if (Sort == null)
                return;
            try
            {
                if (listTextbox != null)
                {
                    for (int i = 0; i < SoNode; i++)
                    {
                        try
                        {
                            listNode[i].n = Int32.Parse(listTextbox[i].Text);
                            listNode[i].img.Controls.Remove(listTextbox[i]);
                            listNode[i].img.Text = listNode[i].n + "";
                        }
                        catch
                        {
                            string st = "Kiem tra lai du lieu nhap vao";
                            string caption = "Error";
                            MessageBox.Show(st, caption, MessageBoxButtons.OK);
                            return;
                        }

                    }
                }
                btnPause.Enabled = true;
                pause = false;
                btnStop.Enabled = true;
                stop = false;
                btnSort.Enabled = false;
                cont = false;
                btnCreateListNode.Enabled = false;
                btnReadFile.Enabled = false;
                btnRandom.Enabled = false;
                btnManual.Enabled = false;
                panListSort.Enabled = false;
                panTypeSort.Enabled = false;

                listNodeOld = new Node[SoNode];
                for (int i = 0; i < SoNode; i++)
                {
                    listNodeOld[i] = listNode[i];
                }


                if (radDecrease.Checked)
                {
                    for (int i = 0; i < SoNode; i++)
                        listNode[i].n = -listNode[i].n;
                }

                isSort = true;
                startTime = new DateTime(2017,06,12,0,0,0);
                time.Enabled = true;

                labTime.Text = "00:00";
                labTime.Visible = true;
                Sort.Start(listNode);

                for (int i = 0; i < listNode.Length; i++)
                    listNode[i].img.BackColor = Color.Green;
                btnSort.Enabled = true;
            }
            catch (Exception)
            {
                for (int i = 0; i < SoNode; i++)
                {
                    this.Controls.Remove(listNodeOld[i].img);
                    this.Controls.Remove(listNodeOld[i].index);
                    Application.DoEvents();
                }
            }
            finally
            {
                if (Sort != null)
                    Sort.Remove_Label();
                GC.Collect();
                time.Enabled = false;
                
            }

            btnCreateListNode.Enabled = true;
            btnReadFile.Enabled = true;
            btnSort.Enabled = false;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            panListSort.Enabled = true;
            panTypeSort.Enabled = true;
            btnDebug.Enabled = false;
            isSort = false;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            startTime = startTime.AddMilliseconds(1000);
            labTime.Text = startTime.ToLongTimeString().ToString().Substring(3, 5);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
            btnCreateListNode.Enabled = true;
            btnReadFile.Enabled = true;
            btnSort.Enabled = false;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            panListSort.Enabled = true;
            panTypeSort.Enabled = true;
            listCode.SelectedIndex = -1;

            if (!cont)
                cont = true;
        }

        private void radInsertionSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new InsertionSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);
        }

        private void radQuickSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new QuickSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);
        }

        private void radSelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new SelectionSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);
        }

        private void radBubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new BubbleSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);
        }

        private void radMergeSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new MergeSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);
        }

        private void radHeapSort_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            Sort = new HeapSort(this, this.listCode);
            Sort.LoadCode(radAscending.Checked);

        }

        private void radAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (Sort != null)
            {
                listCode.Items.Clear();
                Sort.LoadCode(radAscending.Checked);
            }
        }

        private void radDecrease_CheckedChanged(object sender, EventArgs e)
        {
            listCode.Items.Clear();
            if (Sort != null)
            {
                Sort.LoadCode(radAscending.Checked);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            time.Stop();
            btnDebug.Enabled = false;
            btnContinue.Enabled = true;
            btnPause.Enabled = false;
            while (!cont)
            {
                Application.DoEvents();
            }
            cont = false;
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!isDebug)
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            time.Start();
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
            isDebug = false;
            btnDebug.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        
        private void trbSpeedCode_ValueChanged(object sender, System.EventArgs e)
        {
            NodeServices.timeSleep = 2500 - trbSpeedCode.Value;
        }

        private void labGuide_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.ShowDialog(this);
        }

        private void labGuide_MouseHover(object sender, EventArgs e)
        {
            labGuide.BackColor = Color.BlueViolet;
        }

        private void labGuide_MouseLeave(object sender, EventArgs e)
        {
            labGuide.BackColor = Color.Transparent;
        }

        private void labSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(this);
            setting.Show();
        }

        private void labSetting_MouseHover(object sender, EventArgs e)
        {
            labSetting.BackColor = Color.BlueViolet;
        }

        private void labSetting_MouseLeave(object sender, EventArgs e)
        {
            labSetting.BackColor = Color.Transparent;

        }

        private void labInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog(this);
        }

        private void labInfo_MouseHover(object sender, EventArgs e)
        {
            labInfo.BackColor = Color.BlueViolet;
        }

        private void labInfo_MouseLeave(object sender, EventArgs e)
        {
            labInfo.BackColor = Color.Transparent;
        }

        private void Form1_ForeColorChanged(object sender, EventArgs e)
        {
            groupBox1.ForeColor = this.ForeColor;
            groupBox2.ForeColor = groupBox1.ForeColor;
            groupBox3.ForeColor = groupBox1.ForeColor;
            groupBox4.ForeColor = groupBox1.ForeColor;
            numNodeNumber.ForeColor = this.ForeColor;
        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            listCode.BackColor = this.BackColor;
            foreach (Control c in groupBox1.Controls)
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = this.BackColor;
                }
            foreach (Control c in groupBox2.Controls)
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = this.BackColor;
                }
            foreach (Control c in groupBox3.Controls)
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = this.BackColor;
                }
            foreach (Control c in groupBox4.Controls)
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = this.BackColor;
                }
            foreach (Control c in paneldieukhien.Controls)
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = this.BackColor;
                }
            numNodeNumber.BackColor = this.BackColor;
        }

        private void btnSort_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSort.Enabled)
                btnDebug.Enabled = btnSort.Enabled;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            debug = false;
            isDebug = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = true;
            if (!isSort)
            {
                Start_Sort();
            }
        }

        private void trbDelayImage_ValueChanged(object sender, System.EventArgs e)
        {
            NodeServices.delay = 10 - trbDelayImage.Value;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Control t in this.Controls)
                this.Controls.Remove(t);
            this.Dispose();
            Application.Exit();
        }
    }
}
