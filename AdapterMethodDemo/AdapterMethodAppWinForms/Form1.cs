using AdapterMethodClass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdapterMethodAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            IDataSource dataSource = null;

            if (radioSQL.Checked)
            {
                dataSource = new SQLAdapter(new SQLDatabase());
            }
            else if (radioNoSQL.Checked)
            {
                dataSource = new NoSQLAdapter(new NoSQLDatabase());
            }
            else if (radioXML.Checked)
            {
                dataSource = new XMLAdapter(new XMLDatabase());
            }

            if (dataSource != null)
            {
                List<DataRecord> data = dataSource.GetData();
                listData.Items.Clear();
                foreach (var record in data)
                {
                    listData.Items.Add(record.ToString());
                }
            }
            else
            {
                MessageBox.Show("Виберіть тип бази даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
