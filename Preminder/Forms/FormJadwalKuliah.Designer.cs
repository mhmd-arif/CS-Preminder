
namespace Preminder.Forms
{
    partial class FormJadwalKuliah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCourseSchedule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourseSchedule = new System.Windows.Forms.DataGridView();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbSelasa = new System.Windows.Forms.RadioButton();
            this.rbRabu = new System.Windows.Forms.RadioButton();
            this.rbKamis = new System.Windows.Forms.RadioButton();
            this.rbJumat = new System.Windows.Forms.RadioButton();
            this.rbSabtu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preminderDataSet = new Preminder.PreminderDataSet();
            this.preminderDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCourseScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCourseScheduleTableAdapter = new Preminder.PreminderDataSetTableAdapters.TblCourseScheduleTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCourseSchedule
            // 
            this.tbCourseSchedule.Location = new System.Drawing.Point(137, 27);
            this.tbCourseSchedule.Name = "tbCourseSchedule";
            this.tbCourseSchedule.Size = new System.Drawing.Size(199, 20);
            this.tbCourseSchedule.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Jadwal :";
            // 
            // dgvCourseSchedule
            // 
            this.dgvCourseSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourseSchedule.AutoGenerateColumns = false;
            this.dgvCourseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.hourDataGridViewTextBoxColumn});
            this.dgvCourseSchedule.DataSource = this.tblCourseScheduleBindingSource;
            this.dgvCourseSchedule.Location = new System.Drawing.Point(137, 136);
            this.dgvCourseSchedule.Name = "dgvCourseSchedule";
            this.dgvCourseSchedule.Size = new System.Drawing.Size(709, 302);
            this.dgvCourseSchedule.TabIndex = 3;
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(137, 63);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(52, 17);
            this.rbSenin.TabIndex = 6;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            // 
            // rbSelasa
            // 
            this.rbSelasa.AutoSize = true;
            this.rbSelasa.Location = new System.Drawing.Point(244, 63);
            this.rbSelasa.Name = "rbSelasa";
            this.rbSelasa.Size = new System.Drawing.Size(57, 17);
            this.rbSelasa.TabIndex = 7;
            this.rbSelasa.TabStop = true;
            this.rbSelasa.Text = "Selasa";
            this.rbSelasa.UseVisualStyleBackColor = true;
            // 
            // rbRabu
            // 
            this.rbRabu.AutoSize = true;
            this.rbRabu.Location = new System.Drawing.Point(356, 63);
            this.rbRabu.Name = "rbRabu";
            this.rbRabu.Size = new System.Drawing.Size(51, 17);
            this.rbRabu.TabIndex = 8;
            this.rbRabu.TabStop = true;
            this.rbRabu.Text = "Rabu";
            this.rbRabu.UseVisualStyleBackColor = true;
            // 
            // rbKamis
            // 
            this.rbKamis.AutoSize = true;
            this.rbKamis.Location = new System.Drawing.Point(462, 63);
            this.rbKamis.Name = "rbKamis";
            this.rbKamis.Size = new System.Drawing.Size(53, 17);
            this.rbKamis.TabIndex = 9;
            this.rbKamis.TabStop = true;
            this.rbKamis.Text = "Kamis";
            this.rbKamis.UseVisualStyleBackColor = true;
            // 
            // rbJumat
            // 
            this.rbJumat.AutoSize = true;
            this.rbJumat.Location = new System.Drawing.Point(570, 63);
            this.rbJumat.Name = "rbJumat";
            this.rbJumat.Size = new System.Drawing.Size(53, 17);
            this.rbJumat.TabIndex = 10;
            this.rbJumat.TabStop = true;
            this.rbJumat.Text = "Jumat";
            this.rbJumat.UseVisualStyleBackColor = true;
            // 
            // rbSabtu
            // 
            this.rbSabtu.AutoSize = true;
            this.rbSabtu.Location = new System.Drawing.Point(678, 63);
            this.rbSabtu.Name = "rbSabtu";
            this.rbSabtu.Size = new System.Drawing.Size(53, 17);
            this.rbSabtu.TabIndex = 11;
            this.rbSabtu.TabStop = true;
            this.rbSabtu.Text = "Sabtu";
            this.rbSabtu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Atur Jam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hari :";
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(786, 63);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(60, 17);
            this.rbMinggu.TabIndex = 14;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 31);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 31);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 31);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(137, 99);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(199, 20);
            this.tbHour.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "(format = 00:00)";
            // 
            // preminderDataSet
            // 
            this.preminderDataSet.DataSetName = "PreminderDataSet";
            this.preminderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preminderDataSetBindingSource
            // 
            this.preminderDataSetBindingSource.DataSource = this.preminderDataSet;
            this.preminderDataSetBindingSource.Position = 0;
            // 
            // tblCourseScheduleBindingSource
            // 
            this.tblCourseScheduleBindingSource.DataMember = "TblCourseSchedule";
            this.tblCourseScheduleBindingSource.DataSource = this.preminderDataSet;
            // 
            // tblCourseScheduleTableAdapter
            // 
            this.tblCourseScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Nama Jadwal";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Hari";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 200;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Jam";
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            this.hourDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormJadwalKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSabtu);
            this.Controls.Add(this.rbJumat);
            this.Controls.Add(this.rbKamis);
            this.Controls.Add(this.rbRabu);
            this.Controls.Add(this.rbSelasa);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.dgvCourseSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCourseSchedule);
            this.Name = "FormJadwalKuliah";
            this.Text = "JadwalKuliah";
            this.Load += new System.EventHandler(this.FormJadwalKuliah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCourseSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourseSchedule;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbSelasa;
        private System.Windows.Forms.RadioButton rbRabu;
        private System.Windows.Forms.RadioButton rbKamis;
        private System.Windows.Forms.RadioButton rbJumat;
        private System.Windows.Forms.RadioButton rbSabtu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource preminderDataSetBindingSource;
        private PreminderDataSet preminderDataSet;
        private System.Windows.Forms.BindingSource tblCourseScheduleBindingSource;
        private PreminderDataSetTableAdapters.TblCourseScheduleTableAdapter tblCourseScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
    }
}