using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DiveAnalyzer.iOS
{
    //public interface IRestService
    //{
    //    Task<string> GetDives();
    //}
    //public class RestService : IRestService
    //{
    //    public async Task<string> GetDives()
    //    {
    //        try
    //        {
    //            var client = new HttpClient();
    //            client.BaseAddress = new Uri("http://localhost:1487/");
    //            client.DefaultRequestHeaders.Accept.Add(
    //            new MediaTypeWithQualityHeaderValue("application/json"));
    //            var response = client.GetAsync("api/dive").Result;
    //            string content = await response.Content.ReadAsStringAsync();
    //            return content;
    //        }
    //        catch (Exception ex)
    //        {
    //            var t = ex.Message;
    //        }
    //        return null;
    //    }
    //}

    //public partial class Dive
    //{
    //    public string id { get; set; }
    //    public string Identifier { get; set; }
    //    public string Units { get; set; }
    //    public DateTime DiveStart { get; set; }
    //    public string DecoModel { get; set; }
    //    public List<DivePoint> DivePoints { get; set; }
    //}

    //public class DivePoint
    //{
    //    public ushort Time { get; set; }

    //    /// <remarks/>
    //    public decimal Depth { get; set; }

    //    /// <remarks/>
    //    public decimal Pressure { get; set; }

    //    /// <remarks/>
    //    public string Alarm { get; set; }

    //    /// <remarks/>
    //    public object Extra { get; set; }

    //    /// <remarks/>
    //    public decimal Temperature { get; set; }

    //    /// <remarks/>
    //    public decimal PPO2 { get; set; }
    //    /// <remarks/>
    //    public byte NDT { get; set; }
    //}
}