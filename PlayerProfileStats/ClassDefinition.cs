using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfileStats
{
    class ClassDefinition
    {
    }
    public class Connecton
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Version { get; set; }
        public string dbType { get; set; }
        public Connecton(string userId, string password, string server, string version, string dbtype)
        {
            UserId = userId;
            Password = password;
            Server = server;
            Version = version;
            dbType = dbtype;
        }

               public Connecton()
        {
            UserId = null;
            Password = null;
            Server = null;
            Version = null;
            dbType = null;
        }
    }
    public class Stats
    {
        public DatabaseStat DBStats { get; set; }
        public List<LogStat> LogStats { get; set; }

        public Stats(DatabaseStat dbStats, List<LogStat> logStats)
        {
            DBStats = dbStats;
            LogStats = logStats;
        }

        public Stats()
        {
            DBStats = null;
            LogStats = null;
        }
    }
    
    public class DatabaseStat
    {
        public double DBSize { get; set; }
        public int TableRows { get; set; }
        public double TableSize { get; set; }
        public string Version { get; set; }
        public string DBType { get; set; }

        public DatabaseStat(double dbSize, int tableRows, double tableSize, string version, string dbType)
        {
            DBSize = dbSize;
            TableRows = tableRows;
            TableSize = tableSize;
            Version = version;
            DBType = dbType;
                    }

        public DatabaseStat()
        {
            DBSize = 0;
            TableRows = 0;
            TableSize = 0;
            Version = "";
            DBType = "";
        }
    }
    
    public class LogStat
    {
        public int Count { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public LogStat(int count, int year, int month)
        {
            Count = count;
            Year = year;
            Month = month;
        }

        public LogStat()
        {
            Count = 0;
            Year = 0;
            Month = 0;
        }
    }

   public class ProfileList
    {
        public int ID { get; set; }
        public string TimeStamp { get; set; }
       public string Inventory { get; set; }
 
        public ProfileList(int id, string timeStamp,string inventory)
        {
            ID = id;
            TimeStamp = timeStamp;
            Inventory = inventory;

        }

        public ProfileList()
        {
            ID = 0;
            TimeStamp = "";
            Inventory = "";
                    }
    }
   public class PlayerStatsList
   {
       public int V1 { get; set; }
       public string V2 { get; set; }
       public int V3 { get; set; }
       public int V4 { get; set; }
       public int V5 { get; set; }

       public PlayerStatsList(int v1, string v2, int v3, int v4, int v5)
       {
           V1 = v1;
           V2 = v2;
           V3 = v3;
           V4 = v4;
           V5 = v5;
       }

       public PlayerStatsList()
       {
           V1 = 0;
           V2 = "";
           V3 = 0;
           V4 = 0;
           V5 = 0;
       }
   }
   public class PlayerStatsListx
   {
       public int ID { get; set; }
       public string TimeStamp { get; set; }
       public int UniquePlayers { get; set; }
       public int ActivePlayers { get; set; }
       public int MaxPlayers { get; set; }

       public PlayerStatsListx(int id, string timeStamp, int uniqueplayers, int activeplayers, int maxplayers)
       {
           ID = id;
           TimeStamp = timeStamp;
           UniquePlayers = uniqueplayers;
           ActivePlayers = activeplayers;
           MaxPlayers = maxplayers;
       }

       public PlayerStatsListx()
       {
           ID = 0;
           TimeStamp = "";
           UniquePlayers = 0;
           ActivePlayers = 0;
           MaxPlayers = 0;
       }
   }
}
