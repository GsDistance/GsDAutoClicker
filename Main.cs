using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static GsDAutoClicker.Program;
using System.Text.Json;
using System.Diagnostics;

namespace GsDAutoClicker
{
    public partial class Main : Form
    {
        static Thread clicker = new(PRG.Clicker);
        private static ManualResetEvent clickerPauseEvent = new(true);
        private static CancellationTokenSource clickerCancellationTokenSource = new();
        public static Keys hotkey = Keys.None;
        private Point? clickLocation = null;

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        public Main()
        {
            InitializeComponent();
        }

        public void Clicker()
        {
            var token = clickerCancellationTokenSource.Token;
            decimal repeats = Math.Round(numericUpDown5.Value);
            string clickType;
            if (comboBox1.InvokeRequired)
            {
                clickType = comboBox1.Invoke(new Func<string>(() => comboBox1.Text));
            }
            else
            {
                clickType = comboBox1.Text;
            }
            string clickMode;
            if (comboBox2.InvokeRequired)
            {
                clickMode = comboBox2.Invoke(new Func<string>(() => comboBox2.Text));
            }
            else
            {
                clickMode = comboBox2.Text;
            }
            Stopwatch stopwatch = new();
            bool isNotInfinite = radioButton1.Checked;

            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    break; // Exit the loop if cancellation is requested
                }

                stopwatch.Reset();
                stopwatch.Start();
                if (repeats < 1 && isNotInfinite)
                {
                    StopClicker(); // Stop the clicker if repeats is 0
                    break; // Exit the loop
                }

                clickerPauseEvent.WaitOne();

                if (clickLocation.HasValue)
                {
                    Cursor.Position = clickLocation.Value;
                }

                uint mouseDownEvent = MOUSEEVENTF_LEFTDOWN;
                uint mouseUpEvent = MOUSEEVENTF_LEFTUP;

                // Determine the click type based on comboBox1 selection
                switch (clickType)
                {
                    case "Right":
                        mouseDownEvent = MOUSEEVENTF_RIGHTDOWN;
                        mouseUpEvent = MOUSEEVENTF_RIGHTUP;
                        break;
                    case "Left":
                        mouseDownEvent = MOUSEEVENTF_LEFTDOWN;
                        mouseUpEvent = MOUSEEVENTF_LEFTUP;
                        break;
                    case "Middle":
                        mouseDownEvent = MOUSEEVENTF_MIDDLEDOWN;
                        mouseUpEvent = MOUSEEVENTF_MIDDLEUP;
                        break;
                }

                // Perform the mouse click(s) based on clickMode
                if (clickMode == "Single")
                {
                    mouse_event(mouseDownEvent | mouseUpEvent, 0, 0, 0, 0);
                }
                else if (clickMode == "Double")
                {
                    mouse_event(mouseDownEvent | mouseUpEvent, 0, 0, 0, 0);
                    mouse_event(mouseDownEvent | mouseUpEvent, 0, 0, 0, 0);
                }

                Clicks++;
                repeats--;

                Thread.Sleep((int)Math.Min(GetInterval() - stopwatch.ElapsedMilliseconds, int.MaxValue));
            }
        }

        private long GetInterval()
        {
            // Calculate interval based on numericUpDown1-4 values
            return (long)(numericUpDown1.Value * 3600000 + numericUpDown2.Value * 60000 +
                         numericUpDown3.Value * 1000 + numericUpDown4.Value);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label14.Text = "Version: " + Application.ProductVersion;
            label15.Text = "Author: " + Application.CompanyName;
            comboBox1.SelectedItem = "Left";
            comboBox2.SelectedItem = "Single";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void button1_Click(object? sender, EventArgs? e)
        {
            if (GetInterval() == 0)
            {
                if (MessageBox.Show("Setting the interval to 0 is risky, proceed with caution.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }

            button1.Enabled = false; // Disable the button to prevent multiple clicks
            button2.Enabled = true; // Enable the stop button
            clickerPauseEvent.Set(); // Resume the thread
            if (!clicker.IsAlive)
            {
                if (clicker == null || !clicker.IsAlive)
                {
                    clicker = new(Clicker);
                    clicker.Start();
                }

            }
        }

        public void StopClicker()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => button2_Click(null, null)));
            }
            else
            {
                button2_Click(null, null);
            }
            clickerPauseEvent.Reset(); // Pause the thread
            clickerCancellationTokenSource.Cancel(); // Signal the thread to exit
        }

        private void button2_Click(object? sender, EventArgs? e)
        {
            button1.Enabled = true; // Enable the button to allow starting again
            button2.Enabled = false; // Disable the stop button
            clickerPauseEvent.Reset(); // Pause the thread
            clickerCancellationTokenSource.Cancel(); // Signal the thread to exit
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var hotkeyForm = new HotkeyForm())
            {
                if (hotkeyForm.ShowDialog() == DialogResult.OK)
                {
                    hotkey = hotkeyForm.SelectedHotkey;
                    button3.Text = "Set Hotkey (" + hotkey.ToString() + ")";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO - Implement location picker before this but not yet

            //using (var locationPicker = new LocationPicker())
            //{
            //    if (locationPicker.ShowDialog() == DialogResult.OK)
            //    {
            //        clickLocation = locationPicker.SelectedLocation;
            //        textBox1.Text = clickLocation.Value.X.ToString();
            //        textBox2.Text = clickLocation.Value.Y.ToString();
            //    }
            //}
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == hotkey)
            {
                if (clickerPauseEvent.WaitOne(0))
                {
                    StopClicker(); // Stop
                }
                else
                {
                    button1_Click(null, null); // Start
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopClicker(); // Stop the clicker if it's running
            clickerCancellationTokenSource.Cancel(); // Ensure the thread exits
            string json = JsonSerializer.Serialize(config);
            File.WriteAllText("config.json", json);
            File.WriteAllText("clicks", Clicks.ToString());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = "Click count: " + Clicks;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int x))
            {
                clickLocation = new Point(x, clickLocation?.Y ?? 0);
            }
            else
            {
                clickLocation = null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int y))
            {
                clickLocation = new Point(clickLocation?.X ?? 0, y);
            }
            else
            {
                clickLocation = null;
            }
        }
    }
}
