namespace mf_apis_web_services_fuel_manager.Models
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Href { get; set; }
        public string Rel { get; set; }
        public string Metodo { get; set; }
        public LinkDto(int id, string href, string rel, string metodo) //esse método diz qual o Id do objeto, href é o link disponível pra editar/apagar seus dados, rel é o relacionamento(a ação q vc tá tomando em relação a seu obj, e método é o HTTP
        {
            Id = id;
            Href = href;
            Rel = rel;
            Metodo = metodo;
        }

    }
    public class LinksHATEOS
    {
        public List<LinkDto> Links { get; set; } = new List<LinkDto>(); //gera a lista de links a ser instanciada
    }
}
