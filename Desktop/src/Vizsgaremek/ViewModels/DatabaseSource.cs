using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.ViewModels
{
        public enum DbSource { NONE, LOCALHOST, DEVOPS }

        public class DatabaseSource
        {
            DbSource dbSource;

            private DbSource DbSource { get => dbSource; set => dbSource = value; }

            public DatabaseSource()
            {
                this.DbSource = DbSource.NONE;
            }

        }
    }
