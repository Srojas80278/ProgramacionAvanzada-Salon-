﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiSalonBelleza.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class salonEntities : DbContext
    {
        public salonEntities()
            : base("name=salonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<citas> citas { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<users> users { get; set; }
    
        public virtual int ActualizarCitaSP(string estilista, Nullable<System.DateTime> fecha, string sede, string nombre_cliente, string servicio, string descripcion_servicio, Nullable<int> id_cita)
        {
            var estilistaParameter = estilista != null ?
                new ObjectParameter("estilista", estilista) :
                new ObjectParameter("estilista", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var sedeParameter = sede != null ?
                new ObjectParameter("sede", sede) :
                new ObjectParameter("sede", typeof(string));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
            var servicioParameter = servicio != null ?
                new ObjectParameter("servicio", servicio) :
                new ObjectParameter("servicio", typeof(string));
    
            var descripcion_servicioParameter = descripcion_servicio != null ?
                new ObjectParameter("descripcion_servicio", descripcion_servicio) :
                new ObjectParameter("descripcion_servicio", typeof(string));
    
            var id_citaParameter = id_cita.HasValue ?
                new ObjectParameter("id_cita", id_cita) :
                new ObjectParameter("id_cita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarCitaSP", estilistaParameter, fechaParameter, sedeParameter, nombre_clienteParameter, servicioParameter, descripcion_servicioParameter, id_citaParameter);
        }
    
        public virtual int ActualizarProductoSP(string nombre, string descripcion, Nullable<int> cantidad, Nullable<decimal> precio, string imagen, Nullable<bool> estado, Nullable<long> conProducto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var conProductoParameter = conProducto.HasValue ?
                new ObjectParameter("ConProducto", conProducto) :
                new ObjectParameter("ConProducto", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarProductoSP", nombreParameter, descripcionParameter, cantidadParameter, precioParameter, imagenParameter, estadoParameter, conProductoParameter);
        }
    
        public virtual int BorrarCita_SP(Nullable<int> id_cita)
        {
            var id_citaParameter = id_cita.HasValue ?
                new ObjectParameter("id_cita", id_cita) :
                new ObjectParameter("id_cita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BorrarCita_SP", id_citaParameter);
        }
    
        public virtual int BorrarProducto_SP(Nullable<long> conProducto)
        {
            var conProductoParameter = conProducto.HasValue ?
                new ObjectParameter("ConProducto", conProducto) :
                new ObjectParameter("ConProducto", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BorrarProducto_SP", conProductoParameter);
        }
    
        public virtual ObjectResult<ConsultarCitaSP_Result> ConsultarCitaSP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCitaSP_Result>("ConsultarCitaSP");
        }
    
        public virtual ObjectResult<ConsultarProductoSP_Result> ConsultarProductoSP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarProductoSP_Result>("ConsultarProductoSP");
        }
    
        public virtual ObjectResult<ConsultarUnaCita_Result> ConsultarUnaCita(Nullable<int> id_cita)
        {
            var id_citaParameter = id_cita.HasValue ?
                new ObjectParameter("id_cita", id_cita) :
                new ObjectParameter("id_cita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarUnaCita_Result>("ConsultarUnaCita", id_citaParameter);
        }
    
        public virtual ObjectResult<ConsultarUnProductoSP_Result> ConsultarUnProductoSP(Nullable<int> conProducto)
        {
            var conProductoParameter = conProducto.HasValue ?
                new ObjectParameter("ConProducto", conProducto) :
                new ObjectParameter("ConProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarUnProductoSP_Result>("ConsultarUnProductoSP", conProductoParameter);
        }
    
        public virtual ObjectResult<IniciarSesionSP_Result> IniciarSesionSP(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IniciarSesionSP_Result>("IniciarSesionSP", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<RecuperarCuentaSP_Result> RecuperarCuentaSP(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RecuperarCuentaSP_Result>("RecuperarCuentaSP", emailParameter);
        }
    
        public virtual int RegistrarCitaSP(string estilista, Nullable<System.DateTime> fecha, string sede, string nombre_cliente, string servicio, string descripcion_servicio)
        {
            var estilistaParameter = estilista != null ?
                new ObjectParameter("estilista", estilista) :
                new ObjectParameter("estilista", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var sedeParameter = sede != null ?
                new ObjectParameter("sede", sede) :
                new ObjectParameter("sede", typeof(string));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
            var servicioParameter = servicio != null ?
                new ObjectParameter("servicio", servicio) :
                new ObjectParameter("servicio", typeof(string));
    
            var descripcion_servicioParameter = descripcion_servicio != null ?
                new ObjectParameter("descripcion_servicio", descripcion_servicio) :
                new ObjectParameter("descripcion_servicio", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarCitaSP", estilistaParameter, fechaParameter, sedeParameter, nombre_clienteParameter, servicioParameter, descripcion_servicioParameter);
        }
    
        public virtual int RegistrarCuentaSP(string name, string email, string password, Nullable<long> role_id)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var role_idParameter = role_id.HasValue ?
                new ObjectParameter("role_id", role_id) :
                new ObjectParameter("role_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarCuentaSP", nameParameter, emailParameter, passwordParameter, role_idParameter);
        }
    
        public virtual int RegistrarProductoSP(string nombre, string descripcion, Nullable<int> cantidad, Nullable<decimal> precio, string imagen, Nullable<bool> estado)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarProductoSP", nombreParameter, descripcionParameter, cantidadParameter, precioParameter, imagenParameter, estadoParameter);
        }
    }
}
