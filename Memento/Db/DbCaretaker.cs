using Memento.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace Memento.Db
{
    internal class DbCaretaker
    {
        public AppDbContext DbContext { get; private set; }

        public List<DatabaseSnapshot> Snapshots { get; set; } = new List<DatabaseSnapshot>();

        public DbCaretaker(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void SaveChanges(string snapshotTitle)
        {
            Console.WriteLine("\nSaving current database state...");
            var timestamp = DateTime.Now;
            var snapshot = DbContext.SaveSnapshot(snapshotTitle, timestamp);
            Snapshots.Add(snapshot);
        }

        public void Rollback()
        {
            if (Snapshots.Count == 0) return;

            var toDelete = Snapshots.Last();
            Snapshots.Remove(toDelete);

            if (Snapshots.Count == 0) return;
            var prev = Snapshots.Last();

            Console.WriteLine($"Rolling back to \"{prev}\"...");
            DbContext.Restore(prev);
        }

        public void RollbackTo(string title, DateTime timestamp)
        {
            if (Snapshots.Count == 0) return;

            var prev = Snapshots.First(item => item.Title == title && item.Timestamp == timestamp);
            var range = Snapshots.Where(item => Snapshots.IndexOf(item) > Snapshots.IndexOf(prev)).ToList();
            if (Snapshots.Count != 0)
                range.ForEach(item => Snapshots.Remove(item));

            Console.WriteLine($"Rolling back to \"{prev}\"...");
            DbContext.Restore(prev);
        }

        public void GetHistory()
        {
            Console.WriteLine("List of snapshots: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Snapshots.ForEach(item => Console.WriteLine(item));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
