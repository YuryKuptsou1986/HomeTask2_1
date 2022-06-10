using CartService.DAL.LiteDb.Providers;
using LiteDB;

namespace CartService.DAL.LiteDb.DbContext
{
    public class LiteDBContext : ILiteDBContext
    {
        public ILiteDatabase Database { get; }

        public LiteDBContext(ILiteDbSettingsProvider settingsProvider)
        {
            Database = new LiteDatabase(settingsProvider.ProvideSettings().DataBaseLocation);
        }
    }
}
