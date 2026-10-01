using Microsoft.AspNetCore.Identity;
namespace Academia;

public class ApplicationUser : IdentityUser
{
    public string NomeCompleto {get; set;} = string.Empty;
}
