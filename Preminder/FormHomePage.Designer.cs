
namespace Preminder
{
    partial class FormHomePage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMerk = new System.Windows.Forms.Panel();
            this.lblMerk = new System.Windows.Forms.Label();
            this.panelJudul = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnKegiatan = new System.Windows.Forms.Button();
            this.btnTugas = new System.Windows.Forms.Button();
            this.btnLihatSemua = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelMerk.SuspendLayout();
            this.panelJudul.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.btnJadwal);
            this.panelMenu.Controls.Add(this.btnKegiatan);
            this.panelMenu.Controls.Add(this.btnTugas);
            this.panelMenu.Controls.Add(this.btnLihatSemua);
            this.panelMenu.Controls.Add(this.panelMerk);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMerk
            // 
            this.panelMerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMerk.Controls.Add(this.lblMerk);
            this.panelMerk.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMerk.Location = new System.Drawing.Point(0, 0);
            this.panelMerk.Name = "panelMerk";
            this.panelMerk.Size = new System.Drawing.Size(220, 80);
            this.panelMerk.TabIndex = 0;
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerk.ForeColor = System.Drawing.Color.White;
            this.lblMerk.Location = new System.Drawing.Point(62, 33);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(86, 16);
            this.lblMerk.TabIndex = 0;
            this.lblMerk.Text = "PREMINDER";
            // 
            // panelJudul
            // 
            this.panelJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelJudul.Controls.Add(this.lblJudul);
            this.panelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudul.Location = new System.Drawing.Point(220, 0);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(580, 80);
            this.panelJudul.TabIndex = 1;
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(266, 32);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(51, 18);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(580, 370);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnJadwal
            // 
            this.btnJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJadwal.FlatAppearance.BorderSize = 0;
            this.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwal.ForeColor = System.Drawing.Color.Snow;
            this.btnJadwal.Image = global::Preminder.Properties.Resources.calendar_fix;
            this.btnJadwal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJadwal.Location = new System.Drawing.Point(0, 260);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnJadwal.Size = new System.Drawing.Size(220, 60);
            this.btnJadwal.TabIndex = 4;
            this.btnJadwal.Text = "   Jadwal Kuliah";
            this.btnJadwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJadwal.UseVisualStyleBackColor = true;
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);
            // 
            // btnKegiatan
            // 
            this.btnKegiatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKegiatan.FlatAppearance.BorderSize = 0;
            this.btnKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKegiatan.ForeColor = System.Drawing.Color.Snow;
            this.btnKegiatan.Image = global::Preminder.Properties.Resources.diary_fix;
            this.btnKegiatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKegiatan.Location = new System.Drawing.Point(0, 200);
            this.btnKegiatan.Name = "btnKegiatan";
            this.btnKegiatan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKegiatan.Size = new System.Drawing.Size(220, 60);
            this.btnKegiatan.TabIndex = 3;
            this.btnKegiatan.Text = "   Kegiatan";
            this.btnKegiatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKegiatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKegiatan.UseVisualStyleBackColor = true;
            this.btnKegiatan.Click += new System.EventHandler(this.btnKegiatan_Click);
            // 
            // btnTugas
            // 
            this.btnTugas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTugas.FlatAppearance.BorderSize = 0;
            this.btnTugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTugas.ForeColor = System.Drawing.Color.Snow;
            this.btnTugas.Image = global::Preminder.Properties.Resources.to_do_list_fix;
            this.btnTugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTugas.Location = new System.Drawing.Point(0, 140);
            this.btnTugas.Name = "btnTugas";
            this.btnTugas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTugas.Size = new System.Drawing.Size(220, 60);
            this.btnTugas.TabIndex = 2;
            this.btnTugas.Text = "   Tugas";
            this.btnTugas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTugas.UseVisualStyleBackColor = true;
            this.btnTugas.Click += new System.EventHandler(this.btnTugas_Click);
            // 
            // btnLihatSemua
            // 
            this.btnLihatSemua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLihatSemua.FlatAppearance.BorderSize = 0;
            this.btnLihatSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihatSemua.ForeColor = System.Drawing.Color.Snow;
            this.btnLihatSemua.Image = global::Preminder.Properties.Resources.task_fix;
            this.btnLihatSemua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatSemua.Location = new System.Drawing.Point(0, 80);
            this.btnLihatSemua.Name = "btnLihatSemua";
            this.btnLihatSemua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLihatSemua.Size = new System.Drawing.Size(220, 60);
            this.btnLihatSemua.TabIndex = 1;
            this.btnLihatSemua.Text = "   Lihat Semua";
            this.btnLihatSemua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatSemua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLihatSemua.UseVisualStyleBackColor = true;
            this.btnLihatSemua.Click += new System.EventHandler(this.btnLihatSemua_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelJudul);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.panelMenu.ResumeLayout(false);
            this.panelMerk.ResumeLayout(false);
            this.panelMerk.PerformLayout();
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnJadwal;
        private System.Windows.Forms.Button btnKegiatan;
        private System.Windows.Forms.Button btnTugas;
        private System.Windows.Forms.Button btnLihatSemua;
        private System.Windows.Forms.Panel panelMerk;
        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

