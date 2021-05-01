using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preminder
{
    public partial class FormHomePage : Form
    {
        //fields
        private Form activeForm;

        //Constructor
        public FormHomePage()
        {
            InitializeComponent();
        }

        //Method
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblJudul.Text = childForm.Text;
        }

        private void btnLihatSemua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLihatSemua(), sender);
        }

        private void btnTugas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTambahTugas(), sender);
        }

        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTambahKegiatan(), sender);
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormJadwalKuliah(), sender);
        }
    }
}
