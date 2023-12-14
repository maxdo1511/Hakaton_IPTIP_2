using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebCore.Communicators;
using WebCore.Models;

namespace WebCore.Controllers;
[ApiController]
public class AuthController : ControllerBase
{
    private MireaRequestCommunicator _mireaRequestCommunicator;

    public AuthController(MireaRequestCommunicator mireaRequestCommunicator)
    {
        _mireaRequestCommunicator = mireaRequestCommunicator;
    }
    [Route("/signin")]
    [HttpPost]
    public async Task<IActionResult> SignIn([FromBody]SingInModel model)
    {
        var result = await _mireaRequestCommunicator.SignIn(model.email);
        if (result.Result)
        {
            return Ok(await Authentificate(model.email));
        }
        return BadRequest(result.Error);
    }

    private async Task<string> Authentificate(string email)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimsIdentity.DefaultNameClaimType, email)
        };
        var jwt = new JwtSecurityToken(
            issuer: "kurator.mirea",
            audience: "kurator.mirea",
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromDays(7)), 
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")), SecurityAlgorithms.HmacSha256));
        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);;
        return  encodedJwt;
    }
}