using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    public class DatabaseSourceViewModel
    {
        ObservableCollection<string> displayDatabaseSources;
        private string selectedDatabaseSource;
        DatabaseSources repoDatabaseSources;
        private DbSource dbSource;

        public DatabaseSourceViewModel() 
        {
            repoDatabaseSources = new DatabaseSources();
            displayDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
        }
        public ObservableCollection<string> DisplayDatabaseSources 
        { 
            get => displayDatabaseSources; 
            //set => displayDatabaseSource = value; 
        }
        public string SelectedDatabaseSource 
        { 
            get => selectedDatabaseSource; 
            set => selectedDatabaseSource = value; 
        }

        public DbSource DbSource
        {
            get 
            {
                //TDD fejlesztés 
                return DbSource.NONE;
                if (selectedDatabaseSource=="localhost")
                {
                    return DbSource.LOCALHOST;
                }
                else if (selectedDatabaseSource=="devops")
                {
                    return DbSource.DEVOPS;
                }
                return DbSource.NONE;
            }
        }
    }
}
