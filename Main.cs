using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static GsDAutoClicker.Program;

namespace GsDAutoClicker
{
    public partial class Main : Form
    {
        static Thread clicker = new( PRG.Clicker );
        private static ManualResetEvent clickerPauseEvent = new( true );
        public static Keys hotkey = Keys.None;
        private Point? clickLocation = null;

        [DllImport( "user32.dll" )]
        private static extern void mouse_event( uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo );

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public Main()
        {
            InitializeComponent();
        }

        public void Clicker()
        {
            decimal repeats = -1; // Initialize repeats to 0
            if (radioButton2.Checked)
            {
                repeats = Math.Round(numericUpDown5.Value);
            }
            while (true)
            {
                if (repeats == 0)
                {
                    button2_Click( null, null ); // Stop the clicker if repeats is 0
                    break; // Exit the loop
                }
                clickerPauseEvent.WaitOne();

                if (clickLocation.HasValue)
                {
                    Cursor.Position = clickLocation.Value;
                }

                mouse_event( MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 );

                repeats--;
                Thread.Sleep( GetInterval() );
            }
        }

        private int GetInterval()
        {
            // Calculate interval based on numericUpDown1-4 values
            return (int)(numericUpDown1.Value * 3600000 + numericUpDown2.Value * 60000 +
                         numericUpDown3.Value * 1000 + numericUpDown4.Value);
        }

        private void Main_Load( object sender, EventArgs e )
        {

        }

        private void radioButton1_CheckedChanged( object sender, EventArgs e )
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged( object sender, EventArgs e )
        {
            radioButton1.Checked = false;
        }

        private void button1_Click( object? sender, EventArgs? e )
        {
            if (GetInterval() == 0)
            {
                if (MessageBox.Show( "Setting the interval to 0 is risky, proceed with caution.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning ) == DialogResult.Cancel)
                {
                    return;
                }
            }

            button1.Enabled = false; // Disable the button to prevent multiple clicks
            button2.Enabled = true; // Enable the stop button
            clickerPauseEvent.Set(); // Resume the thread
            if (!clicker.IsAlive)
            {
                clicker.Start();
            }
        }

        private void button2_Click( object? sender, EventArgs? e )
        {
            button1.Enabled = true; // Enable the button to allow starting again
            button2.Enabled = false; // Disable the stop button
            clickerPauseEvent.Reset(); // Pause the thread
        }

        // ...existing code...
        private void button3_Click( object sender, EventArgs e )
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

        private void button4_Click( object sender, EventArgs e )
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

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if (keyData == hotkey)
            {
                if (clickerPauseEvent.WaitOne( 0 ))
                {
                    button2_Click( null, null ); // Stop
                }
                else
                {
                    button1_Click( null, null ); // Start
                }
                return true;
            }
            return base.ProcessCmdKey( ref msg, keyData );
        }

        private void Main_FormClosing( object sender, FormClosingEventArgs e )
        {
            button2_Click( null, null ); // Stop the clicker if it's running
        }
    }
}
