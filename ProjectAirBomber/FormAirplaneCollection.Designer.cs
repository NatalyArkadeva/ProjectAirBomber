namespace ProjectAirBomber
{
    partial class FormAirplaneCollection
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
            groupBoxTools = new GroupBox();
            panelCompanyTools = new Panel();
            buttonAddAirplane = new Button();
            maskedTextBox = new MaskedTextBox();
            buttonRemoveAirplane = new Button();
            buttonRefresh = new Button();
            buttonGoToCheck = new Button();
            buttonCreateCompany = new Button();
            panelStorage = new Panel();
            buttonCollectionDel = new Button();
            listBoxCollection = new ListBox();
            buttonCollectionAdd = new Button();
            radioButtonList = new RadioButton();
            radioButtonMassive = new RadioButton();
            textBoxCollectionName = new TextBox();
            labelCollectionName = new Label();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            groupBoxTools.SuspendLayout();
            panelCompanyTools.SuspendLayout();
            panelStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(panelCompanyTools);
            groupBoxTools.Controls.Add(buttonCreateCompany);
            groupBoxTools.Controls.Add(panelStorage);
            groupBoxTools.Controls.Add(comboBoxSelectorCompany);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(759, 24);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(175, 523);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // panelCompanyTools
            // 
            panelCompanyTools.Controls.Add(buttonAddAirplane);
            panelCompanyTools.Controls.Add(maskedTextBox);
            panelCompanyTools.Controls.Add(buttonRemoveAirplane);
            panelCompanyTools.Controls.Add(buttonRefresh);
            panelCompanyTools.Controls.Add(buttonGoToCheck);
            panelCompanyTools.Dock = DockStyle.Bottom;
            panelCompanyTools.Enabled = false;
            panelCompanyTools.Location = new Point(3, 275);
            panelCompanyTools.Name = "panelCompanyTools";
            panelCompanyTools.Size = new Size(169, 245);
            panelCompanyTools.TabIndex = 9;
            // 
            // buttonAddAirplane
            // 
            buttonAddAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddAirplane.Location = new Point(6, 5);
            buttonAddAirplane.Name = "buttonAddAirplane";
            buttonAddAirplane.Size = new Size(158, 43);
            buttonAddAirplane.TabIndex = 1;
            buttonAddAirplane.Text = "Добавление самолета";
            buttonAddAirplane.UseVisualStyleBackColor = true;
            buttonAddAirplane.Click += ButtonAddAirplane_Click;
            // 
            // maskedTextBox
            // 
            maskedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox.Location = new Point(6, 76);
            maskedTextBox.Mask = "00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(158, 23);
            maskedTextBox.TabIndex = 3;
            maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonRemoveAirplane
            // 
            buttonRemoveAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveAirplane.Location = new Point(6, 105);
            buttonRemoveAirplane.Name = "buttonRemoveAirplane";
            buttonRemoveAirplane.Size = new Size(158, 28);
            buttonRemoveAirplane.TabIndex = 4;
            buttonRemoveAirplane.Text = "Удалить самолет";
            buttonRemoveAirplane.UseVisualStyleBackColor = true;
            buttonRemoveAirplane.Click += ButtonRemoveAirplane_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(6, 186);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(159, 34);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGoToCheck.Location = new Point(6, 139);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(158, 41);
            buttonGoToCheck.TabIndex = 5;
            buttonGoToCheck.Text = "Передать на тесты";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(5, 246);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(162, 23);
            buttonCreateCompany.TabIndex = 7;
            buttonCreateCompany.Text = "Создать компанию";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // panelStorage
            // 
            panelStorage.Controls.Add(buttonCollectionDel);
            panelStorage.Controls.Add(listBoxCollection);
            panelStorage.Controls.Add(buttonCollectionAdd);
            panelStorage.Controls.Add(radioButtonList);
            panelStorage.Controls.Add(radioButtonMassive);
            panelStorage.Controls.Add(textBoxCollectionName);
            panelStorage.Controls.Add(labelCollectionName);
            panelStorage.Dock = DockStyle.Top;
            panelStorage.Location = new Point(3, 19);
            panelStorage.Name = "panelStorage";
            panelStorage.Size = new Size(169, 191);
            panelStorage.TabIndex = 8;
            // 
            // buttonCollectionDel
            // 
            buttonCollectionDel.Location = new Point(3, 165);
            buttonCollectionDel.Name = "buttonCollectionDel";
            buttonCollectionDel.Size = new Size(162, 23);
            buttonCollectionDel.TabIndex = 6;
            buttonCollectionDel.Text = "Удалить коллекцию";
            buttonCollectionDel.UseVisualStyleBackColor = true;
            buttonCollectionDel.Click += buttonCollectionDel_Click;
            // 
            // listBoxCollection
            // 
            listBoxCollection.FormattingEnabled = true;
            listBoxCollection.ItemHeight = 15;
            listBoxCollection.Location = new Point(3, 110);
            listBoxCollection.Name = "listBoxCollection";
            listBoxCollection.Size = new Size(161, 49);
            listBoxCollection.TabIndex = 5;
            // 
            // buttonCollectionAdd
            // 
            buttonCollectionAdd.Location = new Point(2, 81);
            buttonCollectionAdd.Name = "buttonCollectionAdd";
            buttonCollectionAdd.Size = new Size(162, 23);
            buttonCollectionAdd.TabIndex = 4;
            buttonCollectionAdd.Text = "Добавить коллекцию";
            buttonCollectionAdd.UseVisualStyleBackColor = true;
            buttonCollectionAdd.Click += buttonCollectionAdd_Click;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(94, 56);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(66, 19);
            radioButtonList.TabIndex = 3;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(3, 56);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(67, 19);
            radioButtonMassive.TabIndex = 2;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            // 
            // textBoxCollectionName
            // 
            textBoxCollectionName.Location = new Point(3, 27);
            textBoxCollectionName.Name = "textBoxCollectionName";
            textBoxCollectionName.Size = new Size(161, 23);
            textBoxCollectionName.TabIndex = 1;
            // 
            // labelCollectionName
            // 
            labelCollectionName.AutoSize = true;
            labelCollectionName.Location = new Point(22, 9);
            labelCollectionName.Name = "labelCollectionName";
            labelCollectionName.Size = new Size(125, 15);
            labelCollectionName.TabIndex = 0;
            labelCollectionName.Text = "Название коллекции:";
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
            comboBoxSelectorCompany.Location = new Point(5, 217);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(162, 23);
            comboBoxSelectorCompany.TabIndex = 7;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(759, 523);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(934, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 22);
            saveToolStripMenuItem.Text = "Сохранение";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(181, 22);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormAirplaneCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 547);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormAirplaneCollection";
            Text = "Коллекция самолетов";
            groupBoxTools.ResumeLayout(false);
            panelCompanyTools.ResumeLayout(false);
            panelCompanyTools.PerformLayout();
            panelStorage.ResumeLayout(false);
            panelStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTools;
        private Button buttonAddAirplane;
        private Button buttonRemoveAirplane;
        private MaskedTextBox maskedTextBox;
        private PictureBox pictureBox;
        private Button buttonRefresh;
        private Button buttonGoToCheck;
        private ComboBox comboBoxSelectorCompany;
        private Panel panelStorage;
        private RadioButton radioButtonList;
        private RadioButton radioButtonMassive;
        private TextBox textBoxCollectionName;
        private Label labelCollectionName;
        private Button buttonCollectionDel;
        private ListBox listBoxCollection;
        private Button buttonCollectionAdd;
        private Button buttonCreateCompany;
        private Panel panelCompanyTools;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}