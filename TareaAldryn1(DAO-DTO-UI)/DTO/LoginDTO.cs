using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAldryn1_DAO_DTO_UI_.DAO
{
    class LoginDTO
    {
        int MaticulA;
        string Nombre;
        string Apellido_Paterno;
        string Apellido_Materno;
        string Celular;
        string Correo;
        string Admin;
        string Contraseña;

        public LoginDTO(int maticulA, string nombre, string apellido_Paterno, string apellido_Materno, string celular, string correo, string admin, string contraseña)
        {
            MaticulA = maticulA;
            Nombre = nombre;
            Apellido_Paterno = apellido_Paterno;
            Apellido_Materno = apellido_Materno;
            Celular = celular;
            Correo = correo;
            Admin = admin;
            Contraseña = contraseña;
        }

        public int MaticulA1 { get => MaticulA; set => MaticulA = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido_Paterno1 { get => Apellido_Paterno; set => Apellido_Paterno = value; }
        public string Apellido_Materno1 { get => Apellido_Materno; set => Apellido_Materno = value; }
        public string Celular1 { get => Celular; set => Celular = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Admin1 { get => Admin; set => Admin = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
    }
}
