using Member.Application;
using Member.Domain;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Member.Infrastructure
{
    //En esta capa se implementan los adaptadores de interfaz.
    //Esta capa referencia a la capa de Entities y Aplications, ya que son las capas internas.
    public class MemberRepository : IMemberRepository
    {
        public static List<Domain.IPlayer> lstMembers = new List<Domain.IPlayer>()
        {
           new Domain.Winger{  Name= "Vinícius Júnior", Matches= 5, Goals= 1, SuccesfulDribbles= 26},
           new Domain.Striker{  Name= "Erling Haaland", Matches= 7, Goals= 8},
           new Domain.Striker{  Name= "Kylian Mbappé", Matches= 6, Goals= 7},
           new Domain.Goalkeeper{  Name= "Yassine Bounou", Matches= 6, CleanSheets= 3},
        };
        public List<Domain.IPlayer> GetAllMembers()
        {
            return lstMembers;
        }
    }
}