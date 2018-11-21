using Meetup.NetStandard.Response;
using Meetup.NetStandard.Response.Groups;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.NetStandard
{
    public class ProCalls : IMeetupPro
    {
        private readonly MeetupClientOptions _options;

        public ProCalls(MeetupClientOptions options)
        {
            _options = options;
        }

        public Task<MeetupResponse<List<ProGroup>>> Groups(string urlName)
        {
            if (string.IsNullOrWhiteSpace(urlName))
            {
                throw new ArgumentNullException(nameof(urlName));
            }

            return MeetupRequestMethods.GetWithRequestAsync<List<ProGroup>>($"/pro/{urlName}/groups", _options, null);
        }
    }
}
