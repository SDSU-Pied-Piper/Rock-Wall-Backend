using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDSU_Rock_Wall_CRM
{
    public partial class DisplayWaiverUI : Form
    {
        public DisplayWaiverUI(MemoryStream ms,string firstName, string lastName)
        {
            InitializeComponent();
            this.Text = ($"Waiver Signature of {firstName} {lastName}");
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
