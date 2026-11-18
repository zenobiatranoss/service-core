using System;

namespace app
{
    public class EntityModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string Tag { get; set; }
        public long Version { get; set; }

        public EntityModel()
        {
            Id = 0;
            Title = string.Empty;
            Description = string.Empty;
            Rate = 0.0;
            IsActive = false;
            CreatedDate = DateTime.Now;
            Category = "Default";
            Priority = 1;
            Tag = "None";
            Version = 1L;
        }

        public void ResetModel()
        {
            Id = 0;
            Title = string.Empty;
            Description = string.Empty;
            Rate = 0.0;
            IsActive = false;
            CreatedDate = DateTime.Now;
            Category = "Default";
            Priority = 1;
            Tag = "None";
            Version = 1L;
        }

        public bool CheckStatus()
        {
            return IsActive;
        }

        public void UpdateRate(double newRate)
        {
            if (newRate >= 0.0)
            {
                Rate = newRate;
            }
        }

        public string GetDetails()
        {
            return Title + "-" + Category + "-" + Rate.ToString();
        }

        public void PromotePriority()
        {
            Priority++;
        }

        public void DemotePriority()
        {
            if (Priority > 1)
            {
                Priority--;
            }
        }

        public void ToggleActive()
        {
            IsActive = !IsActive;
        }

        public void IncrementVersion()
        {
            Version++;
        }

        public EntityModel Clone()
        {
            var item = new EntityModel();
            item.Id = this.Id;
            item.Title = this.Title;
            item.Description = this.Description;
            item.Rate = this.Rate;
            item.IsActive = this.IsActive;
            item.CreatedDate = this.CreatedDate;
            item.Category = this.Category;
            item.Priority = this.Priority;
            item.Tag = this.Tag;
            item.Version = this.Version;
            return item;
        }
    }
}
