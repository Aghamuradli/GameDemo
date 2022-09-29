using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamePlayerManager : IGamePlayerService
    {
        IMernisCheckService mernisCheckService;

        public GamePlayerManager(IMernisCheckService mernisCheckService)
        {
            this.mernisCheckService = mernisCheckService;
        }

        public void Delete(GamePlayer gamePlayer)
        {
            Console.WriteLine("Game player deleted : " + gamePlayer.FirstName + " " + gamePlayer.LastName);
        }

        public void Save(GamePlayer gamePlayer)
        {
            if (mernisCheckService.CheckIfRealPerson(gamePlayer))
            {
                Console.WriteLine("Game player saved : "+gamePlayer.FirstName+" "+gamePlayer.LastName);
            }
            else
            {
                Console.WriteLine("Game player can not saved. Try again please.");
            }
        }

        public void Update(GamePlayer gamePlayer)
        {
            Console.WriteLine("Game player updated : " + gamePlayer.FirstName + " " + gamePlayer.LastName);
        }
    }
}
