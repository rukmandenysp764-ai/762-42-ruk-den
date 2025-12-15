namespace BuilderMethodAppWinForms
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
            groupBox1 = new GroupBox();
            radioWedding = new RadioButton();
            radioMixed = new RadioButton();
            radioRose = new RadioButton();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            btnFull = new Button();
            groupBox3 = new GroupBox();
            btnRibbon = new Button();
            btnStyle = new Button();
            btnSize = new Button();
            btnDecoration = new Button();
            btnWrapper = new Button();
            btnFlowers = new Button();
            listSteps = new ListBox();
            ButtonbtnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioWedding);
            groupBox1.Controls.Add(radioMixed);
            groupBox1.Controls.Add(radioRose);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вибір типу букета";
            // 
            // radioWedding
            // 
            radioWedding.AutoSize = true;
            radioWedding.Location = new Point(6, 72);
            radioWedding.Name = "radioWedding";
            radioWedding.Size = new Size(114, 19);
            radioWedding.TabIndex = 2;
            radioWedding.TabStop = true;
            radioWedding.Text = "Весільний букет";
            radioWedding.UseVisualStyleBackColor = true;
            radioWedding.CheckedChanged += radioWedding_CheckedChanged;
            // 
            // radioMixed
            // 
            radioMixed.AutoSize = true;
            radioMixed.Location = new Point(6, 47);
            radioMixed.Name = "radioMixed";
            radioMixed.Size = new Size(115, 19);
            radioMixed.TabIndex = 1;
            radioMixed.TabStop = true;
            radioMixed.Text = "Змішаний букет";
            radioMixed.UseVisualStyleBackColor = true;
            // 
            // radioRose
            // 
            radioRose.AutoSize = true;
            radioRose.Location = new Point(6, 22);
            radioRose.Name = "radioRose";
            radioRose.Size = new Size(77, 19);
            radioRose.TabIndex = 0;
            radioRose.TabStop = true;
            radioRose.Text = "Букет роз";
            radioRose.UseVisualStyleBackColor = true;
            radioRose.CheckedChanged += radioRose_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnFull);
            groupBox2.Location = new Point(624, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Керування процесом";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 51);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(152, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFull
            // 
            btnFull.Location = new Point(6, 22);
            btnFull.Name = "btnFull";
            btnFull.Size = new Size(152, 23);
            btnFull.TabIndex = 0;
            btnFull.Text = "Побудувати повністю";
            btnFull.UseVisualStyleBackColor = true;
            btnFull.Click += btnFull_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRibbon);
            groupBox3.Controls.Add(btnStyle);
            groupBox3.Controls.Add(btnSize);
            groupBox3.Controls.Add(btnDecoration);
            groupBox3.Controls.Add(btnWrapper);
            groupBox3.Controls.Add(btnFlowers);
            groupBox3.Location = new Point(12, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(158, 201);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Покрокове будівництво";
            // 
            // btnRibbon
            // 
            btnRibbon.Location = new Point(6, 167);
            btnRibbon.Name = "btnRibbon";
            btnRibbon.Size = new Size(126, 23);
            btnRibbon.TabIndex = 5;
            btnRibbon.Text = "Додати стрічку";
            btnRibbon.UseVisualStyleBackColor = true;
            btnRibbon.Click += btnRibbon_Click;
            // 
            // btnStyle
            // 
            btnStyle.Location = new Point(6, 138);
            btnStyle.Name = "btnStyle";
            btnStyle.Size = new Size(126, 23);
            btnStyle.TabIndex = 4;
            btnStyle.Text = "Встановити стиль";
            btnStyle.UseVisualStyleBackColor = true;
            btnStyle.Click += btnStyle_Click;
            // 
            // btnSize
            // 
            btnSize.Location = new Point(6, 109);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(127, 23);
            btnSize.TabIndex = 3;
            btnSize.Text = "Встановити розмір";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnDecoration
            // 
            btnDecoration.Location = new Point(6, 80);
            btnDecoration.Name = "btnDecoration";
            btnDecoration.Size = new Size(126, 23);
            btnDecoration.TabIndex = 2;
            btnDecoration.Text = "Додати декор";
            btnDecoration.UseVisualStyleBackColor = true;
            btnDecoration.Click += btnDecoration_Click;
            // 
            // btnWrapper
            // 
            btnWrapper.Location = new Point(6, 51);
            btnWrapper.Name = "btnWrapper";
            btnWrapper.Size = new Size(126, 23);
            btnWrapper.TabIndex = 1;
            btnWrapper.Text = "Додати обгортку";
            btnWrapper.UseVisualStyleBackColor = true;
            btnWrapper.Click += btnWrapper_Click;
            // 
            // btnFlowers
            // 
            btnFlowers.Location = new Point(6, 22);
            btnFlowers.Name = "btnFlowers";
            btnFlowers.Size = new Size(126, 23);
            btnFlowers.TabIndex = 0;
            btnFlowers.Text = "Додати квіти";
            btnFlowers.UseVisualStyleBackColor = true;
            btnFlowers.Click += btnFlowers_Click;
            // 
            // listSteps
            // 
            listSteps.FormattingEnabled = true;
            listSteps.ItemHeight = 15;
            listSteps.Location = new Point(242, 59);
            listSteps.Name = "listSteps";
            listSteps.Size = new Size(299, 244);
            listSteps.TabIndex = 3;
            // 
            // ButtonbtnClear
            // 
            ButtonbtnClear.Location = new Point(18, 325);
            ButtonbtnClear.Name = "ButtonbtnClear";
            ButtonbtnClear.Size = new Size(139, 23);
            ButtonbtnClear.TabIndex = 4;
            ButtonbtnClear.Text = "Очистити список";
            ButtonbtnClear.UseVisualStyleBackColor = true;
            ButtonbtnClear.Click += ButtonbtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonbtnClear);
            Controls.Add(listSteps);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioWedding;
        private RadioButton radioMixed;
        private RadioButton radioRose;
        private GroupBox groupBox2;
        private Button btnReset;
        private Button btnFull;
        private GroupBox groupBox3;
        private Button btnRibbon;
        private Button btnStyle;
        private Button btnSize;
        private Button btnDecoration;
        private Button btnWrapper;
        private Button btnFlowers;
        private ListBox listSteps;
        private Button ButtonbtnClear;
    }
}
