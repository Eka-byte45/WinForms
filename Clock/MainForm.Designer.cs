namespace Clock
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.cbShowWeekday = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.всегдаПоверхОстальныхОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(13, 14);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(261, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime";
			this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseDown);
			this.labelTime.MouseHover += new System.EventHandler(this.labelTime_MouseHover);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(43, 168);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(176, 29);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Показать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			// 
			// cbShowWeekday
			// 
			this.cbShowWeekday.AutoSize = true;
			this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowWeekday.Location = new System.Drawing.Point(43, 217);
			this.cbShowWeekday.Name = "cbShowWeekday";
			this.cbShowWeekday.Size = new System.Drawing.Size(256, 29);
			this.cbShowWeekday.TabIndex = 2;
			this.cbShowWeekday.Text = "Показать день недели";
			this.cbShowWeekday.UseVisualStyleBackColor = true;
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(43, 264);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(248, 67);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "System tray";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
			// 
			// всегдаПоверхОстальныхОконToolStripMenuItem
			// 
			this.всегдаПоверхОстальныхОконToolStripMenuItem.Name = "всегдаПоверхОстальныхОконToolStripMenuItem";
			this.всегдаПоверхОстальныхОконToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// contextMenuStripMain
			// 
			this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem8,
            this.ToolStripMenuItem6});
			this.contextMenuStripMain.Name = "contextMenuStripMain";
			this.contextMenuStripMain.Size = new System.Drawing.Size(135, 92);
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem7});
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItem1.Text = "Вид";
			// 
			// ToolStripMenuItem2
			// 
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(265, 22);
			this.ToolStripMenuItem2.Text = "Показывать элементы управления";
			this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
			// 
			// ToolStripMenuItem3
			// 
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new System.Drawing.Size(265, 22);
			this.ToolStripMenuItem3.Text = "Отображать дату";
			this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
			// 
			// ToolStripMenuItem7
			// 
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new System.Drawing.Size(265, 22);
			this.ToolStripMenuItem7.Text = "Отображать день недели";
			this.ToolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
			// 
			// ToolStripMenuItem4
			// 
			this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5});
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItem4.Text = "Настройки";
			// 
			// ToolStripMenuItem5
			// 
			this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			this.ToolStripMenuItem5.Size = new System.Drawing.Size(244, 22);
			this.ToolStripMenuItem5.Text = "Всегда поверх остальных окон";
			this.ToolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
			// 
			// ToolStripMenuItem8
			// 
			this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
			this.ToolStripMenuItem8.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItem8.Text = "Будильник";
			// 
			// ToolStripMenuItem6
			// 
			this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			this.ToolStripMenuItem6.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItem6.Text = "Выход";
			this.ToolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 352);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowWeekday);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ClockPV_521";
			this.contextMenuStripMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.CheckBox cbShowWeekday;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripMenuItem всегдаПоверхОстальныхОконToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem8;
	}
}

