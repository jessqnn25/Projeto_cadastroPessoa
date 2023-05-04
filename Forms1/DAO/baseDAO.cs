using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MeuPrimeiroApp.DAO
{
   public  class baseDAO
    {
        public string ConnectionString = "server=localhost; uid=root; pwd='';database=primeiroapp;";
        private MySqlConnection cn { get; set; }

        public MySqlCommand cmd { get; set; }

        public MySqlDataAdapter adapt { get; set; }

        public List<MySqlParameter> parametros {get; set;}

        public string sql { get; set; }
        public baseDAO()
        {
            if(cn==null)
            {
                cn = new MySqlConnection(ConnectionString);
            }
            cmd = new MySqlCommand();
            adapt = new MySqlDataAdapter();
            parametros = new List<MySqlParameter>();
        }
        public void execute()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                foreach (var item in parametros)
                {
                    cmd.Parameters.Add(item);
                }
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
        public MySqlDataReader executeReader()
        {
            try
            {
                cmd = new MySqlCommand(sql, cn);
                cn.Open();
                return this.cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                cn.Dispose();
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
    }
}
   



