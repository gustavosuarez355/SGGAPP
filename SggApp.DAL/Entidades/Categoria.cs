using System.Collections.Generic;

namespace SggApp.DAL.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
public bool Activo { get; set; } = true; // por defecto activa

        // Relación con gastos
        public ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

        // Relación con presupuestos
        public ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
    }
}
