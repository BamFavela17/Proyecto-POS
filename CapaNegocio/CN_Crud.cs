using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        public void Insertarpuesto(string nom, decimal sueldo)
        {

            objCD.Insertarpuesto(nom, sueldo);
        }
        public void InsertarHorario(string turno, DateTime HE, DateTime HS)
        {

            objCD.InsertarHorario(turno, HE, HS);
        }
        public void Insertarcliente(string nom, string importancia)
        {

            objCD.InsertarCliente(nom, importancia);
        }
        public void InsertarProveedor(string nombre, string ape, string lada, string tel, string correo, string empresa, string recurso, string desc)
        {

            objCD.InsertarProveedor(nombre, ape, lada, tel, correo, empresa, recurso, desc);
        }
        public void InsertarCategoria(string nom, string desc)
        {

            objCD.InsertarCategoria(nom, desc);
        }
        public void InsertarMaterial(string nom, int cant, int proveedor, decimal costo, string unidad, DateTime fCad, int cate, int stock)
        {

            objCD.InsertarMaterial(nom, cant, proveedor, costo, unidad, fCad, cate, stock);
        }
        public void InsertarPlatillo(string nom, string des, int cate, decimal preU)
        {

            objCD.InsertarPlatillo(nom, des, cate, preU);
        }
        public void InsertarVenta(DateTime fh, int idemp, int idcli, decimal importe)
        {

            objCD.InsertarVenta(fh, idemp, idcli, importe);

        }
        public void Insertarcompra(DateTime fh, int idemp, int prov, decimal importe)
        {

            objCD.InsertarCompra(fh, idemp, prov, importe);

        }
        public void InsertarDetalleVenta(int vent, int idprod, decimal precio, int cant, decimal importe)
        {

            objCD.InsertarDetalleVenta( vent,  idprod,  precio,  cant,  importe);

        }
        public void InsertarDetalecompra(int compra, int idprod, decimal precio, int cant, decimal importe)
        {

            objCD.InsertarDetalleCompra( compra,  idprod,  precio,  cant, importe);

        }



        public void EditarEmp(string nom, string ape, int tipo, DateTime fhN, DateTime fhC, string dir, string tel, string cor, int turno, string user, string pass, string id)
        {
            objCD.EditarEmpleado(nom, ape, tipo, fhN, fhC, dir, tel, cor, turno, user, pass, id);
        }




        public void EliminarEmp(string id)
        {

            objCD.EliminarEmpleado(Convert.ToInt32(id));
        }
    }
}

