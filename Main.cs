using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static GsDAutoClicker.Program;
using System.Text.Json;
using System.Diagnostics;
using System.Reflection;

namespace GsDAutoClicker
{
    public partial class Main : Form
    {
        static Thread clicker = new( PRG.Clicker );
        private static ManualResetEvent clickerPauseEvent = new( true );
        private static CancellationTokenSource clickerCancellationTokenSource = new();
        public static Keys hotkey = Keys.None;
        private Point? clickLocation = null;
        private bool isRunning = false;

        [DllImport( "user32.dll" )]
        private static extern void mouse_event( uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo );

        [DllImport( "user32.dll", SetLastError = true )]
        private static extern bool RegisterHotKey( IntPtr hWnd, int id, uint fsModifiers, uint vk );

        [DllImport( "user32.dll", SetLastError = true )]
        private static extern bool UnregisterHotKey( IntPtr hWnd, int id );

        private const int HOTKEY_ID = 1; // Unique ID for the hotkey
        private const uint MOD_NONE = 0x0000; // No modifier
        private const uint WM_HOTKEY = 0x0312; // Hotkey message

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

        public void logString( string str, string level = "Info" )
        {
            string log = $"[{DateTime.Now} / {level}]: {str}";
            if (InvokeRequired)
            {
                Invoke( new Action( () => logString( str, level ) ) );
            }
            else
            {
                logs.AppendText( log + Environment.NewLine );
                logs.SelectionStart = logs.Text.Length;
                logs.ScrollToCaret();
            }
        }

        public void Clicker()
        {
            logString( "Clicker starting" );
            isRunning = true;
            var token = clickerCancellationTokenSource.Token;
            decimal repeats = Math.Round( numericUpDown5.Value );
            string clickType;
            if (comboBox1.InvokeRequired)
            {
                clickType = comboBox1.Invoke( new Func<string>( () => comboBox1.Text ) );
            }
            else
            {
                clickType = comboBox1.Text;
            }
            string clickMode;
            if (comboBox2.InvokeRequired)
            {
                clickMode = comboBox2.Invoke( new Func<string>( () => comboBox2.Text ) );
            }
            else
            {
                clickMode = comboBox2.Text;
            }
            Stopwatch stopwatch = new();
            bool isNotInfinite = radioButton1.Checked;
            bool setLocation = radioButton4.Checked;

            logString( "Clicker started" + Environment.NewLine +
                "Click Type: " + clickType + Environment.NewLine +
                "Click Mode: " + clickMode + Environment.NewLine +
                "Repeats: " + repeats + Environment.NewLine +
                "Interval: " + GetInterval() + Environment.NewLine +
                "Click Location: " + (clickLocation.HasValue ? clickLocation.Value.ToString() : "Current Cursor Position") );

            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    logString( "Clicker exited" );
                    isRunning = false;
                    break; // Exit the loop if cancellation is requested
                }

                stopwatch.Reset();
                stopwatch.Start();
                if (repeats < 1 && isNotInfinite)
                {
                    logString( "Clicker exiting, repeats is 0" );
                    StopClicker(); // Stop the clicker if repeats is 0
                    isRunning = false;
                    break; // Exit the loop
                }

                clickerPauseEvent.WaitOne();

                if (setLocation)
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
                    mouse_event( mouseDownEvent | mouseUpEvent, 0, 0, 0, 0 );
                }
                else if (clickMode == "Double")
                {
                    mouse_event( mouseDownEvent | mouseUpEvent, 0, 0, 0, 0 );
                    mouse_event( mouseDownEvent | mouseUpEvent, 0, 0, 0, 0 );
                }

                Clicks++;
                repeats--;

                Thread.Sleep( (int)Math.Max( Math.Min( GetInterval() - stopwatch.ElapsedMilliseconds, int.MaxValue ), 0 ) );
            }
        }

        private long GetInterval()
        {
            // Calculate interval based on numericUpDown1-4 values
            return (long)(numericUpDown1.Value * 3600000 + numericUpDown2.Value * 60000 +
                         numericUpDown3.Value * 1000 + numericUpDown4.Value);
        }

        private void Main_Load( object sender, EventArgs e )
        {
            logString( "Loading form" );
            label14.Text = "Version: " + Application.ProductVersion;
            label15.Text = "Company: " + Application.CompanyName;
            label16.Text = "App Version: " + Assembly.GetExecutingAssembly().GetName().Version?.ToString();
            comboBox1.SelectedItem = config.clickType;
            comboBox2.SelectedItem = config.clickMode;
            numericUpDown1.Value = config.interval1;
            numericUpDown2.Value = config.interval2;
            numericUpDown3.Value = config.interval3;
            numericUpDown4.Value = config.interval4;
            numericUpDown5.Value = config.repeats;
            textBox1.Text = config.X.ToString();
            textBox2.Text = config.Y.ToString();
            checkBox1.Checked = config.intervalZeroWarn;
            checkBox2.Checked = config.locationWithoutHotkeyWarn;

            hotkey = config.hotKey;
            button3.Text = "Set Hotkey (" + hotkey.ToString() + ")";
            if (hotkey != Keys.None)
            {
                RegisterGlobalHotKey( hotkey ); // Register the hotkey if it's set
            }
            else
            {
                logString( "No hotkey set" );
            }
            logString( "Application started" );
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
            if (GetInterval() == 0 && config.intervalZeroWarn)
            {
                if (MessageBox.Show( "Setting the interval to 0 is risky, proceed with caution.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning ) == DialogResult.Cancel)
                {
                    logString( "Clicker not started, user cancelled" );
                    return;
                }
                logString( "Clicker starting with interval of 0", "Warning" );
            }

            if (radioButton4.Checked && hotkey.Equals( Keys.None ) && config.locationWithoutHotkeyWarn)
            {
                if (MessageBox.Show( "Not setting a hotkey while setting a clicker location can prevent you from stopping the clicker, proceed with caution.", "Warning", MessageBoxButtons.OKCancel ) == DialogResult.Cancel)
                {
                    logString( "Clicker not started, user cancelled" );
                    return;
                }
                logString( "Clicker starting with location picker, but no hotkey set", "Warning" );
            }

            button1.Enabled = false; // Disable the button to prevent multiple clicks
            button2.Enabled = true; // Enable the stop button
            clickerPauseEvent.Set(); // Resume the thread
            if (!clicker.IsAlive)
            {
                if (clicker == null || !clicker.IsAlive)
                {
                    logString( "Starting clicker" );
                    clickerCancellationTokenSource = new(); // Create a new CancellationTokenSource
                    clicker = new( Clicker );
                    clicker.Start();
                }

            }
        }

        public void StopClicker()
        {
            logString( "Stopping clicker" );
            if (InvokeRequired)
            {
                Invoke( new Action( () => button2_Click( null, null ) ) );
            }
            else
            {
                button2_Click( null, null );
            }
            clickerPauseEvent.Reset(); // Pause the thread
            clickerCancellationTokenSource.Cancel(); // Signal the thread to exit
        }

        private void button2_Click( object? sender, EventArgs? e )
        {
            button1.Enabled = true; // Enable the button to allow starting again
            button2.Enabled = false; // Disable the stop button
            clickerPauseEvent.Reset(); // Pause the thread
            clickerCancellationTokenSource.Cancel(); // Signal the thread to exit
        }

        private void button3_Click( object sender, EventArgs e )
        {
            using (var hotkeyForm = new HotkeyForm())
            {
                if (hotkeyForm.ShowDialog() == DialogResult.OK)
                {
                    hotkey = hotkeyForm.SelectedHotkey;
                    config.hotKey = hotkey;
                    logString( "Hotkey set to: " + hotkey.ToString() );
                    button3.Text = "Set Hotkey (" + hotkey.ToString() + ")";
                    RegisterGlobalHotKey( hotkey ); // Register the new hotkey
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
                    StopClicker(); // Stop
                }
                else
                {
                    button1_Click( null, null ); // Start
                }
                return true;
            }
            return base.ProcessCmdKey( ref msg, keyData );
        }

        protected override void WndProc( ref Message m )
        {
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                if (isRunning)
                {
                    StopClicker(); // Stop the clicker if it's running
                }
                else
                {
                    button1_Click( null, null ); // Start the clicker
                }
            }
            base.WndProc( ref m );
        }

        private void RegisterGlobalHotKey( Keys key )
        {
            UnregisterGlobalHotKey(); // Unregister any existing hotkey
            if (key != Keys.None)
            {
                logString( "Registering hotkey: " + key.ToString() );
                RegisterHotKey( Handle, HOTKEY_ID, MOD_NONE, (uint)key );
            }
        }

        private void UnregisterGlobalHotKey()
        {
            logString( "Unregistering hotkey" );
            UnregisterHotKey( Handle, HOTKEY_ID );
        }

        private void Main_FormClosing( object sender, FormClosingEventArgs e )
        {
            logString( "Application closing" );
            StopClicker(); // Stop the clicker if it's running
            clickerCancellationTokenSource.Cancel(); // Ensure the thread exits
            UnregisterGlobalHotKey(); // Unregister the hotkey
            string json = JsonSerializer.Serialize( config );
            File.WriteAllText( "config.json", json );
            File.WriteAllText( "clicks", Clicks.ToString() );
        }

        private void radioButton3_CheckedChanged( object sender, EventArgs e )
        {
            radioButton4.Checked = false;
        }

        private void radioButton4_CheckedChanged( object sender, EventArgs e )
        {
            radioButton3.Checked = false;
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            label13.Text = "Click count: " + Clicks;
        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {
            if (int.TryParse( textBox1.Text, out int x ))
            {
                clickLocation = new Point( x, clickLocation?.Y ?? 0 );
                config.X = x;
            }
            else
            {
                clickLocation = null;
            }
        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {
            if (int.TryParse( textBox2.Text, out int y ))
            {
                clickLocation = new Point( clickLocation?.X ?? 0, y );
                config.Y = y;
            }
            else
            {
                clickLocation = null;
            }
        }

        private void numericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            config.interval1 = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged( object sender, EventArgs e )
        {
            config.interval2 = numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged( object sender, EventArgs e )
        {
            config.interval3 = numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged( object sender, EventArgs e )
        {
            config.interval4 = numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged( object sender, EventArgs e )
        {
            config.repeats = numericUpDown5.Value;
        }

        private void checkBox1_CheckedChanged( object sender, EventArgs e )
        {
            config.intervalZeroWarn = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged( object sender, EventArgs e )
        {
            config.locationWithoutHotkeyWarn = checkBox2.Checked;
        }
    }
}
