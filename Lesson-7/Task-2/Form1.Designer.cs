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
            this.btnGame = new System.Windows.Forms.Button();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.lblInputText = new System.Windows.Forms.Label();
            this.lbltextGame = new System.Windows.Forms.Label();
            this.btnTry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(53, 48);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(200, 70);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "button1";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // tBInput
            // 
            this.tBInput.Enabled = false;
            this.tBInput.Location = new System.Drawing.Point(12, 74);
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(299, 20);
            this.tBInput.TabIndex = 1;
            this.tBInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBInput.Visible = false;
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Enabled = false;
            this.lblInputText.Location = new System.Drawing.Point(12, 97);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(35, 13);
            this.lblInputText.TabIndex = 2;
            this.lblInputText.Text = "label1";
            this.lblInputText.Visible = false;
            // 
            // lbltextGame
            // 
            this.lbltextGame.AutoSize = true;
            this.lbltextGame.Enabled = false;
            this.lbltextGame.Location = new System.Drawing.Point(13, 13);
            this.lbltextGame.Name = "lbltextGame";
            this.lbltextGame.Size = new System.Drawing.Size(62, 13);
            this.lbltextGame.TabIndex = 3;
            this.lbltextGame.Text = "lbltextGame";
            this.lbltextGame.Visible = false;
            // 
            // btnTry
            // 
            this.btnTry.Enabled = false;
            this.btnTry.Location = new System.Drawing.Point(111, 118);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(75, 23);
            this.btnTry.TabIndex = 4;
            this.btnTry.Text = "button1";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Visible = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 189);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.lbltextGame);
            this.Controls.Add(this.lblInputText);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.btnGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.Label lbltextGame;
        private System.Windows.Forms.Button btnTry;
    }
}

