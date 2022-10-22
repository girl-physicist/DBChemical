using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBChemical
{
    public partial class Form1 : Form
    {
        public ChemicalElementModal Element { get; private set; }
        private readonly SqlConnection _connection;
        private SqlDataAdapter _adapter = null;
        private DataSet _dataSet = null;
        private int _numerLastColumn;
        private bool _newRowAdd = false;
        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\girl-\\source\\repos\\ProjectDataBase\\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            Element = new ChemicalElementModal();
            _connection = new SqlConnection(ConnectionString);
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await ConnectWithDb(GetData);
        }
        private void ReloadData()
        {
            try
            {
                _dataSet.Tables["Elements"].Clear();
                _adapter.Fill(_dataSet, "Elements");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowData();

        }
        private SqlDataAdapter CreateAdapter(string sqlCommand, SqlConnection connection)
        {
            var command = new SqlCommand(sqlCommand, connection);
            return new SqlDataAdapter(command);
        }
        public async Task ConnectWithDb(Action<SqlConnection> action)
        {
            try
            {
                await _connection.OpenAsync();
                action(_connection);
                FillDataSet();
                ShowData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        private void FillDataSet()
        {
            _dataSet = new DataSet();
            _adapter.Fill(_dataSet, "Elements");
        }
        private void GetData(SqlConnection connection)
        {
            _adapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM [Elements]", connection);
        }
        private void ShowData()
        {
            try
            {
                dataGridView1.DataSource = _dataSet.Tables["Elements"];
                _numerLastColumn = dataGridView1.ColumnCount - 1;
                for (var i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var linkCell = new DataGridViewLinkCell();
                    dataGridView1[_numerLastColumn, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FindElementByName(SqlConnection connection)
        {
            _adapter = CreateAdapter($"SELECT *, 'Delete' AS [Delete] FROM [Elements] where [nameElement]  = '{textBoxName.Text}'", connection);
        }
        public void Insert(SqlConnection connection)
        {
            var a = $"INSERT INTO [Elements] ([nameElement], [symbol], [nuclearCharge], [molarMass], [atomicRadius], [DebyeTemperature]) VALUES" +
                $" ('{Element.Name}','{Element.Symbol}',{Element.NuclearCharge},{Element.MolarMass},{Element.AtomicRadius},{Element.DebyeTemperature})";
            _adapter = CreateAdapter(a, connection);

        }
        public async Task Insert()
        {
            await ConnectWithDb(Insert);
            await ConnectWithDb(GetData);
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = 0;
                try
                {
                    if (e.ColumnIndex == _numerLastColumn)
                    {
                        string task = dataGridView1.Rows[e.RowIndex].Cells[_numerLastColumn].Value.ToString();
                        switch (task)
                        {
                            case "Delete":
                            {
                                if (MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление строки",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    == DialogResult.Yes)
                                {
                                    rowIndex = e.RowIndex;
                                    dataGridView1.Rows.RemoveAt(rowIndex);
                                    _adapter.Update(_dataSet, "Elements");
                                }

                                break;
                            }
                            case "Update":
                            {
                                var r = e.RowIndex;
                                _dataSet.Tables["Elements"].Rows[r][1] = dataGridView1.Rows[r].Cells[1].Value;
                                _dataSet.Tables["Elements"].Rows[r][2] = dataGridView1.Rows[r].Cells[2].Value;
                                _dataSet.Tables["Elements"].Rows[r][3] = dataGridView1.Rows[r].Cells[3].Value;
                                _dataSet.Tables["Elements"].Rows[r][4] = dataGridView1.Rows[r].Cells[4].Value;
                                _dataSet.Tables["Elements"].Rows[r][5] = dataGridView1.Rows[r].Cells[5].Value;
                                _dataSet.Tables["Elements"].Rows[r][6] = dataGridView1.Rows[r].Cells[6].Value;
                                _adapter.Update(_dataSet, "Elements");
                                dataGridView1.Rows[e.RowIndex].Cells[_numerLastColumn].Value = "Delete";
                                break;
                            }
                        }

                        ReloadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_newRowAdd == false)
                {
                    var rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[_numerLastColumn, rowIndex] = linkCell;
                    row.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ButtonShowDB_Click(object sender, EventArgs e)
        {

            await ConnectWithDb(GetData);
        }
        private async void ButtonFind_Click(object sender, EventArgs e)
        {
            await ConnectWithDb(FindElementByName);
        }
        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            FormInsertcs form = new FormInsertcs(this);
            form.Show();
        }

    }
}

