using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Data;
using Datos.Entidades;
using Datos.Query;

namespace CRUD_Empleados
{
    public partial class _Default : Page
    {
        Info Info = new Info();

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados() 
        {
            List<Empleado> lista = Info.Listar();

            GridEmpleado.DataSource = lista;
            GridEmpleado.DataBind();
        }

        protected void Nuevo(Object sender, EventArgs e)
        {
            Response.Redirect("~/AddEmpleado.aspx?idEmpleado=0");
        }

        protected void Editar(Object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string idEmpleado = btn.CommandArgument;

            Response.Redirect($"~/AddEmpleado.aspx?idEmpleado={idEmpleado}");
        }
        protected void Eliminar(Object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string idEmpleado = btn.CommandArgument;

            bool respuesta = Info.Eliminar(Convert.ToInt32(idEmpleado));

            if (respuesta)
                MostrarEmpleados();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            List<Empleado> lista = Info.Buscar(txtSearch.Text);

            GridEmpleado.DataSource = lista;
            GridEmpleado.DataBind();

        }

    }
}