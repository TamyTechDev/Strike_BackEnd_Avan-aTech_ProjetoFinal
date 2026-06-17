using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class CopinhaModel : PageModel
{
    private readonly ILogger<CopinhaModel > _logger;

    public CopinhaModel(ILogger<CopinhaModel > logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}