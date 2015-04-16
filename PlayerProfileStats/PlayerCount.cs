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
        private static string COUNTCHART = "ChartTop10PlayerCount";
        private void playerCount24Hours()
        {
            string select = "";
 
            startDate = top10CountStart.Value;
            select = "select Name V2, count(*) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }

            chartTop10PlayerCount.Series.Clear();
            ChartArea chartArea = this.chartTop10PlayerCount.ChartAreas[COUNTCHART];
            chartArea.AxisX.Interval = 1;

            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Number of Sessions";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = COUNTCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.ToolTip = "#VALX, Logins=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartTop10PlayerCount.Series.Add(seriesActivePlayerLoad);

             List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
             if (playerStats == null || playerStats.Count == 0)
                return;

            int rowNum = playerStats.Count;
            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }
        private void playerCount7Days()
        {
            string select = "";
            startDate = top10CountStart.Value;
            select = "select Name V2, count(*) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            chartTop10PlayerCount.Series.Clear();
            ChartArea chartArea = this.chartTop10PlayerCount.ChartAreas[COUNTCHART];
            chartArea.AxisX.Interval = 1;

            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Number of Sessions";
            chartArea.AxisX.Title = "Player";
 
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = COUNTCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.ToolTip = "#VALX, Logins=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartTop10PlayerCount.Series.Add(seriesActivePlayerLoad);

              List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }
        private void playerCount1Month()
        {
            string select = "";
            startDate = top10CountStart.Value;
            select = "select Name V2, count(*) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
  
            chartTop10PlayerCount.Series.Clear();
            ChartArea chartArea = this.chartTop10PlayerCount.ChartAreas[COUNTCHART];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Number of Sessions";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = COUNTCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.ToolTip = "#VALX, Logins=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartTop10PlayerCount.Series.Add(seriesActivePlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
             if (playerStats == null || playerStats.Count == 0)
                return;

            int rowNum = playerStats.Count;
            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }

        private void playerCount12Months()
        {
            string select = "";
            startDate = top10CountStart.Value;
            select = "select Name V2, count(*) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2, count(*) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            chartTop10PlayerCount.Series.Clear();
            ChartArea chartArea = this.chartTop10PlayerCount.ChartAreas[COUNTCHART];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Number of Sessions";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = COUNTCHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Max Player Load";
            seriesActivePlayerLoad.ToolTip = "#VALX, Logins=#VALY";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            this.chartTop10PlayerCount.Series.Add(seriesActivePlayerLoad);
 
            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();

            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }

    }
}
