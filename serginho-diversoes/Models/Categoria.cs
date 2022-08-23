namespace serginho_diversoes.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }   
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Brinquedo> Brinquedos { get; set; }
    }
}
