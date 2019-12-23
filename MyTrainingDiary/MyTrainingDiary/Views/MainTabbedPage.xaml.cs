using MyTrainingDiary.DAL.Entities;
using MyTrainingDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTrainingDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage (INavigation navigation, Guid loggedUserId)
        {
            InitializeComponent();
            BindingContext = new MainTabbedPageVM(navigation, loggedUserId);
        }
    }
}