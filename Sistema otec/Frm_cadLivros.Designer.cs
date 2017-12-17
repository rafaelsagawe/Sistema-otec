namespace Sistema_otec
{
    partial class Frm_cadLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadLivros));
            System.Windows.Forms.Label id_livroLabel;
            System.Windows.Forms.Label id_editoraLabel;
            System.Windows.Forms.Label titularLabel;
            System.Windows.Forms.Label edicaoLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label isbnLabel;
            System.Windows.Forms.Label localizacaoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label classificacaoLabel;
            System.Windows.Forms.Label colecaoLabel;
            System.Windows.Forms.Label tomboLabel;
            System.Windows.Forms.Label capaLabel;
            System.Windows.Forms.Label resenhaLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label comentariosLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bibliotecaDataSet = new Sistema_otec.bibliotecaDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new Sistema_otec.bibliotecaDataSetTableAdapters.livrosTableAdapter();
            this.tableAdapterManager = new Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.livrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.livrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_livroTextBox = new System.Windows.Forms.TextBox();
            this.id_editoraTextBox = new System.Windows.Forms.TextBox();
            this.titularTextBox = new System.Windows.Forms.TextBox();
            this.edicaoTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.localizacaoTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.classificacaoTextBox = new System.Windows.Forms.TextBox();
            this.colecaoTextBox = new System.Windows.Forms.TextBox();
            this.tomboCheckBox = new System.Windows.Forms.CheckBox();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.resenhaTextBox = new System.Windows.Forms.TextBox();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            id_livroLabel = new System.Windows.Forms.Label();
            id_editoraLabel = new System.Windows.Forms.Label();
            titularLabel = new System.Windows.Forms.Label();
            edicaoLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            isbnLabel = new System.Windows.Forms.Label();
            localizacaoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            classificacaoLabel = new System.Windows.Forms.Label();
            colecaoLabel = new System.Windows.Forms.Label();
            tomboLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            resenhaLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).BeginInit();
            this.livrosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 432);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(105, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 363);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(id_livroLabel);
            this.tabPage1.Controls.Add(this.id_livroTextBox);
            this.tabPage1.Controls.Add(id_editoraLabel);
            this.tabPage1.Controls.Add(this.id_editoraTextBox);
            this.tabPage1.Controls.Add(titularLabel);
            this.tabPage1.Controls.Add(this.titularTextBox);
            this.tabPage1.Controls.Add(edicaoLabel);
            this.tabPage1.Controls.Add(this.edicaoTextBox);
            this.tabPage1.Controls.Add(anoLabel);
            this.tabPage1.Controls.Add(this.anoTextBox);
            this.tabPage1.Controls.Add(isbnLabel);
            this.tabPage1.Controls.Add(this.isbnTextBox);
            this.tabPage1.Controls.Add(localizacaoLabel);
            this.tabPage1.Controls.Add(this.localizacaoTextBox);
            this.tabPage1.Controls.Add(assuntoLabel);
            this.tabPage1.Controls.Add(this.assuntoTextBox);
            this.tabPage1.Controls.Add(classificacaoLabel);
            this.tabPage1.Controls.Add(this.classificacaoTextBox);
            this.tabPage1.Controls.Add(colecaoLabel);
            this.tabPage1.Controls.Add(this.colecaoTextBox);
            this.tabPage1.Controls.Add(tomboLabel);
            this.tabPage1.Controls.Add(this.tomboCheckBox);
            this.tabPage1.Controls.Add(capaLabel);
            this.tabPage1.Controls.Add(this.capaTextBox);
            this.tabPage1.Controls.Add(resenhaLabel);
            this.tabPage1.Controls.Add(this.resenhaTextBox);
            this.tabPage1.Controls.Add(autoresLabel);
            this.tabPage1.Controls.Add(this.autoresTextBox);
            this.tabPage1.Controls.Add(comentariosLabel);
            this.tabPage1.Controls.Add(this.comentariosTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(583, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imagem da Capa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.editoraTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itemLocacaoTableAdapter = null;
            this.tableAdapterManager.livrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.locacaoTableAdapter = null;
            this.tableAdapterManager.locatarioTableAdapter = null;
            this.tableAdapterManager.perfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_otec.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livrosBindingNavigator
            // 
            this.livrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livrosBindingNavigator.BindingSource = this.livrosBindingSource;
            this.livrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.livrosBindingNavigatorSaveItem});
            this.livrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livrosBindingNavigator.Name = "livrosBindingNavigator";
            this.livrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livrosBindingNavigator.Size = new System.Drawing.Size(700, 25);
            this.livrosBindingNavigator.TabIndex = 4;
            this.livrosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // livrosBindingNavigatorSaveItem
            // 
            this.livrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosBindingNavigatorSaveItem.Image")));
            this.livrosBindingNavigatorSaveItem.Name = "livrosBindingNavigatorSaveItem";
            this.livrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.livrosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.livrosBindingNavigatorSaveItem_Click_1);
            // 
            // id_livroLabel
            // 
            id_livroLabel.AutoSize = true;
            id_livroLabel.Location = new System.Drawing.Point(44, 16);
            id_livroLabel.Name = "id_livroLabel";
            id_livroLabel.Size = new System.Drawing.Size(40, 13);
            id_livroLabel.TabIndex = 0;
            id_livroLabel.Text = "id livro:";
            // 
            // id_livroTextBox
            // 
            this.id_livroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "id_livro", true));
            this.id_livroTextBox.Location = new System.Drawing.Point(121, 13);
            this.id_livroTextBox.Name = "id_livroTextBox";
            this.id_livroTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_livroTextBox.TabIndex = 1;
            // 
            // id_editoraLabel
            // 
            id_editoraLabel.AutoSize = true;
            id_editoraLabel.Location = new System.Drawing.Point(44, 42);
            id_editoraLabel.Name = "id_editoraLabel";
            id_editoraLabel.Size = new System.Drawing.Size(53, 13);
            id_editoraLabel.TabIndex = 2;
            id_editoraLabel.Text = "id editora:";
            // 
            // id_editoraTextBox
            // 
            this.id_editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "id_editora", true));
            this.id_editoraTextBox.Location = new System.Drawing.Point(121, 39);
            this.id_editoraTextBox.Name = "id_editoraTextBox";
            this.id_editoraTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_editoraTextBox.TabIndex = 3;
            // 
            // titularLabel
            // 
            titularLabel.AutoSize = true;
            titularLabel.Location = new System.Drawing.Point(44, 68);
            titularLabel.Name = "titularLabel";
            titularLabel.Size = new System.Drawing.Size(35, 13);
            titularLabel.TabIndex = 4;
            titularLabel.Text = "titular:";
            // 
            // titularTextBox
            // 
            this.titularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "titular", true));
            this.titularTextBox.Location = new System.Drawing.Point(121, 65);
            this.titularTextBox.Name = "titularTextBox";
            this.titularTextBox.Size = new System.Drawing.Size(104, 20);
            this.titularTextBox.TabIndex = 5;
            // 
            // edicaoLabel
            // 
            edicaoLabel.AutoSize = true;
            edicaoLabel.Location = new System.Drawing.Point(44, 94);
            edicaoLabel.Name = "edicaoLabel";
            edicaoLabel.Size = new System.Drawing.Size(42, 13);
            edicaoLabel.TabIndex = 6;
            edicaoLabel.Text = "edicao:";
            // 
            // edicaoTextBox
            // 
            this.edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "edicao", true));
            this.edicaoTextBox.Location = new System.Drawing.Point(121, 91);
            this.edicaoTextBox.Name = "edicaoTextBox";
            this.edicaoTextBox.Size = new System.Drawing.Size(104, 20);
            this.edicaoTextBox.TabIndex = 7;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(44, 120);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(28, 13);
            anoLabel.TabIndex = 8;
            anoLabel.Text = "ano:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(121, 117);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(104, 20);
            this.anoTextBox.TabIndex = 9;
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new System.Drawing.Point(44, 146);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new System.Drawing.Size(29, 13);
            isbnLabel.TabIndex = 10;
            isbnLabel.Text = "isbn:";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "isbn", true));
            this.isbnTextBox.Location = new System.Drawing.Point(121, 143);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(104, 20);
            this.isbnTextBox.TabIndex = 11;
            // 
            // localizacaoLabel
            // 
            localizacaoLabel.AutoSize = true;
            localizacaoLabel.Location = new System.Drawing.Point(44, 172);
            localizacaoLabel.Name = "localizacaoLabel";
            localizacaoLabel.Size = new System.Drawing.Size(63, 13);
            localizacaoLabel.TabIndex = 12;
            localizacaoLabel.Text = "localizacao:";
            // 
            // localizacaoTextBox
            // 
            this.localizacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "localizacao", true));
            this.localizacaoTextBox.Location = new System.Drawing.Point(121, 169);
            this.localizacaoTextBox.Name = "localizacaoTextBox";
            this.localizacaoTextBox.Size = new System.Drawing.Size(104, 20);
            this.localizacaoTextBox.TabIndex = 13;
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(44, 198);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(47, 13);
            assuntoLabel.TabIndex = 14;
            assuntoLabel.Text = "assunto:";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(121, 195);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(104, 20);
            this.assuntoTextBox.TabIndex = 15;
            // 
            // classificacaoLabel
            // 
            classificacaoLabel.AutoSize = true;
            classificacaoLabel.Location = new System.Drawing.Point(44, 224);
            classificacaoLabel.Name = "classificacaoLabel";
            classificacaoLabel.Size = new System.Drawing.Size(71, 13);
            classificacaoLabel.TabIndex = 16;
            classificacaoLabel.Text = "classificacao:";
            // 
            // classificacaoTextBox
            // 
            this.classificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "classificacao", true));
            this.classificacaoTextBox.Location = new System.Drawing.Point(121, 221);
            this.classificacaoTextBox.Name = "classificacaoTextBox";
            this.classificacaoTextBox.Size = new System.Drawing.Size(104, 20);
            this.classificacaoTextBox.TabIndex = 17;
            // 
            // colecaoLabel
            // 
            colecaoLabel.AutoSize = true;
            colecaoLabel.Location = new System.Drawing.Point(44, 250);
            colecaoLabel.Name = "colecaoLabel";
            colecaoLabel.Size = new System.Drawing.Size(48, 13);
            colecaoLabel.TabIndex = 18;
            colecaoLabel.Text = "colecao:";
            // 
            // colecaoTextBox
            // 
            this.colecaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "colecao", true));
            this.colecaoTextBox.Location = new System.Drawing.Point(121, 247);
            this.colecaoTextBox.Name = "colecaoTextBox";
            this.colecaoTextBox.Size = new System.Drawing.Size(104, 20);
            this.colecaoTextBox.TabIndex = 19;
            // 
            // tomboLabel
            // 
            tomboLabel.AutoSize = true;
            tomboLabel.Location = new System.Drawing.Point(44, 278);
            tomboLabel.Name = "tomboLabel";
            tomboLabel.Size = new System.Drawing.Size(39, 13);
            tomboLabel.TabIndex = 20;
            tomboLabel.Text = "tombo:";
            // 
            // tomboCheckBox
            // 
            this.tomboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.livrosBindingSource, "tombo", true));
            this.tomboCheckBox.Location = new System.Drawing.Point(121, 273);
            this.tomboCheckBox.Name = "tomboCheckBox";
            this.tomboCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tomboCheckBox.TabIndex = 21;
            this.tomboCheckBox.Text = "checkBox1";
            this.tomboCheckBox.UseVisualStyleBackColor = true;
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Location = new System.Drawing.Point(44, 306);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(34, 13);
            capaLabel.TabIndex = 22;
            capaLabel.Text = "capa:";
            // 
            // capaTextBox
            // 
            this.capaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "capa", true));
            this.capaTextBox.Location = new System.Drawing.Point(121, 303);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(104, 20);
            this.capaTextBox.TabIndex = 23;
            // 
            // resenhaLabel
            // 
            resenhaLabel.AutoSize = true;
            resenhaLabel.Location = new System.Drawing.Point(44, 332);
            resenhaLabel.Name = "resenhaLabel";
            resenhaLabel.Size = new System.Drawing.Size(48, 13);
            resenhaLabel.TabIndex = 24;
            resenhaLabel.Text = "resenha:";
            // 
            // resenhaTextBox
            // 
            this.resenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "resenha", true));
            this.resenhaTextBox.Location = new System.Drawing.Point(121, 329);
            this.resenhaTextBox.Name = "resenhaTextBox";
            this.resenhaTextBox.Size = new System.Drawing.Size(104, 20);
            this.resenhaTextBox.TabIndex = 25;
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(44, 358);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(45, 13);
            autoresLabel.TabIndex = 26;
            autoresLabel.Text = "autores:";
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "autores", true));
            this.autoresTextBox.Location = new System.Drawing.Point(121, 355);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(104, 20);
            this.autoresTextBox.TabIndex = 27;
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(44, 384);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(67, 13);
            comentariosLabel.TabIndex = 28;
            comentariosLabel.Text = "comentarios:";
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "comentarios", true));
            this.comentariosTextBox.Location = new System.Drawing.Point(121, 381);
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(104, 20);
            this.comentariosTextBox.TabIndex = 29;
            // 
            // Frm_cadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 431);
            this.Controls.Add(this.livrosBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cadLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_cadLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).EndInit();
            this.livrosBindingNavigator.ResumeLayout(false);
            this.livrosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private bibliotecaDataSetTableAdapters.livrosTableAdapter livrosTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livrosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton livrosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_livroTextBox;
        private System.Windows.Forms.TextBox id_editoraTextBox;
        private System.Windows.Forms.TextBox titularTextBox;
        private System.Windows.Forms.TextBox edicaoTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox localizacaoTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox classificacaoTextBox;
        private System.Windows.Forms.TextBox colecaoTextBox;
        private System.Windows.Forms.CheckBox tomboCheckBox;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.TextBox resenhaTextBox;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.TextBox comentariosTextBox;
    }
}