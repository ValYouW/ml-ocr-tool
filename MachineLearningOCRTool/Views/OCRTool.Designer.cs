namespace MachineLearningOCRTool.Views
{
    partial class OCRTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRTool));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPostMergeFilter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreMergeFilter = new System.Windows.Forms.NumericUpDown();
            this.lblSelected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeightMergeSense = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidthMergeSense = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinThershold = new System.Windows.Forms.NumericUpDown();
            this.chkShowBinarize = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResizeInterval = new System.Windows.Forms.NumericUpDown();
            this.btnResRight = new System.Windows.Forms.Button();
            this.btnResLeft = new System.Windows.Forms.Button();
            this.btnResDown = new System.Windows.Forms.Button();
            this.btnResUp = new System.Windows.Forms.Button();
            this.chkShowRows = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.txtModelParams = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExtractedBackColor = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOpenModelFile = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExportSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostMergeFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreMergeFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeightMergeSense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidthMergeSense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinThershold)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResizeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtractedBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExportSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "c:\\";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(282, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(83, 7);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(193, 20);
            this.txtFile.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFile, "Image to load and analyze.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 665);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "(Re)Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPostMergeFilter
            // 
            this.txtPostMergeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostMergeFilter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtPostMergeFilter.Location = new System.Drawing.Point(988, 215);
            this.txtPostMergeFilter.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPostMergeFilter.Name = "txtPostMergeFilter";
            this.txtPostMergeFilter.Size = new System.Drawing.Size(54, 20);
            this.txtPostMergeFilter.TabIndex = 6;
            this.txtPostMergeFilter.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Post Merge Filter Size:";
            this.toolTip1.SetToolTip(this.label1, "The size of blobs (width*height) that will get filtered\r\nafter the merge process " +
        "finished. This is used\r\nto filter some medium sized blobs that are most\r\nlikely " +
        "not letters.");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pre Merge Filter Size:";
            this.toolTip1.SetToolTip(this.label2, "The size of blobs (width*height) that will get filtered\r\nbefore the merge process" +
        " take place. This is used\r\nto filter some very small blobs.");
            // 
            // txtPreMergeFilter
            // 
            this.txtPreMergeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreMergeFilter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtPreMergeFilter.Location = new System.Drawing.Point(988, 187);
            this.txtPreMergeFilter.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPreMergeFilter.Name = "txtPreMergeFilter";
            this.txtPreMergeFilter.Size = new System.Drawing.Size(54, 20);
            this.txtPreMergeFilter.TabIndex = 8;
            this.txtPreMergeFilter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSelected.Location = new System.Drawing.Point(460, 36);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(113, 15);
            this.lblSelected.TabIndex = 10;
            this.lblSelected.Text = "0 Blobs selected";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Height Merge Sensitivity:";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtHeightMergeSense
            // 
            this.txtHeightMergeSense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeightMergeSense.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtHeightMergeSense.Location = new System.Drawing.Point(988, 133);
            this.txtHeightMergeSense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtHeightMergeSense.Name = "txtHeightMergeSense";
            this.txtHeightMergeSense.Size = new System.Drawing.Size(54, 20);
            this.txtHeightMergeSense.TabIndex = 13;
            this.txtHeightMergeSense.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Width Merge Sensitivity:";
            this.toolTip1.SetToolTip(this.label4, "See tooltip for \"Height Merge Sensitivity\"");
            // 
            // txtWidthMergeSense
            // 
            this.txtWidthMergeSense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWidthMergeSense.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtWidthMergeSense.Location = new System.Drawing.Point(988, 161);
            this.txtWidthMergeSense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtWidthMergeSense.Name = "txtWidthMergeSense";
            this.txtWidthMergeSense.Size = new System.Drawing.Size(54, 20);
            this.txtWidthMergeSense.TabIndex = 11;
            this.txtWidthMergeSense.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Binarization Thershold:";
            this.toolTip1.SetToolTip(this.label5, "The pixel intensity (between 0-255) that separates\r\nbetween the black and white i" +
        "n the binarization process.");
            // 
            // txtBinThershold
            // 
            this.txtBinThershold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinThershold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtBinThershold.Location = new System.Drawing.Point(988, 105);
            this.txtBinThershold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtBinThershold.Name = "txtBinThershold";
            this.txtBinThershold.Size = new System.Drawing.Size(54, 20);
            this.txtBinThershold.TabIndex = 15;
            this.txtBinThershold.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // chkShowBinarize
            // 
            this.chkShowBinarize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowBinarize.AutoSize = true;
            this.chkShowBinarize.Location = new System.Drawing.Point(864, 60);
            this.chkShowBinarize.Name = "chkShowBinarize";
            this.chkShowBinarize.Size = new System.Drawing.Size(131, 17);
            this.chkShowBinarize.TabIndex = 17;
            this.chkShowBinarize.Text = "Show Binarized Image";
            this.toolTip1.SetToolTip(this.chkShowBinarize, "The blob recognition is running on a binarized \r\nimage (B&W), check this to see t" +
        "he binarized image.");
            this.chkShowBinarize.UseVisualStyleBackColor = true;
            this.chkShowBinarize.CheckedChanged += new System.EventHandler(this.chkShowBinarize_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtResizeInterval);
            this.groupBox1.Controls.Add(this.btnResRight);
            this.groupBox1.Controls.Add(this.btnResLeft);
            this.groupBox1.Controls.Add(this.btnResDown);
            this.groupBox1.Controls.Add(this.btnResUp);
            this.groupBox1.Location = new System.Drawing.Point(864, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 114);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move Selected Blobs";
            this.toolTip1.SetToolTip(this.groupBox1, "Move the selected blobs.\r\nIn order to change the size of the blob hover the\r\nblob" +
        " edge and drag.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interval:";
            // 
            // txtResizeInterval
            // 
            this.txtResizeInterval.Location = new System.Drawing.Point(57, 19);
            this.txtResizeInterval.Name = "txtResizeInterval";
            this.txtResizeInterval.Size = new System.Drawing.Size(37, 20);
            this.txtResizeInterval.TabIndex = 4;
            this.txtResizeInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnResRight
            // 
            this.btnResRight.Location = new System.Drawing.Point(92, 65);
            this.btnResRight.Name = "btnResRight";
            this.btnResRight.Size = new System.Drawing.Size(31, 23);
            this.btnResRight.TabIndex = 3;
            this.btnResRight.Text = ">";
            this.btnResRight.UseVisualStyleBackColor = true;
            this.btnResRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnResLeft
            // 
            this.btnResLeft.Location = new System.Drawing.Point(34, 65);
            this.btnResLeft.Name = "btnResLeft";
            this.btnResLeft.Size = new System.Drawing.Size(31, 23);
            this.btnResLeft.TabIndex = 2;
            this.btnResLeft.Text = "<";
            this.btnResLeft.UseVisualStyleBackColor = true;
            this.btnResLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnResDown
            // 
            this.btnResDown.Location = new System.Drawing.Point(63, 84);
            this.btnResDown.Name = "btnResDown";
            this.btnResDown.Size = new System.Drawing.Size(31, 23);
            this.btnResDown.TabIndex = 1;
            this.btnResDown.Text = "v";
            this.btnResDown.UseVisualStyleBackColor = true;
            this.btnResDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnResUp
            // 
            this.btnResUp.Location = new System.Drawing.Point(63, 45);
            this.btnResUp.Name = "btnResUp";
            this.btnResUp.Size = new System.Drawing.Size(31, 23);
            this.btnResUp.TabIndex = 0;
            this.btnResUp.Text = "^";
            this.btnResUp.UseVisualStyleBackColor = true;
            this.btnResUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // chkShowRows
            // 
            this.chkShowRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowRows.AutoSize = true;
            this.chkShowRows.Checked = true;
            this.chkShowRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowRows.Location = new System.Drawing.Point(864, 83);
            this.chkShowRows.Name = "chkShowRows";
            this.chkShowRows.Size = new System.Drawing.Size(83, 17);
            this.chkShowRows.TabIndex = 20;
            this.chkShowRows.Text = "Show Rows";
            this.toolTip1.SetToolTip(this.chkShowRows, "The tool tries to automatically group the letters\r\ninto rows, which will be expor" +
        "ted together.\r\nIf you don\'t want to see those rows uncheck this checkbox.");
            this.chkShowRows.UseVisualStyleBackColor = true;
            this.chkShowRows.CheckedChanged += new System.EventHandler(this.chkShowRows_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(8, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export Blobs";
            this.toolTip1.SetToolTip(this.btnExport, resources.GetString("btnExport.ToolTip"));
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Input Image:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(45, 47);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(156, 20);
            this.txtOutput.TabIndex = 24;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(318, 36);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 27;
            this.btnPredict.Text = "Load Model";
            this.toolTip1.SetToolTip(this.btnPredict, "Loads model parameters and runs the model\r\non the current image trying to identif" +
        "y the lettes.");
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txtModelParams
            // 
            this.txtModelParams.Location = new System.Drawing.Point(83, 36);
            this.txtModelParams.Name = "txtModelParams";
            this.txtModelParams.Size = new System.Drawing.Size(193, 20);
            this.txtModelParams.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Extracted Back Color:";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // txtExtractedBackColor
            // 
            this.txtExtractedBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtractedBackColor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtExtractedBackColor.Location = new System.Drawing.Point(988, 241);
            this.txtExtractedBackColor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtExtractedBackColor.Name = "txtExtractedBackColor";
            this.txtExtractedBackColor.Size = new System.Drawing.Size(54, 20);
            this.txtExtractedBackColor.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Model Params:";
            // 
            // btnOpenModelFile
            // 
            this.btnOpenModelFile.Location = new System.Drawing.Point(282, 34);
            this.btnOpenModelFile.Name = "btnOpenModelFile";
            this.btnOpenModelFile.Size = new System.Drawing.Size(30, 23);
            this.btnOpenModelFile.TabIndex = 32;
            this.btnOpenModelFile.Text = "...";
            this.btnOpenModelFile.UseVisualStyleBackColor = true;
            this.btnOpenModelFile.Click += new System.EventHandler(this.btnOpenModelFile_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Export Size (W/H):";
            this.toolTip1.SetToolTip(this.label12, "The exported image size (the exported image is\r\nalways a square, so this is the w" +
        "idth & height).");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(863, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Hover controls for tooltips";
            // 
            // txtExportSize
            // 
            this.txtExportSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtExportSize.Location = new System.Drawing.Point(108, 22);
            this.txtExportSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtExportSize.Name = "txtExportSize";
            this.txtExportSize.Size = new System.Drawing.Size(54, 20);
            this.txtExportSize.TabIndex = 36;
            this.txtExportSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.txtExportSize);
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(864, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 117);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // OCRTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 738);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOpenModelFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExtractedBackColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModelParams);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkShowRows);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkShowBinarize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBinThershold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeightMergeSense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWidthMergeSense);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreMergeFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostMergeFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "OCRTool";
            this.Text = "OCR Helper Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostMergeFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreMergeFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeightMergeSense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidthMergeSense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinThershold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResizeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtractedBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExportSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtPostMergeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPreMergeFilter;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtHeightMergeSense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtWidthMergeSense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtBinThershold;
        private System.Windows.Forms.CheckBox chkShowBinarize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResRight;
        private System.Windows.Forms.Button btnResLeft;
        private System.Windows.Forms.Button btnResDown;
        private System.Windows.Forms.Button btnResUp;
        private System.Windows.Forms.NumericUpDown txtResizeInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShowRows;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.TextBox txtModelParams;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtExtractedBackColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOpenModelFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtExportSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}