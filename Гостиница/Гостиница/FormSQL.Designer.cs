namespace Гостиница
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.radioButtonContracts = new System.Windows.Forms.RadioButton();
            this.radioButtonRooms = new System.Windows.Forms.RadioButton();
            this.radioButtonClients = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.textBoxMinCount = new System.Windows.Forms.TextBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxCategorySub = new System.Windows.Forms.TextBox();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.panelClient = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelFio = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.labelPas = new System.Windows.Forms.Label();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.dataGridViewDML = new System.Windows.Forms.DataGridView();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 421);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 315);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.textBoxCategory);
            this.groupBoxSelect.Controls.Add(this.radioButtonContracts);
            this.groupBoxSelect.Controls.Add(this.radioButtonRooms);
            this.groupBoxSelect.Controls.Add(this.radioButtonClients);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(215, 46);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 22);
            this.textBoxCategory.TabIndex = 3;
            // 
            // radioButtonContracts
            // 
            this.radioButtonContracts.AutoSize = true;
            this.radioButtonContracts.Location = new System.Drawing.Point(21, 74);
            this.radioButtonContracts.Name = "radioButtonContracts";
            this.radioButtonContracts.Size = new System.Drawing.Size(133, 20);
            this.radioButtonContracts.TabIndex = 2;
            this.radioButtonContracts.TabStop = true;
            this.radioButtonContracts.Text = "Договоры (JOIN)";
            this.radioButtonContracts.UseVisualStyleBackColor = true;
            this.radioButtonContracts.CheckedChanged += new System.EventHandler(this.radioButtonContracts_CheckedChanged);
            // 
            // radioButtonRooms
            // 
            this.radioButtonRooms.AutoSize = true;
            this.radioButtonRooms.Location = new System.Drawing.Point(21, 48);
            this.radioButtonRooms.Name = "radioButtonRooms";
            this.radioButtonRooms.Size = new System.Drawing.Size(177, 20);
            this.radioButtonRooms.TabIndex = 1;
            this.radioButtonRooms.TabStop = true;
            this.radioButtonRooms.Text = "Номера (по категории)";
            this.radioButtonRooms.UseVisualStyleBackColor = true;
            this.radioButtonRooms.CheckedChanged += new System.EventHandler(this.radioButtonRooms_CheckedChanged);
            // 
            // radioButtonClients
            // 
            this.radioButtonClients.AutoSize = true;
            this.radioButtonClients.Location = new System.Drawing.Point(21, 22);
            this.radioButtonClients.Name = "radioButtonClients";
            this.radioButtonClients.Size = new System.Drawing.Size(84, 20);
            this.radioButtonClients.TabIndex = 0;
            this.radioButtonClients.TabStop = true;
            this.radioButtonClients.Text = "Клиенты";
            this.radioButtonClients.UseVisualStyleBackColor = true;
            this.radioButtonClients.CheckedChanged += new System.EventHandler(this.radioButtonClients_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 421);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 315);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.textBoxMinCount);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.label1);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Статистика по сотрудникам";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(327, 36);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(179, 47);
            this.buttonF_select.TabIndex = 3;
            this.buttonF_select.Text = "Выполнить";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // textBoxMinCount
            // 
            this.textBoxMinCount.Location = new System.Drawing.Point(172, 22);
            this.textBoxMinCount.Name = "textBoxMinCount";
            this.textBoxMinCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinCount.TabIndex = 2;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(10, 50);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(197, 20);
            this.checkBoxOrder.TabIndex = 1;
            this.checkBoxOrder.Text = "Сортировка по убыванию";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мин. кол-во договоров:";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 421);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxCategorySub);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(344, 57);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(217, 23);
            this.buttonSubquery.TabIndex = 3;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxCategorySub
            // 
            this.textBoxCategorySub.Location = new System.Drawing.Point(344, 19);
            this.textBoxCategorySub.Name = "textBoxCategorySub";
            this.textBoxCategorySub.Size = new System.Drawing.Size(100, 22);
            this.textBoxCategorySub.TabIndex = 2;
            this.textBoxCategorySub.Text = "Люкс";
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 47);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(268, 20);
            this.radioButtonCorrelated.TabIndex = 1;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный (Занятые номера)";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(6, 21);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(304, 20);
            this.radioButtonNoCorrelated.TabIndex = 0;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный (Клиенты с Люксами)";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewDML);
            this.tabPageDML.Controls.Add(this.panelClient);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 421);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonShowAll);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 114);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы (Таблица Клиенты)";
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(6, 21);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(148, 20);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Добавить клиента";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.radioButtonInsert_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(6, 47);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(150, 20);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить клиента";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(6, 73);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(140, 20);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить клиента";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.textBoxTel);
            this.panelClient.Controls.Add(this.labelTel);
            this.panelClient.Controls.Add(this.textBoxPas);
            this.panelClient.Controls.Add(this.labelPas);
            this.panelClient.Controls.Add(this.textBoxFio);
            this.panelClient.Controls.Add(this.labelFio);
            this.panelClient.Controls.Add(this.textBoxId);
            this.panelClient.Controls.Add(this.labelId);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClient.Location = new System.Drawing.Point(3, 117);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(786, 54);
            this.panelClient.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(5, 3);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(88, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Код клиента";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(6, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Location = new System.Drawing.Point(130, 3);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(38, 16);
            this.labelFio.TabIndex = 2;
            this.labelFio.Text = "ФИО";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(133, 22);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(203, 22);
            this.textBoxFio.TabIndex = 3;
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(342, 3);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(63, 16);
            this.labelPas.TabIndex = 4;
            this.labelPas.Text = "Паспорт";
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(345, 22);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(85, 22);
            this.textBoxPas.TabIndex = 5;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(436, 3);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(67, 16);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Телефон";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(439, 22);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(123, 22);
            this.textBoxTel.TabIndex = 7;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(311, 13);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(176, 36);
            this.buttonExecuteDML.TabIndex = 3;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(311, 57);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(176, 36);
            this.buttonShowAll.TabIndex = 4;
            this.buttonShowAll.Text = "Показать всех";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // dataGridViewDML
            // 
            this.dataGridViewDML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDML.Location = new System.Drawing.Point(3, 171);
            this.dataGridViewDML.Name = "dataGridViewDML";
            this.dataGridViewDML.RowHeadersWidth = 51;
            this.dataGridViewDML.RowTemplate.Height = 24;
            this.dataGridViewDML.Size = new System.Drawing.Size(786, 247);
            this.dataGridViewDML.TabIndex = 2;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.RowTemplate.Height = 24;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 315);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonContracts;
        private System.Windows.Forms.RadioButton radioButtonRooms;
        private System.Windows.Forms.RadioButton radioButtonClients;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.TextBox textBoxMinCount;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxCategorySub;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.DataGridView dataGridViewDML;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
    }
}