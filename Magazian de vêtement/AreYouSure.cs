using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazian_de_vêtement
{
    public partial class AreYouSure : Form
    {
      public  bool sûre {get;set;}
        public AreYouSure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
               this.sûre =true;
               Close();
        }
        public bool getSure()
        {
            return this.sûre;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
