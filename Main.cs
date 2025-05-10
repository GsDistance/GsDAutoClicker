using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace GsDAutoClicker
{
    public partial class Main : Form
    {
        static Thread clicker = new(Clicker);
        private static ManualResetEvent clickerPauseEvent = new(true);
        private Keys hotkey = Keys.None;
        private Point? clickLocation = null;

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public Main()
        {
            InitializeComponent();
        }

        public static void Clicker()
        {
            while (true)
            {
                clickerPauseEvent.WaitOne();

                if (clickLocation.HasValue)
                {
                    Cursor.Position = clickLocation.Value;
                }

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                Thread.Sleep(GetInterval());
            }
        }

        private static int GetInterval()
        {
            // Calculate interval based on numericUpDown1-4 values
            return (int)(numericUpDown1.Value * 3600000 + numericUpDown2.Value * 60000 +
                         numericUpDown3.Value * 1000 + numericUpDown4.Value);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void button1_Click(object? sender, EventArgs? e )
        {
            clickerPauseEvent.Set(); // Resume the thread
            if (!clicker.IsAlive)
            {
                clicker.Start();
            }
        }

        private void button2_Click(object? sender, EventArgs? e )
        {
            clickerPauseEvent.Reset(); // Pause the thread
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var hotkeyForm = new HotkeyForm())
            {
                if (hotkeyForm.ShowDialog() == DialogResult.OK)
                {
                    hotkey = hotkeyForm.SelectedHotkey;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var locationPicker = new LocationPicker())
            {
                if (locationPicker.ShowDialog() == DialogResult.OK)
                {
                    clickLocation = locationPicker.SelectedLocation;
                    textBox1.Text = clickLocation.Value.X.ToString();
                    textBox2.Text = clickLocation.Value.Y.ToString();
                }
            }
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if (keyData == hotkey)
            {
                if (clickerPauseEvent.WaitOne(0))
                {
                    button2_Click(null, null); // Stop
                }
                else
                {
                    button1_Click(null, null); // Start
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
