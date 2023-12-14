using WebCore.Models.Attributes;

namespace WebCore.Models;

public class SingInModel
{
    [Email]
    public string email { get; set; }
}