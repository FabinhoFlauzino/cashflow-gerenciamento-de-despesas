using System.Globalization;

namespace CashFlow.API.Middleware;

public class CultureMiddleware
{
    private readonly RequestDelegate _next;
    public CultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        //pegando todos os idiomas suportado
        var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();

        //Extraindo da requisição qual a cultura o aplicativo deseja
        var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        //Instancia uma cultura padrão
        var cultureInfo = new CultureInfo("pt-BR");

        //Sobreescrevendo a nova instancia
        //Verificando se é vazia e verificando se da suporte a lingua
        if (string.IsNullOrWhiteSpace(requestedCulture) == false
            && supportedLanguages.Exists(language => language.Name.Equals(requestedCulture)))
        {
            cultureInfo = new CultureInfo(requestedCulture);
        }

        //Código que altera a cultura correta
        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        //permitindo o curso da requisição continuar
        await _next(context);
    }
}