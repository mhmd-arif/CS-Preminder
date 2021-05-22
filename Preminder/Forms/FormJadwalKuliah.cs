using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Preminder.Repository;
using Preminder.Entity;
using System.Data.SqlClient;

namespace Preminder.Forms
{
    public partial class FormJadwalKuliah : Form
    {
        static string pathDB = Path.GetFullPath(Environment.CurrentDirectory) + @"\Database\";
        static string DbName = "PreminderDataSet.mdf";
        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathDB + DbName + ";Integrated Security=True";

         private ScheduleRepository newCourse = new ScheduleRepository();



        public FormJadwalKuliah()
        {
            InitializeComponent();
        }
        private void FormJadwalKuliah_Load(object sender, EventArgs e)
        {
            
            List<Schedule> dgvSchedule = newCourse.GetAll();
            dgvCourseSchedule.DataSource = dgvSchedule;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string day = getDay();
            newCourse.Add(tbCourseSchedule.Text, day,tbHour.Text);
            MessageBox.Show("Jadwal Kuliah berhasil ditambahkan");

            updateDgv();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string day = getDay();
            int id = int.Parse(dgvCourseSchedule.CurrentRow.Cells[0].Value.ToString());
            newCourse.Update(id, tbCourseSchedule.Text, day, tbHour.Text);

            updateDgv();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCourseSchedule.CurrentRow.Cells[0].Value.ToString());
            newCourse.Delete(id);
            MessageBox.Show("jadwal telah dihapus");

            updateDgv();
            clear();
        }

        public string getDay()
        {
            string day = "";
            if (rbSenin.Checked == true)
                day = rbSenin.Text;
            else if (rbSelasa.Checked == true)
                day = rbSelasa.Text;
            else if (rbRabu.Checked == true)
                day = rbRabu.Text;
            else if (rbKamis.Checked == true)
                day = rbKamis.Text;
            else if (rbJumat.Checked == true)
                day = rbJumat.Text;
            else if (rbSabtu.Checked == true)
                day = rbSabtu.Text;
            else if (rbMinggu.Checked == true)
                day = rbMinggu.Text;
            return day;
        }

        public void updateDgv()
        {
            List<Schedule> dgvSchedule = newCourse.GetAll();
            dgvCourseSchedule.DataSource = dgvSchedule;
        }

        public void clear()
        {
            tbCourseSchedule.Clear();
            tbHour.Clear();
            rbSenin.Checked = false;
            rbSelasa.Checked = false;
            rbRabu.Checked = false;
            rbKamis.Checked = false;
            rbJumat.Checked = false;
            rbSabtu.Checked = false;
            rbMinggu.Checked = false;
        }
    }
}
