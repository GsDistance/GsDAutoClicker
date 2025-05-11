using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GsDAutoClicker.Program;

namespace GsDAutoClicker
{
    public partial class HotkeyForm : Form
    {
        public Keys SelectedHotkey = Keys.None;
        bool isRunning = false;
        public HotkeyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            if (isRunning)
            {
                button1.Text = "Stop";
                textBox1.Text = "Press a key...";
            }
            else
            {
                button1.Text = "Start";
                textBox1.Text = SelectedHotkey.ToString();
            }
        }

        private void HotkeyForm_Load(object sender, EventArgs e)
        {
            SelectedHotkey = Main.hotkey;
            textBox1.Text = SelectedHotkey.ToString();
            PRG.logString( "Hotkey selector opened." );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRG.logString( "Hotkey selector closed." );
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isRunning)
            {
                SelectedHotkey = keyData;
                textBox1.Text = SelectedHotkey.ToString();
            }
            return true;
        }
    }
}
