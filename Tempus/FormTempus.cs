using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Tempus
{
    public partial class FormTempus : Form
    {
        private TimeSpan lastTime;
        private bool isStarted;
        private int numberOfMinutes;
        private bool isFirstStart = true;
        private TempusConfig lastconfig = new TempusConfig().loadConfig();
        private string clockType;
        private string finalTime;
        private bool flashRed;
        FormTempusSec frmSec = new FormTempusSec();
        Screen[] screens = Screen.AllScreens;

        public FormTempus()
        {
            InitializeComponent();
            isStarted = false;
        }

        private void FormTempus_Load(object sender, EventArgs e)
        {
            tbTime.Text = lastconfig.Time.ToString();
            clockType = lastconfig.Type.ToString();
            btnStart.Select();
            lblCrono.Text = lastTime.ToString(clockType);

            lblCrono.SizeChanged += CentralizeLabel;
            Resize += CentralizeLabel;

            CentralizeLabel(this, EventArgs.Empty);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lastconfig = new TempusConfig().loadConfig();
            clockType = lastconfig.Type;
            finalTime = lastconfig.FinalTime;

            if (!isStarted && tbTime.Text != string.Empty && (int)Convert.ToInt64(tbTime.Text) > 0 && isFirstStart)
            {
                numberOfMinutes = (int)Convert.ToInt64(tbTime.Text);
                
                if (lastconfig.Debug)
                {
                    lastTime = TimeSpan.FromSeconds(numberOfMinutes);
                }
                else
                {
                    lastTime = TimeSpan.FromMinutes(numberOfMinutes);
                }

                UpdateDisplay();
                isStarted = true;
                timerClock.Enabled = true;


                TempusConfig config = new TempusConfig()
                {
                    Time = (int)Convert.ToInt64(tbTime.Text),
                    FontSize = lastconfig.FontSize,
                    Type = lastconfig.Type,
                    BackGround = lastconfig.BackGround,
                    FinalTime = lastconfig.FinalTime
                };
                config.SaveConfig();

                tbTime.Enabled = false;
                btnConfig.Enabled = false;
                btnZero.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Select();
                
                AjustSecondaryDisplay();
            }
            else if (!isStarted && lastTime > TimeSpan.Zero)
            {
                UpdateDisplay();
                isStarted = true;
                timerClock.Enabled = true;
                tbTime.Enabled = false;
                btnConfig.Enabled = false;
                btnZero.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Select();
               
                AjustSecondaryDisplay();
            }
            else if (!isStarted && !isFirstStart)
            {
                numberOfMinutes = (int)Convert.ToInt64(tbTime.Text);

                if (lastconfig.Debug)
                {
                    lastTime = TimeSpan.FromSeconds(numberOfMinutes);
                }
                else
                {
                    lastTime = TimeSpan.FromMinutes(numberOfMinutes);
                }

                UpdateDisplay();
                isStarted = true;
                timerClock.Enabled = true;
                tbTime.Enabled = false;
                btnConfig.Enabled = false;
                btnZero.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Select();
                                
                AjustSecondaryDisplay();

                TempusConfig config = new TempusConfig()
                {
                    Time = (int)Convert.ToInt64(tbTime.Text),
                    FontSize = lastconfig.FontSize,
                    Type = lastconfig.Type,
                    BackGround = lastconfig.BackGround,
                    FinalTime = lastconfig.FinalTime
                };
                config.SaveConfig();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            if (isStarted)
            {
                timerClock.Enabled = false;
                isStarted = false;
                isFirstStart = false;
                btnConfig.Enabled = true;
                btnZero.Enabled = true;
                btnStart.Enabled = true;
                frmSec.Hide();
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                lastTime = TimeSpan.Zero;
                lblCrono.Text = lastTime.ToString(clockType);
                tbTime.Enabled = Enabled;
                lblCrono.ForeColor = Color.Black;
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormTempusConfig config = new FormTempusConfig();
            config.ShowDialog();

            lastconfig = new TempusConfig().loadConfig();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (isStarted)
            {
                if ((lastTime.Seconds > 0 || lastTime.Minutes > 0) || (finalTime == "Continue" && lastTime.Seconds <= 0))
                {
                    lastTime = lastTime.Subtract(TimeSpan.FromSeconds(1));
                }
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            lblCrono.Text = lastTime.ToString(clockType);
            lblCrono.ForeColor = Color.Black;
            frmSec.lblTimeSec.Text = lastTime.ToString(clockType);

            if (lastTime <= TimeSpan.FromMinutes(1))
            {

                if (flashRed)
                {
                    lblCrono.ForeColor = Color.Red;
                    frmSec.lblTimeSec.ForeColor = Color.Red;
                    flashRed = false;
                }
                else
                {
                    if (lastconfig.BackGround == "Dark")
                    {
                        lblCrono.ForeColor = Color.Black;
                        frmSec.lblTimeSec.ForeColor = Color.White;
                    }
                    else
                    {
                        lblCrono.ForeColor = Color.Black;
                        frmSec.lblTimeSec.ForeColor = Color.Black;
                    }
                    flashRed = true;
                }

            }          

            if (lastTime < TimeSpan.Zero)
            {
                lblCrono.Text = lastTime.ToString(@"\-" + clockType);
                frmSec.lblTimeSec.Text = lastTime.ToString(@"\-" + clockType);

                lblCrono.ForeColor = Color.Red;
                frmSec.lblTimeSec.ForeColor = Color.Red;
            }

            lblCrono.SizeChanged += CentralizeLabel;
            Resize += CentralizeLabel;

            CentralizeLabel(this, EventArgs.Empty);
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Me
        }

        private void CentralizeLabel(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - lblCrono.Width) / 2;
            int y = lblCrono.Location.Y;

            lblCrono.Location = new Point(x, y);
        }

        private void CentralizeSecondaryLabel(object sender, EventArgs e)
        {
            int x = (frmSec.ClientSize.Width - frmSec.lblTimeSec.Width) / 2;
            int y = (frmSec.ClientSize.Height - frmSec.lblTimeSec.Height) / 2;

            frmSec.lblTimeSec.Location = new Point(x, y);
        }

        private void AjustSecondaryDisplay()
        {
            frmSec.lblTimeSec.Font = new Font(frmSec.lblTimeSec.Font.FontFamily, lastconfig.FontSize, FontStyle.Bold);
            if (lastconfig.BackGround == "Dark")
            {

                frmSec.BackColor = Color.Black;
                frmSec.lblTimeSec.ForeColor = Color.White;
            }
            else
            {
                frmSec.BackColor = Color.FromName("Control");
                frmSec.lblTimeSec.ForeColor = Color.Black;
            }
            frmSec.Left = screens[1].Bounds.Width;
            frmSec.Top = screens[1].Bounds.Height;
            frmSec.StartPosition = FormStartPosition.Manual;
            frmSec.Location = screens[1].Bounds.Location;

            Point p = new Point(screens[1].Bounds.Location.X, screens[1].Bounds.Location.Y);

            frmSec.Location = p;
            frmSec.WindowState = FormWindowState.Maximized;            

            frmSec.Show();

            frmSec.lblTimeSec.SizeChanged += CentralizeSecondaryLabel;
            Resize += CentralizeSecondaryLabel;

            CentralizeSecondaryLabel(this, EventArgs.Empty);

        }
    }
}
