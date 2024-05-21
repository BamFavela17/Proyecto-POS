using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Crud
    {
        CD_Crud objCD = new CD_Crud(); 

        public DataTable MostrarEmp()
        {   
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarEmp();
            return tabla;
        }
        public DataTable Mostrarclientes()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarClientes();
            return tabla;
        }
        public DataTable Mostrarproveedor()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.Mostrarproveedores();
            return tabla;
        }
        public DataTable Mostrarpuesto()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarPuesto();
            return tabla;
        }
        public DataTable Mostrarhorario()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarHorario();
            return tabla;
        }
        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarCategorias();
            return tabla;
        }
        public DataTable MostrarMateriales()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarMateriales();
            return tabla;
        }
        public DataTable Mostrarplatillos()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.MostrarPlatillos();
            return tabla;
        }
        public void InsertarEmp(string nom, string ape, int tipo, DateTime fhN, DateTime fhC, string dir, string tel, string cor, int turno, string user, string pass)
        {

            objCD.InsertarEmpleado(nom, ape, tipo, fhN, fhC, dir, tel, cor, turno, user, pass);
        }

        public void EditarEmp(string nom, string ape, int tipo, DateTime fhN, DateTime fhC, string dir, string tel, string cor, int turno, string user, string pass, string id)
        {
            objCD.EditarEmpleado(nom, ape, tipo, fhN, fhC, dir, tel, cor, turno, user, pass,id);
        }

        public void EliminarEmp(string id)
        {

            objCD.EliminarEmpleado(Convert.ToInt32(id));
        }
    }
}
