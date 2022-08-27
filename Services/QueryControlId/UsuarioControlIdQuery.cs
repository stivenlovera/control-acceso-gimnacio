using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlIDMvc.Entities;
using ControlIDMvc.Services.BodyControlId;
using ControlIDMvc.Services.ControlId;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ControlIDMvc.Services.QueryControlId
{
    public class UsuarioControlIdQuery
    {
        public string ApiUrl { get; set; }
        public UsuarioControlIdQuery()
        {
        }
        public BodyCreateObject CreateUser(List<Persona> personas)
        {
            usersCreateDto user = new usersCreateDto();
            foreach (var persona in personas)
            {
                user.name = persona.nombre;
                user.password = "";
                user.registration = "";
                user.salt = "";
            }
            List<usersCreateDto> users = new List<usersCreateDto>();
            users.Add(user);

            BodyCreateObject body = new BodyCreateObject()
            {
                objeto = "users",
                values = users
            };
            return body;
        }
    }

}