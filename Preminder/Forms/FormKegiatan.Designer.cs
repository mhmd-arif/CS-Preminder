
namespace Preminder.Forms
{
    partial class FormKegiatan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambahKegiatan = new System.Windows.Forms.Button();
            this.btnHapusKegiatan = new System.Windows.Forms.Button();
            this.btnAturPengingat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTambahKegiatan
            // 
            this.btnTambahKegiatan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTambahKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKegiatan.Location = new System.Drawing.Point(50, 20);
            this.btnTambahKegiatan.Name = "btnTambahKegiatan";
            this.btnTambahKegiatan.Size = new System.Drawing.Size(139, 56);
            this.btnTambahKegiatan.TabIndex = 1;
            this.btnTambahKegiatan.Text = "Tambah";
            this.btnTambahKegiatan.UseVisualStyleBackColor = false;
            this.btnTambahKegiatan.Click += new System.EventHandler(this.btnTambahKegiatan_Click);
            // 
            // btnHapusKegiatan
            // 
            this.btnHapusKegiatan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHapusKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusKegiatan.Location = new System.Drawing.Point(50, 108);
            this.btnHapusKegiatan.Name = "btnHapusKegiatan";
            this.btnHapusKegiatan.Size = new System.Drawing.Size(139, 56);
            this.btnHapusKegiatan.TabIndex = 2;
            this.btnHapusKegiatan.Text = "Hapus";
            this.btnHapusKegiatan.UseVisualStyleBackColor = false;
            // 
            // btnAturPengingat
            // 
            this.btnAturPengingat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAturPengingat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAturPengingat.Location = new System.Drawing.Point(50, 189);
            this.btnAturPengingat.Name = "btnAturPengingat";
            this.btnAturPengingat.Size = new System.Drawing.Size(139, 56);
            this.btnAturPengingat.TabIndex = 3;
            this.btnAturPengingat.Text = "Atur Pengingat";
            this.btnAturPengingat.UseVisualStyleBackColor = false;
            // 
            // FormKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAturPengingat);
            this.Controls.Add(this.btnHapusKegiatan);
            this.Controls.Add(this.btnTambahKegiatan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKegiatan";
            this.Text = "Kegiatan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambahKegiatan;
        private System.Windows.Forms.Button btnHapusKegiatan;
        private System.Windows.Forms.Button btnAturPengingat;
    }
}