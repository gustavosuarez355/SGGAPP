using System.Collections.Generic;
using SggApp.DAL.Entidades; // Opcional si ya está en el mismo namespace

namespace SggApp.DAL.Entidades
{
    public class Moneda
    {
        public int Id { get; set; }  // Identificador único de la moneda
        public string Codigo { get; set; }  // Código de la moneda (ej: COP, USD)
        public string Nombre { get; set; }  // Nombre completo de la moneda (ej: Peso colombiano)
        public string Simbolo { get; set; }  // Símbolo de la moneda (ej: $, €, ¥)

        // Relaciones de navegación
        public ICollection<Gasto> Gastos { get; set; }  // Gastos que están en esta moneda
        public ICollection<Presupuesto> Presupuestos { get; set; }  // Presupuestos que están en esta moneda
    }
}
