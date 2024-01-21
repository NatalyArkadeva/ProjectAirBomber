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
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirBomber).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAirBomber
            // 
            pictureBoxAirBomber.Dock = DockStyle.Fill;
            pictureBoxAirBomber.Location = new Point(0, 0);
            pictureBoxAirBomber.Name = "pictureBoxAirBomber";
            pictureBoxAirBomber.Size = new Size(615, 365);
            pictureBoxAirBomber.TabIndex = 0;
            pictureBoxAirBomber.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreate.Location = new Point(12, 330);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.Image = Properties.Resources.arrowUp;
            buttonUp.Location = new Point(527, 283);
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
            buttonLeft.Location = new Point(486, 318);
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
            buttonDown.Location = new Point(527, 318);
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
            buttonRight.Location = new Point(568, 318);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 5;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonMove_Click;
            // 
            // FormAirBomber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 365);
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
    }
}