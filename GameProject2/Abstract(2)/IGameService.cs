using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
