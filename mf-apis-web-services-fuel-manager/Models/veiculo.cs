﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Veiculos")]
    public class Veiculo : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int AnoFabricaçao { get; set;}
        [Required]
        public int AnoModelo { get; set;}
        public ICollection<Consumo> Consumos { get; set; }
        public ICollection<VeiculoUsuarios> Usuarios { get; set; }
    }
}
