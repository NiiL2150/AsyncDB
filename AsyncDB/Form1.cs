using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDB
{
    public partial class Form1 : Form
    {
        public DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();


        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Step; Integrated Security=true; Asynchronous Processing = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"WAITFOR DELAY '00:00:10'; SELECT * FROM Students";

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private async void buttonAsync_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Step; Integrated Security=true; Asynchronous Processing = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT * FROM Students";

            SqlCommand cmd = new SqlCommand(query, connection);

            //AsyncCallback callback = new AsyncCallback(GetData);

            await connection.OpenAsync();

            await GetData3(cmd);

            connection.Close();

            dataGridView1.DataSource = dt;

            /*
            IAsyncResult result = cmd.BeginExecuteReader();
            cmd.CommandTimeout = 3;

            WaitHandle wait = result.AsyncWaitHandle;

            if (wait.WaitOne(3000))
            {
                GetData2(cmd, result);
            }
            else
            {
                MessageBox.Show("Timeout");
            }
            */

            //IAsyncResult reader = cmd.BeginExecuteReader(callback, cmd);
        }

        private async Task GetData3(SqlCommand command)
        {
            SqlDataReader reader = await command.ExecuteReaderAsync();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                DataRow row = dt.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dt.Rows.Add(row);
            }
        }
        
        private void GetData2(SqlCommand command, IAsyncResult result)
        {
            SqlDataReader reader = null;

            reader = command.EndExecuteReader(result);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                DataRow row = dt.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void GetData(IAsyncResult result)
        {
            SqlDataReader reader = null;

            SqlCommand command = (SqlCommand)result.AsyncState;
            reader = command.EndExecuteReader(result);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                DataRow row = dt.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dt.Rows.Add(row);
            }

            FillGrid();
        }

        private void FillGrid()
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(FillGrid));
            }

            dataGridView1.DataSource = dt;
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello :)");
        }
    }
}
