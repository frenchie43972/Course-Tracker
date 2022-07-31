using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;
using Xamarin.Essentials;
using CourseTracker.Classes;
using System.Threading.Tasks;

namespace CourseTracker.Services
{
	public static class DatabaseServices
	{
		private static SQLiteAsyncConnection _db;

		static async Task Init()
		{
			if (_db != null) // Will not create a duplicate database
			{
				return;
			}

			var databasePath = Path.Combine(FileSystem.AppDataDirectory, "CourseTracker.db");
			_db = new SQLiteAsyncConnection(databasePath);

			await _db.CreateTableAsync<Terms>();
		}

		public static async Task AddTerm(string title, DateTime start, DateTime end)
		{
			await Init();
			var addTerm = new Terms
			{
				Title = title,
				StartDate = start,
				EndDate = end
			};

			var newTerm = await _db.InsertAsync(addTerm);
		}

		public static async Task<IEnumerable<Terms>> GetTerm()
		{
			await Init();

			var terms = await _db.Table<Terms>().ToListAsync();
			return terms;
		}
	}
}
