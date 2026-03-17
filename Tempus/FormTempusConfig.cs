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
        private string type;
        private string background;
        private string finaltime;
        private int time;
        private bool debug;
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
            }
            else if (config.Type == @"hh\:mm\:ss")
            {
                rbHHMM.Checked = false;
                rbHHMMSS.Checked = true;
            }
            else
            {
                rbHHMM.Checked = false;
                rbHHMMSS.Checked = false;
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


            TempusConfig config = new TempusConfig()
            {
                FontSize = (int)nudFontSize.Value,
                Type = type,
                BackGround = background,
                FinalTime = finaltime,
                Time = time
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
