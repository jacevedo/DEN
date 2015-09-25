using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVeterinaria
{
    public class Mascota
    {
        private int _id;
        private string nombre;
        private string nombreDueño;
        private string tipo;
        private string raza;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NombreDueño
        {
            get { return nombreDueño; }
            set { nombreDueño = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
    }
}
