using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinFitnessApp
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
