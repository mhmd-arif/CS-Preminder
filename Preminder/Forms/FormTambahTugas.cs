using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preminder.Forms
{
    public partial class FormTambahTugas : Form
    {
        public FormTambahTugas()
        {
            InitializeComponent();
        }

        private void tBTugasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBTugasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.preminderDataSet);

        }

        private void FormTambahTugas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'preminderDataSet.TBTugas' table. You can move, or remove it, as needed.
            this.tBTugasTableAdapter.Fill(this.preminderDataSet.TBTugas);

        }

        private void refreshTugas_Click(object sender, EventArgs e)
        {
            this.tBTugasTableAdapter.Fill(this.preminderDataSet.TBTugas);
        }

        private void btnAddTugas_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnSaveTugas_Click(object sender, EventArgs e)
        {
            tBTugasBindingNavigatorSaveItem.PerformClick();
        }

        private void btnRemoveTugas_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnRefreshTugas_Click(object sender, EventArgs e)
        {
            refreshTugas.PerformClick();
        }
    }
}
