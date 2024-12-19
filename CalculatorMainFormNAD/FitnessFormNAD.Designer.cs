namespace CalculatorMainFormNAD
{
    partial class FitnessFormNAD
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFitnessCalcMainNAD = new Panel();
            textBoxShowResultNAD = new TextBox();
            buttonCalculateFitnessNAD = new Button();
            labelChooseActivityLevelNAD = new Label();
            comboBoxChooseActivityLevelNAD = new ComboBox();
            labelChooseGenderNAD = new Label();
            labelEnterAgeNAD = new Label();
            labelEnterHeightNAD = new Label();
            labelEnterWeightNAD = new Label();
            radioButtonChooseGenderFemaleNAD = new RadioButton();
            radioButtonChooseGenderMaleNAD = new RadioButton();
            textBoxEnterAgeNAD = new TextBox();
            textBoxEnterHeightNAD = new TextBox();
            textBoxEnterWeightNAD = new TextBox();
            panelFitnessCalcMainNAD.SuspendLayout();
            SuspendLayout();
            // 
            // panelFitnessCalcMainNAD
            // 
            panelFitnessCalcMainNAD.Controls.Add(textBoxShowResultNAD);
            panelFitnessCalcMainNAD.Controls.Add(buttonCalculateFitnessNAD);
            panelFitnessCalcMainNAD.Controls.Add(labelChooseActivityLevelNAD);
            panelFitnessCalcMainNAD.Controls.Add(comboBoxChooseActivityLevelNAD);
            panelFitnessCalcMainNAD.Controls.Add(labelChooseGenderNAD);
            panelFitnessCalcMainNAD.Controls.Add(labelEnterAgeNAD);
            panelFitnessCalcMainNAD.Controls.Add(labelEnterHeightNAD);
            panelFitnessCalcMainNAD.Controls.Add(labelEnterWeightNAD);
            panelFitnessCalcMainNAD.Controls.Add(radioButtonChooseGenderFemaleNAD);
            panelFitnessCalcMainNAD.Controls.Add(radioButtonChooseGenderMaleNAD);
            panelFitnessCalcMainNAD.Controls.Add(textBoxEnterAgeNAD);
            panelFitnessCalcMainNAD.Controls.Add(textBoxEnterHeightNAD);
            panelFitnessCalcMainNAD.Controls.Add(textBoxEnterWeightNAD);
            panelFitnessCalcMainNAD.Dock = DockStyle.Fill;
            panelFitnessCalcMainNAD.Location = new Point(0, 0);
            panelFitnessCalcMainNAD.Name = "panelFitnessCalcMainNAD";
            panelFitnessCalcMainNAD.Size = new Size(484, 361);
            panelFitnessCalcMainNAD.TabIndex = 5;
            // 
            // textBoxShowResultNAD
            // 
            textBoxShowResultNAD.Location = new Point(259, 118);
            textBoxShowResultNAD.Multiline = true;
            textBoxShowResultNAD.Name = "textBoxShowResultNAD";
            textBoxShowResultNAD.ReadOnly = true;
            textBoxShowResultNAD.Size = new Size(213, 104);
            textBoxShowResultNAD.TabIndex = 12;
            // 
            // buttonCalculateFitnessNAD
            // 
            buttonCalculateFitnessNAD.Location = new Point(49, 309);
            buttonCalculateFitnessNAD.Name = "buttonCalculateFitnessNAD";
            buttonCalculateFitnessNAD.Size = new Size(122, 40);
            buttonCalculateFitnessNAD.TabIndex = 11;
            buttonCalculateFitnessNAD.Text = "Расчёт";
            buttonCalculateFitnessNAD.UseVisualStyleBackColor = true;
            buttonCalculateFitnessNAD.Click += buttonCalculateFitnessNAD_Click;
            // 
            // labelChooseActivityLevelNAD
            // 
            labelChooseActivityLevelNAD.AutoSize = true;
            labelChooseActivityLevelNAD.Location = new Point(12, 262);
            labelChooseActivityLevelNAD.Name = "labelChooseActivityLevelNAD";
            labelChooseActivityLevelNAD.Size = new Size(203, 15);
            labelChooseActivityLevelNAD.TabIndex = 10;
            labelChooseActivityLevelNAD.Text = "Выберите ваш уровень активности ";
            // 
            // comboBoxChooseActivityLevelNAD
            // 
            comboBoxChooseActivityLevelNAD.FormattingEnabled = true;
            comboBoxChooseActivityLevelNAD.Location = new Point(12, 280);
            comboBoxChooseActivityLevelNAD.Name = "comboBoxChooseActivityLevelNAD";
            comboBoxChooseActivityLevelNAD.Size = new Size(203, 23);
            comboBoxChooseActivityLevelNAD.TabIndex = 9;
            // 
            // labelChooseGenderNAD
            // 
            labelChooseGenderNAD.AutoSize = true;
            labelChooseGenderNAD.Location = new Point(12, 207);
            labelChooseGenderNAD.Name = "labelChooseGenderNAD";
            labelChooseGenderNAD.Size = new Size(111, 15);
            labelChooseGenderNAD.TabIndex = 8;
            labelChooseGenderNAD.Text = "Выберите ваш пол";
            // 
            // labelEnterAgeNAD
            // 
            labelEnterAgeNAD.AutoSize = true;
            labelEnterAgeNAD.Location = new Point(12, 137);
            labelEnterAgeNAD.Name = "labelEnterAgeNAD";
            labelEnterAgeNAD.Size = new Size(121, 15);
            labelEnterAgeNAD.TabIndex = 7;
            labelEnterAgeNAD.Text = "Введите ваш возраст";
            // 
            // labelEnterHeightNAD
            // 
            labelEnterHeightNAD.AutoSize = true;
            labelEnterHeightNAD.Location = new Point(12, 65);
            labelEnterHeightNAD.Name = "labelEnterHeightNAD";
            labelEnterHeightNAD.Size = new Size(104, 15);
            labelEnterHeightNAD.TabIndex = 6;
            labelEnterHeightNAD.Text = "Введите ваш рост";
            // 
            // labelEnterWeightNAD
            // 
            labelEnterWeightNAD.AutoSize = true;
            labelEnterWeightNAD.Location = new Point(12, 3);
            labelEnterWeightNAD.Name = "labelEnterWeightNAD";
            labelEnterWeightNAD.Size = new Size(97, 15);
            labelEnterWeightNAD.TabIndex = 5;
            labelEnterWeightNAD.Text = "Введите ваш вес";
            // 
            // radioButtonChooseGenderFemaleNAD
            // 
            radioButtonChooseGenderFemaleNAD.AutoSize = true;
            radioButtonChooseGenderFemaleNAD.Location = new Point(114, 225);
            radioButtonChooseGenderFemaleNAD.Name = "radioButtonChooseGenderFemaleNAD";
            radioButtonChooseGenderFemaleNAD.Size = new Size(80, 19);
            radioButtonChooseGenderFemaleNAD.TabIndex = 4;
            radioButtonChooseGenderFemaleNAD.Text = "Женщина";
            radioButtonChooseGenderFemaleNAD.UseVisualStyleBackColor = true;
            // 
            // radioButtonChooseGenderMaleNAD
            // 
            radioButtonChooseGenderMaleNAD.AutoSize = true;
            radioButtonChooseGenderMaleNAD.Location = new Point(12, 225);
            radioButtonChooseGenderMaleNAD.Name = "radioButtonChooseGenderMaleNAD";
            radioButtonChooseGenderMaleNAD.Size = new Size(78, 19);
            radioButtonChooseGenderMaleNAD.TabIndex = 3;
            radioButtonChooseGenderMaleNAD.Text = "Мужчина";
            radioButtonChooseGenderMaleNAD.UseVisualStyleBackColor = true;
            // 
            // textBoxEnterAgeNAD
            // 
            textBoxEnterAgeNAD.Location = new Point(12, 170);
            textBoxEnterAgeNAD.Name = "textBoxEnterAgeNAD";
            textBoxEnterAgeNAD.Size = new Size(121, 23);
            textBoxEnterAgeNAD.TabIndex = 2;
            // 
            // textBoxEnterHeightNAD
            // 
            textBoxEnterHeightNAD.Location = new Point(12, 95);
            textBoxEnterHeightNAD.Name = "textBoxEnterHeightNAD";
            textBoxEnterHeightNAD.Size = new Size(121, 23);
            textBoxEnterHeightNAD.TabIndex = 1;
            // 
            // textBoxEnterWeightNAD
            // 
            textBoxEnterWeightNAD.Location = new Point(12, 30);
            textBoxEnterWeightNAD.Name = "textBoxEnterWeightNAD";
            textBoxEnterWeightNAD.Size = new Size(121, 23);
            textBoxEnterWeightNAD.TabIndex = 0;
            // 
            // FitnessFormNAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(panelFitnessCalcMainNAD);
            Name = "FitnessFormNAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фитнес-калькулятор";
            panelFitnessCalcMainNAD.ResumeLayout(false);
            panelFitnessCalcMainNAD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFitnessCalcMainNAD;
        private Label labelEnterWeightNAD;
        private RadioButton radioButtonChooseGenderFemaleNAD;
        private RadioButton radioButtonChooseGenderMaleNAD;
        private TextBox textBoxEnterAgeNAD;
        private TextBox textBoxEnterHeightNAD;
        private TextBox textBoxEnterWeightNAD;
        private Label labelChooseActivityLevelNAD;
        private ComboBox comboBoxChooseActivityLevelNAD;
        private Label labelChooseGenderNAD;
        private Label labelEnterAgeNAD;
        private Label labelEnterHeightNAD;
        private TextBox textBoxShowResultNAD;
        private Button buttonCalculateFitnessNAD;
    }
}