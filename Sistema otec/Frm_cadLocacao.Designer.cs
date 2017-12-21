namespace Sistema_otec
{
    partial class Frm_cadLocacao
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
            System.Windows.Forms.Label id_locacaoLabel;
            System.Windows.Forms.Label id_locatarioLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label data_saidaLabel;
            System.Windows.Forms.Label data_entregaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadLocacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bibliotecaDataSet = new Sistema_otec.bibliotecaDataSet();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableAdapter = new Sistema_otec.bibliotecaDataSetTableAdapters.locacaoTableAdapter();
            this.tableAdapterManager = new Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.locacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_locacaoTextBox = new System.Windows.Forms.TextBox();
            this.id_locatarioTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_saidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemLocacaoTableAdapter = new Sistema_otec.bibliotecaDataSetTableAdapters.itemLocacaoTableAdapter();
            this.itemLocacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.locacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_locacaoLabel = new System.Windows.Forms.Label();
            id_locatarioLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            data_saidaLabel = new System.Windows.Forms.Label();
            data_entregaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).BeginInit();
            this.locacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(id_locatarioLabel);
            this.groupBox1.Controls.Add(this.id_locatarioTextBox);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(this.horaDateTimePicker);
            this.groupBox1.Controls.Add(data_saidaLabel);
            this.groupBox1.Controls.Add(this.data_saidaDateTimePicker);
            this.groupBox1.Controls.Add(data_entregaLabel);
            this.groupBox1.Controls.Add(this.data_entregaDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(105, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de Locação";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "locacao";
            this.locacaoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.editoraTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itemLocacaoTableAdapter = this.itemLocacaoTableAdapter;
            this.tableAdapterManager.livrosTableAdapter = null;
            this.tableAdapterManager.locacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.locatarioTableAdapter = null;
            this.tableAdapterManager.perfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locacaoBindingNavigator
            // 
            this.locacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoBindingNavigator.BindingSource = this.locacaoBindingSource;
            this.locacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locacaoBindingNavigatorSaveItem});
            this.locacaoBindingNavigator.Location = new System.Drawing.Point(100, 0);
            this.locacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoBindingNavigator.Name = "locacaoBindingNavigator";
            this.locacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoBindingNavigator.Size = new System.Drawing.Size(416, 25);
            this.locacaoBindingNavigator.TabIndex = 2;
            this.locacaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_locacaoLabel
            // 
            id_locacaoLabel.AutoSize = true;
            id_locacaoLabel.Location = new System.Drawing.Point(166, 398);
            id_locacaoLabel.Name = "id_locacaoLabel";
            id_locacaoLabel.Size = new System.Drawing.Size(59, 13);
            id_locacaoLabel.TabIndex = 0;
            id_locacaoLabel.Text = "id locacao:";
            // 
            // id_locacaoTextBox
            // 
            this.id_locacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "id_locacao", true));
            this.id_locacaoTextBox.Location = new System.Drawing.Point(245, 395);
            this.id_locacaoTextBox.Name = "id_locacaoTextBox";
            this.id_locacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_locacaoTextBox.TabIndex = 1;
            // 
            // id_locatarioLabel
            // 
            id_locatarioLabel.AutoSize = true;
            id_locatarioLabel.Location = new System.Drawing.Point(13, 66);
            id_locatarioLabel.Name = "id_locatarioLabel";
            id_locatarioLabel.Size = new System.Drawing.Size(40, 13);
            id_locatarioLabel.TabIndex = 2;
            id_locatarioLabel.Text = "Codigo";
            // 
            // id_locatarioTextBox
            // 
            this.id_locatarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "id_locatario", true));
            this.id_locatarioTextBox.Location = new System.Drawing.Point(10, 82);
            this.id_locatarioTextBox.Name = "id_locatarioTextBox";
            this.id_locatarioTextBox.Size = new System.Drawing.Size(110, 20);
            this.id_locatarioTextBox.TabIndex = 3;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(137, 23);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 6;
            horaLabel.Text = "Hora:";
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaDateTimePicker.Location = new System.Drawing.Point(136, 39);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.ShowUpDown = true;
            this.horaDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.horaDateTimePicker.TabIndex = 7;
            this.horaDateTimePicker.ValueChanged += new System.EventHandler(this.horaDateTimePicker_ValueChanged);
            // 
            // data_saidaLabel
            // 
            data_saidaLabel.AutoSize = true;
            data_saidaLabel.Location = new System.Drawing.Point(7, 23);
            data_saidaLabel.Name = "data_saidaLabel";
            data_saidaLabel.Size = new System.Drawing.Size(89, 13);
            data_saidaLabel.TabIndex = 8;
            data_saidaLabel.Text = "Data de locação:";
            // 
            // data_saidaDateTimePicker
            // 
            this.data_saidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "data_saida", true));
            this.data_saidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_saidaDateTimePicker.Location = new System.Drawing.Point(10, 39);
            this.data_saidaDateTimePicker.Name = "data_saidaDateTimePicker";
            this.data_saidaDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.data_saidaDateTimePicker.TabIndex = 9;
            // 
            // data_entregaLabel
            // 
            data_entregaLabel.AutoSize = true;
            data_entregaLabel.Location = new System.Drawing.Point(265, 23);
            data_entregaLabel.Name = "data_entregaLabel";
            data_entregaLabel.Size = new System.Drawing.Size(101, 13);
            data_entregaLabel.TabIndex = 10;
            data_entregaLabel.Text = "Data de devolução:";
            // 
            // data_entregaDateTimePicker
            // 
            this.data_entregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "data_entrega", true));
            this.data_entregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_entregaDateTimePicker.Location = new System.Drawing.Point(268, 39);
            this.data_entregaDateTimePicker.Name = "data_entregaDateTimePicker";
            this.data_entregaDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.data_entregaDateTimePicker.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Locatario";
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // itemLocacaoDataGridView
            // 
            this.itemLocacaoDataGridView.AutoGenerateColumns = false;
            this.itemLocacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemLocacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemLocacaoDataGridView.DataSource = this.itemLocacaoBindingSource;
            this.itemLocacaoDataGridView.Location = new System.Drawing.Point(106, 208);
            this.itemLocacaoDataGridView.Name = "itemLocacaoDataGridView";
            this.itemLocacaoDataGridView.Size = new System.Drawing.Size(390, 171);
            this.itemLocacaoDataGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(110, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo do livro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = global::Sistema_otec.Properties.Resources.Remove;
            this.button2.Location = new System.Drawing.Point(296, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 35);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_otec.Properties.Resources.Add;
            this.button1.Location = new System.Drawing.Point(257, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 35);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_item";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_locacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_locacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_livro";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_livro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_devolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_devolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // itemLocacaoBindingSource
            // 
            this.itemLocacaoBindingSource.DataMember = "locacaoitemLocacao";
            this.itemLocacaoBindingSource.DataSource = this.locacaoBindingSource;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // locacaoBindingNavigatorSaveItem
            // 
            this.locacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoBindingNavigatorSaveItem.Image")));
            this.locacaoBindingNavigatorSaveItem.Name = "locacaoBindingNavigatorSaveItem";
            this.locacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_cadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemLocacaoDataGridView);
            this.Controls.Add(id_locacaoLabel);
            this.Controls.Add(this.locacaoBindingNavigator);
            this.Controls.Add(this.id_locacaoTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cadLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_cadLocacao";
            this.Load += new System.EventHandler(this.Frm_cadLocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).EndInit();
            this.locacaoBindingNavigator.ResumeLayout(false);
            this.locacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private bibliotecaDataSetTableAdapters.locacaoTableAdapter locacaoTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_locacaoTextBox;
        private System.Windows.Forms.TextBox id_locatarioTextBox;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_saidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_entregaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bibliotecaDataSetTableAdapters.itemLocacaoTableAdapter itemLocacaoTableAdapter;
        private System.Windows.Forms.BindingSource itemLocacaoBindingSource;
        private System.Windows.Forms.DataGridView itemLocacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}