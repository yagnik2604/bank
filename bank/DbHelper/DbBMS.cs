using bank.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bank.DbHelper
{
    public class DbBMS
    {
        private string connectionString = "Server=Yagnik\\SQLEXPRESS;Database=masterDB;Trusted_Connection=True;";

        public DataTable GetUser(int id)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    var command = new System.Data.SqlClient.SqlCommand("sp_get_user", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@user_id", id);

                    var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    var dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public DataTable RegisterUser(RegisterModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("sp_register_user", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@password", model.password);
                command.Parameters.AddWithValue("@first_name", model.first_name);
                command.Parameters.AddWithValue("@last_name", model.last_name);
                command.Parameters.AddWithValue("@date_of_birth", model.date_of_birth);
                command.Parameters.AddWithValue("@email", model.email);
                command.Parameters.AddWithValue("@phone", model.phone);

                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable CreateAccount(AccountModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("sp_account", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@user_id", model.user_id);
                command.Parameters.AddWithValue("@account_type", model.account_type);
                command.Parameters.AddWithValue("@currency", model.currency);

                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }


        public DataTable TransferMoney(TransferModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("sp_transfer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@from_account_id", model.from_account_id);
                command.Parameters.AddWithValue("@to_account_id", model.to_account_id);
                command.Parameters.AddWithValue("@user_id", model.user_id);
                command.Parameters.AddWithValue("@amount", model.amount);
                command.Parameters.AddWithValue("@currency", model.currency);

                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable AddMoney(AddMoneyModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    var command = new SqlCommand("sp_addMoney", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@account_id", model.account_id);
                    command.Parameters.AddWithValue("@amount", model.amount);
                    command.Parameters.AddWithValue("@user_id", model.user_id);

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();

                    adapter.Fill(table);

                    return table;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


    }
}