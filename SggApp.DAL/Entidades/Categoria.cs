using System.Collections.Generic;

namespace SggApp.DAL.Entidades
{
    public class Categoria
    {
        // Identificador único de la categoría (clave primaria)
        public int Id { get; set; }

        // Nombre de la categoría (por ejemplo: Alimentación, Transporte, etc.)
        public string Nombre { get; set; }

        // Indica si la categoría está activa o no (por defecto es true)
        public bool Activo { get; set; } = true;

        // Relación uno a muchos con Gasto:
        // Una categoría puede tener muchos gastos asociados
        public ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

        // Relación uno a muchos con Presupuesto:
        // Una categoría puede tener varios presupuestos asociados
        public ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
    }
}

