namespace ObserverAppWinForms
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
            this.btnMorning = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnEvening = new System.Windows.Forms.Button();
            this.btnNight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMorning
            // 
            this.btnMorning.Location = new System.Drawing.Point(12, 326);
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.Size = new System.Drawing.Size(75, 23);
            this.btnMorning.TabIndex = 0;
            this.btnMorning.Text = "Morning";
            this.btnMorning.UseVisualStyleBackColor = true;
            this.btnMorning.Click += new System.EventHandler(this.btnMorning_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(12, 355);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(75, 23);
            this.btnDay.TabIndex = 1;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnEvening
            // 
            this.btnEvening.Location = new System.Drawing.Point(12, 384);
            this.btnEvening.Name = "btnEvening";
            this.btnEvening.Size = new System.Drawing.Size(75, 23);
            this.btnEvening.TabIndex = 2;
            this.btnEvening.Text = "Evening";
            this.btnEvening.UseVisualStyleBackColor = true;
            this.btnEvening.Click += new System.EventHandler(this.btnEvening_Click);
            // 
            // btnNight
            // 
            this.btnNight.Location = new System.Drawing.Point(12, 413);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(75, 23);
            this.btnNight.TabIndex = 3;
            this.btnNight.Text = "Night";
            this.btnNight.UseVisualStyleBackColor = true;
            this.btnNight.Click += new System.EventHandler(this.btnNight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNight);
            this.Controls.Add(this.btnEvening);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnMorning);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMorning;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnEvening;
        private System.Windows.Forms.Button btnNight;
    }
}

