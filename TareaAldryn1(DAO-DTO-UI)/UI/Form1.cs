using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaAldryn1_DAO_DTO_UI_.DAO;

namespace TareaAldryn1_DAO_DTO_UI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
           
            
        }

        public void btnIniciar_Click(object sender, EventArgs e)
        {
            string matricula, pass, nombre;
          
            matricula = txtMatri.Text;
            pass = txtPass.Text;

            nombre =  logear(matricula, pass);

            if(nombre == "")
            {
                MessageBox.Show("Usuario incorrecto");
            }
            else
            {
                MessageBox.Show("Bienvenido " + nombre); 
            }
        }

        public string logear (string matricula , string pass )
        {
            LoginDAO Logear = new LoginDAO();

            return Logear.Logear(matricula, pass);
             
         
        }

        


    }
}
