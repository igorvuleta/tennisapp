using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TennisAppV2.Src.Common.Models;

namespace TennisAppV2.Src.Data.Database
{
    public class SqlDatabase
    {
        private SQLiteAsyncConnection _Database;

        public SqlDatabase(string Path)
        {
            _Database = new SQLiteAsyncConnection(Path);
            SetupDatabase();
        }

        private void SetupDatabase()
        {
            _Database.CreateTableAsync<Player>().Wait();
            _Database.CreateTableAsync<Court>().Wait();
        }

        public async Task SavePlayer(Player Player)
        {
            await _Database.InsertAsync(Player);
            

        }
        public async Task SaveCourt(Court Court)
        {
            await _Database.InsertAsync(Court);


        }
        public async Task UpdatePlayer(Player Player)
        {
            await _Database.UpdateAsync(Player);
        }

        public async Task<List<Player>> GetAllPlayer()
        {
            return await _Database.Table<Player>().Where(x => x._Id > 0).ToListAsync();
        }
        public async Task ClearAllPlayer()
        {
            await _Database.QueryAsync<Player>("DELETE  FROM Player");

        }
    }
}
