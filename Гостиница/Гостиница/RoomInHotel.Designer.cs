namespace Гостиница
{
    partial class RoomInHotel
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
            System.Windows.Forms.Label room_idLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label этажLabel;
            System.Windows.Forms.Label фотографияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInHotel));
            System.Windows.Forms.Label категорияLabel1;
            this.гостиницаDataSet = new Гостиница.ГостиницаDataSet();
            this.номера_в_гостиницеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номера_в_гостиницеTableAdapter = new Гостиница.ГостиницаDataSetTableAdapters.Номера_в_гостиницеTableAdapter();
            this.tableAdapterManager = new Гостиница.ГостиницаDataSetTableAdapters.TableAdapterManager();
            this.номера_в_гостиницеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.номера_в_гостиницеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.room_idTextBox = new System.Windows.Forms.TextBox();
            this.статусCheckBox = new System.Windows.Forms.CheckBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.этажTextBox = new System.Windows.Forms.TextBox();
            this.фотографияPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.категорияComboBox = new System.Windows.Forms.ComboBox();
            room_idLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            этажLabel = new System.Windows.Forms.Label();
            фотографияLabel = new System.Windows.Forms.Label();
            категорияLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номера_в_гостиницеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номера_в_гостиницеBindingNavigator)).BeginInit();
            this.номера_в_гостиницеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // room_idLabel
            // 
            room_idLabel.AutoSize = true;
            room_idLabel.Location = new System.Drawing.Point(12, 38);
            room_idLabel.Name = "room_idLabel";
            room_idLabel.Size = new System.Drawing.Size(55, 16);
            room_idLabel.TabIndex = 1;
            room_idLabel.Text = "room id:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(12, 96);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(56, 16);
            статусLabel.TabIndex = 5;
            статусLabel.Text = "Статус:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(12, 160);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 7;
            описаниеLabel.Text = "Описание:";
            // 
            // этажLabel
            // 
            этажLabel.AutoSize = true;
            этажLabel.Location = new System.Drawing.Point(12, 127);
            этажLabel.Name = "этажLabel";
            этажLabel.Size = new System.Drawing.Size(44, 16);
            этажLabel.TabIndex = 9;
            этажLabel.Text = "Этаж:";
            // 
            // фотографияLabel
            // 
            фотографияLabel.AutoSize = true;
            фотографияLabel.Location = new System.Drawing.Point(398, 41);
            фотографияLabel.Name = "фотографияLabel";
            фотографияLabel.Size = new System.Drawing.Size(92, 16);
            фотографияLabel.TabIndex = 11;
            фотографияLabel.Text = "Фотография:";
            // 
            // гостиницаDataSet
            // 
            this.гостиницаDataSet.DataSetName = "ГостиницаDataSet";
            this.гостиницаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // номера_в_гостиницеBindingSource
            // 
            this.номера_в_гостиницеBindingSource.DataMember = "Номера в гостинице";
            this.номера_в_гостиницеBindingSource.DataSource = this.гостиницаDataSet;
            // 
            // номера_в_гостиницеTableAdapter
            // 
            this.номера_в_гостиницеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Гостиница.ГостиницаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговорыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Номера_в_гостиницеTableAdapter = this.номера_в_гостиницеTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // номера_в_гостиницеBindingNavigator
            // 
            this.номера_в_гостиницеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.номера_в_гостиницеBindingNavigator.BindingSource = this.номера_в_гостиницеBindingSource;
            this.номера_в_гостиницеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.номера_в_гостиницеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.номера_в_гостиницеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.номера_в_гостиницеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.номера_в_гостиницеBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.номера_в_гостиницеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.номера_в_гостиницеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.номера_в_гостиницеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.номера_в_гостиницеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.номера_в_гостиницеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.номера_в_гостиницеBindingNavigator.Name = "номера_в_гостиницеBindingNavigator";
            this.номера_в_гостиницеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.номера_в_гостиницеBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.номера_в_гостиницеBindingNavigator.TabIndex = 0;
            this.номера_в_гостиницеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // номера_в_гостиницеBindingNavigatorSaveItem
            // 
            this.номера_в_гостиницеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.номера_в_гостиницеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("номера_в_гостиницеBindingNavigatorSaveItem.Image")));
            this.номера_в_гостиницеBindingNavigatorSaveItem.Name = "номера_в_гостиницеBindingNavigatorSaveItem";
            this.номера_в_гостиницеBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.номера_в_гостиницеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.номера_в_гостиницеBindingNavigatorSaveItem.Click += new System.EventHandler(this.номера_в_гостиницеBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Гостиница.Properties.Resources.free_icon_hotel_5140130;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Tag = "";
            this.toolStripButton1.Text = "Выбрать";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // room_idTextBox
            // 
            this.room_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номера_в_гостиницеBindingSource, "room_id", true));
            this.room_idTextBox.Location = new System.Drawing.Point(110, 35);
            this.room_idTextBox.Name = "room_idTextBox";
            this.room_idTextBox.Size = new System.Drawing.Size(104, 22);
            this.room_idTextBox.TabIndex = 2;
            // 
            // статусCheckBox
            // 
            this.статусCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.номера_в_гостиницеBindingSource, "Статус", true));
            this.статусCheckBox.Location = new System.Drawing.Point(110, 91);
            this.статусCheckBox.Name = "статусCheckBox";
            this.статусCheckBox.Size = new System.Drawing.Size(104, 24);
            this.статусCheckBox.TabIndex = 6;
            this.статусCheckBox.UseVisualStyleBackColor = true;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номера_в_гостиницеBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(110, 160);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(240, 201);
            this.описаниеTextBox.TabIndex = 8;
            // 
            // этажTextBox
            // 
            this.этажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номера_в_гостиницеBindingSource, "Этаж", true));
            this.этажTextBox.Location = new System.Drawing.Point(110, 124);
            this.этажTextBox.Name = "этажTextBox";
            this.этажTextBox.Size = new System.Drawing.Size(104, 22);
            this.этажTextBox.TabIndex = 10;
            // 
            // фотографияPictureBox
            // 
            this.фотографияPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.номера_в_гостиницеBindingSource, "Фотография", true));
            this.фотографияPictureBox.Location = new System.Drawing.Point(401, 66);
            this.фотографияPictureBox.Name = "фотографияPictureBox";
            this.фотографияPictureBox.Size = new System.Drawing.Size(349, 295);
            this.фотографияPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотографияPictureBox.TabIndex = 12;
            this.фотографияPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Открыть фото";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // категорияLabel1
            // 
            категорияLabel1.AutoSize = true;
            категорияLabel1.Location = new System.Drawing.Point(12, 66);
            категорияLabel1.Name = "категорияLabel1";
            категорияLabel1.Size = new System.Drawing.Size(78, 16);
            категорияLabel1.TabIndex = 14;
            категорияLabel1.Text = "Категория:";
            // 
            // категорияComboBox
            // 
            this.категорияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номера_в_гостиницеBindingSource, "Категория", true));
            this.категорияComboBox.FormattingEnabled = true;
            this.категорияComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Супериор",
            "Люкс улучшенный"});
            this.категорияComboBox.Location = new System.Drawing.Point(110, 63);
            this.категорияComboBox.Name = "категорияComboBox";
            this.категорияComboBox.Size = new System.Drawing.Size(121, 24);
            this.категорияComboBox.TabIndex = 15;
            // 
            // RoomInHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(категорияLabel1);
            this.Controls.Add(this.категорияComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(room_idLabel);
            this.Controls.Add(this.room_idTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусCheckBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(этажLabel);
            this.Controls.Add(this.этажTextBox);
            this.Controls.Add(фотографияLabel);
            this.Controls.Add(this.фотографияPictureBox);
            this.Controls.Add(this.номера_в_гостиницеBindingNavigator);
            this.Name = "RoomInHotel";
            this.Text = "RoomInHotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.RoomInHotel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номера_в_гостиницеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номера_в_гостиницеBindingNavigator)).EndInit();
            this.номера_в_гостиницеBindingNavigator.ResumeLayout(false);
            this.номера_в_гостиницеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГостиницаDataSet гостиницаDataSet;
        private System.Windows.Forms.BindingSource номера_в_гостиницеBindingSource;
        private ГостиницаDataSetTableAdapters.Номера_в_гостиницеTableAdapter номера_в_гостиницеTableAdapter;
        private ГостиницаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator номера_в_гостиницеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton номера_в_гостиницеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox room_idTextBox;
        private System.Windows.Forms.CheckBox статусCheckBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox этажTextBox;
        private System.Windows.Forms.PictureBox фотографияPictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.ComboBox категорияComboBox;
    }
}