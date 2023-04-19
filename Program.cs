using System.Threading.Tasks;
using Microsoft.Identity.Client;

const string _clientId = "";
const string _tenantId = "";

var app = PublicClientApplicationBuilder
	.Create(_clientId)
	.WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
	.WithRedirectUri("http://localhost")
	.Build();

string[] scopes = { "user.read"};
AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

Console.WriteLine($"Token:\t{result.AccessToken}");

