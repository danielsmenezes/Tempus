using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tempus
{
    public partial class FormTempusConfig : Form
    {
        private string? type;
        private string? background;
        private string? finalbackground;
        private string? finaltime;
        private int time;
        private int timetoblink;
        private bool? debug;
        public FormTempusConfig()
        {
            InitializeComponent();
        }

        private void FormTempusConfig_Load(object sender, EventArgs e)
        {
            TempusConfig config = new TempusConfig().loadConfig();
            time = config.Time;
            debug = config.Debug;

            nudFontSize.Value = config.FontSize;

            if (config.BackGround == "Light")
            {
                rbLight.Checked = true;
                rbDark.Checked = false;
            }
            else if (config.BackGround == "Dark")
            {
                rbLight.Checked = false;
                rbDark.Checked = true;
            }
            else
            {
                rbLight.Checked = false;
                rbDark.Checked = false;
            }

            if (config.Type == @"hh\:mm")
            {
                rbHHMM.Checked = true;
                rbHHMMSS.Checked = false;
                rbMMSS.Checked = false;
            }
            else if (config.Type == @"hh\:mm\:ss")
            {
                rbHHMM.Checked = false;
                rbHHMMSS.Checked = true;
                rbMMSS.Checked = false;
            }
            else if (config.Type == @"mm\:ss")
            {
                rbHHMM.Checked = false;
                rbHHMMSS.Checked = false;
                rbMMSS.Checked = true;
            }
            else
            {
                rbHHMM.Checked = false;
                rbHHMMSS.Checked = false;
                rbMMSS.Checked = false;
            }

            if (config.FinalTime == "Continue")
            {
                rbContinue.Checked = true;
                rbStop.Checked = false;
            }
            else if (config.FinalTime == "Stop")
            {
                rbContinue.Checked = false;
                rbStop.Checked = true;
            }
            else
            {
                rbContinue.Checked = false;
                rbStop.Checked = false;
            }

            if (config.FinalBackGround == "Keep")
            {
                rbKeepConfig.Checked = true;
                rbAlterConfig.Checked = false;
            }
            else if (config.FinalBackGround == "Alter")
            {
                rbKeepConfig.Checked = false;
                rbAlterConfig.Checked = true;
            }
            else
            {
                rbKeepConfig.Checked = false;
                rbAlterConfig.Checked = false;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            if (rbDark.Checked)
            {
                background = "Dark";
            }
            else if (rbLight.Checked)
            {
                background = "Light";
            }
            else
            {
                MessageBox.Show("Favor Selecionar o tipo de BackGround");
                return;
            }

            if (rbHHMM.Checked)
            {
                type = @"hh\:mm";
            }
            else if (rbHHMMSS.Checked)
            {
                type = @"hh\:mm\:ss";
            }
            else if (rbMMSS.Checked)
            {
                type = @"mm\:ss";
            }
            else
            {
                MessageBox.Show("Favor Selecionar o tipo de Controle de Relógio");
                return;
            }

            if (rbContinue.Checked)
            {
                finaltime = "Continue";
            }
            else if (rbStop.Checked)
            {
                finaltime = "Stop";
            }
            else
            {
                MessageBox.Show("Favor Selecionar o tipo de Controle de Tempo");
                return;
            }

            if (rbKeepConfig.Checked)
            {
                finalbackground = "Keep";
            }
            else if (rbAlterConfig.Checked)
            {
                finalbackground = "Alter";
            }
            else
            {
                MessageBox.Show("Favor Selecionar o Tipo de Tela ao Finalizar o Cronômetro");
                return;
            }

            TempusConfig config = new TempusConfig()
            {
                FontSize = (int)nudFontSize.Value,
                Type = type,
                BackGround = background,
                FinalBackGround = finalbackground,
                FinalTime = finaltime,
                Time = time,
                TimeToBlink = (int)nudTimeToBlink.Value
            };

            config.SaveConfig();
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
