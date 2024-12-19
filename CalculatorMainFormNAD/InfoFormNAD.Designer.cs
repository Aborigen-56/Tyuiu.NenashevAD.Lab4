namespace CalculatorMainFormNAD
{
    partial class InfoFormNAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFormNAD));
            panelInfoFormMainNAD = new Panel();
            textBoxShowInfoNAD = new TextBox();
            panelInfoFormMainNAD.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfoFormMainNAD
            // 
            panelInfoFormMainNAD.Controls.Add(textBoxShowInfoNAD);
            panelInfoFormMainNAD.Dock = DockStyle.Fill;
            panelInfoFormMainNAD.Location = new Point(0, 0);
            panelInfoFormMainNAD.Name = "panelInfoFormMainNAD";
            panelInfoFormMainNAD.Size = new Size(334, 211);
            panelInfoFormMainNAD.TabIndex = 0;
            // 
            // textBoxShowInfoNAD
            // 
            textBoxShowInfoNAD.Dock = DockStyle.Fill;
            textBoxShowInfoNAD.Location = new Point(0, 0);
            textBoxShowInfoNAD.Multiline = true;
            textBoxShowInfoNAD.Name = "textBoxShowInfoNAD";
            textBoxShowInfoNAD.ReadOnly = true;
            textBoxShowInfoNAD.Size = new Size(334, 211);
            textBoxShowInfoNAD.TabIndex = 0;
            textBoxShowInfoNAD.Text = resources.GetString("textBoxShowInfoNAD.Text");
            // 
            // InfoFormNAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(panelInfoFormMainNAD);
            Name = "InfoFormNAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            panelInfoFormMainNAD.ResumeLayout(false);
            panelInfoFormMainNAD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfoFormMainNAD;
        private TextBox textBoxShowInfoNAD;
    }
}