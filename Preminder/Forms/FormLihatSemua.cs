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
using System.IO;
using System.Windows.Input;
using Newtonsoft.Json;
using Preminder.Forms;

namespace Preminder.Forms
{
    public partial class FormLihatSemua : Form
    {
        private ScheduleRepository newCourseSchedule = new ScheduleRepository();
        private TodoRepository newToDo = new TodoRepository();
        private List<String> toDoTasks = new List<string>();

        public FormLihatSemua()
        {
            InitializeComponent();
        }

        private void FormLihatSemua_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'preminderDataSet.TBTugas' table. You can move, or remove it, as needed.
            this.tBTugasTableAdapter.Fill(this.preminderDataSet.TBTugas);
            updateDgv();
            loadFromFile();
            lb_Kegiatan.DataSource = toDoTasks;
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            updateDgv();
            loadFromFile();
            lb_Kegiatan.DataSource = toDoTasks;
        }



        public void updateDgv()
        {
            List<Schedule> listSchedule = newCourseSchedule.GetAll();
            dgvCourseSchedule.DataSource = listSchedule;

            List<ToDoList> listToDo = newToDo.GetAllToDo();
            dgvToDo.DataSource = listToDo;
        }

        private void loadFromFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PreminderKegiatan.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    String json;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        json = sr.ReadToEnd();
                    }
                    FormDataKegiatan loadedData = JsonConvert.DeserializeObject<FormDataKegiatan>(json);
                    toDoTasks = loadedData.toDoTasks;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }


    }
}
