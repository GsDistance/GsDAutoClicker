namespace GsDAutoClicker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabs = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            radioButton1 = new RadioButton();
            numericUpDown5 = new NumericUpDown();
            radioButton2 = new RadioButton();
            label7 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            label10 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tabPage3 = new TabPage();
            tabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add( tabPage1 );
            tabs.Controls.Add( tabPage2 );
            tabs.Controls.Add( tabPage3 );
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point( 0, 0 );
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size( 353, 334 );
            tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add( tableLayoutPanel8 );
            tabPage1.Controls.Add( tableLayoutPanel2 );
            tabPage1.Controls.Add( label1 );
            tabPage1.Controls.Add( tableLayoutPanel1 );
            tabPage1.Location = new Point( 4, 24 );
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding( 3 );
            tabPage1.Size = new Size( 345, 306 );
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel8.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel8.Controls.Add( button1, 0, 0 );
            tableLayoutPanel8.Controls.Add( button2, 1, 0 );
            tableLayoutPanel8.Controls.Add( button3, 0, 1 );
            tableLayoutPanel8.Location = new Point( 8, 202 );
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel8.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel8.Size = new Size( 329, 98 );
            tableLayoutPanel8.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point( 3, 3 );
            button1.Name = "button1";
            button1.Size = new Size( 158, 43 );
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Location = new Point( 167, 3 );
            button2.Name = "button2";
            button2.Size = new Size( 159, 43 );
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point( 3, 52 );
            button3.Name = "button3";
            button3.Size = new Size( 158, 43 );
            button3.TabIndex = 2;
            button3.Text = "Set Hotkey (None)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel2.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel2.Controls.Add( tableLayoutPanel4, 1, 0 );
            tableLayoutPanel2.Controls.Add( tableLayoutPanel3, 0, 0 );
            tableLayoutPanel2.Location = new Point( 8, 91 );
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel2.Size = new Size( 329, 105 );
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel4.Controls.Add( tableLayoutPanel6, 0, 1 );
            tableLayoutPanel4.Controls.Add( label7, 0, 0 );
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point( 168, 4 );
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add( new RowStyle( SizeType.Percent, 20F ) );
            tableLayoutPanel4.RowStyles.Add( new RowStyle( SizeType.Percent, 80F ) );
            tableLayoutPanel4.Size = new Size( 157, 97 );
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel6.Controls.Add( tableLayoutPanel7, 0, 0 );
            tableLayoutPanel6.Controls.Add( radioButton2, 0, 1 );
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point( 3, 22 );
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel6.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel6.Size = new Size( 151, 72 );
            tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel7.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel7.Controls.Add( radioButton1, 0, 0 );
            tableLayoutPanel7.Controls.Add( numericUpDown5, 1, 0 );
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point( 4, 4 );
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel7.Size = new Size( 143, 28 );
            tableLayoutPanel7.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point( 3, 3 );
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size( 61, 19 );
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Repeat";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Dock = DockStyle.Fill;
            numericUpDown5.Location = new Point( 74, 3 );
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size( 66, 23 );
            numericUpDown5.TabIndex = 1;
            numericUpDown5.Value = new decimal( new int[] { 1, 0, 0, 0 } );
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point( 8, 44 );
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size( 134, 19 );
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Repeat until stopped";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point( 3, 0 );
            label7.Name = "label7";
            label7.Size = new Size( 151, 19 );
            label7.TabIndex = 0;
            label7.Text = "Repeat options";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel3.Controls.Add( label6, 0, 0 );
            tableLayoutPanel3.Controls.Add( tableLayoutPanel5, 0, 1 );
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point( 4, 4 );
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Percent, 20F ) );
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Percent, 80F ) );
            tableLayoutPanel3.Size = new Size( 157, 97 );
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point( 3, 0 );
            label6.Name = "label6";
            label6.Size = new Size( 151, 19 );
            label6.TabIndex = 0;
            label6.Text = "Click options";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel5.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel5.Controls.Add( label8, 0, 0 );
            tableLayoutPanel5.Controls.Add( comboBox1, 1, 0 );
            tableLayoutPanel5.Controls.Add( comboBox2, 1, 1 );
            tableLayoutPanel5.Controls.Add( label9, 0, 1 );
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point( 3, 22 );
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel5.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel5.Size = new Size( 151, 72 );
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point( 15, 10 );
            label8.Name = "label8";
            label8.Size = new Size( 46, 15 );
            label8.TabIndex = 0;
            label8.Text = "Button:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange( new object[] { "Left", "Right", "Middle" } );
            comboBox1.Location = new Point( 79, 4 );
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size( 68, 23 );
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange( new object[] { "Single", "Double" } );
            comboBox2.Location = new Point( 79, 39 );
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size( 68, 23 );
            comboBox2.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point( 6, 46 );
            label9.Name = "label9";
            label9.Size = new Size( 63, 15 );
            label9.TabIndex = 3;
            label9.Text = "Click Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 15, 3 );
            label1.Name = "label1";
            label1.Size = new Size( 46, 15 );
            label1.TabIndex = 1;
            label1.Text = "Interval";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 25F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 25F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 25F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 25F ) );
            tableLayoutPanel1.Controls.Add( numericUpDown1, 0, 1 );
            tableLayoutPanel1.Controls.Add( numericUpDown2, 1, 1 );
            tableLayoutPanel1.Controls.Add( numericUpDown3, 2, 1 );
            tableLayoutPanel1.Controls.Add( numericUpDown4, 3, 1 );
            tableLayoutPanel1.Controls.Add( label2, 3, 0 );
            tableLayoutPanel1.Controls.Add( label3, 2, 0 );
            tableLayoutPanel1.Controls.Add( label4, 1, 0 );
            tableLayoutPanel1.Controls.Add( label5, 0, 0 );
            tableLayoutPanel1.Location = new Point( 8, 21 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.Size = new Size( 329, 64 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point( 4, 35 );
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size( 75, 23 );
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point( 86, 35 );
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size( 75, 23 );
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Dock = DockStyle.Fill;
            numericUpDown3.Location = new Point( 168, 35 );
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size( 75, 23 );
            numericUpDown3.TabIndex = 2;
            numericUpDown3.Value = new decimal( new int[] { 1, 0, 0, 0 } );
            // 
            // numericUpDown4
            // 
            numericUpDown4.Dock = DockStyle.Fill;
            numericUpDown4.Location = new Point( 250, 35 );
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size( 75, 23 );
            numericUpDown4.TabIndex = 3;
            numericUpDown4.Value = new decimal( new int[] { 100, 0, 0, 0 } );
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point( 252, 8 );
            label2.Name = "label2";
            label2.Size = new Size( 70, 15 );
            label2.TabIndex = 4;
            label2.Text = "Miliseconds";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point( 180, 8 );
            label3.Name = "label3";
            label3.Size = new Size( 51, 15 );
            label3.TabIndex = 5;
            label3.Text = "Seconds";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point( 98, 8 );
            label4.Name = "label4";
            label4.Size = new Size( 50, 15 );
            label4.TabIndex = 6;
            label4.Text = "Minutes";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point( 22, 8 );
            label5.Name = "label5";
            label5.Size = new Size( 39, 15 );
            label5.TabIndex = 7;
            label5.Text = "Hours";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add( tableLayoutPanel9 );
            tabPage2.Location = new Point( 4, 24 );
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size( 345, 306 );
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel9.Controls.Add( label10, 0, 0 );
            tableLayoutPanel9.Controls.Add( tableLayoutPanel10, 0, 1 );
            tableLayoutPanel9.Location = new Point( 8, 13 );
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add( new RowStyle( SizeType.Percent, 20F ) );
            tableLayoutPanel9.RowStyles.Add( new RowStyle( SizeType.Percent, 80F ) );
            tableLayoutPanel9.Size = new Size( 329, 73 );
            tableLayoutPanel9.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point( 4, 1 );
            label10.Name = "label10";
            label10.Size = new Size( 79, 14 );
            label10.TabIndex = 0;
            label10.Text = "Click location";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 7;
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 23.346302F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 7.78210163F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 29.18288F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.95330763F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 13.8910513F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.95330763F ) );
            tableLayoutPanel10.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 13.8910513F ) );
            tableLayoutPanel10.Controls.Add( radioButton3, 0, 0 );
            tableLayoutPanel10.Controls.Add( radioButton4, 1, 0 );
            tableLayoutPanel10.Controls.Add( button4, 2, 0 );
            tableLayoutPanel10.Controls.Add( textBox1, 4, 0 );
            tableLayoutPanel10.Controls.Add( textBox2, 6, 0 );
            tableLayoutPanel10.Controls.Add( label11, 3, 0 );
            tableLayoutPanel10.Controls.Add( label12, 5, 0 );
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point( 4, 19 );
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel10.Size = new Size( 321, 50 );
            tableLayoutPanel10.TabIndex = 1;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point( 7, 15 );
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size( 60, 19 );
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cursor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point( 79, 18 );
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size( 14, 13 );
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point( 101, 3 );
            button4.Name = "button4";
            button4.Size = new Size( 87, 44 );
            button4.TabIndex = 2;
            button4.Text = "Pick location";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point( 213, 13 );
            textBox1.Name = "textBox1";
            textBox1.Size = new Size( 38, 23 );
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point( 276, 13 );
            textBox2.Name = "textBox2";
            textBox2.Size = new Size( 41, 23 );
            textBox2.TabIndex = 4;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point( 194, 17 );
            label11.Name = "label11";
            label11.Size = new Size( 13, 15 );
            label11.TabIndex = 5;
            label11.Text = "X";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point( 257, 17 );
            label12.Name = "label12";
            label12.Size = new Size( 13, 15 );
            label12.TabIndex = 6;
            label12.Text = "Y";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point( 4, 24 );
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size( 345, 306 );
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 353, 334 );
            Controls.Add( tabs );
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowIcon = false;
            Text = "Auto Clicker";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            tabs.ResumeLayout( false );
            tabPage1.ResumeLayout( false );
            tabPage1.PerformLayout();
            tableLayoutPanel8.ResumeLayout( false );
            tableLayoutPanel2.ResumeLayout( false );
            tableLayoutPanel4.ResumeLayout( false );
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout( false );
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout( false );
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            tableLayoutPanel3.ResumeLayout( false );
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout( false );
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            tabPage2.ResumeLayout( false );
            tableLayoutPanel9.ResumeLayout( false );
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout( false );
            tableLayoutPanel10.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private TabControl tabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown numericUpDown5;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button1;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel10;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label11;
        private Label label12;
    }
}
