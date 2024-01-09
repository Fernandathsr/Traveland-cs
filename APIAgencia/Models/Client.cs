using System.ComponentModel.DataAnnotations.Schema;

namespace APIAgencia.Models
{
    public class Client 
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; } = string.Empty;


    }
}
