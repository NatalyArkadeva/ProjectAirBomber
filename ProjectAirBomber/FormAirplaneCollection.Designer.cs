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
            comboBoxSelectorCompany = new ComboBox();
            buttonRefresh = new Button();
            buttonGoToCheck = new Button();
            buttonRemoveAirplane = new Button();
            maskedTextBox = new MaskedTextBox();
            buttonAddAirBomber = new Button();
            buttonAddAirplane = new Button();
            pictureBox = new PictureBox();
            groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(comboBoxSelectorCompany);
            groupBoxTools.Controls.Add(buttonRefresh);
            groupBoxTools.Controls.Add(buttonGoToCheck);
            groupBoxTools.Controls.Add(buttonRemoveAirplane);
            groupBoxTools.Controls.Add(maskedTextBox);
            groupBoxTools.Controls.Add(buttonAddAirBomber);
            groupBoxTools.Controls.Add(buttonAddAirplane);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(759, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(175, 547);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
            comboBoxSelectorCompany.Location = new Point(6, 22);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(162, 23);
            comboBoxSelectorCompany.TabIndex = 7;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(6, 498);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(163, 43);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGoToCheck.Location = new Point(6, 384);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(163, 43);
            buttonGoToCheck.TabIndex = 5;
            buttonGoToCheck.Text = "Передать на тесты";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonRemoveAirplane
            // 
            buttonRemoveAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveAirplane.Location = new Point(6, 265);
            buttonRemoveAirplane.Name = "buttonRemoveAirplane";
            buttonRemoveAirplane.Size = new Size(163, 43);
            buttonRemoveAirplane.TabIndex = 4;
            buttonRemoveAirplane.Text = "Удалить самолет";
            buttonRemoveAirplane.UseVisualStyleBackColor = true;
            buttonRemoveAirplane.Click += ButtonRemoveAirplane_Click;
            // 
            // maskedTextBox
            // 
            maskedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox.Location = new Point(5, 236);
            maskedTextBox.Mask = "00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(163, 23);
            maskedTextBox.TabIndex = 3;
            maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonAddAirBomber
            // 
            buttonAddAirBomber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddAirBomber.Location = new Point(5, 150);
            buttonAddAirBomber.Name = "buttonAddAirBomber";
            buttonAddAirBomber.Size = new Size(163, 43);
            buttonAddAirBomber.TabIndex = 2;
            buttonAddAirBomber.Text = "Добавление бомбардировщика";
            buttonAddAirBomber.UseVisualStyleBackColor = true;
            buttonAddAirBomber.Click += ButtonAddAirBomber_Click;
            // 
            // buttonAddAirplane
            // 
            buttonAddAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddAirplane.Location = new Point(6, 101);
            buttonAddAirplane.Name = "buttonAddAirplane";
            buttonAddAirplane.Size = new Size(163, 43);
            buttonAddAirplane.TabIndex = 1;
            buttonAddAirplane.Text = "Добавление самолета";
            buttonAddAirplane.UseVisualStyleBackColor = true;
            buttonAddAirplane.Click += ButtonAddAirplane_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(759, 547);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // FormAirplaneCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 547);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Name = "FormAirplaneCollection";
            Text = "Коллекция самолетов";
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTools;
        private Button buttonAddAirBomber;
        private Button buttonAddAirplane;
        private Button buttonRemoveAirplane;
        private MaskedTextBox maskedTextBox;
        private PictureBox pictureBox;
        private Button buttonRefresh;
        private Button buttonGoToCheck;
        private ComboBox comboBoxSelectorCompany;
    }
}