
namespace Preminder.Forms
{
    partial class FormTambahTugas
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
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label tugasLabel;
            System.Windows.Forms.Label tenggat_PengumpulanLabel;
            System.Windows.Forms.Label keteranganLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahTugas));
            this.tBTugasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tBTugasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshTugas = new System.Windows.Forms.ToolStripButton();
            this.tBTugasDataGridView = new System.Windows.Forms.DataGridView();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.tugasTextBox = new System.Windows.Forms.TextBox();
            this.tenggat_PengumpulanTextBox = new System.Windows.Forms.TextBox();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.tBTugasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preminderDataSet = new Preminder.PreminderDataSet();
            this.tBTugasTableAdapter = new Preminder.PreminderDataSetTableAdapters.TBTugasTableAdapter();
            this.tableAdapterManager = new Preminder.PreminderDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTugas = new System.Windows.Forms.Button();
            this.btnSaveTugas = new System.Windows.Forms.Button();
            this.btnRemoveTugas = new System.Windows.Forms.Button();
            this.btnRefreshTugas = new System.Windows.Forms.Button();
            noLabel = new System.Windows.Forms.Label();
            tugasLabel = new System.Windows.Forms.Label();
            tenggat_PengumpulanLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingNavigator)).BeginInit();
            this.tBTugasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(19, 31);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(24, 13);
            noLabel.TabIndex = 2;
            noLabel.Text = "No:";
            // 
            // tugasLabel
            // 
            tugasLabel.AutoSize = true;
            tugasLabel.Location = new System.Drawing.Point(19, 57);
            tugasLabel.Name = "tugasLabel";
            tugasLabel.Size = new System.Drawing.Size(40, 13);
            tugasLabel.TabIndex = 4;
            tugasLabel.Text = "Tugas:";
            // 
            // tenggat_PengumpulanLabel
            // 
            tenggat_PengumpulanLabel.AutoSize = true;
            tenggat_PengumpulanLabel.Location = new System.Drawing.Point(19, 83);
            tenggat_PengumpulanLabel.Name = "tenggat_PengumpulanLabel";
            tenggat_PengumpulanLabel.Size = new System.Drawing.Size(118, 13);
            tenggat_PengumpulanLabel.TabIndex = 6;
            tenggat_PengumpulanLabel.Text = "Tenggat Pengumpulan:";
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Location = new System.Drawing.Point(19, 109);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(65, 13);
            keteranganLabel.TabIndex = 8;
            keteranganLabel.Text = "Keterangan:";
            // 
            // tBTugasBindingNavigator
            // 
            this.tBTugasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tBTugasBindingNavigator.BindingSource = this.tBTugasBindingSource;
            this.tBTugasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tBTugasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tBTugasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tBTugasBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.refreshTugas});
            this.tBTugasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tBTugasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBTugasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBTugasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBTugasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBTugasBindingNavigator.Name = "tBTugasBindingNavigator";
            this.tBTugasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBTugasBindingNavigator.Size = new System.Drawing.Size(851, 25);
            this.tBTugasBindingNavigator.TabIndex = 0;
            this.tBTugasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tBTugasBindingNavigatorSaveItem
            // 
            this.tBTugasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBTugasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tBTugasBindingNavigatorSaveItem.Image")));
            this.tBTugasBindingNavigatorSaveItem.Name = "tBTugasBindingNavigatorSaveItem";
            this.tBTugasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tBTugasBindingNavigatorSaveItem.Text = "Save Data";
            this.tBTugasBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBTugasBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshTugas
            // 
            this.refreshTugas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshTugas.Image = ((System.Drawing.Image)(resources.GetObject("refreshTugas.Image")));
            this.refreshTugas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshTugas.Name = "refreshTugas";
            this.refreshTugas.Size = new System.Drawing.Size(50, 22);
            this.refreshTugas.Text = "Refresh";
            this.refreshTugas.Click += new System.EventHandler(this.refreshTugas_Click);
            // 
            // tBTugasDataGridView
            // 
            this.tBTugasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTugasDataGridView.AutoGenerateColumns = false;
            this.tBTugasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tBTugasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBTugasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tBTugasDataGridView.DataSource = this.tBTugasBindingSource;
            this.tBTugasDataGridView.Location = new System.Drawing.Point(316, 28);
            this.tBTugasDataGridView.MultiSelect = false;
            this.tBTugasDataGridView.Name = "tBTugasDataGridView";
            this.tBTugasDataGridView.Size = new System.Drawing.Size(523, 410);
            this.tBTugasDataGridView.TabIndex = 1;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBTugasBindingSource, "No", true));
            this.noTextBox.Location = new System.Drawing.Point(143, 28);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.ReadOnly = true;
            this.noTextBox.Size = new System.Drawing.Size(144, 20);
            this.noTextBox.TabIndex = 3;
            // 
            // tugasTextBox
            // 
            this.tugasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBTugasBindingSource, "Tugas", true));
            this.tugasTextBox.Location = new System.Drawing.Point(143, 54);
            this.tugasTextBox.Name = "tugasTextBox";
            this.tugasTextBox.Size = new System.Drawing.Size(144, 20);
            this.tugasTextBox.TabIndex = 5;
            // 
            // tenggat_PengumpulanTextBox
            // 
            this.tenggat_PengumpulanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBTugasBindingSource, "Tenggat_Pengumpulan", true));
            this.tenggat_PengumpulanTextBox.Location = new System.Drawing.Point(143, 80);
            this.tenggat_PengumpulanTextBox.Name = "tenggat_PengumpulanTextBox";
            this.tenggat_PengumpulanTextBox.Size = new System.Drawing.Size(144, 20);
            this.tenggat_PengumpulanTextBox.TabIndex = 7;
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBTugasBindingSource, "Keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(143, 106);
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(144, 20);
            this.keteranganTextBox.TabIndex = 9;
            // 
            // tBTugasBindingSource
            // 
            this.tBTugasBindingSource.DataMember = "TBTugas";
            this.tBTugasBindingSource.DataSource = this.preminderDataSet;
            // 
            // preminderDataSet
            // 
            this.preminderDataSet.DataSetName = "PreminderDataSet";
            this.preminderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBTugasTableAdapter
            // 
            this.tBTugasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBTugasTableAdapter = this.tBTugasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Preminder.PreminderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tugas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tugas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tenggat_Pengumpulan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tenggat_Pengumpulan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Keterangan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Keterangan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnAddTugas
            // 
            this.btnAddTugas.Location = new System.Drawing.Point(22, 168);
            this.btnAddTugas.Name = "btnAddTugas";
            this.btnAddTugas.Size = new System.Drawing.Size(115, 61);
            this.btnAddTugas.TabIndex = 10;
            this.btnAddTugas.Text = "Tambah Tugas";
            this.btnAddTugas.UseVisualStyleBackColor = true;
            this.btnAddTugas.Click += new System.EventHandler(this.btnAddTugas_Click);
            // 
            // btnSaveTugas
            // 
            this.btnSaveTugas.Location = new System.Drawing.Point(172, 168);
            this.btnSaveTugas.Name = "btnSaveTugas";
            this.btnSaveTugas.Size = new System.Drawing.Size(115, 61);
            this.btnSaveTugas.TabIndex = 11;
            this.btnSaveTugas.Text = "Simpan Tugas";
            this.btnSaveTugas.UseVisualStyleBackColor = true;
            this.btnSaveTugas.Click += new System.EventHandler(this.btnSaveTugas_Click);
            // 
            // btnRemoveTugas
            // 
            this.btnRemoveTugas.Location = new System.Drawing.Point(22, 288);
            this.btnRemoveTugas.Name = "btnRemoveTugas";
            this.btnRemoveTugas.Size = new System.Drawing.Size(115, 61);
            this.btnRemoveTugas.TabIndex = 12;
            this.btnRemoveTugas.Text = "Hapus Tugas";
            this.btnRemoveTugas.UseVisualStyleBackColor = true;
            this.btnRemoveTugas.Click += new System.EventHandler(this.btnRemoveTugas_Click);
            // 
            // btnRefreshTugas
            // 
            this.btnRefreshTugas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshTugas.Location = new System.Drawing.Point(172, 288);
            this.btnRefreshTugas.Name = "btnRefreshTugas";
            this.btnRefreshTugas.Size = new System.Drawing.Size(115, 61);
            this.btnRefreshTugas.TabIndex = 13;
            this.btnRefreshTugas.Text = "Refresh";
            this.btnRefreshTugas.UseVisualStyleBackColor = true;
            this.btnRefreshTugas.Click += new System.EventHandler(this.btnRefreshTugas_Click);
            // 
            // FormTambahTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.btnRefreshTugas);
            this.Controls.Add(this.btnRemoveTugas);
            this.Controls.Add(this.btnSaveTugas);
            this.Controls.Add(this.btnAddTugas);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(tugasLabel);
            this.Controls.Add(this.tugasTextBox);
            this.Controls.Add(tenggat_PengumpulanLabel);
            this.Controls.Add(this.tenggat_PengumpulanTextBox);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Controls.Add(this.tBTugasDataGridView);
            this.Controls.Add(this.tBTugasBindingNavigator);
            this.Name = "FormTambahTugas";
            this.Text = "FormTambahTugas";
            this.Load += new System.EventHandler(this.FormTambahTugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingNavigator)).EndInit();
            this.tBTugasBindingNavigator.ResumeLayout(false);
            this.tBTugasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PreminderDataSet preminderDataSet;
        private System.Windows.Forms.BindingSource tBTugasBindingSource;
        private PreminderDataSetTableAdapters.TBTugasTableAdapter tBTugasTableAdapter;
        private PreminderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tBTugasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tBTugasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tBTugasDataGridView;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox tugasTextBox;
        private System.Windows.Forms.TextBox tenggat_PengumpulanTextBox;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshTugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnAddTugas;
        private System.Windows.Forms.Button btnSaveTugas;
        private System.Windows.Forms.Button btnRemoveTugas;
        private System.Windows.Forms.Button btnRefreshTugas;
    }
}