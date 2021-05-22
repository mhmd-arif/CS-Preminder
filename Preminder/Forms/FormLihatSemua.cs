using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Preminder.Entity;
using Preminder.Repository;
using System.IO;
using Newtonsoft.Json;


namespace Preminder.Forms
{
    public partial class FormLihatSemua : Form
    {
        // Variables
        readonly private ScheduleRepository newCourseSchedule = new ScheduleRepository();
        readonly private TodoRepository newToDo = new TodoRepository();
        private List<String> toDoTasks = new List<string>();


        public FormLihatSemua()
        {
            InitializeComponent();
        }

        private void FormLihatSemua_Load(object sender, EventArgs e)
        {           
            UpdateDgv();
            LoadFromFile();
            lb_Kegiatan.DataSource = toDoTasks;
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            LoadFromFile();
            lb_Kegiatan.DataSource = toDoTasks;
        }


        // Methods 

        /// <summary>
        /// Method untuk mengupdate data pada data grid view, sumber data dari data base PreminderDataSet.mdf
        /// </summary>
        public void UpdateDgv()
        {
            List<Schedule> listSchedule = newCourseSchedule.GetAll();
            dgvCourseSchedule.DataSource = listSchedule;

            List<ToDoList> listToDo = newToDo.GetAllToDo();
            dgvToDo.DataSource = listToDo;
        }

        /// <summary>
        ///  Method untuk mengupdate data dari file .tct
        /// </summary>
        private void LoadFromFile()
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
