// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://catfact.ninja");
var result = await httpClient.GetFromJsonAsync<dynamic>("fact");
var msg = new HttpRequestMessage(HttpMethod.Get, "fact");
var result1 = await httpClient.SendAsync(msg);
var str = await result1.Content.ReadAsStringAsync();
Console.WriteLine(str);