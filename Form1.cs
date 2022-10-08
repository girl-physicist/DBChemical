using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBChemical
{
    public partial class Form1 : Form
    {
        public const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\girl-\\source\\repos\\DBChemical\\DBElements.mdf;Integrated Security=True";
        private string _name = "nnn";
        private double _massa = 35/10^10;
            public Form1()
        {
            InitializeComponent();
        }

        private static async Task ConnectWithDB(Action<SqlConnection> action)
        {
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Открываем подключение
                await connection.OpenAsync();
                action(connection);
                //MessageBox.Show("Подключение открыто");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                //MessageBox.Show("Подключение закрыто");
            }
        }

        private SqlDataAdapter CreateAdapter(string text, SqlConnection connection)
        {
            var command = new SqlCommand(text, connection);
            return new SqlDataAdapter(command);
        }
        private void GetData(SqlConnection connection)
        {
            var sqlDataAdap = CreateAdapter("SELECT * FROM [Table]", connection);
            ShowData(sqlDataAdap);
        }

        private void ShowData(SqlDataAdapter sqlDataAdap)
        {
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }
        private void FindElementByName(SqlConnection connection)
        {
            var sqlDataAdap = CreateAdapter($"SELECT * FROM [Table] where [nameEl] = '{_name}'", connection);
            ShowData(sqlDataAdap);
        }

        private void Create(SqlConnection connection)
        {
            var a = $"INSERT INTO [Table] ([nameEl], [massa]) VALUES ('{_name}', {_massa})";


            var sqlDataAdap = CreateAdapter(a, connection);
            ShowData(sqlDataAdap);
        }


        private async void button1_Click(object sender, EventArgs e)
        { //_name = text
           
          //  await ConnectWithDB(FindElementByName);
            await ConnectWithDB(Create);
            await ConnectWithDB(GetData);
        }
    }
}

