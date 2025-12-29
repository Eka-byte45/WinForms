using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;


namespace Clock
{
	public partial class FontDialog : Form
	{
		public Font Font {  get; set; }
		int lastChosenIndex;
		public FontDialog()
		{
			InitializeComponent();
			lastChosenIndex = 0;
			LoadFonts("*.ttf");
			LoadFonts("*.otf");
			comboBoxFont.SelectedIndex = 1;
			LoadFontSettings();
		}

		private void FontDialog_Load(object sender, EventArgs e)
		{
			numericUpDownFontSize.Value = (decimal)Font.Size;
		}
		void LoadFonts(string extension)
		{
			string currentDir = Application.ExecutablePath;
			Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\..\\Fonts");
			//MessageBox.Show
			//	(
			//	this,
			//	Directory.GetCurrentDirectory(),
			//	//currentDir,
			//	"CurrentDyrectory",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(),extension);
			//comboBoxFont.Items.AddRange(files);//добавляем все содержимое массива files в выпадающий список(комбо бокс)
			for (int i = 0; i < files.Length; i++)
			{
				comboBoxFont.Items.Add( files[i].Split('\\').Last());
			}
		}

		private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			string info =$"Selected:\nIndex:\t{comboBoxFont.SelectedIndex.ToString()}";
			info += $"\nItem:\t{comboBoxFont.SelectedItem}";
			info += $"\nText:\t{comboBoxFont.SelectedText}";
			info += $"\nValue:\t{comboBoxFont.SelectedValue}";
			//MessageBox.Show(this, info,"SelectedIndexChanged", MessageBoxButtons.OK,MessageBoxIcon.Information);
			SetFont();
		}
		void SetFont()
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			//pfc.AddFontFile(filename);
			pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
			labelExample.Font = new Font(pfc.Families[0], (float)numericUpDownFontSize.Value);

		}
		void SaveFontSettings()
		{
			string filename = Path.Combine(Application.StartupPath, "font_settings.txt");
			StreamWriter writer = new StreamWriter(filename);
			writer.WriteLine(lastChosenIndex); // Индекс выбранного шрифта
			writer.WriteLine(numericUpDownFontSize.Value); // Размер шрифта
			writer.Close(); // Ручное закрытие потока
		}

		void LoadFontSettings()
		{
			string filename = Path.Combine(Application.StartupPath, "font_settings.txt");
			if (File.Exists(filename))
			{
				StreamReader reader = new StreamReader(filename);
				int index = int.Parse(reader.ReadLine());
				decimal size = decimal.Parse(reader.ReadLine());

				// Применяем последний выбранный шрифт
				comboBoxFont.SelectedIndex = index;
				numericUpDownFontSize.Value = size;
				SetFont(); // Устанавливаем шрифт на примере
				reader.Close(); // Ручное закрытие потока
			}
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Font = labelExample.Font;
			this.lastChosenIndex = comboBoxFont.SelectedIndex;
			SaveFontSettings();

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			labelExample.Font = this.Font;
			comboBoxFont.SelectedIndex = lastChosenIndex;
		}

		private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
		{
			SetFont();
		}

		private void FontDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveFontSettings();
		}
	}
}
