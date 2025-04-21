using System;

namespace SggApp.DAL.Entidades
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        // Claves foráneas
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public int MonedaId { get; set; }
        public Moneda Moneda { get; set; }
    }
}
