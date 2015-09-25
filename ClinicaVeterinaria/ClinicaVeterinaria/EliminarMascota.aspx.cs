using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVeterinaria;

namespace ClinicaVeterinaria
{
    public partial class EliminarMascota : System.Web.UI.Page
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

        protected void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            Mascota mascota = clinica.ListMascotas.Find(c => c.Id == int.Parse(txtIdEliminar.Text));
            lblIdMascota.Text = string.Format("{0}", mascota.Id);
            lblNombreMascota.Text = mascota.Nombre;
            lblNombreDueno.Text = mascota.NombreDueño;
            lblTipoMascota.Text = mascota.Tipo;
            lblRazaMascota.Text = mascota.Raza;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            Mascota mascota = clinica.ListMascotas.Find(c => c.Id == int.Parse(lblIdMascota.Text));
            clinica.ListMascotas.Remove(mascota);

            lblIdMascota.Text = "";
            lblNombreMascota.Text = "";
            lblNombreDueno.Text = "";
            lblTipoMascota.Text = "";
            lblRazaMascota.Text = "";
        }
    }
}