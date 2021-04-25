using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Preminder.Forms
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void btnTambahKegiatan_Click(object sender, EventArgs e)
        {
            Thread Th1 = new Thread((ThreadStart)delegate { Application.Run(new FormTambahTugas()); });
            Th1.Start();
        }
    }
}
