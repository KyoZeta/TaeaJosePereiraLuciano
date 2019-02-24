using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TareaAldryn1_DAO_DTO_UI_.DAO
{
    class ConexionMySQL_DAO
    {
        MySqlConnection conect;
        string parametros = "";

        public  MySqlConnection conectar()
        {
             conect = new MySqlConnection(parametros);
             return conect;              
        }

        public ConexionMySQL_DAO()
        {
            parametros = "server=127.0.0.1; database=sci_bd; Uid=root; pwd=root;";
            conect = conectar();
        }
    }
}
