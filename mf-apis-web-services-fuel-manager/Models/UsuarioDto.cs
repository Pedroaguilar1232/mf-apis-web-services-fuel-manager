using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace mf_apis_web_services_fuel_manager.Models
{
    public class UsuarioDto //é apenas para transferência de objetos entre cliente e servidor, não está no banco de dados
    {
        public int? Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
    }
}
