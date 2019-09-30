namespace SwitchProjectWinForms
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
            this.buttonDay = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxOperation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDay
            // 
            this.buttonDay.BackColor = System.Drawing.Color.Navy;
            this.buttonDay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDay.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDay.Location = new System.Drawing.Point(15, 15);
            this.buttonDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(187, 67);
            this.buttonDay.TabIndex = 0;
            this.buttonDay.Text = "Расшифровка дня недели";
            this.buttonDay.UseVisualStyleBackColor = false;
            this.buttonDay.Click += new System.EventHandler(this.ButtonDay_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.BackColor = System.Drawing.Color.Navy;
            this.buttonMonth.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMonth.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMonth.Location = new System.Drawing.Point(15, 100);
            this.buttonMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(187, 77);
            this.buttonMonth.TabIndex = 1;
            this.buttonMonth.Text = "Расшифровка месяца";
            this.buttonMonth.UseVisualStyleBackColor = false;
            this.buttonMonth.Click += new System.EventHandler(this.ButtonMonth_Click);
            // 
            // buttonOperation
            // 
            this.buttonOperation.BackColor = System.Drawing.Color.Navy;
            this.buttonOperation.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOperation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperation.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOperation.Location = new System.Drawing.Point(15, 183);
            this.buttonOperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(187, 91);
            this.buttonOperation.TabIndex = 2;
            this.buttonOperation.Text = "Выполнение операций над числами";
            this.buttonOperation.UseVisualStyleBackColor = false;
            this.buttonOperation.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(13, 330);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 40);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(427, 36);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(179, 25);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.TextChanged += new System.EventHandler(this.TextBoxNumA_TextChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(202, 181);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 5;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRes.Location = new System.Drawing.Point(445, 219);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(120, 27);
            this.labelRes.TabIndex = 10;
            this.labelRes.Text = "Результат";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(427, 82);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(179, 25);
            this.textBoxB.TabIndex = 11;
            // 
            // textBoxOperation
            // 
            this.textBoxOperation.Location = new System.Drawing.Point(427, 126);
            this.textBoxOperation.Name = "textBoxOperation";
            this.textBoxOperation.Size = new System.Drawing.Size(100, 25);
            this.textBoxOperation.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(209, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите знак операции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(629, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOperation);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOperation);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonDay);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(762, 532);
            this.MinimumSize = new System.Drawing.Size(645, 416);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Some Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxOperation;
        private System.Windows.Forms.Label label3;
    }
}

