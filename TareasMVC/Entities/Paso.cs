using System.ComponentModel.DataAnnotations.Schema;

namespace TareasMVC.Entities;

[Table("Pasos")]
public class Paso
{
    [Column("id")] public Guid Id { get; set; }
    [Column("tarea_id")] public int TareaId { get; set; }
    public Tarea Tarea { get; set; }
    [Column("descripcion")] public string Descripcion { get; set; }
    [Column("completado")] public bool Completado { get; set; }
    [Column("orden")] public int Orden { get; set; }
}