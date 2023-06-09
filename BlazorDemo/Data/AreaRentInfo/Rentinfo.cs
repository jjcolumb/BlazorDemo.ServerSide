using System;

namespace BlazorDemo.Data {
    public class Rentinfo {
        public Guid Oid { get; set; }
        public Guid Area { get; set; }
        public int Bedrooms { get; set; }
        public int Year { get; set; }
        public decimal Rent { get; set; }

        public virtual Area AreaNavigation { get; set; }
    }
}
