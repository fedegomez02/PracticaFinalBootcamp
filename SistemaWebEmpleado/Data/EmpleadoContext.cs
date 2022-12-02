using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;
using System;

namespace SistemaWebEmpleado.Data
{
    public class EmpleadoContext : DbContext
    {
   

        public EmpleadoContext(DbContextOptions<EmpleadoContext> options)
            : base(options)
        { }

        public DbSet<Empleado> empleados { get; set; }

    }
}
