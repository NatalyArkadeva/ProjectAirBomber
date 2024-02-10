namespace ProjectAirBomber
{
    partial class FormAirplaneConfig
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
            groupBoxConfig = new GroupBox();
            groupBoxColors = new GroupBox();
            panelWhite = new Panel();
            panelBlack = new Panel();
            panelCyan = new Panel();
            panelBlue = new Panel();
            panelLime = new Panel();
            panelFuchsia = new Panel();
            panelYellow = new Panel();
            panelRed = new Panel();
            checkBoxExtraFuelTank = new CheckBox();
            checkBoxAircraftBomb = new CheckBox();
            checkBoxAirRefueling = new CheckBox();
            numericUpDownWeight = new NumericUpDown();
            labelWeigth = new Label();
            numericUpDownSpeed = new NumericUpDown();
            labelSpeed = new Label();
            labelModifiedObject = new Label();
            labelSimpleObject = new Label();
            pictureBoxObject = new PictureBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            panelObject = new Panel();
            labelAdditionalColor = new Label();
            labelBodyColor = new Label();
            groupBoxConfig.SuspendLayout();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            panelObject.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(groupBoxColors);
            groupBoxConfig.Controls.Add(checkBoxExtraFuelTank);
            groupBoxConfig.Controls.Add(checkBoxAircraftBomb);
            groupBoxConfig.Controls.Add(checkBoxAirRefueling);
            groupBoxConfig.Controls.Add(numericUpDownWeight);
            groupBoxConfig.Controls.Add(labelWeigth);
            groupBoxConfig.Controls.Add(numericUpDownSpeed);
            groupBoxConfig.Controls.Add(labelSpeed);
            groupBoxConfig.Controls.Add(labelModifiedObject);
            groupBoxConfig.Controls.Add(labelSimpleObject);
            groupBoxConfig.Dock = DockStyle.Left;
            groupBoxConfig.Location = new Point(0, 0);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(519, 204);
            groupBoxConfig.TabIndex = 0;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Параметры";
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelWhite);
            groupBoxColors.Controls.Add(panelBlack);
            groupBoxColors.Controls.Add(panelCyan);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelLime);
            groupBoxColors.Controls.Add(panelFuchsia);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Location = new Point(282, 27);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(223, 122);
            groupBoxColors.TabIndex = 9;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Цвета";
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(172, 75);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(34, 30);
            panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(121, 75);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(34, 30);
            panelBlack.TabIndex = 1;
            // 
            // panelCyan
            // 
            panelCyan.BackColor = Color.Cyan;
            panelCyan.Location = new Point(70, 75);
            panelCyan.Name = "panelCyan";
            panelCyan.Size = new Size(34, 30);
            panelCyan.TabIndex = 1;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(172, 35);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(34, 30);
            panelBlue.TabIndex = 1;
            // 
            // panelLime
            // 
            panelLime.BackColor = Color.Lime;
            panelLime.Location = new Point(121, 35);
            panelLime.Name = "panelLime";
            panelLime.Size = new Size(34, 30);
            panelLime.TabIndex = 1;
            // 
            // panelFuchsia
            // 
            panelFuchsia.BackColor = Color.Fuchsia;
            panelFuchsia.Location = new Point(21, 75);
            panelFuchsia.Name = "panelFuchsia";
            panelFuchsia.Size = new Size(34, 30);
            panelFuchsia.TabIndex = 1;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(70, 35);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(34, 30);
            panelYellow.TabIndex = 1;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(21, 35);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(34, 30);
            panelRed.TabIndex = 0;
            panelRed.MouseDown += Panel_MouseDown;
            // 
            // checkBoxExtraFuelTank
            // 
            checkBoxExtraFuelTank.AutoSize = true;
            checkBoxExtraFuelTank.Location = new Point(6, 173);
            checkBoxExtraFuelTank.Name = "checkBoxExtraFuelTank";
            checkBoxExtraFuelTank.Size = new Size(270, 19);
            checkBoxExtraFuelTank.TabIndex = 8;
            checkBoxExtraFuelTank.Text = "Наличие дополнительных товливных баков";
            checkBoxExtraFuelTank.UseVisualStyleBackColor = true;
            // 
            // checkBoxAircraftBomb
            // 
            checkBoxAircraftBomb.AutoSize = true;
            checkBoxAircraftBomb.Location = new Point(6, 102);
            checkBoxAircraftBomb.Name = "checkBoxAircraftBomb";
            checkBoxAircraftBomb.Size = new Size(142, 19);
            checkBoxAircraftBomb.TabIndex = 7;
            checkBoxAircraftBomb.Text = "Наличие авиабомбы";
            checkBoxAircraftBomb.UseVisualStyleBackColor = true;
            // 
            // checkBoxAirRefueling
            // 
            checkBoxAirRefueling.AutoSize = true;
            checkBoxAirRefueling.Location = new Point(6, 137);
            checkBoxAirRefueling.Name = "checkBoxAirRefueling";
            checkBoxAirRefueling.Size = new Size(195, 19);
            checkBoxAirRefueling.TabIndex = 6;
            checkBoxAirRefueling.Text = "Наличие дозаправки в воздухе";
            checkBoxAirRefueling.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(74, 58);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(71, 23);
            numericUpDownWeight.TabIndex = 5;
            numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelWeigth
            // 
            labelWeigth.AutoSize = true;
            labelWeigth.Location = new Point(6, 58);
            labelWeigth.Name = "labelWeigth";
            labelWeigth.Size = new Size(29, 15);
            labelWeigth.TabIndex = 4;
            labelWeigth.Text = "Вес:";
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(74, 27);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(71, 23);
            numericUpDownSpeed.TabIndex = 3;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(6, 29);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(62, 15);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорость:";
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(405, 155);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(100, 37);
            labelModifiedObject.TabIndex = 1;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(282, 155);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(100, 37);
            labelSimpleObject.TabIndex = 0;
            labelSimpleObject.Text = "Простой";
            labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
            labelSimpleObject.MouseDown += LabelObject_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(46, 41);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(142, 119);
            pictureBoxObject.TabIndex = 1;
            pictureBoxObject.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(554, 169);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(661, 169);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelObject
            // 
            panelObject.AllowDrop = true;
            panelObject.Controls.Add(labelAdditionalColor);
            panelObject.Controls.Add(pictureBoxObject);
            panelObject.Controls.Add(labelBodyColor);
            panelObject.Location = new Point(525, 0);
            panelObject.Name = "panelObject";
            panelObject.Size = new Size(232, 163);
            panelObject.TabIndex = 4;
            panelObject.DragDrop += PanelObject_DragDrop;
            panelObject.DragEnter += PanelObject_DragEnter;
            // 
            // labelAdditionalColor
            // 
            labelAdditionalColor.AllowDrop = true;
            labelAdditionalColor.Anchor = AnchorStyles.Top;
            labelAdditionalColor.BorderStyle = BorderStyle.FixedSingle;
            labelAdditionalColor.Image = Properties.Resources.background;
            labelAdditionalColor.Location = new Point(136, 9);
            labelAdditionalColor.Name = "labelAdditionalColor";
            labelAdditionalColor.Size = new Size(75, 26);
            labelAdditionalColor.TabIndex = 11;
            labelAdditionalColor.Text = "Доп. цвет";
            labelAdditionalColor.TextAlign = ContentAlignment.MiddleCenter;
            labelAdditionalColor.DragDrop += labelColor_DragDrop;
            labelAdditionalColor.DragEnter += labelColor_DragEnter;
            // 
            // labelBodyColor
            // 
            labelBodyColor.AllowDrop = true;
            labelBodyColor.Anchor = AnchorStyles.Top;
            labelBodyColor.BackColor = SystemColors.Control;
            labelBodyColor.BorderStyle = BorderStyle.FixedSingle;
            labelBodyColor.Image = Properties.Resources.background;
            labelBodyColor.Location = new Point(29, 9);
            labelBodyColor.Name = "labelBodyColor";
            labelBodyColor.Size = new Size(75, 26);
            labelBodyColor.TabIndex = 10;
            labelBodyColor.Text = "Цвет";
            labelBodyColor.TextAlign = ContentAlignment.MiddleCenter;
            labelBodyColor.DragDrop += labelColor_DragDrop;
            labelBodyColor.DragEnter += labelColor_DragEnter;
            labelBodyColor.MouseDown += Panel_MouseDown;
            // 
            // FormAirplaneConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 204);
            Controls.Add(panelObject);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxConfig);
            Name = "FormAirplaneConfig";
            Text = "Создание объекта";
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            panelObject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConfig;
        private Label labelSimpleObject;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private Label labelModifiedObject;
        private NumericUpDown numericUpDownWeight;
        private Label labelWeigth;
        private CheckBox checkBoxAirRefueling;
        private CheckBox checkBoxExtraFuelTank;
        private CheckBox checkBoxAircraftBomb;
        private GroupBox groupBoxColors;
        private Panel panelBlack;
        private Panel panelWhite;
        private Panel panelCyan;
        private Panel panelBlue;
        private Panel panelLime;
        private Panel panelFuchsia;
        private Panel panelYellow;
        private Panel panelRed;
        private PictureBox pictureBoxObject;
        private Button buttonAdd;
        private Button buttonCancel;
        private Panel panelObject;
        private Label labelAdditionalColor;
        public Label labelBodyColor;
    }
}