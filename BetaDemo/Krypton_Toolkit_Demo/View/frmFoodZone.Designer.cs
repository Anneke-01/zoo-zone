namespace Krypton_Toolkit_Demo.View
{
    partial class frmFoodZone
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTours = new System.Windows.Forms.DataGridView();
            this.lblEspecieName = new System.Windows.Forms.Label();
            this.btnActualizarAlimento = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAgregarAliemento = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEliminarAlimento = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvZona = new System.Windows.Forms.DataGridView();
            this.btnActualizarDonador = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAgregarDonador = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEliminarDonador = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlPrimary = new System.Windows.Forms.Panel();
            this.dgvConsumo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarProveedor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAgregarProveedor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnActualizarProveedor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchAlimentos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZona)).BeginInit();
            this.pnlPrimary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Alimentos";
            // 
            // dgvTours
            // 
            this.dgvTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTours.Location = new System.Drawing.Point(27, 93);
            this.dgvTours.Name = "dgvTours";
            this.dgvTours.Size = new System.Drawing.Size(1018, 259);
            this.dgvTours.TabIndex = 24;
            // 
            // lblEspecieName
            // 
            this.lblEspecieName.AutoSize = true;
            this.lblEspecieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.lblEspecieName.Location = new System.Drawing.Point(370, 444);
            this.lblEspecieName.Name = "lblEspecieName";
            this.lblEspecieName.Size = new System.Drawing.Size(172, 37);
            this.lblEspecieName.TabIndex = 62;
            this.lblEspecieName.Text = "Proveedor";
            // 
            // btnActualizarAlimento
            // 
            this.btnActualizarAlimento.Location = new System.Drawing.Point(848, 358);
            this.btnActualizarAlimento.Name = "btnActualizarAlimento";
            this.btnActualizarAlimento.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarAlimento.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarAlimento.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizarAlimento.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarAlimento.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarAlimento.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizarAlimento.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarAlimento.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarAlimento.OverrideDefault.Border.Rounding = 20;
            this.btnActualizarAlimento.OverrideDefault.Border.Width = 1;
            this.btnActualizarAlimento.Size = new System.Drawing.Size(101, 44);
            this.btnActualizarAlimento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarAlimento.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarAlimento.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizarAlimento.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarAlimento.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarAlimento.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizarAlimento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarAlimento.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarAlimento.StateCommon.Border.Rounding = 20;
            this.btnActualizarAlimento.StateCommon.Border.Width = 1;
            this.btnActualizarAlimento.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizarAlimento.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizarAlimento.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAlimento.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarAlimento.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarAlimento.StatePressed.Back.ColorAngle = 135F;
            this.btnActualizarAlimento.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarAlimento.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarAlimento.StatePressed.Border.ColorAngle = 135F;
            this.btnActualizarAlimento.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarAlimento.StatePressed.Border.Rounding = 20;
            this.btnActualizarAlimento.StatePressed.Border.Width = 1;
            this.btnActualizarAlimento.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarAlimento.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarAlimento.StateTracking.Back.ColorAngle = 135F;
            this.btnActualizarAlimento.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarAlimento.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarAlimento.StateTracking.Border.ColorAngle = 135F;
            this.btnActualizarAlimento.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarAlimento.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarAlimento.StateTracking.Border.Rounding = 20;
            this.btnActualizarAlimento.StateTracking.Border.Width = 1;
            this.btnActualizarAlimento.TabIndex = 71;
            this.btnActualizarAlimento.Values.Text = "Actualizar";
            this.btnActualizarAlimento.Click += new System.EventHandler(this.btnActualizarAlimento_Click);
            // 
            // btnAgregarAliemento
            // 
            this.btnAgregarAliemento.Location = new System.Drawing.Point(734, 358);
            this.btnAgregarAliemento.Name = "btnAgregarAliemento";
            this.btnAgregarAliemento.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarAliemento.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarAliemento.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarAliemento.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarAliemento.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarAliemento.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarAliemento.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarAliemento.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarAliemento.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarAliemento.OverrideDefault.Border.Width = 1;
            this.btnAgregarAliemento.Size = new System.Drawing.Size(108, 44);
            this.btnAgregarAliemento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarAliemento.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarAliemento.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarAliemento.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarAliemento.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarAliemento.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarAliemento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarAliemento.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarAliemento.StateCommon.Border.Rounding = 20;
            this.btnAgregarAliemento.StateCommon.Border.Width = 1;
            this.btnAgregarAliemento.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarAliemento.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarAliemento.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAliemento.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarAliemento.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarAliemento.StatePressed.Back.ColorAngle = 135F;
            this.btnAgregarAliemento.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarAliemento.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarAliemento.StatePressed.Border.ColorAngle = 135F;
            this.btnAgregarAliemento.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarAliemento.StatePressed.Border.Rounding = 20;
            this.btnAgregarAliemento.StatePressed.Border.Width = 1;
            this.btnAgregarAliemento.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarAliemento.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarAliemento.StateTracking.Back.ColorAngle = 135F;
            this.btnAgregarAliemento.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarAliemento.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarAliemento.StateTracking.Border.ColorAngle = 135F;
            this.btnAgregarAliemento.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarAliemento.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarAliemento.StateTracking.Border.Rounding = 20;
            this.btnAgregarAliemento.StateTracking.Border.Width = 1;
            this.btnAgregarAliemento.TabIndex = 70;
            this.btnAgregarAliemento.Values.Text = "Agregar";
            this.btnAgregarAliemento.Click += new System.EventHandler(this.btnAgregarAliemento_Click);
            // 
            // btnEliminarAlimento
            // 
            this.btnEliminarAlimento.Location = new System.Drawing.Point(955, 358);
            this.btnEliminarAlimento.Name = "btnEliminarAlimento";
            this.btnEliminarAlimento.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarAlimento.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarAlimento.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminarAlimento.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarAlimento.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarAlimento.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminarAlimento.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarAlimento.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarAlimento.OverrideDefault.Border.Rounding = 20;
            this.btnEliminarAlimento.OverrideDefault.Border.Width = 1;
            this.btnEliminarAlimento.Size = new System.Drawing.Size(90, 44);
            this.btnEliminarAlimento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarAlimento.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarAlimento.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminarAlimento.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarAlimento.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarAlimento.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminarAlimento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarAlimento.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarAlimento.StateCommon.Border.Rounding = 20;
            this.btnEliminarAlimento.StateCommon.Border.Width = 1;
            this.btnEliminarAlimento.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminarAlimento.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminarAlimento.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlimento.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarAlimento.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarAlimento.StatePressed.Back.ColorAngle = 135F;
            this.btnEliminarAlimento.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarAlimento.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarAlimento.StatePressed.Border.ColorAngle = 135F;
            this.btnEliminarAlimento.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarAlimento.StatePressed.Border.Rounding = 20;
            this.btnEliminarAlimento.StatePressed.Border.Width = 1;
            this.btnEliminarAlimento.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarAlimento.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarAlimento.StateTracking.Back.ColorAngle = 135F;
            this.btnEliminarAlimento.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarAlimento.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarAlimento.StateTracking.Border.ColorAngle = 135F;
            this.btnEliminarAlimento.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarAlimento.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarAlimento.StateTracking.Border.Rounding = 20;
            this.btnEliminarAlimento.StateTracking.Border.Width = 1;
            this.btnEliminarAlimento.TabIndex = 72;
            this.btnEliminarAlimento.Values.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(738, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 74;
            this.label3.Text = "Donador";
            // 
            // dgvZona
            // 
            this.dgvZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZona.Location = new System.Drawing.Point(729, 484);
            this.dgvZona.Name = "dgvZona";
            this.dgvZona.Size = new System.Drawing.Size(316, 145);
            this.dgvZona.TabIndex = 79;
            // 
            // btnActualizarDonador
            // 
            this.btnActualizarDonador.Location = new System.Drawing.Point(848, 635);
            this.btnActualizarDonador.Name = "btnActualizarDonador";
            this.btnActualizarDonador.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarDonador.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarDonador.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizarDonador.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarDonador.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarDonador.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizarDonador.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarDonador.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarDonador.OverrideDefault.Border.Rounding = 20;
            this.btnActualizarDonador.OverrideDefault.Border.Width = 1;
            this.btnActualizarDonador.Size = new System.Drawing.Size(101, 44);
            this.btnActualizarDonador.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarDonador.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarDonador.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizarDonador.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarDonador.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarDonador.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizarDonador.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarDonador.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarDonador.StateCommon.Border.Rounding = 20;
            this.btnActualizarDonador.StateCommon.Border.Width = 1;
            this.btnActualizarDonador.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizarDonador.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizarDonador.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDonador.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarDonador.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarDonador.StatePressed.Back.ColorAngle = 135F;
            this.btnActualizarDonador.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarDonador.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarDonador.StatePressed.Border.ColorAngle = 135F;
            this.btnActualizarDonador.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarDonador.StatePressed.Border.Rounding = 20;
            this.btnActualizarDonador.StatePressed.Border.Width = 1;
            this.btnActualizarDonador.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarDonador.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarDonador.StateTracking.Back.ColorAngle = 135F;
            this.btnActualizarDonador.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarDonador.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarDonador.StateTracking.Border.ColorAngle = 135F;
            this.btnActualizarDonador.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarDonador.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarDonador.StateTracking.Border.Rounding = 20;
            this.btnActualizarDonador.StateTracking.Border.Width = 1;
            this.btnActualizarDonador.TabIndex = 81;
            this.btnActualizarDonador.Values.Text = "Actualizar";
            this.btnActualizarDonador.Click += new System.EventHandler(this.btnActualizarDonador_Click);
            // 
            // btnAgregarDonador
            // 
            this.btnAgregarDonador.Location = new System.Drawing.Point(734, 635);
            this.btnAgregarDonador.Name = "btnAgregarDonador";
            this.btnAgregarDonador.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarDonador.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarDonador.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarDonador.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarDonador.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarDonador.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarDonador.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarDonador.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarDonador.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarDonador.OverrideDefault.Border.Width = 1;
            this.btnAgregarDonador.Size = new System.Drawing.Size(108, 44);
            this.btnAgregarDonador.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarDonador.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarDonador.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarDonador.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarDonador.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarDonador.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarDonador.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarDonador.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarDonador.StateCommon.Border.Rounding = 20;
            this.btnAgregarDonador.StateCommon.Border.Width = 1;
            this.btnAgregarDonador.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarDonador.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarDonador.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDonador.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarDonador.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarDonador.StatePressed.Back.ColorAngle = 135F;
            this.btnAgregarDonador.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarDonador.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarDonador.StatePressed.Border.ColorAngle = 135F;
            this.btnAgregarDonador.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarDonador.StatePressed.Border.Rounding = 20;
            this.btnAgregarDonador.StatePressed.Border.Width = 1;
            this.btnAgregarDonador.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarDonador.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarDonador.StateTracking.Back.ColorAngle = 135F;
            this.btnAgregarDonador.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarDonador.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarDonador.StateTracking.Border.ColorAngle = 135F;
            this.btnAgregarDonador.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarDonador.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarDonador.StateTracking.Border.Rounding = 20;
            this.btnAgregarDonador.StateTracking.Border.Width = 1;
            this.btnAgregarDonador.TabIndex = 80;
            this.btnAgregarDonador.Values.Text = "Agregar";
            this.btnAgregarDonador.Click += new System.EventHandler(this.btnAgregarDonador_Click);
            // 
            // btnEliminarDonador
            // 
            this.btnEliminarDonador.Location = new System.Drawing.Point(955, 635);
            this.btnEliminarDonador.Name = "btnEliminarDonador";
            this.btnEliminarDonador.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarDonador.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarDonador.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminarDonador.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarDonador.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarDonador.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminarDonador.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarDonador.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarDonador.OverrideDefault.Border.Rounding = 20;
            this.btnEliminarDonador.OverrideDefault.Border.Width = 1;
            this.btnEliminarDonador.Size = new System.Drawing.Size(90, 44);
            this.btnEliminarDonador.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarDonador.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarDonador.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminarDonador.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarDonador.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarDonador.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminarDonador.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarDonador.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarDonador.StateCommon.Border.Rounding = 20;
            this.btnEliminarDonador.StateCommon.Border.Width = 1;
            this.btnEliminarDonador.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminarDonador.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminarDonador.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDonador.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarDonador.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarDonador.StatePressed.Back.ColorAngle = 135F;
            this.btnEliminarDonador.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarDonador.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarDonador.StatePressed.Border.ColorAngle = 135F;
            this.btnEliminarDonador.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarDonador.StatePressed.Border.Rounding = 20;
            this.btnEliminarDonador.StatePressed.Border.Width = 1;
            this.btnEliminarDonador.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarDonador.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarDonador.StateTracking.Back.ColorAngle = 135F;
            this.btnEliminarDonador.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarDonador.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarDonador.StateTracking.Border.ColorAngle = 135F;
            this.btnEliminarDonador.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarDonador.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarDonador.StateTracking.Border.Rounding = 20;
            this.btnEliminarDonador.StateTracking.Border.Width = 1;
            this.btnEliminarDonador.TabIndex = 82;
            this.btnEliminarDonador.Values.Text = "Eliminar";
            // 
            // pnlPrimary
            // 
            this.pnlPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.pnlPrimary.Controls.Add(this.dgvConsumo);
            this.pnlPrimary.Controls.Add(this.label1);
            this.pnlPrimary.Controls.Add(this.btnEliminarProveedor);
            this.pnlPrimary.Controls.Add(this.btnAgregarProveedor);
            this.pnlPrimary.Controls.Add(this.btnActualizarProveedor);
            this.pnlPrimary.Controls.Add(this.dgvProveedor);
            this.pnlPrimary.Controls.Add(this.btnEliminarDonador);
            this.pnlPrimary.Controls.Add(this.btnAgregarDonador);
            this.pnlPrimary.Controls.Add(this.btnActualizarDonador);
            this.pnlPrimary.Controls.Add(this.dgvZona);
            this.pnlPrimary.Controls.Add(this.label3);
            this.pnlPrimary.Controls.Add(this.btnEliminarAlimento);
            this.pnlPrimary.Controls.Add(this.btnAgregarAliemento);
            this.pnlPrimary.Controls.Add(this.btnActualizarAlimento);
            this.pnlPrimary.Controls.Add(this.lblEspecieName);
            this.pnlPrimary.Controls.Add(this.pbSearch);
            this.pnlPrimary.Controls.Add(this.txtSearchAlimentos);
            this.pnlPrimary.Controls.Add(this.dgvTours);
            this.pnlPrimary.Controls.Add(this.label2);
            this.pnlPrimary.Location = new System.Drawing.Point(2, -3);
            this.pnlPrimary.Name = "pnlPrimary";
            this.pnlPrimary.Size = new System.Drawing.Size(1064, 686);
            this.pnlPrimary.TabIndex = 1;
            // 
            // dgvConsumo
            // 
            this.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumo.Location = new System.Drawing.Point(27, 484);
            this.dgvConsumo.Name = "dgvConsumo";
            this.dgvConsumo.Size = new System.Drawing.Size(316, 145);
            this.dgvConsumo.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(25, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 87;
            this.label1.Text = "Consumo";
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(603, 635);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarProveedor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarProveedor.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminarProveedor.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarProveedor.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarProveedor.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminarProveedor.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarProveedor.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarProveedor.OverrideDefault.Border.Rounding = 20;
            this.btnEliminarProveedor.OverrideDefault.Border.Width = 1;
            this.btnEliminarProveedor.Size = new System.Drawing.Size(90, 44);
            this.btnEliminarProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarProveedor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarProveedor.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminarProveedor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarProveedor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarProveedor.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminarProveedor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarProveedor.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarProveedor.StateCommon.Border.Rounding = 20;
            this.btnEliminarProveedor.StateCommon.Border.Width = 1;
            this.btnEliminarProveedor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminarProveedor.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminarProveedor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarProveedor.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarProveedor.StatePressed.Back.ColorAngle = 135F;
            this.btnEliminarProveedor.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarProveedor.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarProveedor.StatePressed.Border.ColorAngle = 135F;
            this.btnEliminarProveedor.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarProveedor.StatePressed.Border.Rounding = 20;
            this.btnEliminarProveedor.StatePressed.Border.Width = 1;
            this.btnEliminarProveedor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarProveedor.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarProveedor.StateTracking.Back.ColorAngle = 135F;
            this.btnEliminarProveedor.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarProveedor.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarProveedor.StateTracking.Border.ColorAngle = 135F;
            this.btnEliminarProveedor.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarProveedor.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarProveedor.StateTracking.Border.Rounding = 20;
            this.btnEliminarProveedor.StateTracking.Border.Width = 1;
            this.btnEliminarProveedor.TabIndex = 86;
            this.btnEliminarProveedor.Values.Text = "Eliminar";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(382, 635);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarProveedor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarProveedor.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarProveedor.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarProveedor.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarProveedor.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarProveedor.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarProveedor.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarProveedor.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarProveedor.OverrideDefault.Border.Width = 1;
            this.btnAgregarProveedor.Size = new System.Drawing.Size(108, 44);
            this.btnAgregarProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarProveedor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarProveedor.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarProveedor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarProveedor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarProveedor.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarProveedor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarProveedor.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarProveedor.StateCommon.Border.Rounding = 20;
            this.btnAgregarProveedor.StateCommon.Border.Width = 1;
            this.btnAgregarProveedor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarProveedor.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarProveedor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarProveedor.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarProveedor.StatePressed.Back.ColorAngle = 135F;
            this.btnAgregarProveedor.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarProveedor.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarProveedor.StatePressed.Border.ColorAngle = 135F;
            this.btnAgregarProveedor.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarProveedor.StatePressed.Border.Rounding = 20;
            this.btnAgregarProveedor.StatePressed.Border.Width = 1;
            this.btnAgregarProveedor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarProveedor.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarProveedor.StateTracking.Back.ColorAngle = 135F;
            this.btnAgregarProveedor.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarProveedor.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarProveedor.StateTracking.Border.ColorAngle = 135F;
            this.btnAgregarProveedor.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarProveedor.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarProveedor.StateTracking.Border.Rounding = 20;
            this.btnAgregarProveedor.StateTracking.Border.Width = 1;
            this.btnAgregarProveedor.TabIndex = 84;
            this.btnAgregarProveedor.Values.Text = "Agregar";
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Location = new System.Drawing.Point(496, 635);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarProveedor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarProveedor.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizarProveedor.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarProveedor.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarProveedor.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizarProveedor.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarProveedor.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarProveedor.OverrideDefault.Border.Rounding = 20;
            this.btnActualizarProveedor.OverrideDefault.Border.Width = 1;
            this.btnActualizarProveedor.Size = new System.Drawing.Size(101, 44);
            this.btnActualizarProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarProveedor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarProveedor.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizarProveedor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarProveedor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarProveedor.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizarProveedor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarProveedor.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarProveedor.StateCommon.Border.Rounding = 20;
            this.btnActualizarProveedor.StateCommon.Border.Width = 1;
            this.btnActualizarProveedor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizarProveedor.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizarProveedor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProveedor.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarProveedor.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarProveedor.StatePressed.Back.ColorAngle = 135F;
            this.btnActualizarProveedor.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarProveedor.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarProveedor.StatePressed.Border.ColorAngle = 135F;
            this.btnActualizarProveedor.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarProveedor.StatePressed.Border.Rounding = 20;
            this.btnActualizarProveedor.StatePressed.Border.Width = 1;
            this.btnActualizarProveedor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarProveedor.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarProveedor.StateTracking.Back.ColorAngle = 135F;
            this.btnActualizarProveedor.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarProveedor.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarProveedor.StateTracking.Border.ColorAngle = 135F;
            this.btnActualizarProveedor.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarProveedor.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarProveedor.StateTracking.Border.Rounding = 20;
            this.btnActualizarProveedor.StateTracking.Border.Width = 1;
            this.btnActualizarProveedor.TabIndex = 85;
            this.btnActualizarProveedor.Values.Text = "Actualizar";
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(377, 484);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(316, 145);
            this.dgvProveedor.TabIndex = 83;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::Krypton_Toolkit_Demo.Properties.Resources.icons8_search_ios_16_70;
            this.pbSearch.Location = new System.Drawing.Point(729, 48);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(30, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 28;
            this.pbSearch.TabStop = false;
            // 
            // txtSearchAlimentos
            // 
            this.txtSearchAlimentos.Location = new System.Drawing.Point(765, 47);
            this.txtSearchAlimentos.Name = "txtSearchAlimentos";
            this.txtSearchAlimentos.Size = new System.Drawing.Size(280, 31);
            this.txtSearchAlimentos.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchAlimentos.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchAlimentos.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchAlimentos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchAlimentos.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchAlimentos.StateCommon.Border.Rounding = 20;
            this.txtSearchAlimentos.StateCommon.Border.Width = 1;
            this.txtSearchAlimentos.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchAlimentos.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAlimentos.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchAlimentos.TabIndex = 27;
            // 
            // frmFoodZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 680);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrimary);
            this.Name = "frmFoodZone";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZona)).EndInit();
            this.pnlPrimary.ResumeLayout(false);
            this.pnlPrimary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTours;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label lblEspecieName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizarAlimento;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarAliemento;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminarAlimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvZona;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizarDonador;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarDonador;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminarDonador;
        private System.Windows.Forms.Panel pnlPrimary;
        private System.Windows.Forms.DataGridView dgvConsumo;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminarProveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarProveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchAlimentos;
    }
}