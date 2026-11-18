using System;
using System.Collections.Generic;

namespace app
{
    public class ServiceB : IService
    {
        private List<string> logs;

        public ServiceB()
        {
            logs = new List<string>();
        }

        public void Initialize()
        {
            logs.Clear();
            logs.Add("Log_Start");
            logs.Add("Log_Init");
            logs.Add("Log_Load");
            logs.Add("Log_Ready");
            logs.Add("Log_Check");
        }

        public void Process()
        {
            for (int i = 0; i < logs.Count; i++)
            {
                logs[i] = logs[i] + "_Step";
            }
        }

        public void Finalize()
        {
            for (int i = 0; i < logs.Count; i++)
            {
                logs[i] = logs[i] + "_End";
            }
        }

        public bool Validate(int id)
        {
            return id >= 0 && id < logs.Count;
        }

        public string GetStatus()
        {
            return "Running";
        }

        public void Reset()
        {
            logs.Clear();
        }

        public int GetCount()
        {
            return logs.Count;
        }

        public void Update(int id, string name)
        {
            if (id >= 0 && id < logs.Count)
            {
                logs[id] = name;
            }
            else
            {
                logs.Add(name);
            }
        }

        public Dictionary<int, string> Export()
        {
            var dict = new Dictionary<int, string>();
            for (int i = 0; i < logs.Count; i++)
            {
                dict.Add(i, logs[i]);
            }
            return dict;
        }

        public void Import(Dictionary<int, string> data)
        {
            logs.Clear();
            foreach (var item in data)
            {
                logs.Add(item.Value);
            }
        }
    }
}
