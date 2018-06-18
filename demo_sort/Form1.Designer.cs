namespace demo_sort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneldulieu = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numNodeNumber = new System.Windows.Forms.NumericUpDown();
            this.btnCreateListNode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcode = new System.Windows.Forms.Panel();
            this.listCode = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelthuattoan = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panTypeSort = new System.Windows.Forms.FlowLayoutPanel();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.radDecrease = new System.Windows.Forms.RadioButton();
            this.panListSort = new System.Windows.Forms.FlowLayoutPanel();
            this.radQuickSort = new System.Windows.Forms.RadioButton();
            this.radInsertionSort = new System.Windows.Forms.RadioButton();
            this.radSelectionSort = new System.Windows.Forms.RadioButton();
            this.radBubbleSort = new System.Windows.Forms.RadioButton();
            this.radMergeSort = new System.Windows.Forms.RadioButton();
            this.radHeapSort = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.paneldieukhien = new System.Windows.Forms.Panel();
            this.btnDebug = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trbDelayImage = new System.Windows.Forms.TrackBar();
            this.trbSpeedCode = new System.Windows.Forms.TrackBar();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labGuide = new System.Windows.Forms.Label();
            this.labSetting = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.paneldulieu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNodeNumber)).BeginInit();
            this.panelcode.SuspendLayout();
            this.panelthuattoan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panTypeSort.SuspendLayout();
            this.panListSort.SuspendLayout();
            this.paneldieukhien.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDelayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedCode)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldulieu
            // 
            this.paneldulieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldulieu.Controls.Add(this.groupBox2);
            this.paneldulieu.Controls.Add(this.groupBox1);
            this.paneldulieu.Controls.Add(this.label1);
            this.paneldulieu.Location = new System.Drawing.Point(1, 431);
            this.paneldulieu.Name = "paneldulieu";
            this.paneldulieu.Size = new System.Drawing.Size(250, 278);
            this.paneldulieu.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandom);
            this.groupBox2.Controls.Add(this.btnReadFile);
            this.groupBox2.Controls.Add(this.btnManual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo giá trị cho mảng";
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(19, 21);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(87, 27);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(78, 56);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(87, 27);
            this.btnReadFile.TabIndex = 10;
            this.btnReadFile.Text = "Đọc file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnManual
            // 
            this.btnManual.Enabled = false;
            this.btnManual.Location = new System.Drawing.Point(135, 21);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(87, 27);
            this.btnManual.TabIndex = 8;
            this.btnManual.Text = "Bằng tay";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numNodeNumber);
            this.groupBox1.Controls.Add(this.btnCreateListNode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo mảng";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(2, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số phần tử (max = 10)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numNodeNumber
            // 
            this.numNodeNumber.Location = new System.Drawing.Point(154, 17);
            this.numNodeNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNodeNumber.Name = "numNodeNumber";
            this.numNodeNumber.Size = new System.Drawing.Size(69, 22);
            this.numNodeNumber.TabIndex = 4;
            this.numNodeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateListNode
            // 
            this.btnCreateListNode.Location = new System.Drawing.Point(154, 47);
            this.btnCreateListNode.Name = "btnCreateListNode";
            this.btnCreateListNode.Size = new System.Drawing.Size(69, 23);
            this.btnCreateListNode.TabIndex = 5;
            this.btnCreateListNode.Text = "Tạo mảng";
            this.btnCreateListNode.UseVisualStyleBackColor = true;
            this.btnCreateListNode.Click += new System.EventHandler(this.btnCreateListNode_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelcode
            // 
            this.panelcode.AllowDrop = true;
            this.panelcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelcode.Controls.Add(this.listCode);
            this.panelcode.Controls.Add(this.label2);
            this.panelcode.Location = new System.Drawing.Point(257, 430);
            this.panelcode.Name = "panelcode";
            this.panelcode.Size = new System.Drawing.Size(592, 271);
            this.panelcode.TabIndex = 2;
            // 
            // listCode
            // 
            this.listCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCode.FormattingEnabled = true;
            this.listCode.ItemHeight = 16;
            this.listCode.Location = new System.Drawing.Point(6, 28);
            this.listCode.Name = "listCode";
            this.listCode.Size = new System.Drawing.Size(579, 228);
            this.listCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelthuattoan
            // 
            this.panelthuattoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelthuattoan.Controls.Add(this.groupBox3);
            this.panelthuattoan.Controls.Add(this.panListSort);
            this.panelthuattoan.Controls.Add(this.label3);
            this.panelthuattoan.Location = new System.Drawing.Point(855, 430);
            this.panelthuattoan.Name = "panelthuattoan";
            this.panelthuattoan.Size = new System.Drawing.Size(154, 271);
            this.panelthuattoan.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panTypeSort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiểu sắp xếp";
            // 
            // panTypeSort
            // 
            this.panTypeSort.Controls.Add(this.radAscending);
            this.panTypeSort.Controls.Add(this.radDecrease);
            this.panTypeSort.Location = new System.Drawing.Point(6, 19);
            this.panTypeSort.Name = "panTypeSort";
            this.panTypeSort.Size = new System.Drawing.Size(130, 49);
            this.panTypeSort.TabIndex = 3;
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Checked = true;
            this.radAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAscending.Location = new System.Drawing.Point(3, 3);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(109, 17);
            this.radAscending.TabIndex = 0;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Sắp xếp tăng dần";
            this.radAscending.UseVisualStyleBackColor = true;
            this.radAscending.CheckedChanged += new System.EventHandler(this.radAscending_CheckedChanged);
            // 
            // radDecrease
            // 
            this.radDecrease.AutoSize = true;
            this.radDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecrease.Location = new System.Drawing.Point(3, 26);
            this.radDecrease.Name = "radDecrease";
            this.radDecrease.Size = new System.Drawing.Size(110, 17);
            this.radDecrease.TabIndex = 1;
            this.radDecrease.Text = "Sắp xếp giảm dần";
            this.radDecrease.UseVisualStyleBackColor = true;
            this.radDecrease.CheckedChanged += new System.EventHandler(this.radDecrease_CheckedChanged);
            // 
            // panListSort
            // 
            this.panListSort.Controls.Add(this.radQuickSort);
            this.panListSort.Controls.Add(this.radInsertionSort);
            this.panListSort.Controls.Add(this.radSelectionSort);
            this.panListSort.Controls.Add(this.radBubbleSort);
            this.panListSort.Controls.Add(this.radMergeSort);
            this.panListSort.Controls.Add(this.radHeapSort);
            this.panListSort.Location = new System.Drawing.Point(14, 31);
            this.panListSort.Name = "panListSort";
            this.panListSort.Size = new System.Drawing.Size(130, 150);
            this.panListSort.TabIndex = 0;
            // 
            // radQuickSort
            // 
            this.radQuickSort.AutoSize = true;
            this.radQuickSort.Location = new System.Drawing.Point(3, 3);
            this.radQuickSort.Name = "radQuickSort";
            this.radQuickSort.Size = new System.Drawing.Size(75, 17);
            this.radQuickSort.TabIndex = 0;
            this.radQuickSort.Text = "Quick Sort";
            this.radQuickSort.UseVisualStyleBackColor = true;
            this.radQuickSort.CheckedChanged += new System.EventHandler(this.radQuickSort_CheckedChanged);
            // 
            // radInsertionSort
            // 
            this.radInsertionSort.AutoSize = true;
            this.radInsertionSort.Location = new System.Drawing.Point(3, 26);
            this.radInsertionSort.Name = "radInsertionSort";
            this.radInsertionSort.Size = new System.Drawing.Size(87, 17);
            this.radInsertionSort.TabIndex = 1;
            this.radInsertionSort.Text = "Insertion Sort";
            this.radInsertionSort.UseVisualStyleBackColor = true;
            this.radInsertionSort.CheckedChanged += new System.EventHandler(this.radInsertionSort_CheckedChanged);
            // 
            // radSelectionSort
            // 
            this.radSelectionSort.AutoSize = true;
            this.radSelectionSort.Location = new System.Drawing.Point(3, 49);
            this.radSelectionSort.Name = "radSelectionSort";
            this.radSelectionSort.Size = new System.Drawing.Size(91, 17);
            this.radSelectionSort.TabIndex = 2;
            this.radSelectionSort.Text = "Selection Sort";
            this.radSelectionSort.UseVisualStyleBackColor = true;
            this.radSelectionSort.CheckedChanged += new System.EventHandler(this.radSelectionSort_CheckedChanged);
            // 
            // radBubbleSort
            // 
            this.radBubbleSort.AutoSize = true;
            this.radBubbleSort.Location = new System.Drawing.Point(3, 72);
            this.radBubbleSort.Name = "radBubbleSort";
            this.radBubbleSort.Size = new System.Drawing.Size(80, 17);
            this.radBubbleSort.TabIndex = 3;
            this.radBubbleSort.Text = "Bubble Sort";
            this.radBubbleSort.UseVisualStyleBackColor = true;
            this.radBubbleSort.CheckedChanged += new System.EventHandler(this.radBubbleSort_CheckedChanged);
            // 
            // radMergeSort
            // 
            this.radMergeSort.AutoSize = true;
            this.radMergeSort.Location = new System.Drawing.Point(3, 95);
            this.radMergeSort.Name = "radMergeSort";
            this.radMergeSort.Size = new System.Drawing.Size(77, 17);
            this.radMergeSort.TabIndex = 4;
            this.radMergeSort.Text = "Merge Sort";
            this.radMergeSort.UseVisualStyleBackColor = true;
            this.radMergeSort.CheckedChanged += new System.EventHandler(this.radMergeSort_CheckedChanged);
            // 
            // radHeapSort
            // 
            this.radHeapSort.AutoSize = true;
            this.radHeapSort.Location = new System.Drawing.Point(3, 118);
            this.radHeapSort.Name = "radHeapSort";
            this.radHeapSort.Size = new System.Drawing.Size(73, 17);
            this.radHeapSort.TabIndex = 5;
            this.radHeapSort.Text = "Heap Sort";
            this.radHeapSort.UseVisualStyleBackColor = true;
            this.radHeapSort.CheckedChanged += new System.EventHandler(this.radHeapSort_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thuật toán";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneldieukhien
            // 
            this.paneldieukhien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldieukhien.Controls.Add(this.btnDebug);
            this.paneldieukhien.Controls.Add(this.groupBox4);
            this.paneldieukhien.Controls.Add(this.btnContinue);
            this.paneldieukhien.Controls.Add(this.btnStop);
            this.paneldieukhien.Controls.Add(this.btnPause);
            this.paneldieukhien.Controls.Add(this.btnSort);
            this.paneldieukhien.Controls.Add(this.label4);
            this.paneldieukhien.Location = new System.Drawing.Point(1014, 430);
            this.paneldieukhien.Name = "paneldieukhien";
            this.paneldieukhien.Size = new System.Drawing.Size(227, 271);
            this.paneldieukhien.TabIndex = 0;
            // 
            // btnDebug
            // 
            this.btnDebug.Enabled = false;
            this.btnDebug.Location = new System.Drawing.Point(19, 225);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 8;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.trbDelayImage);
            this.groupBox4.Controls.Add(this.trbSpeedCode);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 150);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tốc độ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tốc độ hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tốc độ dòng lệnh";
            // 
            // trbDelayImage
            // 
            this.trbDelayImage.LargeChange = 1;
            this.trbDelayImage.Location = new System.Drawing.Point(12, 103);
            this.trbDelayImage.Minimum = 1;
            this.trbDelayImage.Name = "trbDelayImage";
            this.trbDelayImage.Size = new System.Drawing.Size(203, 45);
            this.trbDelayImage.TabIndex = 8;
            this.trbDelayImage.Value = 5;
            // 
            // trbSpeedCode
            // 
            this.trbSpeedCode.LargeChange = 250;
            this.trbSpeedCode.Location = new System.Drawing.Point(12, 46);
            this.trbSpeedCode.Maximum = 2500;
            this.trbSpeedCode.Minimum = 250;
            this.trbSpeedCode.Name = "trbSpeedCode";
            this.trbSpeedCode.Size = new System.Drawing.Size(203, 45);
            this.trbSpeedCode.SmallChange = 250;
            this.trbSpeedCode.TabIndex = 2000;
            this.trbSpeedCode.TickFrequency = 250;
            this.trbSpeedCode.Value = 1250;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(122, 210);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "▶️";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(122, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "⏹️";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(122, 182);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "⏸️";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(19, 196);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.EnabledChanged += new System.EventHandler(this.btnSort_EnabledChanged);
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điều khiển";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGuide
            // 
            this.labGuide.AutoSize = true;
            this.labGuide.BackColor = System.Drawing.Color.Transparent;
            this.labGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGuide.Location = new System.Drawing.Point(3, 4);
            this.labGuide.MinimumSize = new System.Drawing.Size(70, 13);
            this.labGuide.Name = "labGuide";
            this.labGuide.Size = new System.Drawing.Size(82, 17);
            this.labGuide.TabIndex = 4;
            this.labGuide.Text = " Hướng dẫn";
            this.labGuide.Click += new System.EventHandler(this.labGuide_Click);
            this.labGuide.MouseLeave += new System.EventHandler(this.labGuide_MouseLeave);
            this.labGuide.MouseHover += new System.EventHandler(this.labGuide_MouseHover);
            // 
            // labSetting
            // 
            this.labSetting.AutoSize = true;
            this.labSetting.BackColor = System.Drawing.Color.Transparent;
            this.labSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSetting.Location = new System.Drawing.Point(85, 4);
            this.labSetting.MinimumSize = new System.Drawing.Size(60, 13);
            this.labSetting.Name = "labSetting";
            this.labSetting.Size = new System.Drawing.Size(60, 17);
            this.labSetting.TabIndex = 4;
            this.labSetting.Text = " Cài đặt";
            this.labSetting.Click += new System.EventHandler(this.labSetting_Click);
            this.labSetting.MouseLeave += new System.EventHandler(this.labSetting_MouseLeave);
            this.labSetting.MouseHover += new System.EventHandler(this.labSetting_MouseHover);
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.BackColor = System.Drawing.Color.Transparent;
            this.labInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(145, 4);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(138, 17);
            this.labInfo.TabIndex = 4;
            this.labInfo.Text = "Thông tin phần mềm";
            this.labInfo.Click += new System.EventHandler(this.labInfo_Click);
            this.labInfo.MouseLeave += new System.EventHandler(this.labInfo_MouseLeave);
            this.labInfo.MouseHover += new System.EventHandler(this.labInfo_MouseHover);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(1133, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(62, 25);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "00:00";
            this.labTime.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCreateListNode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 720);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labSetting);
            this.Controls.Add(this.labGuide);
            this.Controls.Add(this.paneldieukhien);
            this.Controls.Add(this.panelthuattoan);
            this.Controls.Add(this.panelcode);
            this.Controls.Add(this.paneldulieu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng các thuật toán sắp xếp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.BackColorChanged += new System.EventHandler(this.Form1_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.Form1_ForeColorChanged);
            this.paneldulieu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNodeNumber)).EndInit();
            this.panelcode.ResumeLayout(false);
            this.panelthuattoan.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panTypeSort.ResumeLayout(false);
            this.panTypeSort.PerformLayout();
            this.panListSort.ResumeLayout(false);
            this.panListSort.PerformLayout();
            this.paneldieukhien.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDelayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneldulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelthuattoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel paneldieukhien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCreateListNode;
        private System.Windows.Forms.NumericUpDown numNodeNumber;
        private System.Windows.Forms.FlowLayoutPanel panListSort;
        private System.Windows.Forms.RadioButton radInsertionSort;
        private System.Windows.Forms.RadioButton radQuickSort;
        private System.Windows.Forms.RadioButton radSelectionSort;
        private System.Windows.Forms.RadioButton radBubbleSort;
        private System.Windows.Forms.RadioButton radMergeSort;
        private System.Windows.Forms.RadioButton radHeapSort;
        private System.Windows.Forms.FlowLayoutPanel panTypeSort;
        private System.Windows.Forms.RadioButton radAscending;
        private System.Windows.Forms.RadioButton radDecrease;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trbSpeedCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trbDelayImage;
        private System.Windows.Forms.Label labGuide;
        private System.Windows.Forms.Label labSetting;
        private System.Windows.Forms.Label labInfo;
        public System.Windows.Forms.ListBox listCode;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label labTime;
    }
}

