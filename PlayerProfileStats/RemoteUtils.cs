using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace PlayerProfileStats
{
    class RemoteUtils
    {
        public Connecton conn;

        public RemoteUtils()
        {
            conn = new Connecton();
        }
        private string token = "";

        public bool getToken()
        {

            string sendCommand = "http://" + conn.Server + "/" + "v2/token/create/" + conn.Password + "?username=" + conn.UserId;

            JObject results = Utils.GetHTTP(sendCommand);

            if (results == null)
            {
                MessageBox.Show("Invalid userid/password/server", Profile.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                if (results["token"] != null)
                    token = (string)results["token"];
            }
            else
            {
                token = "";
                return false;
            }

            return true;
        }

        public void getVersion()
        {

             string sendCommand;
            sendCommand = "http://" + conn.Server + "/" + "PlayerStats/version" + "?token=" + token;

            JObject results = Utils.GetHTTP(sendCommand);

            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                conn.Version = (string)results["version"];
                conn.dbType = (string)results["db"];
          }
            else
            {
                MessageBox.Show("Profile database not correctly setup.", Profile.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            return;
        }
        public List<ProfileList> getStats(string option)
        {
            int ID = 0;
            string timeStamp = "";
            string player = "";
            string inventory = "";

            List<ProfileList> profileList = new List<ProfileList>();

            string sendCommand;
            sendCommand = "http://" + conn.Server + "/" + "PlayerStats/getPlayerStats" + "?token=" + token;

            JObject results = Utils.GetHTTP(sendCommand);
            JArray rowList;
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                 ID = 0;
                 timeStamp = "cutlass";
                 player = "jack";
                 inventory = "672,1,4~578,1,20~777,1,0~517,1,43~533,1,43~112,1,26~992,1,37~1336,1,83~170,34,0~2155,4,0~0,0,0~1912,25,0~939,1,0~50,1,0~0,0,0~367,1,81~2584,1,55~2557,2,0~538,1,0~320,20,0~1225,11,0~0,0,0~0,0,0~0,0,0~1872,938,0~0,0,0~0,0,0~0,0,0~1653,1,0~315,1,0~520,22,0~575,122,0~38,11,0~485,1,74~885,1,68~27,26,0~316,6,0~2503,621,0~586,77,0~75,8,0~547,31,0~549,60,0~548,2,0~473,1,0~1911,12,0~1869,9,0~161,57,0~27,99,0~1332,45,0~672,1,1~0,0,0~0,0,0~0,0,0~0,0,0~47,364,0~40,8,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0~0,0,0";
                ProfileList pl = new ProfileList();
                pl.ID = ID;
                pl.TimeStamp = timeStamp;
                pl.Inventory = inventory;
                profileList.Add(pl);
 
            }
            else
            {
                MessageBox.Show("Profile database not correctly setup.", Profile.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return profileList;
        }
        public List<PlayerStatsList> getPlayerStats(string search)
        {
             List<PlayerStatsList> playerStatsList = new List<PlayerStatsList>();

            string sendCommand;
            if (search.Length > 0)
            {
                search = "&search=" + search;
            }
            sendCommand = "http://" + conn.Server + "/" + "PlayerStats/getPlayerStats" + "?token=" + token + search;

            JObject results = Utils.GetHTTP(sendCommand);
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                JArray rows = (JArray)results["Rows"];
                for (int i = 0; i < rows.Count; i++)
                {
                    PlayerStatsList pl = new PlayerStatsList();
                    pl.V1 = (int)rows[i]["V1"];
                    pl.V2 = (string)rows[i]["V2"];
                    pl.V3 = (int)rows[i]["V3"];
                    pl.V4 = (int)rows[i]["V4"];
                    pl.V5 = (int)rows[i]["V5"];
                    playerStatsList.Add(pl);
                }
 
            }
            else
            {
                MessageBox.Show("Player Stats database not correctly setup.", Profile.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return playerStatsList;
        }
        public bool deleteRows(string rows)
        {
            string sendCommand = "http://" + conn.Server + "/" + "SQLLogger/deleteRows" + "?token=" + token + "&delete=(" + rows + ")";

            JObject results = Utils.GetHTTP(sendCommand);

            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                if (results["token"] != null)
                    token = (string)results["token"];
            }
            return true;
        }
    }

    public class Response
    {
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "response")]
        public string response { get; set; }
        [DataMember(Name = "token")]
        public string token { get; set; }
        [DataMember(Name = "rows")]
        public string rows { get; set; }
    }

}
