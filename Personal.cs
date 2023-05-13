using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Herencia_Personal
{
    abstract class Personal
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Personal()
        {
            id = 0;
            nombre = string.Empty;
            apellido = string.Empty;
        }

        public Personal(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return " | ID: "+id+" | NOMBRE: "+nombre+" | APELLIDO: "+apellido;
        }

    }
}
