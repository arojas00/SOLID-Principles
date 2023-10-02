using System.Collections.Generic;

namespace Member.Application
{
    //Implement Bussiness Rule / USE CASES

    //En esta capa se implementan los Use Cases y se utilizan interfaces para realizar el traslado de datos hacia las capas internas.
    //Esta capa referencia a la capa interna.
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }
        List<Domain.IPlayer> IMemberService.GetAllMembers()
        {
            return this.memberRepository.GetAllMembers();
        }
    }
}