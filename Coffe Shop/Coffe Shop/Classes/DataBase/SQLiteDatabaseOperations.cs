using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Classes.DataBase
{
    public class SQLDatabaseOperations
    {
        private readonly SQLiteConnectionManager _connectionManager;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        public SQLDatabaseOperations()
        {
            _connectionManager = new SQLiteConnectionManager();
        }


        /// <summary>
        /// Metoda e pergjithshme per operacionet bazike si Insert,Update, Delete ne databaze 
        /// </summary>
        /// <param name="querry"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task CRUDDataBaseWithParam(string querry, SqlParameter[] parameters)
        {
            try
            {
                using (cmd = new SqlCommand(querry, _connectionManager.GetConnection))
                {
                    await _connectionManager.OpenConnectionAsync();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);

                    await cmd.ExecuteNonQueryAsync();
                    await _connectionManager.CloseConnectionAsync();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error while inserting data in DB: " + ex.Message);
            }

        }

        /// <summary>
        /// Selektimi i te dhenave ne baze  te querry ose procedures ekzakte
        /// </summary>
        /// <param name="querry"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<DataTable> SelectDataAsync(string querry)
        {
            // Sigurohuni që `querry` dhe `database` janë të inicializuara dhe të vlefshme
            if (string.IsNullOrEmpty(querry) || _connectionManager == null)
            {
                throw new ArgumentNullException("Query or database is not valid.");
            }

            using (var adapter = new SqlDataAdapter(querry, _connectionManager.GetConnection))
            {
                await _connectionManager.OpenConnectionAsync();
                var dt = new DataTable();

                try
                {
                    // Përdorimi i await për të pritur përfundimin e ngarkimit të të dhënave
                    Task.Run(() => adapter.Fill(dt)).Wait();
                }
                catch (Exception ex)
                {
                    // Mund të kapni dhe trajtoni gabimet në mënyrë të përshtatshme
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    await _connectionManager.CloseConnectionAsync();
                }

                return dt;
            }
        }

        /// <summary>
        /// Selektimi i te dhenave ne baze  te querry ose procedures ekzakte dhe me ane te parametrave
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<DataTable> LoadDataInDGVProcedur(string procedureName, SqlParameter[] param)
        {
            if (string.IsNullOrEmpty(procedureName) || _connectionManager == null)
            {
                throw new ArgumentNullException("Procedure name or database is not valid.");
            }

            using (var command = new SqlCommand(procedureName, _connectionManager.GetConnection))
            {

                await _connectionManager.OpenConnectionAsync();

                var dt = new DataTable();

                try
                {
                    command.Parameters.AddRange(param);
                    command.CommandType = CommandType.StoredProcedure;
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        await Task.Run(() => adapter.Fill(dt));
                    }
                }
                catch (Exception ex)
                {
                    //AlertMessage.Show(ex.Message, "Error", AlertMessage.Buttons.OK, AlertMessage.Icons.Stop);
                }
                finally
                {
                    await _connectionManager.CloseConnectionAsync();
                }

                return dt;
            }
        }

        /// <summary>
        /// Insertimi ne databaze dhe marrja e id se insertuar per te ber veprime te tjera qe varen nga kjo id
        /// </summary>
        /// <param name="querry"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public async Task<int> InsertAndGetIdOf(string querry, SqlParameter[] sqlParameters)
        {
            int lastInsertedId = -1;
            using (SqlCommand cmd = new SqlCommand(querry, _connectionManager.GetConnection))
            {
                await _connectionManager.OpenConnectionAsync();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParameters);

                // Shto parametrën OUTPUT për të marrë id e kolonës së sapo futur
                cmd.Parameters.Add(new SqlParameter("@LastId", SqlDbType.Int) { Direction = ParameterDirection.Output });

                await cmd.ExecuteNonQueryAsync();

                // Merr id e kolonës së sapo futur nga parametri OUTPUT
                lastInsertedId = (int)cmd.Parameters["@LastId"].Value;

                await _connectionManager.CloseConnectionAsync();
            }
            return lastInsertedId;
        }

    }
}
