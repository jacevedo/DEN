using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVeterinaria
{
    public class Clinica
    {
        private int id;
        private string nombre;
        private string direccion;
        private List<Mascota> listMascotas;

        public Clinica()
        {
            listMascotas = new List<Mascota>();
        }

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

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public List<Mascota> ListMascotas
        {
            get { return listMascotas; }
            set { listMascotas = value; }
        }
    }
}
