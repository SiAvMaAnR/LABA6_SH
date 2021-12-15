using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;

namespace Laba_6_Sh.Services
{
    public abstract class InteractionDataBaseService
    {
        public FbDataAdapter sqlDataAdapter;

        public async Task<DataTable> GetAllDataTable(FbConnection sqlConnection, string nameTable)
        {
            string sqlScript = $"SELECT * FROM {nameTable};";

            DataTable dataTable = new DataTable(nameTable);
            await Task.Run(() =>
            {
                FbCommand sqlCommand = new FbCommand(sqlScript, sqlConnection);
                sqlDataAdapter = new FbDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            });

            return dataTable;
        }

        public async Task UpdateBD(DataTable table)
        {

            await Task.Run(() =>
            {
                try
                {
                    FbCommandBuilder commandBuilder1 = new FbCommandBuilder(sqlDataAdapter);
                    sqlDataAdapter.Update(table);
                }
                catch { throw new Exception("Проверьте корректность введенных данных!"); }
            });

        }
    }
}
