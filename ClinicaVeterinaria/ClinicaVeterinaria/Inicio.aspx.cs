using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVeterinaria;

namespace ClinicaVeterinaria
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            if (clinica == null)
            {
                clinica = new Clinica();
                Session["clinicaVeterinaria"] = clinica;
            }
        }

        public List<Mascota> obtenerListaMascota()
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            return clinica.ListMascotas;
        }
    }
}