using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisLabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn = string.Format("Server={0};Port={1};UserID={2};Password={3};Database={4}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            NpgsqlConnection cnn = new NpgsqlConnection(strconn);
            cnn.Open();
            MessageBox.Show(cnn.State.ToString());


            cnn.Close();
            MessageBox.Show(cnn.State.ToString());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                MessageBox.Show(Convert.ToString(i++));
            }
            while (i < 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (char буква in ("слово"))
            {
                MessageBox.Show(Convert.ToString(буква));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
                 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(textBox6.Text);
            //Рабочий_выходной(a);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strconn = string.Format("Server={0};Port={1};User ID={2};Password={3};Database={4}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            NpgsqlConnection cnn = new NpgsqlConnection(strconn);
            cnn.Open();
            Npgsql.NpgsqlCommand myCommand = cnn.CreateCommand();
            myCommand.CommandText = "Update udal set p2='Деточкин' WHERE P1=1;";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Выполнено!", "Информация", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                cnn.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strconn = string.Format("Server={0};Port={1};User ID={2};Password={3};Database={4}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            NpgsqlConnection cnn = new NpgsqlConnection(strconn);
            cnn.Open();
            Npgsql.NpgsqlCommand myCommand = new NpgsqlCommand("Select count(*) from \"Жанры\";", cnn);
            try
            {
                listBox1.Items.Add("Записей " + Convert.ToString(myCommand.ExecuteScalar()));
            }
            finally
            {
                cnn.Dispose();
            }
        }
    }
}
