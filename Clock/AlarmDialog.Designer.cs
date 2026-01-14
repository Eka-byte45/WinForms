namespace Clock
{
	partial class AlarmDialog
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
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
			this.labelWeekdays = new System.Windows.Forms.Label();
			this.clbWeekDays = new System.Windows.Forms.CheckedListBox();
			this.labelFilename = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "yyy.MM.dd";
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(26, 69);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(190, 31);
			this.dtpDate.TabIndex = 0;
			// 
			// dtpTime
			// 
			this.dtpTime.CustomFormat = "HH:mm:ss";
			this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTime.Location = new System.Drawing.Point(262, 69);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.Size = new System.Drawing.Size(190, 31);
			this.dtpTime.TabIndex = 1;
			// 
			// checkBoxUseDate
			// 
			this.checkBoxUseDate.AutoSize = true;
			this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxUseDate.Location = new System.Drawing.Point(26, 23);
			this.checkBoxUseDate.Name = "checkBoxUseDate";
			this.checkBoxUseDate.Size = new System.Drawing.Size(262, 29);
			this.checkBoxUseDate.TabIndex = 2;
			this.checkBoxUseDate.Text = "На определенную дату";
			this.checkBoxUseDate.UseVisualStyleBackColor = true;
			this.checkBoxUseDate.CheckedChanged += new System.EventHandler(this.checkBoxUseDate_CheckedChanged);
			// 
			// labelWeekdays
			// 
			this.labelWeekdays.AutoSize = true;
			this.labelWeekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWeekdays.Location = new System.Drawing.Point(21, 123);
			this.labelWeekdays.Name = "labelWeekdays";
			this.labelWeekdays.Size = new System.Drawing.Size(130, 25);
			this.labelWeekdays.TabIndex = 3;
			this.labelWeekdays.Text = "Дни недели";
			// 
			// clbWeekDays
			// 
			this.clbWeekDays.CheckOnClick = true;
			this.clbWeekDays.ColumnWidth = 58;
			this.clbWeekDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clbWeekDays.FormattingEnabled = true;
			this.clbWeekDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.clbWeekDays.Location = new System.Drawing.Point(26, 161);
			this.clbWeekDays.MultiColumn = true;
			this.clbWeekDays.Name = "clbWeekDays";
			this.clbWeekDays.Size = new System.Drawing.Size(426, 25);
			this.clbWeekDays.TabIndex = 4;
			this.clbWeekDays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbWeekDays_ItemCheck);
			this.clbWeekDays.SelectedIndexChanged += new System.EventHandler(this.clbWeekDays_SelectedIndexChanged);
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Location = new System.Drawing.Point(23, 214);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(52, 13);
			this.labelFilename.TabIndex = 5;
			this.labelFilename.Text = "Filename:";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(26, 255);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(100, 31);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(233, 255);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(98, 31);
			this.buttonOk.TabIndex = 7;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(386, 256);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// AlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 313);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelFilename);
			this.Controls.Add(this.clbWeekDays);
			this.Controls.Add(this.labelWeekdays);
			this.Controls.Add(this.checkBoxUseDate);
			this.Controls.Add(this.dtpTime);
			this.Controls.Add(this.dtpDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AlarmDialog";
			this.Text = "AlarmDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.CheckBox checkBoxUseDate;
		private System.Windows.Forms.Label labelWeekdays;
		private System.Windows.Forms.CheckedListBox clbWeekDays;
		private System.Windows.Forms.Label labelFilename;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}