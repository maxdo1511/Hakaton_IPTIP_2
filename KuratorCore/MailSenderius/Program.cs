
using EmailCore.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
var app = builder.Build();

app.MapGrpcService<EmailService>();

app.Run();