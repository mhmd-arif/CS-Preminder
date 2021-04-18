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
using System.Windows.Input;
using Preminder.Entity;

namespace Preminder.Forms
{
    public partial class FormTambahKegiatan : Form
    {
        ToDoList tdl = new ToDoList();
        public FormTambahKegiatan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = TBAdd.Text;
            StreamWriter sw = File.AppendText("todoTest.txt");
            sw.WriteLine(var);
            sw.Close();
            lvToDo.Items.Add(var);
            MessageBox.Show("Kegiatan Ditambahkan");
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            
        }

        private void FormTambahKegiatan_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("todoTest.txt");
            foreach (string line in lines)
                lvToDo.Items.Add(line);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            File.Delete("todoTest.txt");
        }
    }
}
