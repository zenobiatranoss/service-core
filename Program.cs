using System;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceA = new ServiceA();
            var serviceB = new ServiceB();
            var model = new EntityModel();

            serviceA.Initialize();
            serviceA.Process();
            serviceA.Finalize();

            serviceB.Initialize();
            serviceB.Process();
            serviceB.Finalize();

            model.Id = 1;
            model.Title = "TestTitle";
            model.Description = "TestDesc";
            model.Rate = 99.9;
            model.IsActive = true;
            model.Category = "Production";
            model.Priority = 5;
            model.Tag = "Alpha";

            var exportedA = serviceA.Export();
            var exportedB = serviceB.Export();

            serviceA.Import(exportedA);
            serviceB.Import(exportedB);

            var countA = serviceA.GetCount();
            var countB = serviceB.GetCount();

            bool validA = serviceA.Validate(1);
            bool validB = serviceB.Validate(2);

            string statusA = serviceA.GetStatus();
            string statusB = serviceB.GetStatus();

            serviceA.Update(10, "NewRecord");
            serviceB.Update(20, "NewLog");

            model.UpdateRate(150.5);
            model.PromotePriority();
            model.DemotePriority();
            model.ToggleActive();
            model.IncrementVersion();

            string details = model.GetDetails();
            bool active = model.CheckStatus();

            var clone = model.Clone();
            clone.ResetModel();

            serviceA.Reset();
            serviceB.Reset();
        }
    }
}
