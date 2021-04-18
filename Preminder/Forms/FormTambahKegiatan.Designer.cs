
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMarkDone = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.TBAdd = new System.Windows.Forms.TextBox();
            this.lvToDo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Daftar Kegiatan";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Location = new System.Drawing.Point(273, 97);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(75, 23);
            this.btnMarkDone.TabIndex = 3;
            this.btnMarkDone.Text = "Mark Done";
            this.btnMarkDone.UseVisualStyleBackColor = true;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(412, 97);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove All";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TBAdd
            // 
            this.TBAdd.Location = new System.Drawing.Point(12, 49);
            this.TBAdd.Name = "TBAdd";
            this.TBAdd.Size = new System.Drawing.Size(584, 20);
            this.TBAdd.TabIndex = 6;
            // 
            // lvToDo
            // 
            this.lvToDo.FormattingEnabled = true;
            this.lvToDo.Location = new System.Drawing.Point(12, 150);
            this.lvToDo.Name = "lvToDo";
            this.lvToDo.Size = new System.Drawing.Size(584, 277);
            this.lvToDo.TabIndex = 7;
            // 
            // FormTambahKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 439);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMarkDone;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox TBAdd;
        private System.Windows.Forms.ListBox lvToDo;
    }
}