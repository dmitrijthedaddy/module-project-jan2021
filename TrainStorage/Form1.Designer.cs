namespace TrainStorage
{
    partial class Form1
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
            this.trainListBox = new System.Windows.Forms.ListBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departureRadioButton = new System.Windows.Forms.RadioButton();
            this.numberRadioButton = new System.Windows.Forms.RadioButton();
            this.destinationRadioButton = new System.Windows.Forms.RadioButton();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainListBox
            // 
            this.trainListBox.FormattingEnabled = true;
            this.trainListBox.Location = new System.Drawing.Point(12, 12);
            this.trainListBox.Name = "trainListBox";
            this.trainListBox.Size = new System.Drawing.Size(355, 199);
            this.trainListBox.TabIndex = 0;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(375, 12);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(149, 23);
            this.fillButton.TabIndex = 1;
            this.fillButton.Text = "Заполнить";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(375, 41);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(375, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departureRadioButton);
            this.groupBox1.Controls.Add(this.numberRadioButton);
            this.groupBox1.Controls.Add(this.destinationRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(375, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // departureRadioButton
            // 
            this.departureRadioButton.AutoSize = true;
            this.departureRadioButton.Location = new System.Drawing.Point(6, 65);
            this.departureRadioButton.Name = "departureRadioButton";
            this.departureRadioButton.Size = new System.Drawing.Size(137, 17);
            this.departureRadioButton.TabIndex = 2;
            this.departureRadioButton.TabStop = true;
            this.departureRadioButton.Text = "отправление (по дате)";
            this.departureRadioButton.UseVisualStyleBackColor = true;
            this.departureRadioButton.Click += new System.EventHandler(this.departureRadioButton_Click);
            // 
            // numberRadioButton
            // 
            this.numberRadioButton.AutoSize = true;
            this.numberRadioButton.Location = new System.Drawing.Point(6, 42);
            this.numberRadioButton.Name = "numberRadioButton";
            this.numberRadioButton.Size = new System.Drawing.Size(96, 17);
            this.numberRadioButton.TabIndex = 1;
            this.numberRadioButton.TabStop = true;
            this.numberRadioButton.Text = "номер поезда";
            this.numberRadioButton.UseVisualStyleBackColor = true;
            this.numberRadioButton.Click += new System.EventHandler(this.numberRadioButton_Click);
            // 
            // destinationRadioButton
            // 
            this.destinationRadioButton.AutoSize = true;
            this.destinationRadioButton.Location = new System.Drawing.Point(6, 19);
            this.destinationRadioButton.Name = "destinationRadioButton";
            this.destinationRadioButton.Size = new System.Drawing.Size(115, 17);
            this.destinationRadioButton.TabIndex = 0;
            this.destinationRadioButton.TabStop = true;
            this.destinationRadioButton.Text = "пункт назначения";
            this.destinationRadioButton.UseVisualStyleBackColor = true;
            this.destinationRadioButton.Click += new System.EventHandler(this.destinationRadioButton_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(12, 245);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(165, 20);
            this.destinationTextBox.TabIndex = 5;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 229);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(99, 13);
            this.destinationLabel.TabIndex = 6;
            this.destinationLabel.Text = "Пункт назначения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер поезда";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(183, 245);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(99, 20);
            this.numberTextBox.TabIndex = 7;
            // 
            // departureDateTime
            // 
            this.departureDateTime.CustomFormat = "MM.dd.yyyy HH:mm";
            this.departureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateTime.Location = new System.Drawing.Point(288, 245);
            this.departureDateTime.Name = "departureDateTime";
            this.departureDateTime.Size = new System.Drawing.Size(128, 20);
            this.departureDateTime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Отправляется";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(422, 243);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(236, 17);
            this.toolStripStatusLabel1.Text = "Проект по модулю (3 семестр), вариант 7";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(285, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Корнев Д.Е., ЭУ-293631";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 307);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departureDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.trainListBox);
            this.Name = "Form1";
            this.Text = "List<T>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox trainListBox;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton departureRadioButton;
        private System.Windows.Forms.RadioButton numberRadioButton;
        private System.Windows.Forms.RadioButton destinationRadioButton;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.DateTimePicker departureDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

