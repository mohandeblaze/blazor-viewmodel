using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListviewCheckboxEx.Data;

namespace ListviewCheckboxEx.Model
{
    public interface IListDataModel
    {
        Task<ListviewItemModel[]> GetListItemsAsync();
    }

    public class ListDataModel : IListDataModel
    {
        public Task<ListviewItemModel[]> GetListItemsAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 100).Select(index => new ListviewItemModel
            {
                Id = Guid.NewGuid().ToString(),
                IsChecked = index % 2 == 0,
                DocumentTypeName = "Text " + index.ToString()
            }).ToArray());
        }
    }
}
