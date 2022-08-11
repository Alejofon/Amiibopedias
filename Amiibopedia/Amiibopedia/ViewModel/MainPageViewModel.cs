using Amiibopedia.Helpers;
using Amiibopedia.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Amiibopedia.ViewModel
{
    internal class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Character> Characters { get; set; }

        public async Task LoadCharacters()
        {
            var url = "";
            var service = new HttpHelper<Characters>();
            var characters = await service.GetRestServiceDataAsync(url);
            Characters = new ObservableCollection<Character>(characters.amiibo);
        }
    }
}
