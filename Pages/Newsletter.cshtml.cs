using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strike_BackEnd_Avan_aTech_ProjetoFinal.Pages;

public class NewsletterModel : PageModel
{
    private readonly ILogger<NewsletterModel> _logger;

    public NewsletterModel(ILogger<NewsletterModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}