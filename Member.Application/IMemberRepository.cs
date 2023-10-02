using System.Collections.Generic;

namespace Member.Application
{
    public interface IMemberRepository
    {
        List<Domain.IPlayer> GetAllMembers();
    }
}