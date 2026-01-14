using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmDialog : Form
	{
		private AlarmsForm _parentForm;

		OpenFileDialog fileDialog;
		public AlarmDialog(AlarmsForm parent)//Форма AlarmDialog принимает ссылку на родительскую форму (AlarmsForm) в своём конструкторе
		{
			InitializeComponent();
			_parentForm = parent;//Хранение ссылки на родительскую форму

			dtpDate.Enabled = false;
			fileDialog = new OpenFileDialog();
			fileDialog.Filter = 
				"All sound files(*.mp3;*.flac;*.flacc;*.wav;*.aac;*.m4a)|*.mp3;*.flac;*.flacc;*.wav;*.aac;*.m4a|" +
				"mp3 files (*.mp3)|*.mp3|" +
				"Flac files(*.flac)|*.flac;*.flacc|"+
				"wav files(*.wav)|*.wav|"+
				"aac files(*.aac)|*.aac|"+
				"m4a files(*.m4a)|*.m4a;";
		}

		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = (sender as CheckBox).Checked;
			clbWeekDays.Enabled = !dtpDate.Enabled;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if(fileDialog.ShowDialog() == DialogResult.OK)
			{
				labelFilename.Text = fileDialog.FileName;
			}
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			PositionRelativeToParent();
		}

		private void PositionRelativeToParent()
		{
			Rectangle parentFormRect = _parentForm.Bounds;//Создаем объект прямоугольника, который представляет границы родительской формы
			//Bounds - свойство, которое возвращает размеры и местоположение родительской формы на экране
			int centerX = parentFormRect.X + parentFormRect.Width / 2;
			int Y = parentFormRect.Bottom;
			int left = centerX - this.Width / 2;
			int top = Y - this.Height/2;
			this.Location = new Point(left, top);
		}

	}
}
