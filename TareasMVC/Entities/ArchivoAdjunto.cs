using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TareasMVC.Entities;

[Table("archivos_adjuntos")]
public class ArchivoAdjunto
{
    [Column("id")] public Guid Id { get; set; }

    [Column("tarea_id")] public int TareaId { get; set; }

    public Tarea Tarea { get; set; }

    [Column("url")] [Unicode] public string Url { get; set; }

    [Column("titulo")] [Required] public string NombreTitulo { get; set; }

    [Column("Orden")] public int Orden { get; set; }

    [Column("fecha_creacion")] public DateTime FechaCreacion { get; set; }
}