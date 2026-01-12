namespace Clock
{
	partial class Alarm
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
			this.dtpActivationDate = new System.Windows.Forms.DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.chkMonday = new System.Windows.Forms.CheckBox();
			this.chkTuesday = new System.Windows.Forms.CheckBox();
			this.chkWednesday = new System.Windows.Forms.CheckBox();
			this.chkThursday = new System.Windows.Forms.CheckBox();
			this.chkFriday = new System.Windows.Forms.CheckBox();
			this.chkSaturday = new System.Windows.Forms.CheckBox();
			this.chkSunday = new System.Windows.Forms.CheckBox();
			this.grpDaySelection = new System.Windows.Forms.GroupBox();
			this.btnSelectSound = new System.Windows.Forms.Button();
			this.btnInstall = new System.Windows.Forms.Button();
			this.lblSound = new System.Windows.Forms.Label();
			this.comboBoxAudio = new System.Windows.Forms.ComboBox();
			this.grpDaySelection.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpActivationDate
			// 
			this.dtpActivationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpActivationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpActivationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpActivationDate.Location = new System.Drawing.Point(12, 47);
			this.dtpActivationDate.Name = "dtpActivationDate";
			this.dtpActivationDate.Size = new System.Drawing.Size(484, 31);
			this.dtpActivationDate.TabIndex = 0;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDate.Location = new System.Drawing.Point(13, 20);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(157, 20);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "Alarm activation date";
			// 
			// chkMonday
			// 
			this.chkMonday.AutoSize = true;
			this.chkMonday.Location = new System.Drawing.Point(6, 19);
			this.chkMonday.Name = "chkMonday";
			this.chkMonday.Size = new System.Drawing.Size(84, 24);
			this.chkMonday.TabIndex = 2;
			this.chkMonday.Text = "Monday";
			this.chkMonday.UseVisualStyleBackColor = true;
			// 
			// chkTuesday
			// 
			this.chkTuesday.AutoSize = true;
			this.chkTuesday.Location = new System.Drawing.Point(6, 42);
			this.chkTuesday.Name = "chkTuesday";
			this.chkTuesday.Size = new System.Drawing.Size(88, 24);
			this.chkTuesday.TabIndex = 3;
			this.chkTuesday.Text = "Tuesday";
			this.chkTuesday.UseVisualStyleBackColor = true;
			// 
			// chkWednesday
			// 
			this.chkWednesday.AutoSize = true;
			this.chkWednesday.Location = new System.Drawing.Point(6, 65);
			this.chkWednesday.Name = "chkWednesday";
			this.chkWednesday.Size = new System.Drawing.Size(112, 24);
			this.chkWednesday.TabIndex = 4;
			this.chkWednesday.Text = "Wednesday";
			this.chkWednesday.UseVisualStyleBackColor = true;
			// 
			// chkThursday
			// 
			this.chkThursday.AutoSize = true;
			this.chkThursday.Location = new System.Drawing.Point(6, 88);
			this.chkThursday.Name = "chkThursday";
			this.chkThursday.Size = new System.Drawing.Size(93, 24);
			this.chkThursday.TabIndex = 5;
			this.chkThursday.Text = "Thursday";
			this.chkThursday.UseVisualStyleBackColor = true;
			// 
			// chkFriday
			// 
			this.chkFriday.AutoSize = true;
			this.chkFriday.Location = new System.Drawing.Point(6, 111);
			this.chkFriday.Name = "chkFriday";
			this.chkFriday.Size = new System.Drawing.Size(71, 24);
			this.chkFriday.TabIndex = 6;
			this.chkFriday.Text = "Friday";
			this.chkFriday.UseVisualStyleBackColor = true;
			// 
			// chkSaturday
			// 
			this.chkSaturday.AutoSize = true;
			this.chkSaturday.Location = new System.Drawing.Point(5, 134);
			this.chkSaturday.Name = "chkSaturday";
			this.chkSaturday.Size = new System.Drawing.Size(92, 24);
			this.chkSaturday.TabIndex = 7;
			this.chkSaturday.Text = "Saturday";
			this.chkSaturday.UseVisualStyleBackColor = true;
			// 
			// chkSunday
			// 
			this.chkSunday.AutoSize = true;
			this.chkSunday.Location = new System.Drawing.Point(6, 158);
			this.chkSunday.Name = "chkSunday";
			this.chkSunday.Size = new System.Drawing.Size(82, 24);
			this.chkSunday.TabIndex = 8;
			this.chkSunday.Text = "Sunday";
			this.chkSunday.UseVisualStyleBackColor = true;
			// 
			// grpDaySelection
			// 
			this.grpDaySelection.Controls.Add(this.chkMonday);
			this.grpDaySelection.Controls.Add(this.chkSunday);
			this.grpDaySelection.Controls.Add(this.chkTuesday);
			this.grpDaySelection.Controls.Add(this.chkSaturday);
			this.grpDaySelection.Controls.Add(this.chkWednesday);
			this.grpDaySelection.Controls.Add(this.chkFriday);
			this.grpDaySelection.Controls.Add(this.chkThursday);
			this.grpDaySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.grpDaySelection.Location = new System.Drawing.Point(12, 108);
			this.grpDaySelection.Name = "grpDaySelection";
			this.grpDaySelection.Size = new System.Drawing.Size(307, 198);
			this.grpDaySelection.TabIndex = 9;
			this.grpDaySelection.TabStop = false;
			this.grpDaySelection.Text = "Selecting days of the week";
			// 
			// btnSelectSound
			// 
			this.btnSelectSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectSound.Location = new System.Drawing.Point(23, 384);
			this.btnSelectSound.Name = "btnSelectSound";
			this.btnSelectSound.Size = new System.Drawing.Size(109, 41);
			this.btnSelectSound.TabIndex = 12;
			this.btnSelectSound.Text = "Listen to the song";
			this.btnSelectSound.UseVisualStyleBackColor = true;
			this.btnSelectSound.Click += new System.EventHandler(this.btnSelectSound_Click);
			// 
			// btnInstall
			// 
			this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnInstall.Location = new System.Drawing.Point(387, 388);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(109, 32);
			this.btnInstall.TabIndex = 13;
			this.btnInstall.Text = "Set";
			this.btnInstall.UseVisualStyleBackColor = true;
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// lblSound
			// 
			this.lblSound.AutoSize = true;
			this.lblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSound.Location = new System.Drawing.Point(19, 309);
			this.lblSound.Name = "lblSound";
			this.lblSound.Size = new System.Drawing.Size(119, 20);
			this.lblSound.TabIndex = 11;
			this.lblSound.Text = "Alarm signal file";
			// 
			// comboBoxAudio
			// 
			this.comboBoxAudio.FormattingEnabled = true;
			this.comboBoxAudio.Location = new System.Drawing.Point(23, 343);
			this.comboBoxAudio.Name = "comboBoxAudio";
			this.comboBoxAudio.Size = new System.Drawing.Size(296, 21);
			this.comboBoxAudio.TabIndex = 14;
			this.comboBoxAudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudio_SelectedIndexChanged);
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 450);
			this.Controls.Add(this.comboBoxAudio);
			this.Controls.Add(this.btnInstall);
			this.Controls.Add(this.btnSelectSound);
			this.Controls.Add(this.lblSound);
			this.Controls.Add(this.grpDaySelection);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.dtpActivationDate);
			this.Name = "Alarm";
			this.Text = "Alarm";
			this.Load += new System.EventHandler(this.Alarm_Load);
			this.grpDaySelection.ResumeLayout(false);
			this.grpDaySelection.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpActivationDate;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.CheckBox chkMonday;
		private System.Windows.Forms.CheckBox chkTuesday;
		private System.Windows.Forms.CheckBox chkWednesday;
		private System.Windows.Forms.CheckBox chkThursday;
		private System.Windows.Forms.CheckBox chkFriday;
		private System.Windows.Forms.CheckBox chkSaturday;
		private System.Windows.Forms.CheckBox chkSunday;
		private System.Windows.Forms.GroupBox grpDaySelection;
		private System.Windows.Forms.Button btnSelectSound;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label lblSound;
		private System.Windows.Forms.ComboBox comboBoxAudio;
	}
}