namespace DecoratorMethodAppWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkRibbon = new CheckBox();
            chkFlowers = new CheckBox();
            chkFrame = new CheckBox();
            btnCreate = new Button();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // chkRibbon
            // 
            chkRibbon.AutoSize = true;
            chkRibbon.Location = new Point(12, 33);
            chkRibbon.Name = "chkRibbon";
            chkRibbon.Size = new Size(108, 19);
            chkRibbon.TabIndex = 0;
            chkRibbon.Text = "Додати стрічку";
            chkRibbon.UseVisualStyleBackColor = true;
            // 
            // chkFlowers
            // 
            chkFlowers.AutoSize = true;
            chkFlowers.Location = new Point(12, 58);
            chkFlowers.Name = "chkFlowers";
            chkFlowers.Size = new Size(95, 19);
            chkFlowers.TabIndex = 1;
            chkFlowers.Text = "Додати квіти";
            chkFlowers.UseVisualStyleBackColor = true;
            // 
            // chkFrame
            // 
            chkFrame.AutoSize = true;
            chkFrame.Location = new Point(12, 83);
            chkFrame.Name = "chkFrame";
            chkFrame.Size = new Size(102, 19);
            chkFrame.TabIndex = 2;
            chkFrame.Text = "Додати рамку";
            chkFrame.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 108);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(122, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Створити листівку";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // rtbResult
            // 
            rtbResult.Dock = DockStyle.Right;
            rtbResult.Location = new Point(163, 0);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(637, 450);
            rtbResult.TabIndex = 4;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(chkFrame);
            Controls.Add(chkFlowers);
            Controls.Add(chkRibbon);
            Controls.Add(rtbResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkRibbon;
        private CheckBox chkFlowers;
        private CheckBox chkFrame;
        private Button btnCreate;
        private RichTextBox rtbResult;
    }
}
