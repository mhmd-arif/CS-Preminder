using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Preminder.Entity;
using Preminder.Repository;

namespace Preminder.Forms
{
    public partial class FormLihatSemua : Form
    {
        ScheduleRepository newCourseSchedule = new ScheduleRepository();
        public FormLihatSemua()
        {
            InitializeComponent();
        }

        private void FormLihatSemua_Load(object sender, EventArgs e)
        {
            updateDgv();
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            updateDgv();
        }

        public void updateDgv()
        {
            List<Schedule> listSchedule = newCourseSchedule.GetAll();
            dgvCourseSchedule.DataSource = listSchedule;
        }
    }
}
