using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVeterinaria;

namespace ClinicaVeterinaria
{
    public partial class ModificarMascota : System.Web.UI.Page
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
        protected void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            Mascota mascota = clinica.ListMascotas.Find(c => c.Id == int.Parse(txtIdMascota.Text));
            if (mascota != null)
            {
                lblIdMascota.Text = string.Format("{0}", mascota.Id);
                txtNombreMascota.Text = mascota.Nombre;
                txtDuenoMascota.Text = mascota.NombreDueño;
                txtTipoMascota.Text = mascota.Tipo;
                txtRazaMascota.Text = mascota.Raza;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            Mascota mascota = clinica.ListMascotas.Find(c => c.Id == int.Parse(lblIdMascota.Text));
            mascota.Nombre = txtNombreMascota.Text;
            mascota.NombreDueño = txtDuenoMascota.Text;
            mascota.Tipo = txtTipoMascota.Text;
            mascota.Raza = txtRazaMascota.Text;

            lblIdMascota.Text = "";
            txtIdMascota.Text = "";
            txtNombreMascota.Text = "";
            txtDuenoMascota.Text = "";
            txtRazaMascota.Text = "";
            txtTipoMascota.Text = "";
        }
    }
}