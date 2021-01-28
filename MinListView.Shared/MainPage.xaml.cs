using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace MinListView
{
  public sealed partial class MainPage : Page
  {
    public class Note
    {
      public string Text { get; set; }
    }

    public ObservableCollection<Note> DetailListItems = new ObservableCollection<Note>();

    public MainPage()
    {
      this.InitializeComponent();

      DetailListItems.Add (new Note { Text = "If you want the items to stretch to fill the horizontal space and be able to specify how many items per row you want, then you'll have to set the ItemWidth of the ItemsWrapGrid manually within the GridView's SizeChanged event." });
      DetailListItems.Add(new Note { Text = "The Grid will fill the screen height and width, and if you only have one child element, you do not need to define additional rows or columns. It will just provide a single cell by default and you can then center the StackLayout within it." });
      DetailListItems.Add(new Note { Text = "Item 3" });
      DetailListItems.Add(new Note { Text = "Item 4" });
      DetailListItems.Add(new Note { Text = "Item 5" });
    }
  }
}
