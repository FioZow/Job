namespace ExcelToMsSql
{
    partial class StartForm
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
            this.button_test0_open = new System.Windows.Forms.Button();
            this.button_test1_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_test0_open
            // 
            this.button_test0_open.Location = new System.Drawing.Point(12, 24);
            this.button_test0_open.Name = "button_test0_open";
            this.button_test0_open.Size = new System.Drawing.Size(191, 23);
            this.button_test0_open.TabIndex = 0;
            this.button_test0_open.Text = "Открыть задание 0";
            this.button_test0_open.UseVisualStyleBackColor = true;
            this.button_test0_open.Click += new System.EventHandler(this.button_test0_open_Click);
            // 
            // button_test1_open
            // 
            this.button_test1_open.Location = new System.Drawing.Point(12, 73);
            this.button_test1_open.Name = "button_test1_open";
            this.button_test1_open.Size = new System.Drawing.Size(191, 23);
            this.button_test1_open.TabIndex = 0;
            this.button_test1_open.Text = "Открыть задание 1";
            this.button_test1_open.UseVisualStyleBackColor = true;
            this.button_test1_open.Click += new System.EventHandler(this.button_test1_open_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 126);
            this.Controls.Add(this.button_test1_open);
            this.Controls.Add(this.button_test0_open);
            this.Name = "StartForm";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_test0_open;
        private System.Windows.Forms.Button button_test1_open;
    }
}