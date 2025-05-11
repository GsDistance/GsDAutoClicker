namespace GsDAutoClicker
{
    partial class LocationPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInstruction = new Label();
            SuspendLayout();
            // 
            // labelInstruction
            // 
            labelInstruction.BackColor = Color.Transparent;
            labelInstruction.Dock = DockStyle.Fill;
            labelInstruction.Location = new Point( 0, 0 );
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size( 304, 170 );
            labelInstruction.TabIndex = 0;
            labelInstruction.Text = "Click anywhere to select location, or press escape to cancel.";
            labelInstruction.TextAlign = ContentAlignment.MiddleCenter;
            labelInstruction.MouseClick += labelInstruction_MouseClick;
            // 
            // LocationPicker
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 304, 170 );
            Controls.Add( labelInstruction );
            FormBorderStyle = FormBorderStyle.None;
            Name = "LocationPicker";
            Text = "LocationPicker";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += LocationPicker_Load;
            KeyPress += LocationPicker_KeyPress;
            ResumeLayout( false );
        }

        #endregion

        private Label labelInstruction;
    }
}