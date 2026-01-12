using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Clock
{
	public partial class Alarm : Form
	{
		public MainForm mainForm; // ссылка на главную форму
		string selectedSong = "";
		string audioFolderPath = ""; // Полный путь к папке с аудиофайлами
        public DateTime alarmTime { get; set; } = DateTime.MinValue;
		public Alarm(MainForm parentForm)
		{
			InitializeComponent();
			mainForm = parentForm; // сохраняем ссылку на основную форму
		}

		private List<string> GetSelectedDays()
		{
			List<string> selectedDays = new List<string>();
			if (chkMonday.Checked) selectedDays.Add("Monday");
			if (chkTuesday.Checked) selectedDays.Add("Tuesday");
			if (chkThursday.Checked) selectedDays.Add("Thursday");
			if (chkFriday.Checked) selectedDays.Add("Friday");
			if (chkSaturday.Checked) selectedDays.Add("Saturday");
			if (chkSunday.Checked) selectedDays.Add("Sunday");

			return selectedDays;
		}

		private void Alarm_Load(object sender, EventArgs e)
		{
			this.dtpActivationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpActivationDate.CustomFormat = "dd MMMM yyyy HH:mm";
			this.dtpActivationDate.ShowUpDown = true;

			// Получаем путь к папке с аудиофайлами относительно исполняемого файла
			audioFolderPath = Path.Combine(Application.StartupPath, "..", "..", "AudioFiles");

			// Проверяем существование папки
			if (!Directory.Exists(audioFolderPath))
			{
				MessageBox.Show("Каталог с аудиофайлами не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Читаем названия файлов и добавляем их в комбобокс
			string[] files = Directory.GetFiles(audioFolderPath);
			foreach (string file in files)
			{
				comboBoxAudio.Items.Add(Path.GetFileName(file)); // добавляем имя файла в комбобокс
			}

		}

		private void btnSelectSound_Click(object sender, EventArgs e)
		{
			PlaySound();
		}

		private void comboBoxAudio_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxAudio.SelectedItem != null)
			{
				selectedSong = comboBoxAudio.SelectedItem.ToString();
				//MessageBox.Show($"Вы выбрали песню: {selectedSong}");
				//MessageBox.Show($"Выбранная песня: {selectedSong}, путь: {Path.Combine(audioFolderPath, selectedSong)}");
			}
		}

		public void PlaySound()
		{
			if (!string.IsNullOrEmpty(selectedSong)) // Проверяем, выбрана ли песня
			{
				// Полный путь к файлу
				string fullPath = Path.Combine(audioFolderPath, selectedSong);

				// Диагностика: выводим путь в консоль
				//Console.WriteLine($"Полный путь к файлу: {fullPath}");

				// Проверяем существование файла
				if (File.Exists(fullPath))
				{
					try
					{
						SoundPlayer player = new SoundPlayer(fullPath);
						player.Play();
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка воспроизведения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show($"Файл '{fullPath}' не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Файл не выбран.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnInstall_Click(object sender, EventArgs e)
		{
			if (dtpActivationDate.Value <= DateTime.Now)
			{
				MessageBox.Show("Нельзя установить будильник на прошедшее время.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			alarmTime = dtpActivationDate.Value;
			Console.WriteLine($"Установлено время будильника: {alarmTime}");
			MessageBox.Show($"Будильник установлен на {dtpActivationDate.Value.ToString("dd/MM/yyyy HH:mm")}.", "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		public void ResetAlarm()
		{
			alarmTime = DateTime.MinValue;
		}
	}

}
	
		

