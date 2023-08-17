﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TareasMVC.Entities;

namespace TareasMVC.Database;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Tarea> Tareas { get; set; }
    public DbSet<Paso> Pasos { get; set; }
    public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
}