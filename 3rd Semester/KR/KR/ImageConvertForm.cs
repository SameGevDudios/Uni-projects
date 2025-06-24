using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KR
{
    public partial class ConvertForm : Form
    {
        private string _selectedFilePath;
        private Image _originalImage;
        public ConvertForm()
        {
            InitializeComponent();
            SetGroupActive();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.webp;*.bmp)|*.png;*.jpeg;*.jpg;*.webp;*.bmp";

                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedFilePath = openFileDialog.FileName;
                    _originalImage = Image.FromFile(_selectedFilePath);
                    FileInfo info = new FileInfo(_selectedFilePath);
                    PreviewPicture.BackgroundImage = _originalImage;
                    FormatLabel.Text = info.Extension;
                    DimentionsLabel.Text = $"Размер: {_originalImage.Size.Width}x{_originalImage.Size.Height}";
                    SizeLabel.Text = $"Вес файла: {info.Length / 1024} Кбайт";
                    NameLabel.Text = $"Имя файла: {info.Name}";
                }
            }
        }

        private void PreviewPicture_Click(object sender, EventArgs e)
        {
            ImageDisplay.ShowForm(PreviewPicture.BackgroundImage, "Просмотр исходного изображения");
        }

        private void QualityTrackBar_Scroll(object sender, EventArgs e)
        {
            ConvertQualityLabel.Text = QualityTrackBar.Value.ToString();
        }

        private void SizeTrackBar_Scroll(object sender, EventArgs e)
        {
            ConvertSizeLabel.Text = SizeTrackBar.Value.ToString();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if(_selectedFilePath != null)
            {
                int index = FormatDropdown.SelectedIndex;
                if (index >= 0)
                {
                    ImageConverter.ConvertImage(_originalImage, index, QualityTrackBar.Value, out string filePath, out bool ok);
                    if (ok)
                        MessageBox.Show($"Изображение успешно сохранено\nПуть сохранения: {filePath}",
                        "Успешная конвертация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Выберите формат файла для конвератции.",
                        "Формат файла не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите изображение для конвертации, нажав на кнопку \"Выбрать изображение\".",
                        "Изображение не выбрано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormatDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGroupActive();
        }

        private void SetGroupActive()
        {
            ConvertSettingsGroup.Enabled = FormatDropdown.SelectedIndex == 1;
        }
    }
}
