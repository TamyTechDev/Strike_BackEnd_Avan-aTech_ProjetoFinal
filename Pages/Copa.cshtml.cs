using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class CopaModel : PageModel
{
    private readonly ILogger<CopaModel> _logger;

    public CopaModel(ILogger<CopaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}