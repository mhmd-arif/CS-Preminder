using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Preminder.Entity;
using Newtonsoft.Json;

namespace Preminder.Forms
{
    public partial class FormTambahKegiatan : Form
    {
        private List<String> toDoTasks = new List<string>();
        private List<String> finishedTasks = new List<string>();
        ToDoList tdl = new ToDoList();
        public FormTambahKegiatan()
        {
            InitializeComponent();
            loadFromFile();
            lvToDo.DataSource = toDoTasks;
            finishedTask.DataSource = finishedTasks;
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
                    finishedTasks = loadedData.finishedTasks;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TBAdd.Text.Length > 0)
            {
                String task = DateTime.Now + " " + TBAdd.Text;
                toDoTasks.Add(task);
                lvToDo.DataSource = null;
                lvToDo.DataSource = toDoTasks;
            }
        }


        private void FormTambahKegiatan_Load(object sender, EventArgs e)
        {

        }

        private void saveToFile(String jsonData)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();


            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\PreminderKegiatan.txt"))
            {
                outfile.Write(jsonData);
            }
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            if (lvToDo.SelectedIndex >= 0)
            {
                finishedTasks.Add(toDoTasks[lvToDo.SelectedIndex]);
                toDoTasks.RemoveAt(lvToDo.SelectedIndex);
                lvToDo.DataSource = null;
                lvToDo.DataSource = toDoTasks;
                finishedTask.DataSource = null;
                finishedTask.DataSource = finishedTasks;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvToDo.SelectedIndex >= 0)
            {
                toDoTasks.RemoveAt(lvToDo.SelectedIndex);
                lvToDo.DataSource = null;
                lvToDo.DataSource = toDoTasks;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDataKegiatan formData = new FormDataKegiatan(toDoTasks, finishedTasks);
            String jsonData = JsonConvert.SerializeObject(formData);
            saveToFile(jsonData);
        }

        private void tbRemoveAll_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();


            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\PreminderKegiatan.txt"))
            {
                outfile.Flush();
                this.Close();
            }
        }
    }
}
