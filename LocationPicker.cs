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
    public partial class LocationPicker : Form
    {
        public Point? SelectedLocation = null;
        public LocationPicker()
        {
            InitializeComponent();
        }

        private void LocationPicker_Load( object sender, EventArgs e )
        {
            Program.PRG.logString( "Location picker opened" );
        }

        private void LocationPicker_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void labelInstruction_MouseClick( object sender, MouseEventArgs e )
        {
            SelectedLocation = PointToScreen( e.Location );
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
