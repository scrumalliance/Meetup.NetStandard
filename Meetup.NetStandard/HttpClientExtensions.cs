using Meetup.NetStandard.Response;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Meetup.NetStandard
{
    public static class HttpClientExtensions
    {
        public static async Task<MeetupResponse<T>> AsObject<T>(this HttpResponseMessage response, MeetupClientOptions options)
        {
            if (response.Content == null)
            {
                if (response.IsSuccessStatusCode)
                {
                    return default(MeetupResponse<T>);
                }
                throw new MeetupException(response.StatusCode);
            }

            var stream = await response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(stream);
            string json = await streamReader.ReadToEndAsync();
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var objectContent = JsonConvert.DeserializeObject<T>(json);
                    return new MeetupResponse<T>(response, objectContent);
                }
                catch (JsonReaderException ex)
                {
                    throw new Exception($"Failed to deserialize json: {json}", ex);
                }
            }

            var errorContent = JsonConvert.DeserializeObject<MeetupErrorContainer>(json);
            throw new MeetupException(response.StatusCode, errorContent.Errors);
        }
    }
}