namespace Task_2
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
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.tB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(12, 38);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(100, 20);
            this.nUpDown.TabIndex = 0;
            this.nUpDown.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(12, 12);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(100, 20);
            this.tB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 71);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.nUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.TextBox tB;
    }
}

