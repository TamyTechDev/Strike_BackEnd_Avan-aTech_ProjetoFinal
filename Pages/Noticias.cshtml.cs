using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class NoticiasModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public NoticiasModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}