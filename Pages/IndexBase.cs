using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListviewCheckboxEx.ViewModels;

namespace ListviewCheckboxEx.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IListDataViewModel ViewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetListItemsAsync();
        }
    }
}
