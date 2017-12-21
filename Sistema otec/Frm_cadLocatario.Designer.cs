namespace Sistema_otec
{
    partial class Frm_cadLocatario
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
            System.Windows.Forms.Label id_locatarioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label identidadeLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label escolaLabel;
            System.Windows.Forms.Label profissaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadLocatario));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.id_locatarioTextBox = new System.Windows.Forms.TextBox();
            this.locatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Sistema_otec.bibliotecaDataSet();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.datanascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.identidadeTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.escolaTextBox = new System.Windows.Forms.TextBox();
            this.profissaoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.locatarioTableAdapter = new Sistema_otec.bibliotecaDataSetTableAdapters.locatarioTableAdapter();
            this.tableAdapterManager = new Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.locatarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.locatarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_locatarioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            identidadeLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            escolaLabel = new System.Windows.Forms.Label();
            profissaoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingNavigator)).BeginInit();
            this.locatarioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_locatarioLabel
            // 
            id_locatarioLabel.AutoSize = true;
            id_locatarioLabel.Location = new System.Drawing.Point(6, 39);
            id_locatarioLabel.Name = "id_locatarioLabel";
            id_locatarioLabel.Size = new System.Drawing.Size(61, 13);
            id_locatarioLabel.TabIndex = 0;
            id_locatarioLabel.Text = "id locatario:";
            id_locatarioLabel.UseWaitCursor = true;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "nome:";
            nomeLabel.UseWaitCursor = true;
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(6, 92);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(54, 13);
            datanascLabel.TabIndex = 4;
            datanascLabel.Text = "datanasc:";
            datanascLabel.UseWaitCursor = true;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(6, 117);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 6;
            enderecoLabel.Text = "endereco:";
            enderecoLabel.UseWaitCursor = true;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(6, 143);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 8;
            bairroLabel.Text = "bairro:";
            bairroLabel.UseWaitCursor = true;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(6, 169);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 10;
            cidadeLabel.Text = "cidade:";
            cidadeLabel.UseWaitCursor = true;
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(6, 196);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 12;
            ufLabel.Text = "uf:";
            ufLabel.UseWaitCursor = true;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(6, 222);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "cep:";
            cepLabel.UseWaitCursor = true;
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(262, 62);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(31, 13);
            foneLabel.TabIndex = 16;
            foneLabel.Text = "fone:";
            foneLabel.UseWaitCursor = true;
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(262, 92);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(28, 13);
            fotoLabel.TabIndex = 18;
            fotoLabel.Text = "foto:";
            fotoLabel.UseWaitCursor = true;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(262, 118);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 20;
            cpfLabel.Text = "cpf:";
            cpfLabel.UseWaitCursor = true;
            // 
            // identidadeLabel
            // 
            identidadeLabel.AutoSize = true;
            identidadeLabel.Location = new System.Drawing.Point(262, 144);
            identidadeLabel.Name = "identidadeLabel";
            identidadeLabel.Size = new System.Drawing.Size(59, 13);
            identidadeLabel.TabIndex = 22;
            identidadeLabel.Text = "identidade:";
            identidadeLabel.UseWaitCursor = true;
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(262, 170);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(32, 13);
            serieLabel.TabIndex = 24;
            serieLabel.Text = "serie:";
            serieLabel.UseWaitCursor = true;
            // 
            // escolaLabel
            // 
            escolaLabel.AutoSize = true;
            escolaLabel.Location = new System.Drawing.Point(262, 196);
            escolaLabel.Name = "escolaLabel";
            escolaLabel.Size = new System.Drawing.Size(41, 13);
            escolaLabel.TabIndex = 26;
            escolaLabel.Text = "escola:";
            escolaLabel.UseWaitCursor = true;
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.Location = new System.Drawing.Point(262, 222);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new System.Drawing.Size(52, 13);
            profissaoLabel.TabIndex = 28;
            profissaoLabel.Text = "profissao:";
            profissaoLabel.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(76, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 277);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.locatarioBindingNavigator);
            this.tabPage1.Controls.Add(id_locatarioLabel);
            this.tabPage1.Controls.Add(this.id_locatarioTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(datanascLabel);
            this.tabPage1.Controls.Add(this.datanascDateTimePicker);
            this.tabPage1.Controls.Add(enderecoLabel);
            this.tabPage1.Controls.Add(this.enderecoTextBox);
            this.tabPage1.Controls.Add(bairroLabel);
            this.tabPage1.Controls.Add(this.bairroTextBox);
            this.tabPage1.Controls.Add(cidadeLabel);
            this.tabPage1.Controls.Add(this.cidadeTextBox);
            this.tabPage1.Controls.Add(ufLabel);
            this.tabPage1.Controls.Add(this.ufTextBox);
            this.tabPage1.Controls.Add(cepLabel);
            this.tabPage1.Controls.Add(this.cepTextBox);
            this.tabPage1.Controls.Add(foneLabel);
            this.tabPage1.Controls.Add(this.foneTextBox);
            this.tabPage1.Controls.Add(fotoLabel);
            this.tabPage1.Controls.Add(this.fotoTextBox);
            this.tabPage1.Controls.Add(cpfLabel);
            this.tabPage1.Controls.Add(this.cpfTextBox);
            this.tabPage1.Controls.Add(identidadeLabel);
            this.tabPage1.Controls.Add(this.identidadeTextBox);
            this.tabPage1.Controls.Add(serieLabel);
            this.tabPage1.Controls.Add(this.serieTextBox);
            this.tabPage1.Controls.Add(escolaLabel);
            this.tabPage1.Controls.Add(this.escolaTextBox);
            this.tabPage1.Controls.Add(profissaoLabel);
            this.tabPage1.Controls.Add(this.profissaoTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // id_locatarioTextBox
            // 
            this.id_locatarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "id_locatario", true));
            this.id_locatarioTextBox.Location = new System.Drawing.Point(73, 36);
            this.id_locatarioTextBox.Name = "id_locatarioTextBox";
            this.id_locatarioTextBox.ReadOnly = true;
            this.id_locatarioTextBox.Size = new System.Drawing.Size(174, 20);
            this.id_locatarioTextBox.TabIndex = 1;
            this.id_locatarioTextBox.UseWaitCursor = true;
            // 
            // locatarioBindingSource
            // 
            this.locatarioBindingSource.DataMember = "locatario";
            this.locatarioBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(73, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(174, 20);
            this.nomeTextBox.TabIndex = 3;
            this.nomeTextBox.UseWaitCursor = true;
            // 
            // datanascDateTimePicker
            // 
            this.datanascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locatarioBindingSource, "datanasc", true));
            this.datanascDateTimePicker.Location = new System.Drawing.Point(73, 88);
            this.datanascDateTimePicker.Name = "datanascDateTimePicker";
            this.datanascDateTimePicker.Size = new System.Drawing.Size(174, 20);
            this.datanascDateTimePicker.TabIndex = 5;
            this.datanascDateTimePicker.UseWaitCursor = true;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(73, 114);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(174, 20);
            this.enderecoTextBox.TabIndex = 7;
            this.enderecoTextBox.UseWaitCursor = true;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(73, 140);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(174, 20);
            this.bairroTextBox.TabIndex = 9;
            this.bairroTextBox.UseWaitCursor = true;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(73, 166);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(174, 20);
            this.cidadeTextBox.TabIndex = 11;
            this.cidadeTextBox.UseWaitCursor = true;
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "uf", true));
            this.ufTextBox.Location = new System.Drawing.Point(73, 193);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(174, 20);
            this.ufTextBox.TabIndex = 13;
            this.ufTextBox.UseWaitCursor = true;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(73, 219);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(174, 20);
            this.cepTextBox.TabIndex = 15;
            this.cepTextBox.UseWaitCursor = true;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(329, 59);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(200, 20);
            this.foneTextBox.TabIndex = 17;
            this.foneTextBox.UseWaitCursor = true;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "foto", true));
            this.fotoTextBox.Location = new System.Drawing.Point(329, 89);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(200, 20);
            this.fotoTextBox.TabIndex = 19;
            this.fotoTextBox.UseWaitCursor = true;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(329, 115);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(200, 20);
            this.cpfTextBox.TabIndex = 21;
            this.cpfTextBox.UseWaitCursor = true;
            // 
            // identidadeTextBox
            // 
            this.identidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "identidade", true));
            this.identidadeTextBox.Location = new System.Drawing.Point(329, 141);
            this.identidadeTextBox.Name = "identidadeTextBox";
            this.identidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.identidadeTextBox.TabIndex = 23;
            this.identidadeTextBox.UseWaitCursor = true;
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "serie", true));
            this.serieTextBox.Location = new System.Drawing.Point(329, 167);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(200, 20);
            this.serieTextBox.TabIndex = 25;
            this.serieTextBox.UseWaitCursor = true;
            // 
            // escolaTextBox
            // 
            this.escolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "escola", true));
            this.escolaTextBox.Location = new System.Drawing.Point(329, 193);
            this.escolaTextBox.Name = "escolaTextBox";
            this.escolaTextBox.Size = new System.Drawing.Size(200, 20);
            this.escolaTextBox.TabIndex = 27;
            this.escolaTextBox.UseWaitCursor = true;
            // 
            // profissaoTextBox
            // 
            this.profissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locatarioBindingSource, "profissao", true));
            this.profissaoTextBox.Location = new System.Drawing.Point(329, 219);
            this.profissaoTextBox.Name = "profissaoTextBox";
            this.profissaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.profissaoTextBox.TabIndex = 29;
            this.profissaoTextBox.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 323);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // locatarioTableAdapter
            // 
            this.locatarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.editoraTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itemLocacaoTableAdapter = null;
            this.tableAdapterManager.livrosTableAdapter = null;
            this.tableAdapterManager.locacaoTableAdapter = null;
            this.tableAdapterManager.locatarioTableAdapter = this.locatarioTableAdapter;
            this.tableAdapterManager.perfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locatarioBindingNavigator
            // 
            this.locatarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locatarioBindingNavigator.BindingSource = this.locatarioBindingSource;
            this.locatarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locatarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locatarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locatarioBindingNavigatorSaveItem});
            this.locatarioBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.locatarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locatarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locatarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locatarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locatarioBindingNavigator.Name = "locatarioBindingNavigator";
            this.locatarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locatarioBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.locatarioBindingNavigator.TabIndex = 30;
            this.locatarioBindingNavigator.Text = "bindingNavigator1";
            this.locatarioBindingNavigator.UseWaitCursor = true;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locatarioBindingNavigatorSaveItem
            // 
            this.locatarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locatarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locatarioBindingNavigatorSaveItem.Image")));
            this.locatarioBindingNavigatorSaveItem.Name = "locatarioBindingNavigatorSaveItem";
            this.locatarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locatarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locatarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.locatarioBindingNavigatorSaveItem_Click_1);
            // 
            // Frm_cadLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cadLocatario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Locatario";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Frm_cadLocatario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingNavigator)).EndInit();
            this.locatarioBindingNavigator.ResumeLayout(false);
            this.locatarioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource locatarioBindingSource;
        private bibliotecaDataSetTableAdapters.locatarioTableAdapter locatarioTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_locatarioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker datanascDateTimePicker;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox identidadeTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox escolaTextBox;
        private System.Windows.Forms.TextBox profissaoTextBox;
        private System.Windows.Forms.BindingNavigator locatarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locatarioBindingNavigatorSaveItem;
    }
}