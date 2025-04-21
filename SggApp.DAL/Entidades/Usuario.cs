namespace SggApp.DAL.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }  // Identificador único del usuario
        public string Nombre { get; set; }  // Nombre del usuario
        public string Email { get; set; }  // Correo electrónico del usuario
        public string PasswordHash { get; set; }  // Contraseña del usuario (en formato hash)
        public DateTime FechaRegistro { get; set; }  // Fecha de registro del usuario

        // Relaciones de navegación
        public ICollection<Gasto> Gastos { get; set; }  // Relación 1 a muchos: Un usuario puede tener muchos gastos
        public ICollection<Presupuesto> Presupuestos { get; set; }  // Relación 1 a muchos: Un usuario puede tener muchos presupuestos
    }
}
