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
    public partial class FishyNotes : Form
    {
        Form _newNote;
        public FishyNotes()
        {
            InitializeComponent();
        }
        //When the More Fish button is clicked it will create a new form to enter a note
        private void AddNote_Click(object sender, EventArgs e)
        {
            if (_newNote == null || _newNote.IsDisposed)
            {
                _newNote = null;
            }
            if (_newNote == null)
                {
                _newNote = new FishyNote();
                _newNote.Show();
            }
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }
    }
}
