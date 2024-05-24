using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSoporte;
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
        public void Editarpuesto(string nom, decimal sueldo, string id)
        {

            objCD.EditarPuesto(nom, sueldo, id);
        }
        public void EditarHorario(string turno, TimeSpan HE, TimeSpan HS, string id)
        {

            objCD.EditarHorario(turno, HE, HS,  id);
        }
        public void Editarcliente(string nom, string importancia, string id)
        {

            objCD.EditarCliente(nom, importancia, id);
        }
        public void EditarProveedor(string nombre, string ape, string lada, string tel, string correo, string empresa, string recurso, string desc, string id)
        {

            objCD.EditarProveedores(nombre, ape, lada, tel, correo, empresa, recurso, desc, id);
        }
        public void EditarCategoria(string nom, string desc, string id)
        {

            objCD.EditarCategoria(nom, desc, id);
        }
        public void EditarMaterial(string nom, int cant, int proveedor, decimal costo, string unidad, DateTime fCad, int cate, int stock, string id)
        {

            objCD.EditarMaterial(nom, cant, proveedor, costo, unidad, fCad, cate, stock, id);
        }
        public void EditarPlatillo(string nom, string des, int cate, decimal preU, string id)
        {

            objCD.EditarPlatillo(nom, des, cate, preU, id);
        }
        public void EditarVenta(DateTime fh, int idemp, int idcli, decimal importe, string id)
        {

            objCD.EditarVenta(fh, idemp, idcli, importe, id);

        }
        public void Editarcompra(DateTime fh, int idemp, int prov, decimal importe, string id)
        {

            objCD.EditarCompra(fh, idemp, prov, importe, id);

        }
        public void EditarDetalleVenta(int venta, int idProd, int idemp, decimal precio, int cant, decimal importe, string id)
        {

            objCD.EditarDetalleVenta( venta,  idProd,  idemp,  precio,  cant,  importe,  id);

        }
        public void EditarDetalecompra(int compra, int idprod, decimal precio, int cant, decimal importe, string id)
        {

            objCD.EditarDetalleCompras(compra, idprod, precio, cant, importe, id);

        }

        public void EliminarEmp(string id)
        {

            objCD.EliminarEmpleado(Convert.ToInt32(id));
        }
        public void Eliminarpuesto(string id)
        {

            objCD.EliminarPuesto(Convert.ToInt32(id));
        }
        public void EliminarHorario( string id)
        {

            objCD.EliminarHorario(Convert.ToInt32(id));
        }
        public void Eliminarliente(string id)
        {

            objCD.EliminarCliente(Convert.ToInt32(id));
        }
        public void EliminarProveedor(string id)
        {

            objCD.EliminarProveedor(Convert.ToInt32(id));
        }
        public void EliminarCategoria( string id)
        {

            objCD.EliminarCategorias(Convert.ToInt32(id));
        }
        public void EliminarMaterial( string id)
        {

            objCD.EliminarMaterial(Convert.ToInt32(id));
        }
        public void EliminarPlatillo( string id)
        {

            objCD.EliminarPlatillo(Convert.ToInt32(id));
        }
        public void EliminarVenta( string id)
        {

            objCD.EliminarVenta(Convert.ToInt32(id));

        }
        public void Eliminarcompra( string id)
        {

            objCD.EliminarCompra(Convert.ToInt32(id));

        }
        public void EliminarDetalleVenta( string id)
        {

            objCD.EliminarDetalleVenta(Convert.ToInt32(id));

        }
        public void EliminarDetalecompra( string id)
        {

            objCD.EliminarDetalleCompra(Convert.ToInt32(id));

        }
        public void ActualizaMisDatos(string nom, string ape, DateTime fhN, string dir, string tel, string cor, string user, string pass, string id)
        {
            objCD.ActualizaMisDatos( nom,  ape,  fhN,  dir,  tel,  cor,  user,  pass,  id);
        }



    }
}

