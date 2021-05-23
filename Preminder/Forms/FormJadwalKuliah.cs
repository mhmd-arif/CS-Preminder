using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Preminder.Repository;
using Preminder.Entity;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Preminder.Forms
{
    public partial class FormJadwalKuliah : Form
    {
        // Variables
        readonly private ScheduleRepository newCourse = new ScheduleRepository();

        readonly static string pathDB = Path.GetFullPath(Environment.CurrentDirectory) + @"\Database\";
        readonly static string DbName = "PreminderDataSet.mdf";
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathDB + DbName + ";Integrated Security=True";


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
            string day = GetDay();
            if (tbCourseSchedule.Text != "" && day != "" && tbHour.Text != ""  )
            {
                newCourse.Add(tbCourseSchedule.Text, day, tbHour.Text);
                MessageBox.Show("Jadwal Kuliah berhasil ditambahkan");
            }
            else
            {
                MessageBox.Show("Input tidak boleh kosong!, silakan ulangi kembali");
            }

            UpdateDgv();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string day = GetDay();
            int id = int.Parse(dgvCourseSchedule.CurrentRow.Cells[0].Value.ToString());
            newCourse.Update(id, tbCourseSchedule.Text, day, tbHour.Text);

            UpdateDgv();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCourseSchedule.CurrentRow.Cells[0].Value.ToString());
            newCourse.Delete(id);
            MessageBox.Show("jadwal telah dihapus");

            UpdateDgv();
            Clear();
        }


        /// <summary>
        ///  method untuk mendapatkan data hari dari radio button
        /// </summary>
        /// <returns></returns>
        public string GetDay()
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

        /// <summary>
        /// method untuk mengupdate data pada data grid view
        /// </summary>
        public void UpdateDgv()
        {
            List<Schedule> dgvSchedule = newCourse.GetAll();
            dgvCourseSchedule.DataSource = dgvSchedule;
        }

        /// <summary>
        /// method untuk membersihkan text box dan radio button
        /// </summary>
        public void Clear()
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

        private void tb_SearchByCourse_TextChanged(object sender, EventArgs e)
        {            
            tb_FilterByDay.Clear();

            SqlConnection con = new SqlConnection(connstring);
            string sqlQuery = "SELECT * FROM TblCourseSchedule where Course = '" + tb_SearchByCourse.Text + "' ";
            
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvCourseSchedule.DataSource = dt;
            con.Close();
        }

        private void tb_FilterByDay_TextChanged(object sender, EventArgs e)
        {
            tb_SearchByCourse.Clear();

            SqlConnection con = new SqlConnection(connstring);
            string sqlQuery = "SELECT * FROM TblCourseSchedule where Day = '" + tb_FilterByDay.Text + "' ";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvCourseSchedule.DataSource = dt;
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Schedule> dgvSchedule = newCourse.GetAll();
            dgvCourseSchedule.DataSource = dgvSchedule;
        }
    }
}
