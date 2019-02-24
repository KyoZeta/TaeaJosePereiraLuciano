using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TareaAldryn1_DAO_DTO_UI_.DAO
{
    class LoginDAO:ConexionMySQL_DAO
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        

        public string Logear(string matricula, string pass)
        {
            string nombreNo = "";
            cn = conectar();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = ("SELECT Nombre FROM usuario WHERE Matricula = '" + matricula + "' AND  Contraseña = '" + pass + "'");
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
               string nombre = leer.GetString("Nombre");
               return nombre;               
            }

            return nombreNo;
        }
        
    }
}
