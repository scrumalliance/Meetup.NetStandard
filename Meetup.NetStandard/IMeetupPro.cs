using Meetup.NetStandard.Response;
using Meetup.NetStandard.Response.Groups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.NetStandard
{
    public interface IMeetupPro
    {
        Task<MeetupResponse<List<ProGroup>>> Groups(string urlName);
    }
}
