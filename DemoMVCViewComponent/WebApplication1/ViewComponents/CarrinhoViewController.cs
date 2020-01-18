using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVCViewComponent.ViewComponents
{

    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewController : ViewComponent
    {

        public int QuantidadeItensCarrinho { get; set; }

        public CarrinhoViewController()
        {
            QuantidadeItensCarrinho = 5;
        }

       public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(QuantidadeItensCarrinho);
        }
    }
}