using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UIKit;

namespace DiveAnalyzer.iOS
{
    public interface IRestService
    {
        Task<string> GetDives();
    }
    public class RestService : IRestService
    {
        public async Task<string> GetDives()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:1487/");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/dive").Result;
                string content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (Exception ex)
            {
                var t = ex.Message;
            }
            return null;
        }
    }
    public partial class RootViewController : UIViewController
    {
        //private async Task<JsonValue> FetchWeatherAsync()
        //{
        //    Uri uri = new Uri("http://localhost:1487/api/dive");

        //    // Create an HTTP web request using the URL:
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        //    request.ContentType = "application/json";
        //    request.Method = "GET";

        //    // Send the request to the server and wait for the response:
        //    using (WebResponse response = await request.GetResponseAsync())
        //    {
        //        // Get a stream representation of the HTTP web response:
        //        using (Stream stream = response.GetResponseStream())
        //        {
        //            // Use this stream to build a JSON document object:
        //            JsonValue jsonDoc = await Task.Run(() => JsonValue.Load(stream));

        //            // Return the JSON document:
        //            return jsonDoc;
        //        }
        //    }
        //}

        public RootViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var rest = new RestService();
            string s =  rest.GetDives().Result;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}