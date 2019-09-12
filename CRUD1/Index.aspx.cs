using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    Conexion con = new Conexion();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<script>console.log('Ejemplooooo');</script>");
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (con.buscarPersona(Convert.ToInt32(txtCedula.Text)) == 0)
        {
            string fechaNacimento = txtAño.Text + "-" + txtMes.Text + "-" + txtDia.Text;
            Response.Write(con.insertar(txtNombre.Text, txtCedula.Text, txtPass.Text, fechaNacimento));
        }
        else
        {
            Response.Write("<script>console.log('El registro ya existe');</script>");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {        
        lblPrueba.Text = txtAño.Text + "-" + txtMes.Text + "-" + txtDia.Text;
    }
}