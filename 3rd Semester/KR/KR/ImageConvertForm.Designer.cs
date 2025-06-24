namespace KR
{
    partial class ConvertForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.Previewlabel = new System.Windows.Forms.Label();
            this.PreviewPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FormatDropdown = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DimentionsLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ConvertSettingsGroup = new System.Windows.Forms.GroupBox();
            this.SizeTrackBar = new System.Windows.Forms.TrackBar();
            this.ConvertSizeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QualityTrackBar = new System.Windows.Forms.TrackBar();
            this.ConvertQualityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicture)).BeginInit();
            this.ConvertSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectImageButton.Location = new System.Drawing.Point(12, 12);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(211, 50);
            this.SelectImageButton.TabIndex = 0;
            this.SelectImageButton.Text = "Выбрать изображение";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // Previewlabel
            // 
            this.Previewlabel.AutoSize = true;
            this.Previewlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Previewlabel.Location = new System.Drawing.Point(12, 77);
            this.Previewlabel.Name = "Previewlabel";
            this.Previewlabel.Size = new System.Drawing.Size(134, 18);
            this.Previewlabel.TabIndex = 1;
            this.Previewlabel.Text = "Предпросмотр:";
            // 
            // PreviewPicture
            // 
            this.PreviewPicture.BackgroundImage = global::KR.Properties.Resources.Default;
            this.PreviewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviewPicture.Location = new System.Drawing.Point(15, 98);
            this.PreviewPicture.Name = "PreviewPicture";
            this.PreviewPicture.Size = new System.Drawing.Size(208, 208);
            this.PreviewPicture.TabIndex = 2;
            this.PreviewPicture.TabStop = false;
            this.PreviewPicture.Click += new System.EventHandler(this.PreviewPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный формат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(485, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конвертировать в:";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.BackColor = System.Drawing.Color.LightGray;
            this.FormatLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormatLabel.Location = new System.Drawing.Point(264, 44);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(47, 18);
            this.FormatLabel.TabIndex = 1;
            this.FormatLabel.Text = ".png";
            // 
            // FormatDropdown
            // 
            this.FormatDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatDropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormatDropdown.FormattingEnabled = true;
            this.FormatDropdown.Items.AddRange(new object[] {
            ".png",
            ".jpeg",
            ".bmp"});
            this.FormatDropdown.Location = new System.Drawing.Point(488, 41);
            this.FormatDropdown.Name = "FormatDropdown";
            this.FormatDropdown.Size = new System.Drawing.Size(174, 26);
            this.FormatDropdown.TabIndex = 3;
            this.FormatDropdown.SelectedIndexChanged += new System.EventHandler(this.FormatDropdown_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 341);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(111, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя: image.png";
            // 
            // DimentionsLabel
            // 
            this.DimentionsLabel.AutoSize = true;
            this.DimentionsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimentionsLabel.Location = new System.Drawing.Point(12, 309);
            this.DimentionsLabel.Name = "DimentionsLabel";
            this.DimentionsLabel.Size = new System.Drawing.Size(121, 16);
            this.DimentionsLabel.TabIndex = 1;
            this.DimentionsLabel.Text = "Размер: 800x600";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.Location = new System.Drawing.Point(12, 325);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(158, 16);
            this.SizeLabel.TabIndex = 1;
            this.SizeLabel.Text = "Вес файла: 148 Кбайт";
            // 
            // ConvertSettingsGroup
            // 
            this.ConvertSettingsGroup.Controls.Add(this.SizeTrackBar);
            this.ConvertSettingsGroup.Controls.Add(this.ConvertSizeLabel);
            this.ConvertSettingsGroup.Controls.Add(this.label9);
            this.ConvertSettingsGroup.Controls.Add(this.QualityTrackBar);
            this.ConvertSettingsGroup.Controls.Add(this.ConvertQualityLabel);
            this.ConvertSettingsGroup.Controls.Add(this.label7);
            this.ConvertSettingsGroup.Location = new System.Drawing.Point(267, 107);
            this.ConvertSettingsGroup.Name = "ConvertSettingsGroup";
            this.ConvertSettingsGroup.Size = new System.Drawing.Size(395, 123);
            this.ConvertSettingsGroup.TabIndex = 4;
            this.ConvertSettingsGroup.TabStop = false;
            this.ConvertSettingsGroup.Text = "Настройки конвертации";
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.Location = new System.Drawing.Point(6, 83);
            this.SizeTrackBar.Maximum = 8192;
            this.SizeTrackBar.Minimum = 10;
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(346, 45);
            this.SizeTrackBar.TabIndex = 8;
            this.SizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SizeTrackBar.Value = 8192;
            this.SizeTrackBar.Visible = false;
            this.SizeTrackBar.Scroll += new System.EventHandler(this.SizeTrackBar_Scroll);
            // 
            // ConvertSizeLabel
            // 
            this.ConvertSizeLabel.AutoSize = true;
            this.ConvertSizeLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertSizeLabel.Location = new System.Drawing.Point(358, 83);
            this.ConvertSizeLabel.Name = "ConvertSizeLabel";
            this.ConvertSizeLabel.Size = new System.Drawing.Size(39, 16);
            this.ConvertSizeLabel.TabIndex = 6;
            this.ConvertSizeLabel.Text = "8192";
            this.ConvertSizeLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Предпочитаемый размер файла, Кбайт";
            this.label9.Visible = false;
            // 
            // QualityTrackBar
            // 
            this.QualityTrackBar.Location = new System.Drawing.Point(6, 35);
            this.QualityTrackBar.Maximum = 100;
            this.QualityTrackBar.Name = "QualityTrackBar";
            this.QualityTrackBar.Size = new System.Drawing.Size(346, 45);
            this.QualityTrackBar.SmallChange = 5;
            this.QualityTrackBar.TabIndex = 5;
            this.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.QualityTrackBar.Value = 100;
            this.QualityTrackBar.Scroll += new System.EventHandler(this.QualityTrackBar_Scroll);
            // 
            // ConvertQualityLabel
            // 
            this.ConvertQualityLabel.AutoSize = true;
            this.ConvertQualityLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertQualityLabel.Location = new System.Drawing.Point(358, 35);
            this.ConvertQualityLabel.Name = "ConvertQualityLabel";
            this.ConvertQualityLabel.Size = new System.Drawing.Size(31, 16);
            this.ConvertQualityLabel.TabIndex = 1;
            this.ConvertQualityLabel.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Качество изображения, %";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.Location = new System.Drawing.Point(267, 241);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(395, 100);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Конвертировать и сохранить";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 370);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertSettingsGroup);
            this.Controls.Add(this.FormatDropdown);
            this.Controls.Add(this.PreviewPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.DimentionsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Previewlabel);
            this.Controls.Add(this.SelectImageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертировать изображение";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicture)).EndInit();
            this.ConvertSettingsGroup.ResumeLayout(false);
            this.ConvertSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Label Previewlabel;
        private System.Windows.Forms.PictureBox PreviewPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.ComboBox FormatDropdown;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DimentionsLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.GroupBox ConvertSettingsGroup;
        private System.Windows.Forms.TrackBar QualityTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar SizeTrackBar;
        private System.Windows.Forms.Label ConvertSizeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ConvertQualityLabel;
        private System.Windows.Forms.Button ConvertButton;
    }
}

