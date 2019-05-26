namespace Text_editor
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.Cb3 = new System.Windows.Forms.ComboBox();
            this.Cb1 = new System.Windows.Forms.ComboBox();
            this.Text_read = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.Cb2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(22, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(21, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(87, 13);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(126, 20);
            this.T1.TabIndex = 4;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(87, 59);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(126, 20);
            this.T3.TabIndex = 5;
            // 
            // Cb3
            // 
            this.Cb3.FormattingEnabled = true;
            this.Cb3.Location = new System.Drawing.Point(235, 58);
            this.Cb3.Name = "Cb3";
            this.Cb3.Size = new System.Drawing.Size(55, 21);
            this.Cb3.TabIndex = 9;
            // 
            // Cb1
            // 
            this.Cb1.FormattingEnabled = true;
            this.Cb1.Location = new System.Drawing.Point(235, 13);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(54, 21);
            this.Cb1.TabIndex = 8;
            // 
            // Text_read
            // 
            this.Text_read.AllowDrop = true;
            this.Text_read.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_read.Location = new System.Drawing.Point(22, 111);
            this.Text_read.Multiline = true;
            this.Text_read.Name = "Text_read";
            this.Text_read.Size = new System.Drawing.Size(560, 179);
            this.Text_read.TabIndex = 10;
            this.Text_read.TextChanged += new System.EventHandler(this.Text_read_TextChanged);
            this.Text_read.DragDrop += new System.Windows.Forms.DragEventHandler(this.Text_read_DragDrop);
            this.Text_read.DragEnter += new System.Windows.Forms.DragEventHandler(this.Text_read_DragEnter);
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(302, 14);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(127, 20);
            this.T2.TabIndex = 11;
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(302, 59);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(126, 20);
            this.T4.TabIndex = 12;
            // 
            // Cb2
            // 
            this.Cb2.FormattingEnabled = true;
            this.Cb2.Location = new System.Drawing.Point(12, 58);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(58, 21);
            this.Cb2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.T4);
            this.panel1.Controls.Add(this.T2);
            this.panel1.Controls.Add(this.Cb3);
            this.panel1.Controls.Add(this.Cb1);
            this.panel1.Controls.Add(this.T3);
            this.panel1.Controls.Add(this.T1);
            this.panel1.Controls.Add(this.Cb2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(153, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 90);
            this.panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Text_read);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Window Title";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.ComboBox Cb3;
        private System.Windows.Forms.ComboBox Cb1;
        private System.Windows.Forms.TextBox Text_read;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.ComboBox Cb2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

