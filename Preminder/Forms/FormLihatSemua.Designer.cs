
namespace Preminder.Forms
{
    partial class FormLihatSemua
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvActiviy = new System.Windows.Forms.Label();
            this.dgvCourseSchedule = new System.Windows.Forms.DataGridView();
            this.dgvToDo = new System.Windows.Forms.DataGridView();
            this.btnRefres = new System.Windows.Forms.Button();
            this.lb_Kegiatan = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jadwal Kuliah :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tugas : ";
            // 
            // dgvActiviy
            // 
            this.dgvActiviy.AutoSize = true;
            this.dgvActiviy.Location = new System.Drawing.Point(44, 303);
            this.dgvActiviy.Name = "dgvActiviy";
            this.dgvActiviy.Size = new System.Drawing.Size(55, 13);
            this.dgvActiviy.TabIndex = 9;
            this.dgvActiviy.Text = "Kegiatan :";
            // 
            // dgvCourseSchedule
            // 
            this.dgvCourseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSchedule.Location = new System.Drawing.Point(47, 41);
            this.dgvCourseSchedule.Name = "dgvCourseSchedule";
            this.dgvCourseSchedule.Size = new System.Drawing.Size(706, 109);
            this.dgvCourseSchedule.TabIndex = 10;
            // 
            // dgvToDo
            // 
            this.dgvToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToDo.Location = new System.Drawing.Point(47, 181);
            this.dgvToDo.Name = "dgvToDo";
            this.dgvToDo.Size = new System.Drawing.Size(706, 109);
            this.dgvToDo.TabIndex = 11;
            // 
            // btnRefres
            // 
            this.btnRefres.Location = new System.Drawing.Point(678, 12);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(75, 23);
            this.btnRefres.TabIndex = 13;
            this.btnRefres.Text = "Refresh";
            this.btnRefres.UseVisualStyleBackColor = true;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // lb_Kegiatan
            // 
            this.lb_Kegiatan.FormattingEnabled = true;
            this.lb_Kegiatan.Location = new System.Drawing.Point(47, 320);
            this.lb_Kegiatan.Name = "lb_Kegiatan";
            this.lb_Kegiatan.Size = new System.Drawing.Size(706, 108);
            this.lb_Kegiatan.TabIndex = 14;
            // 
            // FormLihatSemua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Kegiatan);
            this.Controls.Add(this.btnRefres);
            this.Controls.Add(this.dgvToDo);
            this.Controls.Add(this.dgvCourseSchedule);
            this.Controls.Add(this.dgvActiviy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLihatSemua";
            this.Text = "LihatSemua";
            this.Load += new System.EventHandler(this.FormLihatSemua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dgvActiviy;
        private System.Windows.Forms.DataGridView dgvCourseSchedule;
        private System.Windows.Forms.DataGridView dgvToDo;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.ListBox lb_Kegiatan;
    }
}