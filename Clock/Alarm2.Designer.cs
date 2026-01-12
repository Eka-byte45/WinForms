namespace Clock
{
	partial class Alarm2
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkedListBox = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(235, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alarm";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(75, 285);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(132, 51);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(459, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 52);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// checkedListBox
			// 
			this.checkedListBox.FormattingEnabled = true;
			this.checkedListBox.Location = new System.Drawing.Point(75, 81);
			this.checkedListBox.Name = "checkedListBox";
			this.checkedListBox.Size = new System.Drawing.Size(518, 94);
			this.checkedListBox.TabIndex = 3;
			// 
			// Alarm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 398);
			this.Controls.Add(this.checkedListBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label1);
			this.Name = "Alarm2";
			this.Text = "Alarm2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckedListBox checkedListBox;
	}
}