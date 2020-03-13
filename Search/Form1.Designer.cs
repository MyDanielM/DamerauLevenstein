namespace Search
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.dictionary1 = new System.Windows.Forms.Button();
            this.dictionary2 = new System.Windows.Forms.Button();
            this.dictionary3 = new System.Windows.Forms.Button();
            this.Output1 = new System.Windows.Forms.Label();
            this.outputFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputNotFull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(13, 85);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(759, 38);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // dictionary1
            // 
            this.dictionary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionary1.Location = new System.Drawing.Point(13, 13);
            this.dictionary1.Name = "dictionary1";
            this.dictionary1.Size = new System.Drawing.Size(219, 66);
            this.dictionary1.TabIndex = 1;
            this.dictionary1.Text = "Мой словарь(RU)";
            this.dictionary1.UseVisualStyleBackColor = true;
            this.dictionary1.Click += new System.EventHandler(this.dictionary1_Click);
            // 
            // dictionary2
            // 
            this.dictionary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionary2.Location = new System.Drawing.Point(253, 13);
            this.dictionary2.Name = "dictionary2";
            this.dictionary2.Size = new System.Drawing.Size(219, 66);
            this.dictionary2.TabIndex = 2;
            this.dictionary2.Text = "Мой словарь(EU)";
            this.dictionary2.UseVisualStyleBackColor = true;
            this.dictionary2.Click += new System.EventHandler(this.dictionary2_Click);
            // 
            // dictionary3
            // 
            this.dictionary3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionary3.Location = new System.Drawing.Point(491, 13);
            this.dictionary3.Name = "dictionary3";
            this.dictionary3.Size = new System.Drawing.Size(281, 66);
            this.dictionary3.TabIndex = 3;
            this.dictionary3.Text = "Загрузить словарь";
            this.dictionary3.UseVisualStyleBackColor = true;
            // 
            // Output1
            // 
            this.Output1.AutoSize = true;
            this.Output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output1.Location = new System.Drawing.Point(12, 516);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(213, 24);
            this.Output1.TabIndex = 4;
            this.Output1.Text = "Точное совпадение:";
            // 
            // outputFull
            // 
            this.outputFull.AutoSize = true;
            this.outputFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputFull.Location = new System.Drawing.Point(249, 516);
            this.outputFull.Name = "outputFull";
            this.outputFull.Size = new System.Drawing.Size(0, 24);
            this.outputFull.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Возможно, вы имели в виду:";
            // 
            // outputNotFull
            // 
            this.outputNotFull.AutoSize = true;
            this.outputNotFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputNotFull.Location = new System.Drawing.Point(13, 160);
            this.outputNotFull.Name = "outputNotFull";
            this.outputNotFull.Size = new System.Drawing.Size(0, 20);
            this.outputNotFull.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.outputNotFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputFull);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.dictionary3);
            this.Controls.Add(this.dictionary2);
            this.Controls.Add(this.dictionary1);
            this.Controls.Add(this.inputTextBox);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button dictionary1;
        private System.Windows.Forms.Button dictionary2;
        private System.Windows.Forms.Button dictionary3;
        private System.Windows.Forms.Label Output1;
        private System.Windows.Forms.Label outputFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputNotFull;
    }
}

