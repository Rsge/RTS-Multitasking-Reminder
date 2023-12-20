namespace RTSMultitaskingReminder {
    public partial class MainForm : Form {
        private int _countdown;

        private void SetCountdownText(int seconds) {
            CountdownTxt.Text = seconds.ToString() + Properties.Resources.Unit;
        }

        // Loading
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            CycleNUD.Value = Properties.Settings.Default.Cycle;
        }

        // Start / Stop
        private void StartStopButton_Click(object sender, EventArgs e) {
            if (Timer.Enabled) {
                SetCountdownText(0);
                StartStopButton.Text = Properties.Resources.StartLabel;
                Timer.Stop();
            } else {
                _countdown = (int)CycleNUD.Value;
                SetCountdownText(_countdown);
                StartStopButton.Text = Properties.Resources.StopLabel;
                Timer.Start();
            }
        }

        // Timer
        private void Timer_Tick(object sender, EventArgs e) {
            _countdown--;
            if (_countdown <= 0) {
                _countdown = (int)CycleNUD.Value;
                Console.Beep();
            }
            SetCountdownText(_countdown);
        }

        // Closing
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Properties.Settings.Default.Cycle = (int)CycleNUD.Value;
            Properties.Settings.Default.Save();
        }
    }
}
