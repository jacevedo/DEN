using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVeterinaria;

namespace ClinicaVeterinaria
{
    public partial class IngresarMascota : System.Web.UI.Page
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(txtId.Text);
            mascota.Nombre = txtNombreMascota.Text;
            mascota.NombreDueño = txtNombreDueno.Text;
            mascota.Raza = txtRazaMascota.Text;
            mascota.Tipo = txtTipoMascota.Text;

            Clinica clinica = (Clinica)Session["clinicaVeterinaria"];
            clinica.ListMascotas.Add(mascota);

            txtId.Text = "";
            txtNombreMascota.Text = "";
            txtNombreDueno.Text = "";
            txtRazaMascota.Text = "";
            txtTipoMascota.Text = "";
        }

      
    }
}