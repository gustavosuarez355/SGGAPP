using System;

namespace SggApp.DAL.Entidades
{
    public class Presupuesto
    {
        // Identificador único del presupuesto (clave primaria)
        public int Id { get; set; }

        // Monto asignado en el presupuesto
        public decimal Monto { get; set; }

        // Fecha en que se creó o aplica el presupuesto
        public DateTime Fecha { get; set; }

        // Relación con Usuario:
        // Cada presupuesto pertenece a un usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Relación con Categoría:
        // Cada presupuesto está asociado a una categoría
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        // Relación con Moneda:
        // El presupuesto se define en una moneda específica
        public int MonedaId { get; set; }
        public Moneda Moneda { get; set; }
    }
}
