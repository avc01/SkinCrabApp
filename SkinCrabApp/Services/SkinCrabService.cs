using SkinCrabApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SkinCrabApp.Services
{
    public static class SkinCrabService
    {
        private static SQLiteAsyncConnection _database;

        public static async Task Init() 
        {
            if (_database != null)
            {
                return;
            }

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SkinCrabStorage.db");
            _database = new SQLiteAsyncConnection(databasePath);
            await _database.CreateTableAsync<Usuario>();
            await _database.CreateTableAsync<Emfermedad>();
            await _database.CreateTableAsync<Clinica>();
        }

        #region Usuarios
        public static async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            await Init();
            var result = await _database.Table<Usuario>().ToListAsync();
            return result;
        }

        public static async Task<Usuario> GetUsuario(int id)
        {
            await Init();
            var query = _database.Table<Usuario>().Where(x => x.IdUsuario == id);
            var result = await query.FirstOrDefaultAsync();
            return result;
        }

        public static async Task CreateUsuario(Usuario usuario)
        {
            await Init();
            await _database.InsertAsync(usuario);
        }

        public static async Task DeleteUsuario(int id)
        {
            await Init();
            await _database.DeleteAsync<Usuario>(id);
        }

        public static async Task UpdateUsuario(Usuario usuario)
        {
            await Init();
            await _database.UpdateAsync(usuario);
        }
        #endregion

        #region Emfermedades
        public static async Task<IEnumerable<Emfermedad>> GetEmfermedades()
        {
            await Init();
            var result = await _database.Table<Emfermedad>().ToListAsync();
            return result;
        }

        public static async Task<Emfermedad> GetEmfermedad(int id)
        {
            await Init();
            var query = _database.Table<Emfermedad>().Where(x => x.IdEmfermedad == id);
            var result = await query.FirstOrDefaultAsync();
            return result;
        }

        public static async Task CreateEmfermedad(Emfermedad emfermedad)
        {
            await Init();
            await _database.InsertAsync(emfermedad);
        }

        public static async Task DeleteEmfermedad(int id)
        {
            await Init();
            await _database.DeleteAsync<Emfermedad>(id);
        }

        public static async Task UpdateEmfermedad(Emfermedad emfermedad)
        {
            await Init();
            await _database.UpdateAsync(emfermedad);
        }
        #endregion

        #region Clinicas
        public static async Task<IEnumerable<Clinica>> GetClinicas()
        {
            await Init();
            var result = await _database.Table<Clinica>().ToListAsync();
            return result;
        }

        public static async Task<Clinica> GetClinica(int id)
        {
            await Init();
            var query = _database.Table<Clinica>().Where(x => x.IdClinica == id);
            var result = await query.FirstOrDefaultAsync();
            return result;
        }

        public static async Task CreateClinica(Clinica clinica)
        {
            await Init();
            await _database.InsertAsync(clinica);
        }

        public static async Task DeleteClinica(int id)
        {
            await Init();
            await _database.DeleteAsync<Clinica>(id);
        }

        public static async Task UpdateClinica(Clinica clinica)
        {
            await Init();
            await _database.UpdateAsync(clinica);
        }
        #endregion
    }
}
