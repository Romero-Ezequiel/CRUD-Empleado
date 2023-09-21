using Datos.Entidades;
using Datos.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data
{
    public class EmpleadoD
    {

        Info info = new Info();

        public List<Empleado> Lista()
        {
            try
            {
                return info.Listar();
            }
            catch (Exception e)
            {
                throw e;
            }        
        }

        public Empleado Obtener(int IdEmpleado)
        {
            try
            {
                return info.Obtener(IdEmpleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool Crear(Empleado empleado)
        {
            try
            {
                if (empleado.Nombre == "" || empleado.Apellido == "" || empleado.Correo == "" || empleado.Salario == null)
                    throw new OperationCanceledException("El nombre, apellido, sueldo, correo no puede ser vacios");

                return info.Crear(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public bool Editar(Empleado empleado)
        {
            try
            {
                var buscarEmpleado = info.Obtener(empleado.IdEmpleado);

                if (empleado.IdEmpleado == 0)
                    throw new OperationCanceledException("No existe el empleado");

                return info.Crear(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        } 

        public bool Eliminar(int IdEmpleado)
        {
            try
            {
                var buscarEmpleado = info.Obtener(IdEmpleado);
                if (buscarEmpleado.IdEmpleado == 0)
                    throw new OperationCanceledException("No existe el empleado");
                return info.Eliminar(IdEmpleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        } 



    }
}
