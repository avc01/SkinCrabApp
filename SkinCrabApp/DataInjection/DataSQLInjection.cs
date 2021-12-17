using SkinCrabApp.Models;
using SkinCrabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkinCrabApp.DataInjection
{
    public static class DataSQLInjection
    {
        public static async Task SqlDataInjection() 
        {
            await SkinCrabService.CreateEmfermedad(new Emfermedad
            {
                TipoCancer = "No melanoma",
                Descripcion = "Todos los tipos de cáncer que se producen en la piel y que no son melanomas",
                Tratamiento = "Generalmente implica una cirugía para extraer las células cancerosas"
            });

            await SkinCrabService.CreateEmfermedad(new Emfermedad
            {
                TipoCancer = "Células basales",
                Descripcion = "Comienza en las células basales, un tipo de células que se encuentran en la piel y " +
                "que producen las células cutáneas nuevas a medida que las viejas mueren",
                Tratamiento = "Evitar la exposición al sol y usar protector solar"
            });

            await SkinCrabService.CreateEmfermedad(new Emfermedad
            {
                TipoCancer = "Células escamosas",
                Descripcion = "Se desarrolla en las células escamosas que componen las capas media y externa de la piel",
                Tratamiento = "Evitar la luz ultravioleta ayuda a reducir el riesgo de padecer carcinoma de células escamosas de la piel"
            });

            await SkinCrabService.CreateClinica(new Clinica
            {
                Nombre = "Clinica Central",
                Telefono = "2256-0907",
                Direccion = "San José",
                IdEmfermedad = 1,
                Url = "https://lh5.googleusercontent.com/p/AF1QipPOUqN6-Rk_vEQ8BoaK3Cw6qmN3I0vPPDVsM-DF=w408-h306-k-no"
            });

            await SkinCrabService.CreateClinica(new Clinica
            {
                Nombre = "Clinica Santa Rita",
                Telefono = "2221-6433",
                Direccion = "San José",
                IdEmfermedad = 3,
                Url = "https://lh5.googleusercontent.com/p/AF1QipNVIRN5WATBeDoSXrOE5PM5Bpixvnb85igsyMfJ=w426-h240-k-no"
            });

            await SkinCrabService.CreateClinica(new Clinica
            {
                Nombre = "Clinica Victoria",
                Telefono = "4000-1054",
                Direccion = "San José",
                IdEmfermedad = 2,
                Url = "https://lh5.googleusercontent.com/p/AF1QipMCpPWn3pL5mdsxaoSjDJxGfflKzWO6CH7ICBW4=w408-h500-k-no"
            });

            await SkinCrabService.CreateClinica(new Clinica
            {
                Nombre = "Clinica Medi Club",
                Telefono = "5004-5001",
                Direccion = "San José",
                IdEmfermedad = 1,
                Url = "https://lh5.googleusercontent.com/p/AF1QipOFYOfGHQ3GqcX9yesIHkUq2wPH-gR1lbG6TQfg=w408-h408-k-no"
            });

            await SkinCrabService.UpdateClinica(new Clinica
            {
                Nombre = "Clinica Sin Fronteras",
                Telefono = "2222-6285",
                Direccion = "La Sabana",
                IdEmfermedad = 3,
                Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGzRaqewLSyTBd6rCVuW4tO1fbdD6fF6hOeg&usqp=CAU"
            });
        }
    }
}
