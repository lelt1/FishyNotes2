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
        private IList<Form> _noteList;
        //When the More Fish button is clicked it will create a new form to enter a note
        public FishyNotes(IList<Form> noteList)
        {
            InitializeComponent();
            _noteList = noteList;
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            //If the newNote form is null or it has been disposed (when close button is clicked)
                Form newNote = new FishyNote();
                _noteList.Add(newNote);
                newNote.Show();
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }
    }
}
