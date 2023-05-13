using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Herencia_Personal
{
    class Profesor : Personal
    {

		private string direccion;

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		public Profesor()
		{
			direccion = string.Empty;
		}

		public Profesor (int id, string nombre, string apellido, string direccion) :base(id, nombre, apellido)
		{
			base.Id = id;
			base.Nombre = nombre;
			base.Apellido = apellido;
			this.Direccion = direccion;
		}

        public override string ToString()
        {
            return base.ToString()+ " | DIRECCION: "+this.Direccion;
        }


    }
}
