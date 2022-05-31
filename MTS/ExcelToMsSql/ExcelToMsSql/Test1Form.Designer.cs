namespace ExcelToMsSql
{
    partial class Test1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.button_create_excel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Формирование отчета";
            // 
            // textBox_year
            // 
            this.textBox_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_year.Location = new System.Drawing.Point(45, 130);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(281, 20);
            this.textBox_year.TabIndex = 1;
            this.textBox_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_create_excel
            // 
            this.button_create_excel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_create_excel.Location = new System.Drawing.Point(100, 156);
            this.button_create_excel.Name = "button_create_excel";
            this.button_create_excel.Size = new System.Drawing.Size(164, 29);
            this.button_create_excel.TabIndex = 2;
            this.button_create_excel.Text = "Сформировать отчет";
            this.button_create_excel.UseVisualStyleBackColor = true;
            this.button_create_excel.Click += new System.EventHandler(this.button_create_excel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите год, по которому требуется получить данные:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите полный путь к папке, где расположен файл";
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_filePath.Location = new System.Drawing.Point(42, 48);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(284, 20);
            this.textBox_filePath.TabIndex = 5;
            this.textBox_filePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_chooseFile.Location = new System.Drawing.Point(100, 74);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(164, 29);
            this.button_chooseFile.TabIndex = 2;
            this.button_chooseFile.Text = "Выбрать файл";
            this.button_chooseFile.UseVisualStyleBackColor = true;
            // 
            // Test1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 205);
            this.Controls.Add(this.textBox_filePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_chooseFile);
            this.Controls.Add(this.button_create_excel);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label1);
            this.Name = "Test1Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Задание1";
            this.Load += new System.EventHandler(this.Test1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Button button_create_excel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_chooseFile;
    }
}