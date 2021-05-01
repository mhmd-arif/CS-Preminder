
namespace Preminder.Forms
{
    partial class FormTambahKegiatan
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
            this.finishedTask = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbRemoveAll = new System.Windows.Forms.Button();
            this.lvToDo = new System.Windows.Forms.ListBox();
            this.TBAdd = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMarkDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finishedTask
            // 
            this.finishedTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedTask.FormattingEnabled = true;
            this.finishedTask.Location = new System.Drawing.Point(12, 278);
            this.finishedTask.Name = "finishedTask";
            this.finishedTask.Size = new System.Drawing.Size(860, 160);
            this.finishedTask.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kegiatan yang telah selesai";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbRemoveAll
            // 
            this.tbRemoveAll.Location = new System.Drawing.Point(784, 8);
            this.tbRemoveAll.Name = "tbRemoveAll";
            this.tbRemoveAll.Size = new System.Drawing.Size(88, 23);
            this.tbRemoveAll.TabIndex = 18;
            this.tbRemoveAll.Text = "Hapus Semua";
            this.tbRemoveAll.UseVisualStyleBackColor = true;
            this.tbRemoveAll.Click += new System.EventHandler(this.tbRemoveAll_Click);
            // 
            // lvToDo
            // 
            this.lvToDo.FormattingEnabled = true;
            this.lvToDo.Location = new System.Drawing.Point(12, 92);
            this.lvToDo.Name = "lvToDo";
            this.lvToDo.Size = new System.Drawing.Size(860, 160);
            this.lvToDo.TabIndex = 17;
            // 
            // TBAdd
            // 
            this.TBAdd.Location = new System.Drawing.Point(12, 37);
            this.TBAdd.Name = "TBAdd";
            this.TBAdd.Size = new System.Drawing.Size(860, 20);
            this.TBAdd.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(484, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Hapus Kegiatan";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Location = new System.Drawing.Point(352, 63);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(95, 23);
            this.btnMarkDone.TabIndex = 14;
            this.btnMarkDone.Text = "Tandai Selesai";
            this.btnMarkDone.UseVisualStyleBackColor = true;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Tambah Kegiatan";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(359, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Masukkan Daftar Kegiatan";
            // 
            // FormTambahKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.finishedTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbRemoveAll);
            this.Controls.Add(this.lvToDo);
            this.Controls.Add(this.TBAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahKegiatan";
            this.Text = "Tambah Kegiatan";
            this.Load += new System.EventHandler(this.FormTambahKegiatan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox finishedTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tbRemoveAll;
        private System.Windows.Forms.ListBox lvToDo;
        private System.Windows.Forms.TextBox TBAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMarkDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}