namespace Tempus
{
    partial class FormTempusConfig
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
            gbControle = new GroupBox();
            lblFont = new Label();
            nudFontSize = new NumericUpDown();
            rbDark = new RadioButton();
            rbLight = new RadioButton();
            gbClock = new GroupBox();
            rbHHMM = new RadioButton();
            rbHHMMSS = new RadioButton();
            btnWrite = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            rbStop = new RadioButton();
            rbContinue = new RadioButton();
            gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFontSize).BeginInit();
            gbClock.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbControle
            // 
            gbControle.Controls.Add(lblFont);
            gbControle.Controls.Add(nudFontSize);
            gbControle.Controls.Add(rbDark);
            gbControle.Controls.Add(rbLight);
            gbControle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbControle.Location = new Point(12, 24);
            gbControle.Name = "gbControle";
            gbControle.Size = new Size(535, 118);
            gbControle.TabIndex = 0;
            gbControle.TabStop = false;
            gbControle.Text = "Controle de Font e Background";
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFont.Location = new Point(303, 45);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(139, 20);
            lblFont.TabIndex = 3;
            lblFont.Text = "Tamanho da Fonte";
            // 
            // nudFontSize
            // 
            nudFontSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudFontSize.Location = new Point(448, 43);
            nudFontSize.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudFontSize.Name = "nudFontSize";
            nudFontSize.Size = new Size(64, 27);
            nudFontSize.TabIndex = 2;
            nudFontSize.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // rbDark
            // 
            rbDark.AutoSize = true;
            rbDark.Checked = true;
            rbDark.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rbDark.Location = new Point(10, 59);
            rbDark.Name = "rbDark";
            rbDark.Size = new Size(225, 24);
            rbDark.TabIndex = 1;
            rbDark.TabStop = true;
            rbDark.Text = "Fundo Escuro / Letras Claras";
            rbDark.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            rbLight.AutoSize = true;
            rbLight.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rbLight.Location = new Point(10, 32);
            rbLight.Name = "rbLight";
            rbLight.Size = new Size(225, 24);
            rbLight.TabIndex = 0;
            rbLight.Text = "Fundo Claro / Letras Escuras";
            rbLight.UseVisualStyleBackColor = true;
            // 
            // gbClock
            // 
            gbClock.Controls.Add(rbHHMM);
            gbClock.Controls.Add(rbHHMMSS);
            gbClock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbClock.Location = new Point(553, 24);
            gbClock.Name = "gbClock";
            gbClock.Size = new Size(223, 71);
            gbClock.TabIndex = 1;
            gbClock.TabStop = false;
            gbClock.Text = "Controle do Relógio";
            // 
            // rbHHMM
            // 
            rbHHMM.AutoSize = true;
            rbHHMM.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbHHMM.Location = new Point(130, 26);
            rbHHMM.Name = "rbHHMM";
            rbHHMM.Size = new Size(81, 24);
            rbHHMM.TabIndex = 1;
            rbHHMM.Text = "HH:MM";
            rbHHMM.UseVisualStyleBackColor = true;
            // 
            // rbHHMMSS
            // 
            rbHHMMSS.AutoSize = true;
            rbHHMMSS.Checked = true;
            rbHHMMSS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbHHMMSS.Location = new Point(9, 26);
            rbHHMMSS.Name = "rbHHMMSS";
            rbHHMMSS.Size = new Size(101, 24);
            rbHHMMSS.TabIndex = 0;
            rbHHMMSS.TabStop = true;
            rbHHMMSS.Text = "HH:MM:SS";
            rbHHMMSS.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(113, 154);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(93, 32);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Gravar";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbStop);
            groupBox1.Controls.Add(rbContinue);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(555, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 89);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controle do Tempo";
            // 
            // rbStop
            // 
            rbStop.AutoSize = true;
            rbStop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbStop.Location = new Point(9, 56);
            rbStop.Name = "rbStop";
            rbStop.Size = new Size(126, 24);
            rbStop.TabIndex = 1;
            rbStop.Text = "Parar ao Zerar";
            rbStop.UseVisualStyleBackColor = true;
            // 
            // rbContinue
            // 
            rbContinue.AutoSize = true;
            rbContinue.Checked = true;
            rbContinue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbContinue.Location = new Point(9, 26);
            rbContinue.Name = "rbContinue";
            rbContinue.Size = new Size(164, 24);
            rbContinue.TabIndex = 0;
            rbContinue.TabStop = true;
            rbContinue.Text = "Continuar Negativo";
            rbContinue.UseVisualStyleBackColor = true;
            // 
            // FormTempusConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 202);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnWrite);
            Controls.Add(gbClock);
            Controls.Add(gbControle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTempusConfig";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração Contador Regressivo Tempus (Ver. 5.0)";
            Load += FormTempusConfig_Load;
            gbControle.ResumeLayout(false);
            gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFontSize).EndInit();
            gbClock.ResumeLayout(false);
            gbClock.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbControle;
        private RadioButton rbDark;
        private RadioButton rbLight;
        private Label lblFont;
        private NumericUpDown nudFontSize;
        private GroupBox gbClock;
        private RadioButton rbHHMMSS;
        private RadioButton rbHHMM;
        private Button btnWrite;
        private Button btnCancel;
        private GroupBox groupBox1;
        private RadioButton rbStop;
        private RadioButton rbContinue;
    }
}