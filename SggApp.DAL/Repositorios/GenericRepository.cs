using Microsoft.EntityFrameworkCore;        // Para usar DbContext y métodos como FindAsync, ToListAsync, etc.
using SggApp.DAL.Contextos;                // Para acceder a SggAppDbContext
using System.Collections.Generic;          // Para usar List<T> y IEnumerable<T>
using System.Threading.Tasks;              // Para usar Task y métodos asincrónicos
using System;                              // Para manejar excepciones

namespace SggApp.DAL.Repositorios
{
    // Clase genérica que implementa operaciones básicas de un repositorio (CRUD)
    // T es cualquier clase (entidad) del modelo
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SggAppDbContext _context; // Contexto para acceder a la base de datos
        protected readonly DbSet<T> _dbSet;          // Representa la tabla correspondiente a la entidad T

        // Constructor que recibe el contexto mediante inyección de dependencias
        public GenericRepository(SggAppDbContext context)
        {
            _context = context;                  // Asignamos el contexto recibido
            _dbSet = _context.Set<T>();          // Obtenemos la tabla (DbSet) correspondiente a la entidad T
        }

        // Método para obtener un elemento por su ID (clave primaria)
        public async Task<T?> ObtenerPorIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);   // Busca el elemento en la tabla por su ID
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrarlo
                throw new InvalidOperationException($"Error al obtener el elemento con ID {id}: {ex.Message}");
            }
        }

        // Método para obtener todos los registros de la entidad
        public async Task<IEnumerable<T>> ObtenerTodosAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();   // Retorna todos los registros como una lista
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrarlo
                throw new InvalidOperationException($"Error al obtener todos los registros de la entidad: {ex.Message}");
            }
        }

        // Método para agregar un nuevo registro a la base de datos
        public async Task AgregarAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);      // Agrega la entidad a la tabla
                await _context.SaveChangesAsync();   // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrarlo
                throw new InvalidOperationException($"Error al agregar la entidad: {ex.Message}");
            }
        }

        // Método para actualizar un registro existente
        public async Task ActualizarAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);              // Marca la entidad como modificada
                await _context.SaveChangesAsync();   // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrarlo
                throw new InvalidOperationException($"Error al actualizar la entidad: {ex.Message}");
            }
        }

        // Método para eliminar un registro de la base de datos
        public async Task EliminarAsync(T entidad)
        {
            try
            {
                _dbSet.Remove(entidad);              // Marca la entidad para eliminarla
                await _context.SaveChangesAsync();   // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrarlo
                throw new InvalidOperationException($"Error al eliminar la entidad: {ex.Message}");
            }
        }
    }
}
