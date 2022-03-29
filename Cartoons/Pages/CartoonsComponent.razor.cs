using Cartoons.Core.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Text.Json;

namespace Cartoons.Pages
{
  public partial class CartoonsComponent
  {
    private IEnumerable<Cartoon> _cartoons;
    [Inject] private IHttpClientFactory HttpClientFactory { get; set; }
    protected async override Task OnInitializedAsync()
    {
      var httpClient = HttpClientFactory.CreateClient("Cartoon");
      var httpResponseMessage = await httpClient.GetAsync(
    "cartoons/cartoons2D");
      if (httpResponseMessage.IsSuccessStatusCode)
      {
        var contentStream =
            await httpResponseMessage.Content.ReadAsStringAsync();
        _cartoons = JsonSerializer.Deserialize
            <Cartoon[]>(contentStream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
      }
    }
  }
}