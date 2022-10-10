namespace Krypton_Toolkit_Demo
{
    partial class frmSalesZone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pnlProviders = new System.Windows.Forms.Panel();
            this.btnDeleteSalesM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chTopSellers30Days = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddSalesM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateSalesM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chTopPopularsTours = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpdateTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTopSellers30Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTopPopularsTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Krypton_Toolkit_Demo.Properties.Resources.mc_red;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Krypton_Toolkit_Demo.Properties.Resources.sign_error_icon;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Krypton_Toolkit_Demo.Properties.Resources.sign_error_icon;
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritImage = false;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedNormal = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedPressed = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedTracking = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMin.AllowInheritImage = false;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Krypton_Toolkit_Demo.Properties.Resources.mc_green;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::Krypton_Toolkit_Demo.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // pnlProviders
            // 
            this.pnlProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.pnlProviders.Controls.Add(this.btnDeleteSalesM);
            this.pnlProviders.Controls.Add(this.chTopSellers30Days);
            this.pnlProviders.Controls.Add(this.btnAddSalesM);
            this.pnlProviders.Controls.Add(this.dataGridView1);
            this.pnlProviders.Controls.Add(this.btnUpdateSalesM);
            this.pnlProviders.Controls.Add(this.label2);
            this.pnlProviders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProviders.Location = new System.Drawing.Point(0, 0);
            this.pnlProviders.Name = "pnlProviders";
            this.pnlProviders.Size = new System.Drawing.Size(1048, 312);
            this.pnlProviders.TabIndex = 0;
            // 
            // btnDeleteSalesM
            // 
            this.btnDeleteSalesM.Location = new System.Drawing.Point(622, 254);
            this.btnDeleteSalesM.Name = "btnDeleteSalesM";
            this.btnDeleteSalesM.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteSalesM.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteSalesM.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDeleteSalesM.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteSalesM.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteSalesM.OverrideDefault.Border.ColorAngle = 45F;
            this.btnDeleteSalesM.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteSalesM.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteSalesM.OverrideDefault.Border.Rounding = 20;
            this.btnDeleteSalesM.OverrideDefault.Border.Width = 1;
            this.btnDeleteSalesM.Size = new System.Drawing.Size(90, 44);
            this.btnDeleteSalesM.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDeleteSalesM.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDeleteSalesM.StateCommon.Back.ColorAngle = 45F;
            this.btnDeleteSalesM.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDeleteSalesM.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDeleteSalesM.StateCommon.Border.ColorAngle = 45F;
            this.btnDeleteSalesM.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteSalesM.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteSalesM.StateCommon.Border.Rounding = 20;
            this.btnDeleteSalesM.StateCommon.Border.Width = 1;
            this.btnDeleteSalesM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteSalesM.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeleteSalesM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSalesM.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDeleteSalesM.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeleteSalesM.StatePressed.Back.ColorAngle = 135F;
            this.btnDeleteSalesM.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDeleteSalesM.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeleteSalesM.StatePressed.Border.ColorAngle = 135F;
            this.btnDeleteSalesM.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteSalesM.StatePressed.Border.Rounding = 20;
            this.btnDeleteSalesM.StatePressed.Border.Width = 1;
            this.btnDeleteSalesM.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteSalesM.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteSalesM.StateTracking.Back.ColorAngle = 135F;
            this.btnDeleteSalesM.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteSalesM.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteSalesM.StateTracking.Border.ColorAngle = 135F;
            this.btnDeleteSalesM.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteSalesM.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteSalesM.StateTracking.Border.Rounding = 20;
            this.btnDeleteSalesM.StateTracking.Border.Width = 1;
            this.btnDeleteSalesM.TabIndex = 17;
            this.btnDeleteSalesM.Values.Text = "Eliminar";
            // 
            // chTopSellers30Days
            // 
            chartArea1.Name = "ChartArea1";
            this.chTopSellers30Days.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend2";
            legend1.Title = "Top vendedores en 30 días";
            this.chTopSellers30Days.Legends.Add(legend1);
            this.chTopSellers30Days.Location = new System.Drawing.Point(718, 8);
            this.chTopSellers30Days.Name = "chTopSellers30Days";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend2";
            series1.Name = "Series1";
            this.chTopSellers30Days.Series.Add(series1);
            this.chTopSellers30Days.Size = new System.Drawing.Size(314, 292);
            this.chTopSellers30Days.TabIndex = 19;
            this.chTopSellers30Days.Text = "chart1";
            // 
            // btnAddSalesM
            // 
            this.btnAddSalesM.Location = new System.Drawing.Point(392, 254);
            this.btnAddSalesM.Name = "btnAddSalesM";
            this.btnAddSalesM.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddSalesM.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddSalesM.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddSalesM.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddSalesM.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddSalesM.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAddSalesM.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddSalesM.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddSalesM.OverrideDefault.Border.Rounding = 20;
            this.btnAddSalesM.OverrideDefault.Border.Width = 1;
            this.btnAddSalesM.Size = new System.Drawing.Size(108, 44);
            this.btnAddSalesM.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAddSalesM.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAddSalesM.StateCommon.Back.ColorAngle = 45F;
            this.btnAddSalesM.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAddSalesM.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAddSalesM.StateCommon.Border.ColorAngle = 45F;
            this.btnAddSalesM.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddSalesM.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddSalesM.StateCommon.Border.Rounding = 20;
            this.btnAddSalesM.StateCommon.Border.Width = 1;
            this.btnAddSalesM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddSalesM.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddSalesM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalesM.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddSalesM.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddSalesM.StatePressed.Back.ColorAngle = 135F;
            this.btnAddSalesM.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddSalesM.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddSalesM.StatePressed.Border.ColorAngle = 135F;
            this.btnAddSalesM.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddSalesM.StatePressed.Border.Rounding = 20;
            this.btnAddSalesM.StatePressed.Border.Width = 1;
            this.btnAddSalesM.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddSalesM.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddSalesM.StateTracking.Back.ColorAngle = 135F;
            this.btnAddSalesM.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddSalesM.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddSalesM.StateTracking.Border.ColorAngle = 135F;
            this.btnAddSalesM.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddSalesM.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddSalesM.StateTracking.Border.Rounding = 20;
            this.btnAddSalesM.StateTracking.Border.Width = 1;
            this.btnAddSalesM.TabIndex = 15;
            this.btnAddSalesM.Values.Text = "Agregar";
            this.btnAddSalesM.Click += new System.EventHandler(this.btnAddSalesM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 197);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnUpdateSalesM
            // 
            this.btnUpdateSalesM.Location = new System.Drawing.Point(506, 254);
            this.btnUpdateSalesM.Name = "btnUpdateSalesM";
            this.btnUpdateSalesM.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateSalesM.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateSalesM.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUpdateSalesM.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateSalesM.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateSalesM.OverrideDefault.Border.ColorAngle = 45F;
            this.btnUpdateSalesM.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateSalesM.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateSalesM.OverrideDefault.Border.Rounding = 20;
            this.btnUpdateSalesM.OverrideDefault.Border.Width = 1;
            this.btnUpdateSalesM.Size = new System.Drawing.Size(110, 44);
            this.btnUpdateSalesM.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnUpdateSalesM.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnUpdateSalesM.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdateSalesM.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnUpdateSalesM.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnUpdateSalesM.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdateSalesM.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateSalesM.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateSalesM.StateCommon.Border.Rounding = 20;
            this.btnUpdateSalesM.StateCommon.Border.Width = 1;
            this.btnUpdateSalesM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateSalesM.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateSalesM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSalesM.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUpdateSalesM.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUpdateSalesM.StatePressed.Back.ColorAngle = 135F;
            this.btnUpdateSalesM.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUpdateSalesM.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUpdateSalesM.StatePressed.Border.ColorAngle = 135F;
            this.btnUpdateSalesM.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateSalesM.StatePressed.Border.Rounding = 20;
            this.btnUpdateSalesM.StatePressed.Border.Width = 1;
            this.btnUpdateSalesM.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateSalesM.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateSalesM.StateTracking.Back.ColorAngle = 135F;
            this.btnUpdateSalesM.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateSalesM.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateSalesM.StateTracking.Border.ColorAngle = 135F;
            this.btnUpdateSalesM.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateSalesM.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateSalesM.StateTracking.Border.Rounding = 20;
            this.btnUpdateSalesM.StateTracking.Border.Width = 1;
            this.btnUpdateSalesM.TabIndex = 16;
            this.btnUpdateSalesM.Values.Text = "Actualizar";
            this.btnUpdateSalesM.Click += new System.EventHandler(this.btnUpdateSalesM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.btnDeleteTours);
            this.panel1.Controls.Add(this.chTopPopularsTours);
            this.panel1.Controls.Add(this.btnAddTours);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnUpdateTours);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 319);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteTours
            // 
            this.btnDeleteTours.Location = new System.Drawing.Point(622, 267);
            this.btnDeleteTours.Name = "btnDeleteTours";
            this.btnDeleteTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDeleteTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnDeleteTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteTours.OverrideDefault.Border.Rounding = 20;
            this.btnDeleteTours.OverrideDefault.Border.Width = 1;
            this.btnDeleteTours.Size = new System.Drawing.Size(90, 44);
            this.btnDeleteTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDeleteTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDeleteTours.StateCommon.Back.ColorAngle = 45F;
            this.btnDeleteTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDeleteTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDeleteTours.StateCommon.Border.ColorAngle = 45F;
            this.btnDeleteTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteTours.StateCommon.Border.Rounding = 20;
            this.btnDeleteTours.StateCommon.Border.Width = 1;
            this.btnDeleteTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeleteTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDeleteTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeleteTours.StatePressed.Back.ColorAngle = 135F;
            this.btnDeleteTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDeleteTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeleteTours.StatePressed.Border.ColorAngle = 135F;
            this.btnDeleteTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTours.StatePressed.Border.Rounding = 20;
            this.btnDeleteTours.StatePressed.Border.Width = 1;
            this.btnDeleteTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteTours.StateTracking.Back.ColorAngle = 135F;
            this.btnDeleteTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDeleteTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDeleteTours.StateTracking.Border.ColorAngle = 135F;
            this.btnDeleteTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeleteTours.StateTracking.Border.Rounding = 20;
            this.btnDeleteTours.StateTracking.Border.Width = 1;
            this.btnDeleteTours.TabIndex = 22;
            this.btnDeleteTours.Values.Text = "Eliminar";
            // 
            // chTopPopularsTours
            // 
            chartArea2.Name = "ChartArea1";
            this.chTopPopularsTours.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            legend2.Title = "Top Tours más populares";
            this.chTopPopularsTours.Legends.Add(legend2);
            this.chTopPopularsTours.Location = new System.Drawing.Point(718, 21);
            this.chTopPopularsTours.Name = "chTopPopularsTours";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend2";
            series2.Name = "Series1";
            this.chTopPopularsTours.Series.Add(series2);
            this.chTopPopularsTours.Size = new System.Drawing.Size(314, 292);
            this.chTopPopularsTours.TabIndex = 25;
            this.chTopPopularsTours.Text = "chart2";
            // 
            // btnAddTours
            // 
            this.btnAddTours.Location = new System.Drawing.Point(392, 267);
            this.btnAddTours.Name = "btnAddTours";
            this.btnAddTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAddTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddTours.OverrideDefault.Border.Rounding = 20;
            this.btnAddTours.OverrideDefault.Border.Width = 1;
            this.btnAddTours.Size = new System.Drawing.Size(108, 44);
            this.btnAddTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAddTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAddTours.StateCommon.Back.ColorAngle = 45F;
            this.btnAddTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAddTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAddTours.StateCommon.Border.ColorAngle = 45F;
            this.btnAddTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddTours.StateCommon.Border.Rounding = 20;
            this.btnAddTours.StateCommon.Border.Width = 1;
            this.btnAddTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddTours.StatePressed.Back.ColorAngle = 135F;
            this.btnAddTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddTours.StatePressed.Border.ColorAngle = 135F;
            this.btnAddTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTours.StatePressed.Border.Rounding = 20;
            this.btnAddTours.StatePressed.Border.Width = 1;
            this.btnAddTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddTours.StateTracking.Back.ColorAngle = 135F;
            this.btnAddTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddTours.StateTracking.Border.ColorAngle = 135F;
            this.btnAddTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddTours.StateTracking.Border.Rounding = 20;
            this.btnAddTours.StateTracking.Border.Width = 1;
            this.btnAddTours.TabIndex = 20;
            this.btnAddTours.Values.Text = "Agregar";
            this.btnAddTours.Click += new System.EventHandler(this.btnAddTours_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(679, 197);
            this.dataGridView2.TabIndex = 24;
            // 
            // btnUpdateTours
            // 
            this.btnUpdateTours.Location = new System.Drawing.Point(506, 267);
            this.btnUpdateTours.Name = "btnUpdateTours";
            this.btnUpdateTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUpdateTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnUpdateTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateTours.OverrideDefault.Border.Rounding = 20;
            this.btnUpdateTours.OverrideDefault.Border.Width = 1;
            this.btnUpdateTours.Size = new System.Drawing.Size(110, 44);
            this.btnUpdateTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnUpdateTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnUpdateTours.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdateTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnUpdateTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnUpdateTours.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdateTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateTours.StateCommon.Border.Rounding = 20;
            this.btnUpdateTours.StateCommon.Border.Width = 1;
            this.btnUpdateTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUpdateTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUpdateTours.StatePressed.Back.ColorAngle = 135F;
            this.btnUpdateTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUpdateTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUpdateTours.StatePressed.Border.ColorAngle = 135F;
            this.btnUpdateTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateTours.StatePressed.Border.Rounding = 20;
            this.btnUpdateTours.StatePressed.Border.Width = 1;
            this.btnUpdateTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateTours.StateTracking.Back.ColorAngle = 135F;
            this.btnUpdateTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateTours.StateTracking.Border.ColorAngle = 135F;
            this.btnUpdateTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateTours.StateTracking.Border.Rounding = 20;
            this.btnUpdateTours.StateTracking.Border.Width = 1;
            this.btnUpdateTours.TabIndex = 21;
            this.btnUpdateTours.Values.Text = "Actualizar";
            this.btnUpdateTours.Click += new System.EventHandler(this.btnUpdateTours_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tours";
            // 
            // frmSalesZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1048, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProviders);
            this.Name = "frmSalesZone";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.pnlProviders.ResumeLayout(false);
            this.pnlProviders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTopSellers30Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTopPopularsTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel pnlProviders;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateSalesM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddSalesM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteSalesM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTopSellers30Days;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTopPopularsTours;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteTours;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddTours;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateTours;
    }
}