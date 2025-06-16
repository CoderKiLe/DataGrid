namespace DataGrid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize4 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series4 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize3 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1 = new Panel();
            flexChart1 = new C1.Win.Chart.FlexChart();
            panel3 = new Panel();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            taskRepositoryBindingSource = new BindingSource(components);
            taskRepositoryBindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            flexChart2 = new C1.Win.Chart.FlexChart();
            flexChart3 = new C1.Win.Chart.FlexChart();
            flexChart4 = new C1.Win.Chart.FlexChart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskRepositoryBindingSource1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flexChart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flexChart4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(c1FlexGrid1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 1344);
            panel1.TabIndex = 0;
            // 
            // flexChart1
            // 
            flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart1.AnimationLoad.Duration = 400;
            flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart1.AnimationUpdate.Duration = 400;
            flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart1.AxisX.AxisLine = true;
            flexChart1.AxisX.Chart = flexChart1;
            flexChart1.AxisX.DataSource = null;
            flexChart1.AxisX.Formatter = null;
            flexChart1.AxisX.GroupProvider = null;
            flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisX.GroupVisibilityLevel = 0;
            flexChart1.AxisX.PlotAreaName = null;
            flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.AxisY.AxisLine = false;
            flexChart1.AxisY.Chart = flexChart1;
            flexChart1.AxisY.DataSource = null;
            flexChart1.AxisY.Formatter = null;
            flexChart1.AxisY.GroupProvider = null;
            flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisY.GroupVisibilityLevel = 0;
            flexChart1.AxisY.MajorGrid = true;
            flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart1.AxisY.PlotAreaName = null;
            flexChart1.AxisY.Position = C1.Chart.Position.Left;
            flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.DataLabel.Angle = 0;
            flexChart1.DataLabel.Border = false;
            flexChart1.DataLabel.ConnectingLine = false;
            flexChart1.DataLabel.Content = null;
            flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart1.DataLabel.MaxAutoLabels = 100;
            flexChart1.DataLabel.MaxLines = 0;
            flexChart1.DataLabel.MaxWidth = 0;
            flexChart1.DataLabel.Offset = 0;
            flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart1.Dock = DockStyle.Fill;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.Right;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = "uantity";
            flexChart1.Location = new Point(0, 0);
            flexChart1.Margin = new Padding(10);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = Color.Red;
            series1.ChartType = C1.Chart.ChartType.Spline;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            flexChart1.Series.Add(series1);
            flexChart1.Size = new Size(1110, 279);
            flexChart1.TabIndex = 0;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "";
            flexChart1.Click += flexChart1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(707, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 1344);
            panel3.TabIndex = 2;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowAddNew = true;
            c1FlexGrid1.AllowDelete = true;
            c1FlexGrid1.AllowFiltering = true;
            c1FlexGrid1.ColumnInfo = "1,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 0);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Rows.Count = 1;
            c1FlexGrid1.Size = new Size(707, 1344);
            c1FlexGrid1.TabIndex = 0;
            // 
            // taskRepositoryBindingSource
            // 
            taskRepositoryBindingSource.DataSource = typeof(DataSource.TaskRepository);
            // 
            // taskRepositoryBindingSource1
            // 
            taskRepositoryBindingSource1.DataSource = typeof(DataSource.TaskRepository);
            // 
            // panel2
            // 
            panel2.Controls.Add(flexChart1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 279);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(flexChart2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(1110, 280);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(flexChart3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 559);
            panel5.Name = "panel5";
            panel5.Size = new Size(1110, 368);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(flexChart4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 927);
            panel6.Name = "panel6";
            panel6.Size = new Size(1110, 400);
            panel6.TabIndex = 3;
            // 
            // flexChart2
            // 
            flexChart2.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart2.AnimationLoad.Duration = 400;
            flexChart2.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart2.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart2.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart2.AnimationUpdate.Duration = 400;
            flexChart2.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart2.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart2.AxisX.AxisLine = true;
            flexChart2.AxisX.Chart = flexChart2;
            flexChart2.AxisX.DataSource = null;
            flexChart2.AxisX.Formatter = null;
            flexChart2.AxisX.GroupProvider = null;
            flexChart2.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart2.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart2.AxisX.GroupVisibilityLevel = 0;
            flexChart2.AxisX.PlotAreaName = null;
            flexChart2.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart2.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart2.AxisY.AxisLine = false;
            flexChart2.AxisY.Chart = flexChart2;
            flexChart2.AxisY.DataSource = null;
            flexChart2.AxisY.Formatter = null;
            flexChart2.AxisY.GroupProvider = null;
            flexChart2.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart2.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart2.AxisY.GroupVisibilityLevel = 0;
            flexChart2.AxisY.MajorGrid = true;
            flexChart2.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart2.AxisY.PlotAreaName = null;
            flexChart2.AxisY.Position = C1.Chart.Position.Left;
            flexChart2.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart2.DataLabel.Angle = 0;
            flexChart2.DataLabel.Border = false;
            flexChart2.DataLabel.ConnectingLine = false;
            flexChart2.DataLabel.Content = null;
            flexChart2.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart2.DataLabel.MaxAutoLabels = 100;
            flexChart2.DataLabel.MaxLines = 0;
            flexChart2.DataLabel.MaxWidth = 0;
            flexChart2.DataLabel.Offset = 0;
            flexChart2.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart2.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart2.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart2.Dock = DockStyle.Fill;
            flexChart2.Legend.ItemMaxWidth = 0;
            flexChart2.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart2.Legend.Position = C1.Chart.Position.Right;
            flexChart2.Legend.Reversed = false;
            flexChart2.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart2.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart2.Legend.Title = null;
            flexChart2.Location = new Point(0, 0);
            flexChart2.Margin = new Padding(10);
            flexChart2.Name = "flexChart2";
            flexChart2.Options.Chart = flexChart2;
            elementSize4.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize4.Value = 70D;
            flexChart2.Options.ClusterSize = elementSize4;
            flexChart2.PlotMargin = new Padding(0);
            flexChart2.SelectedSeries = null;
            flexChart2.SelectionStyle.StrokeColor = Color.Red;
            series4.DataLabel = null;
            series4.Name = "Series 1";
            series4.StackingGroup = -1;
            series4.Style.StrokeWidth = 2F;
            series4.Tooltip = null;
            flexChart2.Series.Add(series4);
            flexChart2.Size = new Size(1110, 280);
            flexChart2.TabIndex = 0;
            flexChart2.Text = "flexChart2";
            // 
            // 
            // 
            flexChart2.ToolTip.Content = "";
            // 
            // flexChart3
            // 
            flexChart3.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart3.AnimationLoad.Duration = 400;
            flexChart3.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart3.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart3.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart3.AnimationUpdate.Duration = 400;
            flexChart3.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart3.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart3.AxisX.AxisLine = true;
            flexChart3.AxisX.Chart = flexChart3;
            flexChart3.AxisX.DataSource = null;
            flexChart3.AxisX.Formatter = null;
            flexChart3.AxisX.GroupProvider = null;
            flexChart3.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart3.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart3.AxisX.GroupVisibilityLevel = 0;
            flexChart3.AxisX.PlotAreaName = null;
            flexChart3.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart3.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart3.AxisY.AxisLine = false;
            flexChart3.AxisY.Chart = flexChart3;
            flexChart3.AxisY.DataSource = null;
            flexChart3.AxisY.Formatter = null;
            flexChart3.AxisY.GroupProvider = null;
            flexChart3.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart3.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart3.AxisY.GroupVisibilityLevel = 0;
            flexChart3.AxisY.MajorGrid = true;
            flexChart3.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart3.AxisY.PlotAreaName = null;
            flexChart3.AxisY.Position = C1.Chart.Position.Left;
            flexChart3.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart3.DataLabel.Angle = 0;
            flexChart3.DataLabel.Border = false;
            flexChart3.DataLabel.ConnectingLine = false;
            flexChart3.DataLabel.Content = null;
            flexChart3.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart3.DataLabel.MaxAutoLabels = 100;
            flexChart3.DataLabel.MaxLines = 0;
            flexChart3.DataLabel.MaxWidth = 0;
            flexChart3.DataLabel.Offset = 0;
            flexChart3.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart3.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart3.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart3.Dock = DockStyle.Fill;
            flexChart3.Legend.ItemMaxWidth = 0;
            flexChart3.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart3.Legend.Position = C1.Chart.Position.Right;
            flexChart3.Legend.Reversed = false;
            flexChart3.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart3.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart3.Legend.Title = null;
            flexChart3.Location = new Point(0, 0);
            flexChart3.Margin = new Padding(10);
            flexChart3.Name = "flexChart3";
            flexChart3.Options.Chart = flexChart3;
            elementSize3.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize3.Value = 70D;
            flexChart3.Options.ClusterSize = elementSize3;
            flexChart3.PlotMargin = new Padding(0);
            flexChart3.SelectedSeries = null;
            flexChart3.SelectionStyle.StrokeColor = Color.Red;
            series3.DataLabel = null;
            series3.Name = "Series 1";
            series3.StackingGroup = -1;
            series3.Style.StrokeWidth = 2F;
            series3.Tooltip = null;
            flexChart3.Series.Add(series3);
            flexChart3.Size = new Size(1110, 368);
            flexChart3.TabIndex = 0;
            flexChart3.Text = "flexChart3";
            // 
            // 
            // 
            flexChart3.ToolTip.Content = "";
            // 
            // flexChart4
            // 
            flexChart4.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart4.AnimationLoad.Duration = 400;
            flexChart4.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart4.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart4.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart4.AnimationUpdate.Duration = 400;
            flexChart4.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart4.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart4.AxisX.AxisLine = true;
            flexChart4.AxisX.Chart = flexChart4;
            flexChart4.AxisX.DataSource = null;
            flexChart4.AxisX.Formatter = null;
            flexChart4.AxisX.GroupProvider = null;
            flexChart4.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart4.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart4.AxisX.GroupVisibilityLevel = 0;
            flexChart4.AxisX.PlotAreaName = null;
            flexChart4.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart4.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart4.AxisY.AxisLine = false;
            flexChart4.AxisY.Chart = flexChart4;
            flexChart4.AxisY.DataSource = null;
            flexChart4.AxisY.Formatter = null;
            flexChart4.AxisY.GroupProvider = null;
            flexChart4.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart4.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart4.AxisY.GroupVisibilityLevel = 0;
            flexChart4.AxisY.MajorGrid = true;
            flexChart4.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart4.AxisY.PlotAreaName = null;
            flexChart4.AxisY.Position = C1.Chart.Position.Left;
            flexChart4.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart4.DataLabel.Angle = 0;
            flexChart4.DataLabel.Border = false;
            flexChart4.DataLabel.ConnectingLine = false;
            flexChart4.DataLabel.Content = null;
            flexChart4.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart4.DataLabel.MaxAutoLabels = 100;
            flexChart4.DataLabel.MaxLines = 0;
            flexChart4.DataLabel.MaxWidth = 0;
            flexChart4.DataLabel.Offset = 0;
            flexChart4.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart4.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart4.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart4.Dock = DockStyle.Fill;
            flexChart4.Legend.ItemMaxWidth = 0;
            flexChart4.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart4.Legend.Position = C1.Chart.Position.Right;
            flexChart4.Legend.Reversed = false;
            flexChart4.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart4.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart4.Legend.Title = null;
            flexChart4.Location = new Point(0, 0);
            flexChart4.Margin = new Padding(10);
            flexChart4.Name = "flexChart4";
            flexChart4.Options.Chart = flexChart4;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            flexChart4.Options.ClusterSize = elementSize2;
            flexChart4.PlotMargin = new Padding(0);
            flexChart4.SelectedSeries = null;
            flexChart4.SelectionStyle.StrokeColor = Color.Red;
            series2.DataLabel = null;
            series2.Name = "Series 1";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            series2.Tooltip = null;
            flexChart4.Series.Add(series2);
            flexChart4.Size = new Size(1110, 400);
            flexChart4.TabIndex = 0;
            flexChart4.Text = "flexChart4";
            // 
            // 
            // 
            flexChart4.ToolTip.Content = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1817, 1344);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskRepositoryBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)flexChart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)flexChart4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private Panel panel3;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private BindingSource taskRepositoryBindingSource;
        private BindingSource taskRepositoryBindingSource1;
        private C1.Win.Chart.FlexChart flexChart1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private C1.Win.Chart.FlexChart flexChart4;
        private C1.Win.Chart.FlexChart flexChart3;
        private C1.Win.Chart.FlexChart flexChart2;
    }
}
