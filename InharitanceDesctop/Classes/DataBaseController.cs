using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;


namespace InharitanceDesctop.Classes
{
    public class DataBaseController:IDisposable
    {

        public FbConnection DbConnection;
        public DataBaseController()
        {

            string path = Application.StartupPath + @"\INDB.gdb";
            FbConnectionStringBuilder conn = new FbConnectionStringBuilder()
            {
                Charset = "WIN1251",
                UserID = "SYSDBA",
                Password = "masterkey",
                Database = path,
                ServerType = FbServerType.Default
            };
           
          
            DbConnection = new FbConnection(conn.ToString());
         

        }

        public List<Gene> GetGenes()
        {
            FbCommand command = DbConnection.CreateCommand();
            command.CommandText = "select* from gene";
            DbConnection.Open();
            FbDataReader reader;
            reader = command.ExecuteReader();
            List<Gene> gene = new List<Gene>();
            while (reader.Read())
            {
                gene.Add(new Gene()
                {
                    DominanteAllele = reader.GetValue(2).ToString(),
                    Name = reader.GetValue(1).ToString(),
                    RecessiveAllele = reader.GetValue(3).ToString()
                });
            }
            DbConnection.Close();
            return gene;
        }
        public void Dispose()
        {
            DbConnection.Close();
        }
    }
}