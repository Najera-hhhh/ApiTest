using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infraestructure.DataSource
{
    public class AuthDataSource
    {
       

        public async Task<User>? RealizarLogin(string user, string password)
        {
            string apiUrl = "https://dummyjson.com/auth/login";

            var credentials = new
            {
                username = user,
                password = password,
                // expiresInMins: 60, // optional
            };

            using (HttpClient httpClient = new HttpClient())
            {
                // Convertir las credenciales a formato JSON
                string jsonCredentials = JsonSerializer.Serialize(credentials);

                // Realizar la solicitud HTTP de forma asíncrona
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, new StringContent(jsonCredentials, Encoding.UTF8, "application/json"));

                // Asegurarse de que la solicitud fue exitosa
                response.EnsureSuccessStatusCode();

                // Leer el contenido de la respuesta
                string resultJson = await response.Content.ReadAsStringAsync();

                // Deserializar la respuesta y verificar si el login fue exitoso
                var result = JsonSerializer.Deserialize<User>(resultJson);
                return result;
            }
        }

    }
}
