using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    class DatabaseSourceViewModel
    {
        ObservableCollection<string> displayDatabaseSource;
        private string selectedDatabaseSource;
        DatabaseSources repodatabaseSources;

        public DatabaseSourceViewModel() 
        {
            repodatabaseSources = new DatabaseSources();
            displayDatabaseSource = new ObservableCollection<string>(repodatabaseSources.GetAllDatabaseSources());
        }
        public ObservableCollection<string> DisplayDatabaseSource 
        { 
            get => displayDatabaseSource; 
            //set => displayDatabaseSource = value; 
        }
        public string SelectedDatabaseSource 
        { 
            get => selectedDatabaseSource; 
            set => selectedDatabaseSource = value; 
        }
    }
}
