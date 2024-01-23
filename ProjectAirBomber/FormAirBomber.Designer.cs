namespace ProjectAirBomber
{
    partial class FormAirBomber
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
            pictureBoxAirBomber = new PictureBox();
            buttonCreate = new Button();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            buttonCreateAirplane = new Button();
            comboBoxStrategy = new ComboBox();
            buttonStrategyStep = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirBomber).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAirBomber
            // 
            pictureBoxAirBomber.Dock = DockStyle.Fill;
            pictureBoxAirBomber.Location = new Point(0, 0);
            pictureBoxAirBomber.Name = "pictureBoxAirBomber";
            pictureBoxAirBomber.Size = new Size(854, 481);
            pictureBoxAirBomber.TabIndex = 0;
            pictureBoxAirBomber.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreate.Location = new Point(12, 444);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(163, 25);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать бомбардировщик";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.Image = Properties.Resources.arrowUp;
            buttonUp.Location = new Point(766, 399);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 2;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.Image = Properties.Resources.arrowLeft;
            buttonLeft.Location = new Point(725, 434);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 3;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.Image = Properties.Resources.arrowDown;
            buttonDown.Location = new Point(766, 434);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.Image = Properties.Resources.arrowRight;
            buttonRight.Location = new Point(807, 434);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 5;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonMove_Click;
            // 
            // buttonCreateAirplane
            // 
            buttonCreateAirplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateAirplane.Location = new Point(197, 444);
            buttonCreateAirplane.Name = "buttonCreateAirplane";
            buttonCreateAirplane.Size = new Size(125, 25);
            buttonCreateAirplane.TabIndex = 6;
            buttonCreateAirplane.Text = "Создать самолет";
            buttonCreateAirplane.UseVisualStyleBackColor = true;
            buttonCreateAirplane.Click += buttonCreateAirplane_Click;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "К центру", "К краю" });
            comboBoxStrategy.Location = new Point(725, 12);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(121, 23);
            comboBoxStrategy.TabIndex = 7;
            // 
            // buttonStrategyStep
            // 
            buttonStrategyStep.Location = new Point(771, 41);
            buttonStrategyStep.Name = "buttonStrategyStep";
            buttonStrategyStep.Size = new Size(75, 23);
            buttonStrategyStep.TabIndex = 8;
            buttonStrategyStep.Text = "Шаг";
            buttonStrategyStep.UseVisualStyleBackColor = true;
            buttonStrategyStep.Click += buttonStrategyStep_Click;
            // 
            // FormAirBomber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 481);
            Controls.Add(buttonStrategyStep);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonCreateAirplane);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(buttonUp);
            Controls.Add(buttonCreate);
            Controls.Add(pictureBoxAirBomber);
            Name = "FormAirBomber";
            Text = "Бомбардировщик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirBomber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAirBomber;
        private Button buttonCreate;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
        private Button buttonCreateAirplane;
        private ComboBox comboBoxStrategy;
        private Button buttonStrategyStep;
    }
}