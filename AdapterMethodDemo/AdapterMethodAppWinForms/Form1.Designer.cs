namespace AdapterMethodAppWinForms
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
            btnGetData = new Button();
            groupBox1 = new GroupBox();
            radioSQL = new RadioButton();
            radioNoSQL = new RadioButton();
            radioXML = new RadioButton();
            listData = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(41, 176);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(75, 23);
            btnGetData.TabIndex = 0;
            btnGetData.Text = "GetData";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioXML);
            groupBox1.Controls.Add(radioNoSQL);
            groupBox1.Controls.Add(radioSQL);
            groupBox1.Location = new Point(26, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 111);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioSQL
            // 
            radioSQL.AutoSize = true;
            radioSQL.Location = new Point(16, 24);
            radioSQL.Name = "radioSQL";
            radioSQL.Size = new Size(46, 19);
            radioSQL.TabIndex = 0;
            radioSQL.TabStop = true;
            radioSQL.Text = "SQL";
            radioSQL.UseVisualStyleBackColor = true;
            // 
            // radioNoSQL
            // 
            radioNoSQL.AutoSize = true;
            radioNoSQL.Location = new Point(15, 50);
            radioNoSQL.Name = "radioNoSQL";
            radioNoSQL.Size = new Size(62, 19);
            radioNoSQL.TabIndex = 1;
            radioNoSQL.TabStop = true;
            radioNoSQL.Text = "NoSQL";
            radioNoSQL.UseVisualStyleBackColor = true;
            // 
            // radioXML
            // 
            radioXML.AutoSize = true;
            radioXML.Location = new Point(16, 78);
            radioXML.Name = "radioXML";
            radioXML.Size = new Size(49, 19);
            radioXML.TabIndex = 2;
            radioXML.TabStop = true;
            radioXML.Text = "XML";
            radioXML.UseVisualStyleBackColor = true;
            // 
            // listData
            // 
            listData.FormattingEnabled = true;
            listData.ItemHeight = 15;
            listData.Location = new Point(257, 12);
            listData.Name = "listData";
            listData.Size = new Size(531, 379);
            listData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listData);
            Controls.Add(groupBox1);
            Controls.Add(btnGetData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetData;
        private GroupBox groupBox1;
        private RadioButton radioXML;
        private RadioButton radioNoSQL;
        private RadioButton radioSQL;
        private ListBox listData;
    }
}
