using System;
using System.Text.Json;

namespace Chain
{
    public class Request
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime  Time {get; set; } = DateTime.Now;

        public Request(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}