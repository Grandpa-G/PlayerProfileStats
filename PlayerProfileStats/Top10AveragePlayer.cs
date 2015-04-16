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
        private static string AVERAGECHART = "ChartTop10PlayerAverage";

         private void playerAverage24Hours()
        {
            string select = "";
            startDate = top10AvgStart.Value;
 
            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                startDate = top10AvgStart.Value;
                select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60 as integer) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2,";
                select = select + "timestampdiff(MINUTE,Login,Logout) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddHours(-24)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
             ChartArea chartArea = this.chartTop10PlayerAverage.ChartAreas[AVERAGECHART];
            chartTop10PlayerAverage.Series.Clear();
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Average Minutes On";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Interval = 1;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = AVERAGECHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Mins=#VALY";
            this.chartTop10PlayerAverage.Series.Add(seriesActivePlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);

                //                chartTop10PlayerAverage.ChartAreas[AVERAGECHART].AxisX.CustomLabels.Add((psl.V1 - 0.5), psl.V1 + 0.5, psl.V2);
            }

        }

        private void playerAverage7Days()
        {
            string select = "";
            startDate = top10AvgStart.Value;
            select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60/60 as integer) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                startDate = top10AvgStart.Value;
                select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60 as integer) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2,";
                select = select + "timestampdiff(MINUTE,Login,Logout) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddDays(-7)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            ChartArea chartArea = this.chartTop10PlayerAverage.ChartAreas[AVERAGECHART];
            chartTop10PlayerAverage.Series.Clear();
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Average Hours On";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Interval = 1;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = AVERAGECHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Hours=#VALY";
            this.chartTop10PlayerAverage.Series.Add(seriesActivePlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }

        private void playerAverage1Month()
        {
            string select = "";
            startDate = top10AvgStart.Value;
            select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60/60 as integer) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "AND Logout is not null ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                startDate = top10AvgStart.Value;
                select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60 as integer) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2,";
                select = select + "timestampdiff(MINUTE,Login,Logout) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-1)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            ChartArea chartArea = this.chartTop10PlayerAverage.ChartAreas[AVERAGECHART];
            chartTop10PlayerAverage.Series.Clear();
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Average Hours On";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Interval = 1;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = AVERAGECHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Hours=#VALY";
            this.chartTop10PlayerAverage.Series.Add(seriesActivePlayerLoad);

            List<PlayerStatsList> playerStats = ru.getPlayerStats(select);
            seriesActivePlayerLoad.Points.Clear();
            if (playerStats == null || playerStats.Count == 0)
                return;

            foreach (PlayerStatsList psl in playerStats)
            {
                seriesActivePlayerLoad.Points.AddXY(psl.V2, psl.V1);
            }

        }

        private void playerAverage12Months()
        {
            string select = "";
            startDate = top10AvgStart.Value;
            select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60/60 as integer) V1, ";
            select = select + "0 V3, 0 V4, 0 V5 ";
            select = select + "FROM PlayerLog ";
            select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
            select = select + "AND Login <='" + startDate.ToString("u") + "' ";
            select = select + "AND Logout is not null ";
            select = select + "group by Name ";
            select = select + "order by V1 desc limit 10";

            if (ru.conn.dbType.ToLower().Equals("sqlite"))
            {
                startDate = top10AvgStart.Value;
                select = "select Name V2, CAST(CAST(round(avg(strftime('%s',Logout)-strftime('%s',Login)),0) as real)/60 as integer) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            }
            else
            {
                select = "select Name V2,";
                select = select + "timestampdiff(MINUTE,Login,Logout) V1, ";
                select = select + "0 V3, 0 V4, 0 V5 ";
                select = select + "FROM playerprofilestats.PlayerLog ";
                select = select + "where Login >='" + (startDate.AddMonths(-12)).ToString("u") + "' ";
                select = select + "AND Login <='" + startDate.ToString("u") + "' ";
                select = select + "AND Logout is not null ";
                select = select + "group by Name ";
                select = select + "order by V1 desc limit 10";
            } 
            ChartArea chartArea = this.chartTop10PlayerAverage.ChartAreas[AVERAGECHART];
            chartTop10PlayerAverage.Series.Clear();
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Average Hours On";
            chartArea.AxisX.Title = "Player";
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Interval = 1;

            Series seriesActivePlayerLoad = new Series();
            seriesActivePlayerLoad.ChartArea = AVERAGECHART;
            seriesActivePlayerLoad.ChartType = SeriesChartType.Column;
            seriesActivePlayerLoad.Color = System.Drawing.Color.RoyalBlue;
            seriesActivePlayerLoad.Name = "Active Player Load";
            seriesActivePlayerLoad.YValuesPerPoint = 1;
            seriesActivePlayerLoad["PixelPointWidth"] = "40";
            seriesActivePlayerLoad.ToolTip = "#VALX, Hours=#VALY";
            this.chartTop10PlayerAverage.Series.Add(seriesActivePlayerLoad);

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
