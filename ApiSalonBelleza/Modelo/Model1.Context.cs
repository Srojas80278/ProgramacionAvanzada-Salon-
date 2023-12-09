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
    
    public partial class salonbellezaMNEntities : DbContext
    {
        public salonbellezaMNEntities()
            : base("name=salonbellezaMNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carrito> carrito { get; set; }
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
    
        public virtual ObjectResult<ConsultarCitaSP_Result> ConsultarCitaSP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCitaSP_Result>("ConsultarCitaSP");
        }
    
        public virtual ObjectResult<ConsultarUnaCita_Result> ConsultarUnaCita(Nullable<int> id_cita)
        {
            var id_citaParameter = id_cita.HasValue ?
                new ObjectParameter("id_cita", id_cita) :
                new ObjectParameter("id_cita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarUnaCita_Result>("ConsultarUnaCita", id_citaParameter);
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
    
        public virtual int BorrarCita_SP(Nullable<int> id_cita)
        {
            var id_citaParameter = id_cita.HasValue ?
                new ObjectParameter("id_cita", id_cita) :
                new ObjectParameter("id_cita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BorrarCita_SP", id_citaParameter);
        }
    }
}