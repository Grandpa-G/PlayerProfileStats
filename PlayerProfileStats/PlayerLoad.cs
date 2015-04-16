using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
namespace PlayerProfileStats
{
    public partial class Profile : Form
    {
        private static string LOADCHART = "ChartPlayerLoad";
 
        private void playerStats24Hours()
        {
            string select = "";

            startDate = playerStart.Value;
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "SELECT CAST(strftime('%H', timestamp) as integer) V1, ";
                select = select + "strftime('%d-%H', Timestamp) V2, ";
                select = select + "0 V3, ";
                select = select + "ActivePlayers V4, ";
                select = select + "MaxPlayers V5 ";
                select = select + "FROM PlayerStats ";
                select = select + "where Timestamp >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "order by TimeStamp";
            }
            else
            {
                select = "SELECT HOUR(timestamp) V1, ";
                select = select + "DATE_FORMAT(Timestamp, '%d-%h') V2, ";
                select = select + "0 V3, ";
                select = select + "ActivePlayers V4, ";
                select = select + "MaxPlayers V5 ";
                select = select + "FROM playerprofilestats.playerstats ";
                select = select + "where Timestamp >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "order by TimeStamp";
            }
 
            chartPlayerLoad.Series.Clear();
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.CustomLabels.Clear();
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.Title = "Players";
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.Title = "Date (DD-HH)";
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = "ChartPlayerLoad";
            seriesActivePlayerLoad.ChartType = SeriesChartType.Line;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.ToolTip = "#VALX, Min=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartPlayerLoad.Series.Add(seriesActivePlayerLoad);

            Series seriesMaxPlayerLoad = new Series();
            seriesMaxPlayerLoad.ChartArea = "ChartPlayerLoad";
            seriesMaxPlayerLoad.ChartType = SeriesChartType.Line;
            seriesMaxPlayerLoad.Color = System.Drawing.Color.Red;
            seriesMaxPlayerLoad.Name = "Max Players";
            seriesMaxPlayerLoad.ToolTip = "#VALX, Min=#VALY";
            this.chartPlayerLoad.Series.Add(seriesMaxPlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            seriesMaxPlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            int rowNum = playerStats.Count;
            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(rowNum, psl.V4);

                seriesMaxPlayerLoad.Points.AddXY(rowNum--, psl.V5);
                chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.CustomLabels.Add((psl.V1 - 0.5), psl.V1 + 0.5, psl.V2);
            }

        }
        private void playerStats7Day()
        {
            string select = "";
            startDate = top10AvgStart.Value;
 
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "SELECT CAST(strftime('%d', timestamp) as integer) V1, strftime('%m-%d', Timestamp) V2, CAST(round(max(ActivePlayers),0) as integer) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as integer) V4, MaxPlayers V5 ";
                select = select + "FROM PlayerStats where Timestamp >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by strftime('%d', Timestamp) order by TimeStamp";
            }
            else
            {
                select = "SELECT DAY(timestamp) V1, ";
                select = select + "DATE_FORMAT(Timestamp, '%d-%h') V2, ";
                select = select + "CAST(round(max(ActivePlayers),0) as signed) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as signed) V4, ";
                select = select + "MaxPlayers V5 ";
                select = select + "FROM playerprofilestats.playerstats ";
                select = select + "where Timestamp >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by DAY(Timestamp) order by TimeStamp";
            } 
            chartPlayerLoad.Series.Clear();
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.CustomLabels.Clear();
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.Title = "Players";
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.Title = "Date (MM-DD)";

            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = "ChartPlayerLoad";
            seriesActivePlayerLoad.ChartType = SeriesChartType.RangeColumn;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Min=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 2;

            this.chartPlayerLoad.Series.Add(seriesActivePlayerLoad);

            Series seriesMaxPlayerLoad = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesMaxPlayerLoad.ChartArea = "ChartPlayerLoad";
            seriesMaxPlayerLoad.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMaxPlayerLoad.Color = System.Drawing.Color.Red;
            seriesMaxPlayerLoad.Name = "Max Player";
            seriesMaxPlayerLoad["PixelPointWidth"] = "40";
            seriesMaxPlayerLoad.ToolTip = "#VALX, Min=#VALY";
            this.chartPlayerLoad.Series.Add(seriesMaxPlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            seriesMaxPlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V1, psl.V4, psl.V3);

                seriesMaxPlayerLoad.Points.AddXY(psl.V1, psl.V5);
                chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.CustomLabels.Add((psl.V1 - 0.5), psl.V1 + 0.5, psl.V2);
            }

        }
        private void playerStats1Month()
        {
            string select = "";
            startDate = top10AvgStart.Value;
 
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "SELECT CAST(strftime('%d', timestamp) as integer) V1, strftime('%m-%d', Timestamp) V2, CAST(round(max(ActivePlayers),0) as integer) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as integer) V4, MaxPlayers V5 ";
                select = select + "FROM PlayerStats where Timestamp >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by strftime('%d', Timestamp) order by TimeStamp";
            }
            else
            {
                select = "SELECT DAY(timestamp) V1, ";
                select = select + "DATE_FORMAT(Timestamp, '%m-%d') V2, ";
                select = select + "CAST(round(max(ActivePlayers),0) as signed) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as signed) V4, ";
                select = select + "MaxPlayers V5 ";
                select = select + "FROM playerprofilestats.playerstats ";
                select = select + "where Timestamp >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by DAY(Timestamp) order by TimeStamp";
            }
            chartPlayerLoad.Series.Clear();
            ChartArea chartArea = chartPlayerLoad.ChartAreas[LOADCHART];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Players";
            chartArea.AxisX.Title = "Date (MM-DD)";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = LOADCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Line;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Max=#VALY";
            this.chartPlayerLoad.Series.Add(seriesActivePlayerLoad);

            Series seriesMinPlayerLoad = new Series();
            seriesMinPlayerLoad.ChartArea = LOADCHART;
            seriesMinPlayerLoad.ChartType = SeriesChartType.Line;
            seriesMinPlayerLoad.Color = System.Drawing.Color.DarkGreen;
            seriesMinPlayerLoad.Name = "Min Player Load";
            seriesMinPlayerLoad.YValuesPerPoint = 1;
            seriesMinPlayerLoad["PixelPointWidth"] = "40";
            seriesMinPlayerLoad.ToolTip = "#VALX, Min=#VALY";
            this.chartPlayerLoad.Series.Add(seriesMinPlayerLoad);

            Series seriesMaxPlayerLoad = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesMaxPlayerLoad.ChartArea = LOADCHART;
            seriesMaxPlayerLoad.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMaxPlayerLoad.Color = System.Drawing.Color.Red;
            seriesMaxPlayerLoad.Name = "Max Player";
            seriesMaxPlayerLoad.ToolTip = "#VALX, Players=#VALY";
            this.chartPlayerLoad.Series.Add(seriesMaxPlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            seriesMinPlayerLoad.Points.Clear();
            seriesMaxPlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            int rowNum = playerStats.Count;
            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(rowNum, psl.V3);
                seriesMinPlayerLoad.Points.AddXY(rowNum, psl.V4);

                seriesMaxPlayerLoad.Points.AddXY(rowNum--, psl.V5);
                chartArea.AxisX.CustomLabels.Add((psl.V1 - 0.5), psl.V1 + 0.5, psl.V2);
            }

        }

        private void playerStats12Months()
        {
            string select = "";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                startDate = top10AvgStart.Value;
                select = "SELECT CAST(strftime('%m', timestamp) as integer) V1, strftime('%Y-%m', Timestamp) V2, CAST(round(max(ActivePlayers),0) as integer) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as integer) V4, MaxPlayers V5 ";
                select = select + "FROM PlayerStats where Timestamp >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by strftime('%m', Timestamp) order by TimeStamp";
            }
            else
            {
                select = "SELECT MONTH(timestamp) V1, ";
                select = select + "DATE_FORMAT(Timestamp, '%y-%m') V2, ";
                select = select + "CAST(round(max(ActivePlayers),0) as signed) V3, ";
                select = select + "CAST(round(min(ActivePlayers),0) as signed) V4, ";
                select = select + "MaxPlayers V5 ";
                select = select + "FROM playerprofilestats.playerstats ";
                select = select + "where Timestamp >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Timestamp <='" + startDate.ToString("u") + "' ";
                select = select + "group by MONTH(Timestamp) order by TimeStamp";
            }
            chartPlayerLoad.Series.Clear();
            ChartArea chartArea = chartPlayerLoad.ChartAreas[LOADCHART];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Players";
            chartArea.AxisX.Title = "Date (YYYY-MM)";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = LOADCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.RangeColumn;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 2;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartPlayerLoad.Series.Add(seriesActivePlayerLoad);

            Series seriesMaxPlayerLoad = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesMaxPlayerLoad.ChartArea = LOADCHART;
            seriesMaxPlayerLoad.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMaxPlayerLoad.Color = System.Drawing.Color.Red;
            seriesMaxPlayerLoad.Name = "Max Player";
            this.chartPlayerLoad.Series.Add(seriesMaxPlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            seriesMaxPlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V1, psl.V4, psl.V3);

                seriesMaxPlayerLoad.Points.AddXY(psl.V1, psl.V5);
                chartArea.AxisX.CustomLabels.Add((psl.V1 - 0.5), psl.V1 + 0.5, psl.V2);
            }

        }

    }
}
