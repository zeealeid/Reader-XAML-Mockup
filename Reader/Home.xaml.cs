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
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
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
            DocList.Add(new RecentFiles()
            {
                FileName = "electron_apps",
                Date = "11/20/2020",
                FileType = "PDF",
                Images = "Assets/Blindness.png"
            });
            DocList.Add(new RecentFiles()
            {
                FileName = "work_project",
                Date = "11/20/2020",
                FileType = "EPUB",
                Images = "Assets/Electron 2.png"
            });
            DocsGrid.ItemsSource = DocList;

            ObservableCollection<Caro> Cards = new ObservableCollection<Caro>();
            Cards.Add(new Caro()
            {
                Text = "Amet minim mollit non deserunt ullamco est sit aliqua dolor do amet sint. Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet.",
                Name = "Lorem Ipsum",
                PageRead = "2/6 pages read"
            });
            Cards.Add(new Caro()
            {
                Text = "distract from the layout. A practice not without controversy, laying out pages with meaningless filler text can be very useful when the focus is meant to be on design, not content.",
                Name = "History of Lorem Ipsum",
                PageRead = "3/6 pages read"
            });
            Cards.Add(new Caro()
            {
                Text = "Amet minim mollit non deserunt ullamco est sit aliqua dolor do amet sint. Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet.",
                Name = "Lorem Ipsum",
                PageRead = "2/6 pages read"
            });
            CardsGrid.ItemsSource = Cards;

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        public class RecentFiles
        {
            public string FileName { get; set; }
            public string Date { get; set; }
            public string FileType { get; set; }
            public string Images { get; set; }
        }

        public class Caro
        {
            public string Text { get; set; }
            public string Name { get; set; }
            public string PageRead { get; set; }
        }
    }
}
