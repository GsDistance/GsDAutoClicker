namespace GsDAutoClicker
{
    partial class HotkeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.Controls.Add( button1, 0, 0 );
            tableLayoutPanel1.Controls.Add( button2, 0, 1 );
            tableLayoutPanel1.Controls.Add( button3, 1, 1 );
            tableLayoutPanel1.Controls.Add( textBox1, 1, 0 );
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point( 0, 0 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.Size = new Size( 274, 148 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point( 18, 15 );
            button1.Name = "button1";
            button1.Size = new Size( 101, 43 );
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point( 31, 95 );
            button2.Name = "button2";
            button2.Size = new Size( 75, 31 );
            button2.TabIndex = 1;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point( 168, 95 );
            button3.Name = "button3";
            button3.Size = new Size( 75, 31 );
            button3.TabIndex = 2;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point( 155, 25 );
            textBox1.Name = "textBox1";
            textBox1.Size = new Size( 100, 23 );
            textBox1.TabIndex = 3;
            textBox1.Text = "N/A";
            // 
            // HotkeyForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 274, 148 );
            Controls.Add( tableLayoutPanel1 );
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HotkeyForm";
            Text = "HotkeyForm";
            Load += HotkeyForm_Load;
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}