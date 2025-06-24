
namespace KR2
{
    partial class SearchOptimizationResearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateArrayButton = new System.Windows.Forms.Button();
            this.GenerateArrayLengthText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateArrayMaxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateArrayMinText = new System.Windows.Forms.TextBox();
            this.GenerateArrayTextOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinearSearchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FindElementTextLinear = new System.Windows.Forms.TextBox();
            this.LinearSearchTextOutput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InterpolationSearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FindElementTextInterpolation = new System.Windows.Forms.TextBox();
            this.InterpolationSearchTextOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BinarySearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FindElementTextBinary = new System.Windows.Forms.TextBox();
            this.BinarySearchTextOutput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IterationsText = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.IncreaseIterationsButton = new System.Windows.Forms.Button();
            this.DecreaseIterationsButton = new System.Windows.Forms.Button();
            this.StartAllSearchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.GenerateArrayButton);
            this.groupBox1.Controls.Add(this.GenerateArrayLengthText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GenerateArrayMaxText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GenerateArrayMinText);
            this.groupBox1.Controls.Add(this.GenerateArrayTextOutput);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 433);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация массива";
            // 
            // GenerateArrayButton
            // 
            this.GenerateArrayButton.BackColor = System.Drawing.SystemColors.Window;
            this.GenerateArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateArrayButton.Location = new System.Drawing.Point(6, 385);
            this.GenerateArrayButton.Name = "GenerateArrayButton";
            this.GenerateArrayButton.Size = new System.Drawing.Size(187, 42);
            this.GenerateArrayButton.TabIndex = 4;
            this.GenerateArrayButton.Text = "Создать массив";
            this.GenerateArrayButton.UseVisualStyleBackColor = false;
            this.GenerateArrayButton.Click += new System.EventHandler(this.GenerateArrayButton_Click);
            // 
            // GenerateArrayLengthText
            // 
            this.GenerateArrayLengthText.Location = new System.Drawing.Point(104, 303);
            this.GenerateArrayLengthText.Name = "GenerateArrayLengthText";
            this.GenerateArrayLengthText.Size = new System.Drawing.Size(90, 20);
            this.GenerateArrayLengthText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина массива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "До:";
            // 
            // GenerateArrayMaxText
            // 
            this.GenerateArrayMaxText.Location = new System.Drawing.Point(34, 356);
            this.GenerateArrayMaxText.Name = "GenerateArrayMaxText";
            this.GenerateArrayMaxText.Size = new System.Drawing.Size(159, 20);
            this.GenerateArrayMaxText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "От:";
            // 
            // GenerateArrayMinText
            // 
            this.GenerateArrayMinText.Location = new System.Drawing.Point(35, 329);
            this.GenerateArrayMinText.Name = "GenerateArrayMinText";
            this.GenerateArrayMinText.Size = new System.Drawing.Size(159, 20);
            this.GenerateArrayMinText.TabIndex = 2;
            // 
            // GenerateArrayTextOutput
            // 
            this.GenerateArrayTextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.GenerateArrayTextOutput.Location = new System.Drawing.Point(6, 16);
            this.GenerateArrayTextOutput.Multiline = true;
            this.GenerateArrayTextOutput.Name = "GenerateArrayTextOutput";
            this.GenerateArrayTextOutput.ReadOnly = true;
            this.GenerateArrayTextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenerateArrayTextOutput.Size = new System.Drawing.Size(187, 281);
            this.GenerateArrayTextOutput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.LinearSearchButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FindElementTextLinear);
            this.groupBox2.Controls.Add(this.LinearSearchTextOutput);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 433);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Линейный поиск";
            // 
            // LinearSearchButton
            // 
            this.LinearSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.LinearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LinearSearchButton.Location = new System.Drawing.Point(6, 385);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(187, 42);
            this.LinearSearchButton.TabIndex = 7;
            this.LinearSearchButton.Text = "Найти";
            this.LinearSearchButton.UseVisualStyleBackColor = false;
            this.LinearSearchButton.Click += new System.EventHandler(this.LinearSearchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Найти элемент:";
            // 
            // FindElementTextLinear
            // 
            this.FindElementTextLinear.Location = new System.Drawing.Point(99, 356);
            this.FindElementTextLinear.Name = "FindElementTextLinear";
            this.FindElementTextLinear.Size = new System.Drawing.Size(95, 20);
            this.FindElementTextLinear.TabIndex = 6;
            // 
            // LinearSearchTextOutput
            // 
            this.LinearSearchTextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.LinearSearchTextOutput.Location = new System.Drawing.Point(6, 16);
            this.LinearSearchTextOutput.Multiline = true;
            this.LinearSearchTextOutput.Name = "LinearSearchTextOutput";
            this.LinearSearchTextOutput.ReadOnly = true;
            this.LinearSearchTextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LinearSearchTextOutput.Size = new System.Drawing.Size(187, 329);
            this.LinearSearchTextOutput.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.InterpolationSearchButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.FindElementTextInterpolation);
            this.groupBox3.Controls.Add(this.InterpolationSearchTextOutput);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 433);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Интерполяционный поиск";
            // 
            // InterpolationSearchButton
            // 
            this.InterpolationSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.InterpolationSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InterpolationSearchButton.Location = new System.Drawing.Point(6, 385);
            this.InterpolationSearchButton.Name = "InterpolationSearchButton";
            this.InterpolationSearchButton.Size = new System.Drawing.Size(187, 42);
            this.InterpolationSearchButton.TabIndex = 10;
            this.InterpolationSearchButton.Text = "Найти";
            this.InterpolationSearchButton.UseVisualStyleBackColor = false;
            this.InterpolationSearchButton.Click += new System.EventHandler(this.InterpolationSearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Найти элемент:";
            // 
            // FindElementTextInterpolation
            // 
            this.FindElementTextInterpolation.Location = new System.Drawing.Point(99, 356);
            this.FindElementTextInterpolation.Name = "FindElementTextInterpolation";
            this.FindElementTextInterpolation.Size = new System.Drawing.Size(95, 20);
            this.FindElementTextInterpolation.TabIndex = 9;
            // 
            // InterpolationSearchTextOutput
            // 
            this.InterpolationSearchTextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.InterpolationSearchTextOutput.Location = new System.Drawing.Point(6, 16);
            this.InterpolationSearchTextOutput.Multiline = true;
            this.InterpolationSearchTextOutput.Name = "InterpolationSearchTextOutput";
            this.InterpolationSearchTextOutput.ReadOnly = true;
            this.InterpolationSearchTextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InterpolationSearchTextOutput.Size = new System.Drawing.Size(187, 329);
            this.InterpolationSearchTextOutput.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.BinarySearchButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.FindElementTextBinary);
            this.groupBox4.Controls.Add(this.BinarySearchTextOutput);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(630, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 433);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Бинарный поиск";
            // 
            // BinarySearchButton
            // 
            this.BinarySearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.BinarySearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BinarySearchButton.Location = new System.Drawing.Point(6, 385);
            this.BinarySearchButton.Name = "BinarySearchButton";
            this.BinarySearchButton.Size = new System.Drawing.Size(187, 42);
            this.BinarySearchButton.TabIndex = 13;
            this.BinarySearchButton.Text = "Найти";
            this.BinarySearchButton.UseVisualStyleBackColor = false;
            this.BinarySearchButton.Click += new System.EventHandler(this.BinarySearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Найти элемент:";
            // 
            // FindElementTextBinary
            // 
            this.FindElementTextBinary.Location = new System.Drawing.Point(99, 356);
            this.FindElementTextBinary.Name = "FindElementTextBinary";
            this.FindElementTextBinary.Size = new System.Drawing.Size(95, 20);
            this.FindElementTextBinary.TabIndex = 12;
            // 
            // BinarySearchTextOutput
            // 
            this.BinarySearchTextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.BinarySearchTextOutput.Location = new System.Drawing.Point(6, 16);
            this.BinarySearchTextOutput.Multiline = true;
            this.BinarySearchTextOutput.Name = "BinarySearchTextOutput";
            this.BinarySearchTextOutput.ReadOnly = true;
            this.BinarySearchTextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinarySearchTextOutput.Size = new System.Drawing.Size(187, 329);
            this.BinarySearchTextOutput.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lavender;
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.IterationsText);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.IncreaseIterationsButton);
            this.groupBox5.Controls.Add(this.DecreaseIterationsButton);
            this.groupBox5.Controls.Add(this.StartAllSearchButton);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(836, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 345);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Главный контроллер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество повторений";
            // 
            // IterationsText
            // 
            this.IterationsText.BackColor = System.Drawing.SystemColors.Window;
            this.IterationsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IterationsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IterationsText.Location = new System.Drawing.Point(18, 126);
            this.IterationsText.Name = "IterationsText";
            this.IterationsText.ReadOnly = true;
            this.IterationsText.Size = new System.Drawing.Size(157, 24);
            this.IterationsText.TabIndex = 17;
            this.IterationsText.Text = "10";
            this.IterationsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.Location = new System.Drawing.Point(5, 91);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(187, 94);
            this.textBox11.TabIndex = 11;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncreaseIterationsButton
            // 
            this.IncreaseIterationsButton.BackColor = System.Drawing.SystemColors.Window;
            this.IncreaseIterationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncreaseIterationsButton.Location = new System.Drawing.Point(66, 191);
            this.IncreaseIterationsButton.Name = "IncreaseIterationsButton";
            this.IncreaseIterationsButton.Size = new System.Drawing.Size(60, 40);
            this.IncreaseIterationsButton.TabIndex = 15;
            this.IncreaseIterationsButton.Text = "x10";
            this.IncreaseIterationsButton.UseVisualStyleBackColor = false;
            this.IncreaseIterationsButton.Click += new System.EventHandler(this.IncreaseIterationsButton_Click);
            // 
            // DecreaseIterationsButton
            // 
            this.DecreaseIterationsButton.BackColor = System.Drawing.SystemColors.Window;
            this.DecreaseIterationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecreaseIterationsButton.Location = new System.Drawing.Point(66, 45);
            this.DecreaseIterationsButton.Name = "DecreaseIterationsButton";
            this.DecreaseIterationsButton.Size = new System.Drawing.Size(60, 40);
            this.DecreaseIterationsButton.TabIndex = 14;
            this.DecreaseIterationsButton.Text = "x0.1";
            this.DecreaseIterationsButton.UseVisualStyleBackColor = false;
            this.DecreaseIterationsButton.Click += new System.EventHandler(this.DecreaseIterationsButton_Click);
            // 
            // StartAllSearchButton
            // 
            this.StartAllSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.StartAllSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartAllSearchButton.Location = new System.Drawing.Point(6, 266);
            this.StartAllSearchButton.Name = "StartAllSearchButton";
            this.StartAllSearchButton.Size = new System.Drawing.Size(187, 73);
            this.StartAllSearchButton.TabIndex = 16;
            this.StartAllSearchButton.Text = "Запустить все методы поиска";
            this.StartAllSearchButton.UseVisualStyleBackColor = false;
            this.StartAllSearchButton.Click += new System.EventHandler(this.StartAllSearchButton_Click);
            // 
            // SearchOptimizationResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::KR2.Properties.Resources.Gradient21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 457);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchOptimizationResearchForm";
            this.Text = "Исследование методов оптимизации поиска";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GenerateArrayButton;
        private System.Windows.Forms.TextBox GenerateArrayLengthText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenerateArrayMaxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GenerateArrayMinText;
        private System.Windows.Forms.TextBox GenerateArrayTextOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LinearSearchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FindElementTextLinear;
        private System.Windows.Forms.TextBox LinearSearchTextOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button InterpolationSearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindElementTextInterpolation;
        private System.Windows.Forms.TextBox InterpolationSearchTextOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BinarySearchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FindElementTextBinary;
        private System.Windows.Forms.TextBox BinarySearchTextOutput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IterationsText;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button IncreaseIterationsButton;
        private System.Windows.Forms.Button DecreaseIterationsButton;
        private System.Windows.Forms.Button StartAllSearchButton;
    }
}

