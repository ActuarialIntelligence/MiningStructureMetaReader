using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialIntelligence.MiningStructureMetaReader.Interfaces
{
    public interface IQueryDataConnection<T>
    {
        T LoadData(string query);
        void ClearAndDispose();
    }
}
