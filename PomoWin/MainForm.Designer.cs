namespace PomoWin
{
    using PomoWin.Properties;

    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextFloat = new System.Windows.Forms.ToolStripMenuItem();
			this.contextByte = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.btnClose = new System.Windows.Forms.Button();
			this.btnStopCountdown = new System.Windows.Forms.Button();
			this.chkPin = new System.Windows.Forms.CheckBox();
			this.btnStartTask = new System.Windows.Forms.Button();
			this.btnShortBreak = new System.Windows.Forms.Button();
			this.btnLongBreak = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lblHoursLeft = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextFloat,
            this.contextByte});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(68, 48);
			// 
			// contextFloat
			// 
			this.contextFloat.Name = "contextFloat";
			this.contextFloat.Size = new System.Drawing.Size(67, 22);
			// 
			// contextByte
			// 
			this.contextByte.Name = "contextByte";
			this.contextByte.Size = new System.Drawing.Size(67, 22);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnClose.BackgroundImage = global::PomoWin.Properties.Resources.app_close;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(210, -1);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 25);
			this.btnClose.TabIndex = 6;
			this.tooltip.SetToolTip(this.btnClose, global::PomoWin.Properties.Resources.CloseText);
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnStopCountdown
			// 
			this.btnStopCountdown.BackColor = System.Drawing.Color.Transparent;
			this.btnStopCountdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnStopCountdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnStopCountdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnStopCountdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnStopCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStopCountdown.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStopCountdown.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnStopCountdown.Location = new System.Drawing.Point(10, 40);
			this.btnStopCountdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnStopCountdown.Name = "btnStopCountdown";
			this.btnStopCountdown.Size = new System.Drawing.Size(80, 80);
			this.btnStopCountdown.TabIndex = 4;
			this.btnStopCountdown.TabStop = false;
			this.btnStopCountdown.Text = "-";
			this.tooltip.SetToolTip(this.btnStopCountdown, global::PomoWin.Properties.Resources.StopText);
			this.btnStopCountdown.UseVisualStyleBackColor = false;
			this.btnStopCountdown.Click += new System.EventHandler(this.btnStopCountdown_Click);
			// 
			// chkPin
			// 
			this.chkPin.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.chkPin.BackgroundImage = global::PomoWin.Properties.Resources.pin;
			this.chkPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.chkPin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.chkPin.FlatAppearance.BorderSize = 0;
			this.chkPin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.chkPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chkPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkPin.Location = new System.Drawing.Point(210, 86);
			this.chkPin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.chkPin.Name = "chkPin";
			this.chkPin.Size = new System.Drawing.Size(36, 36);
			this.chkPin.TabIndex = 5;
			this.tooltip.SetToolTip(this.chkPin, global::PomoWin.Properties.Resources.OnTop);
			this.chkPin.UseVisualStyleBackColor = false;
			this.chkPin.CheckedChanged += new System.EventHandler(this.chkPin_CheckedChanged);
			// 
			// btnStartTask
			// 
			this.btnStartTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnStartTask.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnStartTask.FlatAppearance.BorderSize = 0;
			this.btnStartTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnStartTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartTask.Image = global::PomoWin.Properties.Resources.start1;
			this.btnStartTask.Location = new System.Drawing.Point(210, 40);
			this.btnStartTask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnStartTask.Name = "btnStartTask";
			this.btnStartTask.Size = new System.Drawing.Size(36, 36);
			this.btnStartTask.TabIndex = 1;
			this.tooltip.SetToolTip(this.btnStartTask, global::PomoWin.Properties.Resources.StartText);
			this.btnStartTask.UseVisualStyleBackColor = false;
			this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
			// 
			// btnShortBreak
			// 
			this.btnShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnShortBreak.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnShortBreak.FlatAppearance.BorderSize = 0;
			this.btnShortBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.btnShortBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShortBreak.Image = global::PomoWin.Properties.Resources.short_break;
			this.btnShortBreak.Location = new System.Drawing.Point(164, 40);
			this.btnShortBreak.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnShortBreak.Name = "btnShortBreak";
			this.btnShortBreak.Size = new System.Drawing.Size(36, 36);
			this.btnShortBreak.TabIndex = 2;
			this.tooltip.SetToolTip(this.btnShortBreak, global::PomoWin.Properties.Resources.StartText);
			this.btnShortBreak.UseVisualStyleBackColor = false;
			this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
			// 
			// btnLongBreak
			// 
			this.btnLongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnLongBreak.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnLongBreak.FlatAppearance.BorderSize = 0;
			this.btnLongBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnLongBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLongBreak.Image = global::PomoWin.Properties.Resources.long_break;
			this.btnLongBreak.Location = new System.Drawing.Point(164, 86);
			this.btnLongBreak.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnLongBreak.Name = "btnLongBreak";
			this.btnLongBreak.Size = new System.Drawing.Size(36, 36);
			this.btnLongBreak.TabIndex = 3;
			this.tooltip.SetToolTip(this.btnLongBreak, global::PomoWin.Properties.Resources.StartText);
			this.btnLongBreak.UseVisualStyleBackColor = false;
			this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(5, 6);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 0, 10);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(78, 21);
			this.lbTitle.TabIndex = 9;
			this.lbTitle.Text = "PomoWin";
			this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// lblHoursLeft
			// 
			this.lblHoursLeft.AutoSize = true;
			this.lblHoursLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoursLeft.ForeColor = System.Drawing.Color.White;
			this.lblHoursLeft.Location = new System.Drawing.Point(7, 127);
			this.lblHoursLeft.Name = "lblHoursLeft";
			this.lblHoursLeft.Size = new System.Drawing.Size(31, 15);
			this.lblHoursLeft.TabIndex = 10;
			this.lblHoursLeft.Text = "1024";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.ClientSize = new System.Drawing.Size(255, 155);
			this.Controls.Add(this.lblHoursLeft);
			this.Controls.Add(this.btnLongBreak);
			this.Controls.Add(this.btnShortBreak);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnStopCountdown);
			this.Controls.Add(this.chkPin);
			this.Controls.Add(this.btnStartTask);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Color Picker";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.CheckBox chkPin;
        private System.Windows.Forms.Button btnStopCountdown;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextFloat;
        private System.Windows.Forms.ToolStripMenuItem contextByte;
		private System.Windows.Forms.Button btnShortBreak;
		private System.Windows.Forms.Button btnLongBreak;
		private System.Windows.Forms.Label lblHoursLeft;
	}
}

