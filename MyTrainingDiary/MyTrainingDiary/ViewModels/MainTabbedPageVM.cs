using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using MyTrainingDiary.DAL.Entities;
using MyTrainingDiary.DAL;
using MyTrainingDiary;
using System.Linq;
using MyTrainingDiary.Views;
using System.IO;

namespace MyTrainingDiary.ViewModels
{
    public class MainTabbedPageVM : ViewModelBase
    {
        private Guid _userId;

        public List<TrainingRecord> TrainingRecords { get; } // zaznamy budou jen pro cteni, novy se prida tlacitkem "trenovat"
        public List<TrainingPlan> TrainingPlans { get; } // take se bude pridavat tlacitkem

        public INavigation Navigation;

        public MainTabbedPageVM() { } // kvuli xaml binding.context, aby byly videt vlastnosti VM

        public MainTabbedPageVM(INavigation navigation, Guid loggedUserId)
        {
            Navigation = navigation;

            _userId = loggedUserId;

            using (var dc = App.GetAppDbContext())
            {
                // TODO POKRACOVANI PO DB SEEDU ZDE

                // todo mozna bude potreba zavrtat do seedu/konfiguraci, co ma presne mit co, aby to fungovalo...

                // todo mozna upravit xaml na nejakou primitivni verzi na zkouseni, ale s exercises to fungovalo
                var records = dc.TrainingRecords.Where(r => r.UserId == _userId).ToList();
                TrainingRecords = records;

                OnPropertyChanged("TrainingRecords");

                var plans = dc.TrainingPlans.Where(p => p.UserId == _userId).ToList();
                TrainingPlans = plans;

                OnPropertyChanged("TrainingPlans");
            }
        }
    }
}
