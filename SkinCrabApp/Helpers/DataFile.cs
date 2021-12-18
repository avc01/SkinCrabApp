using SkinCrabApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;

namespace SkinCrabApp.Helpers
{
    public static class DataFile
    {
        private static readonly string fileNameUserData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userData.txt");
        private static readonly string fileNameAutoExamData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userAutoExamData.txt");

        public static async Task SaveUserDataToFileAsync(Usuario usuario) 
        {
            var result = await GenerateFileWithUserDataAsync(usuario);

            if (!File.Exists(fileNameUserData))
            {
                using (StreamWriter streamWriter = File.CreateText(fileNameUserData))
                {
                    await streamWriter.WriteLineAsync(result.ToString());
                }
                return;
            }

            using (StreamWriter streamWriter = File.AppendText(fileNameUserData))
            {
                await streamWriter.WriteLineAsync(result.ToString());
            }
        }

        public static async Task SaveUserAutoExamToFileAsync(AutoExamen autoExamen)
        {
            var result = await GenerateFileWithUserAutoExamDataAsync(autoExamen);

            if (!File.Exists(fileNameAutoExamData))
            {
                using (StreamWriter streamWriter = File.CreateText(fileNameAutoExamData))
                {
                    await streamWriter.WriteLineAsync(result.ToString());
                }
                return;
            }

            using (StreamWriter streamWriter = File.AppendText(fileNameAutoExamData))
            {
                await streamWriter.WriteLineAsync(result.ToString());
            }
        }

        private static async Task<StringBuilder> GenerateFileWithUserDataAsync(Usuario usuario)
        {
            StringBuilder stringBuilder = new StringBuilder();
            await Task.Run(() =>
            {
                stringBuilder.AppendLine($"Id Usuario: {usuario.IdUsuario}");
                stringBuilder.AppendLine($"Edad: {usuario.Edad}");
                stringBuilder.AppendLine($"Genero Biologico: {usuario.Genero}");
                stringBuilder.AppendLine($"Etnia: {usuario.Etnia}");
                stringBuilder.AppendLine($"Color de Piel: {usuario.Color}");
                stringBuilder.AppendLine($"Marcas de Nacimiento: {usuario.MarcasNacimiento}");
                stringBuilder.AppendLine($"Historial Medico: {usuario.HistorialMedico}");
                stringBuilder.AppendLine($"Diagnosticado: {usuario.Diagnosticado}");
                stringBuilder.AppendLine($"Tratamiento: {usuario.Tratamiento}");
                stringBuilder.AppendLine($"Piel Palida: {usuario.PielPalida}");
            });
           
            return stringBuilder;
        }

        private static async Task<StringBuilder> GenerateFileWithUserAutoExamDataAsync(AutoExamen autoExamen)
        {
            StringBuilder stringBuilder = new StringBuilder();
            await Task.Run(() =>
            {
                stringBuilder.AppendLine($"Id usuario: {Preferences.Get("currentUser_UsuarioId", "default_value")}");
                stringBuilder.AppendLine($"Hace cuanto noto la lesion: {autoExamen.HaceCuantoNotoLaLesion}");
                stringBuilder.AppendLine($"Nivel del cambio en el tamano de la lesion: {autoExamen.NivelDeCambioTamanoDeLaLesion}");
                stringBuilder.AppendLine($"Tiene hinchazon en la lesion: {autoExamen.HinchazonLesion}");
                stringBuilder.AppendLine($"Tiene un aumento en la temperatura de la lesion: {autoExamen.AumentoTemperaturaDeLaLesion}");
                stringBuilder.AppendLine($"Tiene un enrojecimiento en la zona de la lesion: {autoExamen.EnrojecimientoZonaDeLaLesion}");
                stringBuilder.AppendLine($"Presenta un cambio en la textura de la lesion: {autoExamen.CambioEnLaTexturaDeLaLesion}");
                stringBuilder.AppendLine($"Tiene un cambio el color de la lesion: {autoExamen.CambioColorDeLaLesion}");
            });

            return stringBuilder;
        }
    }
}
