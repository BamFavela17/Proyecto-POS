using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
namespace CapaDatos
{
    public class CD_Crud
    {
        private ConexionSQL conn = new ConexionSQL();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // CRUD de la tabla empleado
        public DataTable MostrarEmp()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarMateriales()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verMaterial";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarCategorias()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarHorario()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verHorarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarPuesto()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "MostrarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable Mostrarproveedores()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verproveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarClientes()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarPlatillos()
        {

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "verPlatillos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }
        //
        //
        public void InsertarEmpleado(string nom, string ape, int tipo, DateTime fhN, DateTime fhC, string dir, string tel, string cor, int turno, string user, string pass)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nom);
            comando.Parameters.AddWithValue("@Apellidos", ape);
            comando.Parameters.AddWithValue("@Puesto", tipo);
            comando.Parameters.AddWithValue("@FhNa", fhN);
            comando.Parameters.AddWithValue("@FhCon", fhC);
            comando.Parameters.AddWithValue("@Dir", dir);
            comando.Parameters.AddWithValue("@Tel", tel);
            comando.Parameters.AddWithValue("@cor", cor);
            comando.Parameters.AddWithValue("@idTurno", turno);
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@contraseña", pass);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }
        public void Insertarpuesto(string nom, decimal sueldo)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsertPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nom);
            comando.Parameters.AddWithValue("@Sueldo", sueldo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarHorario(string turno, DateTime HE, DateTime HS)
        {
            //PROCEDIMNIENTO
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "IncertarHorario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@turno", turno);
            comando.Parameters.AddWithValue("@HoraEnt", HE);
            comando.Parameters.AddWithValue("@Horasal", HS);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarCliente(string nom, string importancia)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "insertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("", nom);
            comando.Parameters.AddWithValue("", importancia);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarProveedor(string nombre, string ape, string lada, string tel, string correo, string empresa, string recurso, string desc)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "insertarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom", nombre);
            comando.Parameters.AddWithValue("@ape", ape);
            comando.Parameters.AddWithValue("@lada", lada);
            comando.Parameters.AddWithValue("@Telefono", tel);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Empresa", empresa);
            comando.Parameters.AddWithValue("@recurso", recurso);
            comando.Parameters.AddWithValue("@Descripcion", desc);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarCategoria(string nom, string desc)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "insertarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nom);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarMaterial(string nom, int cant, int proveedor, decimal costo, string unidad, DateTime fCad, int cate, int stock)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "insertarMaterial";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomM", nom);
            comando.Parameters.AddWithValue("@Cant", cant);
            comando.Parameters.AddWithValue("@Proveedor", proveedor);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@UnidadMedida", unidad);
            comando.Parameters.AddWithValue("@fechaCad", fCad);
            comando.Parameters.AddWithValue("@idCate", cate);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarPlatillo(string nom, string des, int cate, decimal preU)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "insertarPlatillo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom", nom);
            comando.Parameters.AddWithValue("@des", des);
            comando.Parameters.AddWithValue("@Categoria", cate);
            comando.Parameters.AddWithValue("@preunit", preU);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarVenta(DateTime fh, int idemp, int idcli, decimal importe)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsertVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", fh);
            comando.Parameters.AddWithValue("@IdEmpleado", idemp);
            comando.Parameters.AddWithValue("@IdCliente", idcli);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarCompra(DateTime fh, int idemp, int prov, decimal importe)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsertCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", fh);
            comando.Parameters.AddWithValue("@IdEmpleado", idemp);
            comando.Parameters.AddWithValue("@IdProveedor", prov);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarDetalleVenta(int vent, int idprod, decimal precio, int cant, decimal importe)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsertDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Venta", vent);
            comando.Parameters.AddWithValue("@IdProducto", idprod);
            comando.Parameters.AddWithValue("@PrecioU", precio);
            comando.Parameters.AddWithValue("@Cantidad", cant);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void InsertarDetalleCompra(int compra, int idprod, decimal precio, int cant, decimal importe)
        {
            //PROCEDIMNIENTO

            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure insertar
            comando.CommandText = "InsetDetalleCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Compra", compra);
            comando.Parameters.AddWithValue("@IdProducto", idprod);
            comando.Parameters.AddWithValue("@PrecioU", precio);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //
        //

        public void EditarEmpleado(string nom, string ape, int tipo, DateTime fhN, DateTime fhC, string dir, string tel, string cor, int turno, string user, string pass, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "ActualizarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nom);
            comando.Parameters.AddWithValue("@Apellidos", ape);
            comando.Parameters.AddWithValue("@Puesto", tipo);
            comando.Parameters.AddWithValue("@FhNa", fhN);
            comando.Parameters.AddWithValue("@FhCon", fhC);
            comando.Parameters.AddWithValue("@Dir", dir);
            comando.Parameters.AddWithValue("@Tel", tel);
            comando.Parameters.AddWithValue("@cor", cor);
            comando.Parameters.AddWithValue("@idTurno", turno);
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@contraseña", pass);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarPuesto(string nom, decimal sueldo, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "ActualizaPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nom);
            comando.Parameters.AddWithValue("@Sueldo", sueldo);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarHorario(string turno, TimeSpan HE, TimeSpan HS, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "actualizarHorario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@turno", turno);
            comando.Parameters.AddWithValue("@hEnt", HE);
            comando.Parameters.AddWithValue("@hSal", HS);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarProveedores(string nom, string ape, string lada, string tel, string correo, string empresa, string recurso, string des, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom", nom);
            comando.Parameters.AddWithValue("@ape", ape);
            comando.Parameters.AddWithValue("@lada", lada);
            comando.Parameters.AddWithValue("@Telefono", tel);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Empresa", empresa);
            comando.Parameters.AddWithValue("@recurso", recurso);
            comando.Parameters.AddWithValue("@Descripcion", des);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarCategoria(string nom, string desc, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nom);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarMaterial(string nom, int cant, int prov, decimal costo, string unidad, DateTime fCad, int idC, int stock, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarMaterial";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomM", nom);
            comando.Parameters.AddWithValue("@Cant", cant);
            comando.Parameters.AddWithValue("@Proveedor", prov);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@UnidadMedida", unidad);
            comando.Parameters.AddWithValue("@fechaCad", fCad);
            comando.Parameters.AddWithValue("@idCate", idC);
            comando.Parameters.AddWithValue("@idM", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarCliente(string nom, string imp, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nom);
            comando.Parameters.AddWithValue("@imp", imp);
            comando.Parameters.AddWithValue("@idC", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarPlatillo(string nom, string des, int cat, decimal precio, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarPlatillo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom", nom);
            comando.Parameters.AddWithValue("@des", des);
            comando.Parameters.AddWithValue("@Categoria", cat);
            comando.Parameters.AddWithValue("@preunit", precio);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarDetalleCompras(int idProd, int idemp, decimal precio, int cant, decimal importe, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarDetalleCompras";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDProducto", idProd);
            comando.Parameters.AddWithValue("@PrecioUnidad", precio);
            comando.Parameters.AddWithValue("@Cantidad", cant);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarCompra(DateTime fC, int idemp, int idprov, decimal importe, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "modificarCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaCompra", fC);
            comando.Parameters.AddWithValue("@IDEmpleado", idemp);
            comando.Parameters.AddWithValue("@IDProveedor", idprov);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarDetalleVenta(int venta,int idProd, int idemp, decimal precio, int cant, decimal importe, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "InsertDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Venta", venta);
            comando.Parameters.AddWithValue("@IDProducto", idProd);
            comando.Parameters.AddWithValue("@PrecioU", precio);
            comando.Parameters.AddWithValue("@Cantidad", cant);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EditarVenta(DateTime fC, int idemp, int idClt, decimal importe, string id)
        {
            // abrimos conexion 
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure editar
            comando.CommandText = "ActualizaVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", fC);
            comando.Parameters.AddWithValue("@IdEmpleado", idemp);
            comando.Parameters.AddWithValue("@IdCliente", idClt);
            comando.Parameters.AddWithValue("@Importe", importe);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }



        public void EliminarEmpleado(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarPuesto(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "EliminarPuesto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarHorario(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarHorario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idH", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarProveedor(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarProveedores";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarCategorias(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarCategoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarMaterial(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarMaterial";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarCliente(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarPlatillo(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarPlatillo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarCompra(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarCompra";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarDetalleCompra(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "borrarDetalleCompras";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarVenta(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "EliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarDetalleVenta(int id)
        {
            // abrimos coneccion
            comando.Connection = conn.AbrirConexion();
            // hacemos uso del procedure eliminar
            comando.CommandText = "EliminarDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
