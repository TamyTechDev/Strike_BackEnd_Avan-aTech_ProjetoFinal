using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class ApostaModel : PageModel
{
    private readonly ILogger<ApostaModel > _logger;

    public ApostaModel(ILogger<ApostaModel > logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}