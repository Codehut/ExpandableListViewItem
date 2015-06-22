using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace ExpandableListViewItem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Student> studentlist = new List<Student>();
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            studentlist.Add(new Student() { Name = "Janak", University = "Abc University" });
            studentlist.Add(new Student() { Name = "Jack", University = "def University" });
            studentlist.Add(new Student() { Name = "jerry", University = "ghi University" });
            studentlist.Add(new Student() { Name = "Scott", University = "jkl University" });

            Mylistview.DataContext = studentlist;
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public string University { get; set; }
    }
}
namespace ValueConveters
{
    public class VisibilityConverter : IValueConverter
    {
        Visibility vs;
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value.Equals(Visibility.Collapsed))
            {
                vs = Visibility.Visible;
            }
            else if (value.Equals(Visibility.Visible))
            {
                vs = Visibility.Collapsed;
            }
            return vs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

    }
}