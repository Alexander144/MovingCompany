using System;
using System.Collections.Generic;

namespace MovingCompanyAPI.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public string WorkType { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public int PersonId { get; set; }
        public string Note { get; set; }

        public virtual Person Person { get; set; }
    }
}
