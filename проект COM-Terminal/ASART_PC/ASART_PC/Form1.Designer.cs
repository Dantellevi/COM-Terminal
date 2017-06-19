namespace ASART_PC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStop_Bits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxForm_Data = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBit_paraty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBUAD_Speed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPORT = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStop_Bits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxForm_Data);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBit_paraty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBUAD_Speed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Нажмите для соединения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "стоп биты";
            // 
            // comboBoxStop_Bits
            // 
            this.comboBoxStop_Bits.FormattingEnabled = true;
            this.comboBoxStop_Bits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxStop_Bits.Location = new System.Drawing.Point(335, 59);
            this.comboBoxStop_Bits.Name = "comboBoxStop_Bits";
            this.comboBoxStop_Bits.Size = new System.Drawing.Size(135, 21);
            this.comboBoxStop_Bits.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Формат данных";
            // 
            // comboBoxForm_Data
            // 
            this.comboBoxForm_Data.FormattingEnabled = true;
            this.comboBoxForm_Data.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comboBoxForm_Data.Location = new System.Drawing.Point(102, 65);
            this.comboBoxForm_Data.Name = "comboBoxForm_Data";
            this.comboBoxForm_Data.Size = new System.Drawing.Size(145, 21);
            this.comboBoxForm_Data.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Бит четности";
            // 
            // comboBoxBit_paraty
            // 
            this.comboBoxBit_paraty.FormattingEnabled = true;
            this.comboBoxBit_paraty.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBoxBit_paraty.Location = new System.Drawing.Point(603, 18);
            this.comboBoxBit_paraty.Name = "comboBoxBit_paraty";
            this.comboBoxBit_paraty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBit_paraty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скорость";
            // 
            // comboBoxBUAD_Speed
            // 
            this.comboBoxBUAD_Speed.FormattingEnabled = true;
            this.comboBoxBUAD_Speed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBUAD_Speed.Location = new System.Drawing.Point(298, 18);
            this.comboBoxBUAD_Speed.Name = "comboBoxBUAD_Speed";
            this.comboBoxBUAD_Speed.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBUAD_Speed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порт";
            // 
            // comboBoxPORT
            // 
            this.comboBoxPORT.FormattingEnabled = true;
            this.comboBoxPORT.Location = new System.Drawing.Point(74, 20);
            this.comboBoxPORT.Name = "comboBoxPORT";
            this.comboBoxPORT.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPORT.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(782, 304);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Терминал";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStop_Bits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForm_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBit_paraty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBUAD_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPORT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

