using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishy_Notes
{
    public class Controller
    {
        /// <summary>
        /// Constructor for objects of type Controller.
        /// </summary>
        public Controller()
        {
            // Instantiate a List<Form> for the UI to store its notes in, store it as an IList and call it noteForms:
            IList<Form> noteForms = new List<Form>();

            // Fire-up UI by instantiating FishyNotes:
            //Application.Run(new FishyNotes);
            Application.Run(new FishyNotes(noteForms));
        }
    }
}
