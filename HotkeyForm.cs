using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsDAutoClicker
{
    public partial class HotkeyForm : Form
    {
        public Keys SelectedHotkey = Keys.None;
        public HotkeyForm()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void HotkeyForm_Load( object sender, EventArgs e )
        {
            SelectedHotkey = Main.hotkey;
            textBox1.Text = SelectedHotkey.ToString();
        }

        private void button2_Click( object sender, EventArgs e )
        {

        }

        private void button3_Click( object sender, EventArgs e )
        {
            
        }
    }
}
