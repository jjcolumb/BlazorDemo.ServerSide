using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<Shipper>> GetShippersAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetShippersAsync(ct);
            /*EndHide*/
        }
    }
}
