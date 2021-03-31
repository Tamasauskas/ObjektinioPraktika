using System.Data.SQLite;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Klase pagalbai: uzklausoms, saugomas connection string
    /// </summary>
    class ClsHelper
    {
        public string Query { get; set; }
        public static string ConnectionString = @"Data Source=C:/Users/Audrisu/source/repos/ObjektinioPraktika/PraktinisDarbas_AudriusTamasauskasPI19S/PraktinisDarbas_AudriusTamasauskasPI19S/Praktinis darbas DB.db; Version=3;";

    }


}
