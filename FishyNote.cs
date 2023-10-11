using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishy_Notes
{
    public partial class FishyNote : Form
    {
        //Bool for whether the textbox has been shrunk or expanded
        bool Shrunk = false;
        //Bool to check if the text in the note has be
        bool text = false;
        public FishyNote()
        {
            InitializeComponent();
            //Set form autosize to true so later when shrink button is used it will change form size with or without textbox
            this.AutoSize = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Garbage collection cleaning unused memory when form is closed
            GC.Collect();
            //Disposes the fishynote form meaning it can be re opened
            Dispose(true);
        }

        private void Collapse_Click(object sender, EventArgs e)
        {
            //Using bool check if the form has already been shrunk using button or not
            if (Shrunk == true)
            {
                Shrunk = false;
                WrittenNote.Show();
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Collapse.Text = "Shrink";
            }
            else if (Shrunk == false)
            {
                Shrunk = true;
                WrittenNote.Hide();
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Collapse.Text = "Expand";
            }
        }

        private void WrittenNote_MouseClick(object sender, MouseEventArgs e)
        {
            //Empty the string inside of the writtennote textbox
            WrittenNote.Text = String.Empty;
        }

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion

        private void WrittenNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
