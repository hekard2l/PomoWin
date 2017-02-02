using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

namespace PomoWin {

	public partial class MainForm : Form {
		private readonly Timer countdown;
		private int remainingMinutes = 0;
		// Move form dependencies
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute( "user32.dll" )]
		public static extern int SendMessage( IntPtr hWnd, int Msg, int wParam, int lParam );

		[DllImportAttribute( "user32.dll" )]
		public static extern bool ReleaseCapture();

		public MainForm() {
			InitializeComponent();
			SetStyle( ControlStyles.SupportsTransparentBackColor, true );

			chkPin.Checked = Properties.Settings.Default.StayOnTop;
			this.TopMost = chkPin.Checked;

			countdown = new Timer { Interval = 10 };
			countdown.Tick += new EventHandler( CountdownTick );
		}

		void CountdownTick( object sender, EventArgs e ) {
			if( --remainingMinutes <= 0 ) {
				countdown.Stop();
				btnStopCountdown.FlatAppearance.BorderColor = Color.Gray;
				MessageBox.Show( "Countdown complete" );
			}
			UpdateTimerDisplay();
		}

		private void chkPin_CheckedChanged( object sender, EventArgs e ) {
			this.TopMost = chkPin.Checked;
			Properties.Settings.Default.StayOnTop = chkPin.Checked;
			Properties.Settings.Default.Save();
		}

		private void btnClose_Click( object sender, EventArgs e ) {
			this.Close();
		}

		private void MainForm_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e ) {
			// Drag form to move
			if( e.Button == MouseButtons.Left ) {
				ReleaseCapture();
				SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
			}
		}

		protected override bool ProcessCmdKey( ref Message msg, Keys keyData ) {
			if( keyData == Keys.Escape ) {
				this.Hide();
				return true;
			} else {
				return base.ProcessCmdKey( ref msg, keyData );
			}
		}

		private void btnStartTask_Click( object sender, EventArgs e )
		{
			StartTimer(25, Color.Red);
		}

		private void UpdateTimerDisplay() {
			this.btnStopCountdown.Text = remainingMinutes.ToString();
		}

		private void btnStopCountdown_Click( object sender, EventArgs e ) {
			countdown.Stop();
			btnStopCountdown.FlatAppearance.BorderColor = Color.Gray;
		}

		private void btnShortBreak_Click( object sender, EventArgs e ) {
			StartTimer(5, Color.LightSkyBlue);
		}

		private void btnLongBreak_Click( object sender, EventArgs e ) {
			StartTimer(15, Color.DeepSkyBlue);
		}

		private void StartTimer( int minutes, Color borderColor ) {
			remainingMinutes = minutes;
			btnStopCountdown.FlatAppearance.BorderColor = borderColor;
			countdown.Interval = (int)TimeSpan.FromMinutes( 1.0 ).TotalMilliseconds;
			countdown.Start();
			UpdateTimerDisplay();
		}
	}
}
