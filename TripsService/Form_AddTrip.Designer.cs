namespace TripsService
{
    partial class Form_AddTrip
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
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label wiekLabel;
            System.Windows.Forms.Label peselLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label poczatek_podrozyLabel;
            System.Windows.Forms.Label cel_podrozyLabel;
            System.Windows.Forms.Label data_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddTrip));
            this.database_TripDataSet = new TripsService.Database_TripDataSet();
            this.tripallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripallTableAdapter = new TripsService.Database_TripDataSetTableAdapters.TripallTableAdapter();
            this.tableAdapterManager = new TripsService.Database_TripDataSetTableAdapters.TableAdapterManager();
            this.tripallBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tripallBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.wiekTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.poczatek_podrozyTextBox = new System.Windows.Forms.TextBox();
            this.cel_podrozyTextBox = new System.Windows.Forms.TextBox();
            this.data_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tripallDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyślij = new System.Windows.Forms.Button();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            wiekLabel = new System.Windows.Forms.Label();
            peselLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            poczatek_podrozyLabel = new System.Windows.Forms.Label();
            cel_podrozyLabel = new System.Windows.Forms.Label();
            data_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database_TripDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallBindingNavigator)).BeginInit();
            this.tripallBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(35, 41);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(29, 13);
            imieLabel.TabIndex = 1;
            imieLabel.Text = "Imie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(35, 67);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            nazwiskoLabel.TabIndex = 3;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // wiekLabel
            // 
            wiekLabel.AutoSize = true;
            wiekLabel.Location = new System.Drawing.Point(35, 93);
            wiekLabel.Name = "wiekLabel";
            wiekLabel.Size = new System.Drawing.Size(35, 13);
            wiekLabel.TabIndex = 5;
            wiekLabel.Text = "Wiek:";
            // 
            // peselLabel
            // 
            peselLabel.AutoSize = true;
            peselLabel.Location = new System.Drawing.Point(35, 119);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new System.Drawing.Size(36, 13);
            peselLabel.TabIndex = 7;
            peselLabel.Text = "Pesel:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(35, 145);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 9;
            telefonLabel.Text = "Telefon:";
            // 
            // poczatek_podrozyLabel
            // 
            poczatek_podrozyLabel.AutoSize = true;
            poczatek_podrozyLabel.Location = new System.Drawing.Point(35, 171);
            poczatek_podrozyLabel.Name = "poczatek_podrozyLabel";
            poczatek_podrozyLabel.Size = new System.Drawing.Size(95, 13);
            poczatek_podrozyLabel.TabIndex = 11;
            poczatek_podrozyLabel.Text = "Poczatek podrozy:";
            // 
            // cel_podrozyLabel
            // 
            cel_podrozyLabel.AutoSize = true;
            cel_podrozyLabel.Location = new System.Drawing.Point(35, 197);
            cel_podrozyLabel.Name = "cel_podrozyLabel";
            cel_podrozyLabel.Size = new System.Drawing.Size(65, 13);
            cel_podrozyLabel.TabIndex = 13;
            cel_podrozyLabel.Text = "Cel podrozy:";
            // 
            // data_Label
            // 
            data_Label.AutoSize = true;
            data_Label.Location = new System.Drawing.Point(35, 224);
            data_Label.Name = "data_Label";
            data_Label.Size = new System.Drawing.Size(36, 13);
            data_Label.TabIndex = 15;
            data_Label.Text = "Data :";
            // 
            // database_TripDataSet
            // 
            this.database_TripDataSet.DataSetName = "Database_TripDataSet";
            this.database_TripDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripallBindingSource
            // 
            this.tripallBindingSource.DataMember = "Tripall";
            this.tripallBindingSource.DataSource = this.database_TripDataSet;
            this.tripallBindingSource.CurrentChanged += new System.EventHandler(this.tripallBindingSource_CurrentChanged);
            // 
            // tripallTableAdapter
            // 
            this.tripallTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TripallTableAdapter = this.tripallTableAdapter;
            this.tableAdapterManager.UpdateOrder = TripsService.Database_TripDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tripallBindingNavigator
            // 
            this.tripallBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tripallBindingNavigator.BindingSource = this.tripallBindingSource;
            this.tripallBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tripallBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tripallBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tripallBindingNavigatorSaveItem});
            this.tripallBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tripallBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tripallBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tripallBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tripallBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tripallBindingNavigator.Name = "tripallBindingNavigator";
            this.tripallBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tripallBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.tripallBindingNavigator.TabIndex = 0;
            this.tripallBindingNavigator.Text = "bindingNavigator1";
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
            // tripallBindingNavigatorSaveItem
            // 
            this.tripallBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tripallBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tripallBindingNavigatorSaveItem.Image")));
            this.tripallBindingNavigatorSaveItem.Name = "tripallBindingNavigatorSaveItem";
            this.tripallBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tripallBindingNavigatorSaveItem.Text = "Save Data";
            this.tripallBindingNavigatorSaveItem.Click += new System.EventHandler(this.tripallBindingNavigatorSaveItem_Click);
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(136, 38);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieTextBox.TabIndex = 2;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(136, 64);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // wiekTextBox
            // 
            this.wiekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Wiek", true));
            this.wiekTextBox.Location = new System.Drawing.Point(136, 90);
            this.wiekTextBox.Name = "wiekTextBox";
            this.wiekTextBox.Size = new System.Drawing.Size(200, 20);
            this.wiekTextBox.TabIndex = 6;
            // 
            // peselTextBox
            // 
            this.peselTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Pesel", true));
            this.peselTextBox.Location = new System.Drawing.Point(136, 116);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(200, 20);
            this.peselTextBox.TabIndex = 8;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(136, 142);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonTextBox.TabIndex = 10;
            // 
            // poczatek_podrozyTextBox
            // 
            this.poczatek_podrozyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Poczatek podrozy", true));
            this.poczatek_podrozyTextBox.Location = new System.Drawing.Point(136, 168);
            this.poczatek_podrozyTextBox.Name = "poczatek_podrozyTextBox";
            this.poczatek_podrozyTextBox.Size = new System.Drawing.Size(200, 20);
            this.poczatek_podrozyTextBox.TabIndex = 12;
            // 
            // cel_podrozyTextBox
            // 
            this.cel_podrozyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tripallBindingSource, "Cel podrozy", true));
            this.cel_podrozyTextBox.Location = new System.Drawing.Point(136, 194);
            this.cel_podrozyTextBox.Name = "cel_podrozyTextBox";
            this.cel_podrozyTextBox.Size = new System.Drawing.Size(200, 20);
            this.cel_podrozyTextBox.TabIndex = 14;
            // 
            // data_DateTimePicker
            // 
            this.data_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tripallBindingSource, "Data ", true));
            this.data_DateTimePicker.Location = new System.Drawing.Point(136, 220);
            this.data_DateTimePicker.Name = "data_DateTimePicker";
            this.data_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_DateTimePicker.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TripsService.Properties.Resources.tło;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tripallDataGridView
            // 
            this.tripallDataGridView.AutoGenerateColumns = false;
            this.tripallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tripallDataGridView.DataSource = this.tripallBindingSource;
            this.tripallDataGridView.Location = new System.Drawing.Point(52, 408);
            this.tripallDataGridView.Name = "tripallDataGridView";
            this.tripallDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tripallDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Imie";
            this.dataGridViewTextBoxColumn1.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Wiek";
            this.dataGridViewTextBoxColumn3.HeaderText = "Wiek";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pesel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pesel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Poczatek podrozy";
            this.dataGridViewTextBoxColumn6.HeaderText = "Poczatek podrozy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cel podrozy";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cel podrozy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data ";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // wyślij
            // 
            this.wyślij.Location = new System.Drawing.Point(191, 366);
            this.wyślij.Name = "wyślij";
            this.wyślij.Size = new System.Drawing.Size(75, 23);
            this.wyślij.TabIndex = 19;
            this.wyślij.Text = "wyślij";
            this.wyślij.UseVisualStyleBackColor = true;
            this.wyślij.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 785);
            this.Controls.Add(this.wyślij);
            this.Controls.Add(this.tripallDataGridView);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(wiekLabel);
            this.Controls.Add(this.wiekTextBox);
            this.Controls.Add(peselLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(poczatek_podrozyLabel);
            this.Controls.Add(this.poczatek_podrozyTextBox);
            this.Controls.Add(cel_podrozyLabel);
            this.Controls.Add(this.cel_podrozyTextBox);
            this.Controls.Add(data_Label);
            this.Controls.Add(this.data_DateTimePicker);
            this.Controls.Add(this.tripallBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_AddTrip";
            this.Text = "Form_AddTrip";
            this.Load += new System.EventHandler(this.Form_AddTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_TripDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallBindingNavigator)).EndInit();
            this.tripallBindingNavigator.ResumeLayout(false);
            this.tripallBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database_TripDataSet database_TripDataSet;
        private System.Windows.Forms.BindingSource tripallBindingSource;
        private Database_TripDataSetTableAdapters.TripallTableAdapter tripallTableAdapter;
        private Database_TripDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tripallBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tripallBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox wiekTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox poczatek_podrozyTextBox;
        private System.Windows.Forms.TextBox cel_podrozyTextBox;
        private System.Windows.Forms.DateTimePicker data_DateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tripallDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button wyślij;
    }
}