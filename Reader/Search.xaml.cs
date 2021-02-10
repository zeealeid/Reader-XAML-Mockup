using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Reader
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Search : Page
    {

        private List<string> Recents = new List<string>()
        {
            "electron needs to end",
            "electron_apps",
            "news article",
            "work_project",
            "Acrylic causes Blindness",
            "electron_apps_copy"
        };
        public Search()
        {
            this.InitializeComponent();
            ObservableCollection<RecentFiles> DocList = new ObservableCollection<RecentFiles>();
            DocList.Add(new RecentFiles()
            {
                FileName = "electron_apps",
                Date = "11/20/2020",
                FileType = "PDF",
                Images = "Assets/Electron.png"
            });
            DocList.Add(new RecentFiles()
            {
                FileName = "work_project",
                Date = "11/20/2020",
                FileType = "EPUB",
                Images = "Assets/Electron 2.png"
            });
            DocList.Add(new RecentFiles()
            {
                FileName = "news article",
                Date = "11/20/2020",
                FileType = "PDF",
                Images = "Assets/News Article.png"
            });
            DocsGrid.ItemsSource = DocList;
        }

        private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var suitableItems = new List<string>();
            var splitText = sender.Text.ToLower().Split(" ");
            foreach(var recent in Recents)
            {
                var found = splitText.All((key)=>
                {
                    return recent.ToLower().Contains(key);
                });
                if(found)
                {
                    suitableItems.Add(recent);
                }
            }
            if (suitableItems.Count == 0)
            {
                suitableItems.Add("No results found");
            }
            sender.ItemsSource = suitableItems;

        }

        private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            

        }

        private void SearchBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            

        }

        public class RecentFiles
        {
            public string FileName { get; set; }
            public string Date { get; set; }
            public string FileType { get; set; }
            public string Images { get; set; }
        }
    }
}
