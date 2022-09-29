using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamePlayerService
    {
        void Save(GamePlayer gamePlayer);
        void Update(GamePlayer gamePlayer);
        void Delete(GamePlayer gamePlayer);
    }
}
