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
using System.Drawing.Drawing2D;

namespace SDSU_Rock_Wall_CRM
{
    public partial class DisplayWaiverUI : Form
    {
        public DisplayWaiverUI(MemoryStream ms,string firstName, string lastName,string dateOfCreation)
        {
            InitializeComponent();
            this.Text = ($"Waiver Signature of {firstName} {lastName} Signed on: {dateOfCreation.Substring(0,10)}");
            Bitmap waiver = new Bitmap(Properties.Resources.waiver);
            Bitmap signature = new Bitmap(ms);
            Bitmap finalImage = new Bitmap(waiver.Width, waiver.Height);
            Graphics graphics = Graphics.FromImage(finalImage);
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.DrawImage(waiver, 0, 0);
            graphics.DrawImage(signature, 170, 1200);
            pictureBox1.Image = finalImage;
        }
    }
}
