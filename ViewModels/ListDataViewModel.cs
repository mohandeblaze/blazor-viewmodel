using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListviewCheckboxEx.Data;
using ListviewCheckboxEx.Model;

namespace ListviewCheckboxEx.ViewModels
{
    public interface IListDataViewModel
    {
        ListviewItemModel[] ListviewItems { get; set; }
        Task GetListItemsAsync();

    }
    public class ListDataViewModel : IListDataViewModel
    {
        private IListDataModel _listDataModel;
        public ListviewItemModel[] ListviewItems { get; set; }
        public ListDataViewModel(IListDataModel listDataModel)
        {
            Console.WriteLine("ListDataViewModel Constructor Executing");
            _listDataModel = listDataModel;
        }

        public async Task GetListItemsAsync()
        {
            ListviewItems = await _listDataModel.GetListItemsAsync();
            Console.WriteLine("ListDataViewModel GetListItemsAsync Retrieved");
        }
    }
}
