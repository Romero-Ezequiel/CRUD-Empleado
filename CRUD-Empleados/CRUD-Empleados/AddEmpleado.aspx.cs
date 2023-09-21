using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Datos.Data;
using Datos.Entidades;
using Datos.Query;

namespace CRUD_Empleados
{
    public partial class AddEmpleado : Page
    {
        private static int idEmpleado = 0;
        Info Info = new Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idEmpleado"] != null)
                {
                    idEmpleado = Convert.ToInt32(Request.QueryString["idEmpleado"].ToString());

                    if(idEmpleado != 0)
                    {
                        lblTitulo.Text = "Editar Empleado";
                        btnSubmit.Text = "Actualizar";

                        Empleado empleado = Info.Obtener(idEmpleado);
                        txtNombre.Text = empleado.Nombre;
                        txtApellido.Text = empleado.Apellido;
                        TextCorreo.Text = empleado.Correo;
                        TextSalario.Text = empleado.Salario.ToString();

                    }
                    else
                    {
                        lblTitulo.Text = "Nuevo Empleado";
                        btnSubmit.Text = "Guardar";

                    }
                }
                else
                    Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Empleado empleado = new Empleado()
            {
                IdEmpleado = idEmpleado,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = TextCorreo.Text,
                Salario = Convert.ToDouble(TextSalario.Text.ToString())
            };

            bool respuesta;
            if (idEmpleado != 0)
            {
                respuesta = Info.Editar(empleado);
            }
            else
                respuesta = Info.Crear(empleado);

            if (respuesta)
                Response.Redirect("~/Default.aspx");
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('No se pudo realizar la operación')", true);
        }


  
    }
}