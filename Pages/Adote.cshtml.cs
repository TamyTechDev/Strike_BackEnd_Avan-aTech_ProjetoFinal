using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class AdoteModel : PageModel
{
    private readonly ILogger<AdoteModel > _logger;

    public AdoteModel(ILogger<AdoteModel > logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}