using System;
using System.Collections.Generic;

namespace app
{
    public interface IService
    {
        void Initialize();
        void Process();
        void Finalize();
        bool Validate(int id);
        string GetStatus();
        void Reset();
        int GetCount();
        void Update(int id, string name);
        Dictionary<int, string> Export();
        void Import(Dictionary<int, string> data);
    }
}
