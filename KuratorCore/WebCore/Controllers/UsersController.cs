using System.Security.Claims;
using Google.Protobuf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using WebCore.Communicators;

namespace WebCore.Controllers;
[ApiController]
[Authorize]
[Route("user")]
public class UsersController:ControllerBase
{
    private DatabaseCommunicator _databaseCommunicator;
    private MireaRequestCommunicator _mireaRequestCommunicator;

    public UsersController(DatabaseCommunicator databaseCommunicator, MireaRequestCommunicator mireaRequestCommunicator)
    {
        _databaseCommunicator = databaseCommunicator;
        _mireaRequestCommunicator = mireaRequestCommunicator;
    }

    [Route("data/userdata/{email}")]
    [HttpGet]
    public async Task<IActionResult> GerUserData(string email)
    {
        var result = await _mireaRequestCommunicator.GetUserByEmail(email);
        if (result.Email!="")
        {
            return Ok(result);
        }
        else
        {
            return BadRequest("No such email!");
        }
    }

    [Route("data/userdata")]
    [HttpGet]
    public async Task<IActionResult> GetUserByEmail()
    {
        var result1 = await _databaseCommunicator.GetAllUsers();
        if (result1.Users.Any(a => a.Email == HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value))
        {
            var result = await _mireaRequestCommunicator.GetUser(HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value,result1.Users.FirstOrDefault(a=>a.Email==HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value).Token);
            if (result.Email!="")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("No such email!");
            }
        }
        else
        {
            return BadRequest("No such email!");
        }
    
    }
    [Route("data/usersdata")]
    [HttpGet]
    public async Task<IActionResult> GetUsersByEmail()
    {
        List<GetUserResponse> x = new List<GetUserResponse>();
        var result1 = await _databaseCommunicator.GetAllUsers();
        foreach (var VARIABLE in result1.Users)
        {
            x.Add(await _mireaRequestCommunicator.GetUserByEmail(VARIABLE.Email));
        }
        return Ok(x);
    }
    [Route("data/graphic/{email}")]
    [HttpGet]
    public async Task<IActionResult> GetUserGraphic(string email)
    {
        var result = await _databaseCommunicator.GetCuratorGraphic(email);
        if (result.Bytes.Count != 0)
        {
            ByteString[] fileData = result.Bytes.ToArray();
            string contentType = "image/png";
            return new FileContentResult(fileData[0].ToByteArray(), contentType)
            {
                FileDownloadName = "graphic"
            };
        }
        else
        {
            return Problem("No graphic for user!");
        }
    }
    [Route("data/icon/{email}")]
    [HttpGet]
    public async Task<IActionResult> GetUserIcon(string email)
    {
        string filePath = $"MireaCore/images/{email}/icon.png";
        byte[] fileData = System.IO.File.ReadAllBytes(filePath);
        string contentType = MimeTypes.GetMimeType(Path.GetExtension(filePath));
        return new FileContentResult(fileData, contentType)
        {
            FileDownloadName = Path.GetFileName(filePath)
        };
        
    }
    [Route("data/contacts")]
    [HttpGet]
    public async Task<IActionResult> GetUserConcacts()
    {
        var result = await 
            _databaseCommunicator.GetCurator(HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value);
        return Ok(result.Curator.Contacts);
    }
    [Route("data/contacts/{email}")]
    [HttpGet]
    public async Task<IActionResult> GetUserConcacts(string email)
    {
        var result = await 
            _databaseCommunicator.GetCurator(email);
        return Ok(result.Curator.Contacts);
    }
    [Route("data/rating/{email}")]
    [HttpGet]
    public async Task<IActionResult> GetUserRatings(string email)
    {
        var result = await 
            _databaseCommunicator.GetCurator(email);
        return Ok(result.Curator.Ratings);
    }
    [Route("data/slaves")]
    [HttpGet]
    public async Task<IActionResult> GetAllSlaves()
    {
      
        return Ok();
    }
    [Route("data/master")]
    [HttpGet]
    public async Task<IActionResult> GetMaster()
    {
      
        return Ok();
    }
    [Route("admin/curators")]
    [HttpGet]
    public async Task<IActionResult> GetAllCurators()
    {
        var result = await _databaseCommunicator.GetAllUsers();
        if (result.Users.Any(a => a.Email == HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value))
        {
            if (result.Users.FirstOrDefault(a =>
                    a.Email == HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value).Role == "admin")
            {
                return Ok( _databaseCommunicator.GetSortedCurators("role").Result.Curators);
            }
        }

        return BadRequest();
    }

    [IgnoreAntiforgeryToken]
    [Route("action/add_icon")]
    [HttpPost]
    public async Task<IActionResult> AddUserIcon(FormFile Upload)
    {
        string filePath = $"MireaCore/images/{HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value}";
       
        if (Upload.FileName.Contains(".png"))
        {

             filePath = Path.Combine(filePath, "icon.png");
            using (var inStream = Upload.OpenReadStream())
            using (var outStream = new MemoryStream())
            using (var image = Image.Load(inStream))
            {
                image.Mutate(
                    i => i.Resize(165, 165));

                image.Save(filePath);
            }

            return Ok("File sucsessefully added!");



        }
        else
        {
            return BadRequest("bad file!");
        }

    }
}