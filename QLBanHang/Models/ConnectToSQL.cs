using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHang.Models
{
    class ConnectToSQL
    {
        private SqlConnection _connection;//Sql connectiong string to conect to database
        private SqlCommand _cmd = new SqlCommand();//Command to get,update,delete,insert data 

        public SqlConnection Connection
        {
            get { return _connection; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        private string _error;//Return error information

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        string _connectionString;

        ///Contructor
        public ConnectToSQL()
        {
            _connectionString = @"Data Source=_L_-PC;Initial Catalog=QLBanHang;Integrated Security=True";
            try
            {
                _connection = new SqlConnection(_connectionString);//Connect to Database
                InitCMD();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to Server");
            }
        }

        private void InitCMD()//Initialize CMD options
        {
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = _connection;
        }


        public bool OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }

        public bool ExecuteCMD()//Execute particular action
        {
            try
            {
                OpenConnection();
                CMD.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                CMD.Dispose();
                CloseConnection();
            }

            return false;
        }

        public void FillData(DataTable table)
        {
            OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(CMD);
            try
            {
                sda.Fill(table);//Fill table with data 
                CloseConnection();
            }
            catch (Exception ex)//Catch if unable to get data
            {
                string message = ex.Message;
                CMD.Dispose();
                CloseConnection();
            }
        }

    }
}
