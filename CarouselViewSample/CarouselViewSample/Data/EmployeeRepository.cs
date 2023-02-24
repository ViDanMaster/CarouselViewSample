using System;
using System.Collections.Generic;
using System.IO;
using CarouselViewSample.Models;
using SQLite;

namespace CarouselViewSample.Data
{
    public class EmployeeRepository
    {
        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FeladatokAdatbazis.db3");

        public EmployeeRepository()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Feladatok>();
        }

        public List<Feladatok> List()
        {
            return _database.Table<Feladatok>().ToList();
        }
    }
}
