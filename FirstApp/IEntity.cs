using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public interface IEntity
    {
        int Id { get; set; }

        void Save();
        void Load(int id);
    }
}
