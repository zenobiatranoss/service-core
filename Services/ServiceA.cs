using System;
using System.Collections.Generic;

namespace app
{
    public class ServiceA : IService
    {
        private Dictionary<int, string> cache;

        public ServiceA()
        {
            cache = new Dictionary<int, string>();
        }

        public void Initialize()
        {
            cache.Clear();
            cache[1] = "Record_1";
            cache[2] = "Record_2";
            cache[3] = "Record_3";
            cache[4] = "Record_4";
            cache[5] = "Record_5";
        }

        public void Process()
        {
            foreach (var key in new List<int>(cache.Keys))
            {
                cache[key] = cache[key] + "_Processed";
            }
        }

        public void Finalize()
        {
            foreach (var key in new List<int>(cache.Keys))
            {
                cache[key] = cache[key] + "_Done";
            }
        }

        public bool Validate(int id)
        {
            return cache.ContainsKey(id);
        }

        public string GetStatus()
        {
            return "Active";
        }

        public void Reset()
        {
            cache.Clear();
        }

        public int GetCount()
        {
            return cache.Count;
        }

        public void Update(int id, string name)
        {
            if (cache.ContainsKey(id))
            {
                cache[id] = name;
            }
            else
            {
                cache.Add(id, name);
            }
        }

        public Dictionary<int, string> Export()
        {
            return new Dictionary<int, string>(cache);
        }

        public void Import(Dictionary<int, string> data)
        {
            foreach (var item in data)
            {
                cache[item.Key] = item.Value;
            }
        }
    }
}
