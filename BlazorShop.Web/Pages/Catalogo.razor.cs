using BlazorShop.Models.DTOs;

namespace BlazorShop.Web.Pages
{
    public partial class Catalogo
    {
        public IEnumerable<ProdutoDto>? Produtos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Produtos = await produtoService.GetItens();
        }
    }
}
