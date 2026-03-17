namespace Tempus
{
    partial class FormTempus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTempus));
            lblCrono = new Label();
            tbTime = new TextBox();
            lblTempuEmMinutos = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnZero = new Button();
            btnConfig = new Button();
            btnHelp = new Button();
            timerClock = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCrono
            // 
            lblCrono.AutoSize = true;
            lblCrono.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrono.Location = new Point(31, 3);
            lblCrono.Name = "lblCrono";
            lblCrono.Size = new Size(436, 128);
            lblCrono.TabIndex = 0;
            lblCrono.Text = "00:00:00";
            // 
            // tbTime
            // 
            tbTime.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTime.Location = new Point(12, 148);
            tbTime.Margin = new Padding(3, 1, 3, 1);
            tbTime.MaxLength = 3;
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(88, 46);
            tbTime.TabIndex = 1;
            tbTime.TextAlign = HorizontalAlignment.Center;
            tbTime.KeyPress += tbTime_KeyPress;
            // 
            // lblTempuEmMinutos
            // 
            lblTempuEmMinutos.AutoSize = true;
            lblTempuEmMinutos.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempuEmMinutos.Location = new Point(121, 145);
            lblTempuEmMinutos.Name = "lblTempuEmMinutos";
            lblTempuEmMinutos.Size = new Size(358, 50);
            lblTempuEmMinutos.TabIndex = 2;
            lblTempuEmMinutos.Text = "Tempo em Minutos";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(64, 220);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(381, 63);
            btnStart.TabIndex = 3;
            btnStart.Text = "Iniciar Cronômetro";
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(64, 289);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(381, 63);
            btnStop.TabIndex = 4;
            btnStop.Text = "Parar Cronômetro";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(64, 358);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(381, 63);
            btnZero.TabIndex = 5;
            btnZero.Text = "Zerar Cronômetro";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnConfig
            // 
            btnConfig.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(64, 427);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(381, 63);
            btnConfig.TabIndex = 6;
            btnConfig.Text = "Configuração";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(449, 391);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(30, 30);
            btnHelp.TabIndex = 7;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // FormTempus
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 514);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnZero);
            Controls.Add(btnHelp);
            Controls.Add(btnConfig);
            Controls.Add(lblTempuEmMinutos);
            Controls.Add(tbTime);
            Controls.Add(lblCrono);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTempus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tempus (Ver 5.0)";
            Load += FormTempus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrono;
        private TextBox tbTime;
        private Label label2;
        private Button btnStart;
        private Button btnStop;
        private Button btnZero;
        private Button btnHelp;
        private Button btnConfig;        
        private Label lblTempuEmMinutos;
        public System.Windows.Forms.Timer timerClock;
    }
}
