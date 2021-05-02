
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).BeginInit();
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
            this.dgvCourseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSchedule.Location = new System.Drawing.Point(137, 136);
            this.dgvCourseSchedule.Name = "dgvCourseSchedule";
            this.dgvCourseSchedule.Size = new System.Drawing.Size(626, 302);
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
            this.rbSelasa.Location = new System.Drawing.Point(228, 63);
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
            this.rbRabu.Location = new System.Drawing.Point(319, 63);
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
            this.rbKamis.Location = new System.Drawing.Point(396, 63);
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
            this.rbJumat.Location = new System.Drawing.Point(498, 63);
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
            this.rbSabtu.Location = new System.Drawing.Point(601, 63);
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
            this.rbMinggu.Location = new System.Drawing.Point(692, 63);
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
            this.btnUpdate.Location = new System.Drawing.Point(15, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 31);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 254);
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
            // FormJadwalKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}