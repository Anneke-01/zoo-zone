namespace Krypton_Toolkit_Demo.View
{
    partial class frmToursZone
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
            this.pnlPrimary = new System.Windows.Forms.Panel();
            this.txtZona = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarZona = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAgregarZona = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnActualizarZona = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvZona = new System.Windows.Forms.DataGridView();
            this.txtPrecioTour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaTour = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDuración = new System.Windows.Forms.ComboBox();
            this.btnEliminarTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAgregarTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnActualizarTours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtVisitantesAutorizados = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEspecieName = new System.Windows.Forms.Label();
            this.btnDescartarCambios = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGuardar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchTours = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvTours = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPrimary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).BeginInit();
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
            // pnlPrimary
            // 
            this.pnlPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.pnlPrimary.Controls.Add(this.txtZona);
            this.pnlPrimary.Controls.Add(this.label7);
            this.pnlPrimary.Controls.Add(this.btnEliminarZona);
            this.pnlPrimary.Controls.Add(this.btnAgregarZona);
            this.pnlPrimary.Controls.Add(this.btnActualizarZona);
            this.pnlPrimary.Controls.Add(this.dgvZona);
            this.pnlPrimary.Controls.Add(this.txtPrecioTour);
            this.pnlPrimary.Controls.Add(this.label6);
            this.pnlPrimary.Controls.Add(this.dtpFechaTour);
            this.pnlPrimary.Controls.Add(this.label4);
            this.pnlPrimary.Controls.Add(this.label3);
            this.pnlPrimary.Controls.Add(this.cmbDuración);
            this.pnlPrimary.Controls.Add(this.btnEliminarTours);
            this.pnlPrimary.Controls.Add(this.btnAgregarTours);
            this.pnlPrimary.Controls.Add(this.btnActualizarTours);
            this.pnlPrimary.Controls.Add(this.txtVisitantesAutorizados);
            this.pnlPrimary.Controls.Add(this.label1);
            this.pnlPrimary.Controls.Add(this.label5);
            this.pnlPrimary.Controls.Add(this.lblEspecieName);
            this.pnlPrimary.Controls.Add(this.btnDescartarCambios);
            this.pnlPrimary.Controls.Add(this.btnGuardar);
            this.pnlPrimary.Controls.Add(this.pbSearch);
            this.pnlPrimary.Controls.Add(this.txtSearchTours);
            this.pnlPrimary.Controls.Add(this.dgvTours);
            this.pnlPrimary.Controls.Add(this.label2);
            this.pnlPrimary.Location = new System.Drawing.Point(3, 3);
            this.pnlPrimary.Name = "pnlPrimary";
            this.pnlPrimary.Size = new System.Drawing.Size(1064, 686);
            this.pnlPrimary.TabIndex = 0;
            // 
            // txtZona
            // 
            this.txtZona.Enabled = false;
            this.txtZona.Location = new System.Drawing.Point(443, 574);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(213, 31);
            this.txtZona.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtZona.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtZona.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtZona.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtZona.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtZona.StateCommon.Border.Rounding = 20;
            this.txtZona.StateCommon.Border.Width = 1;
            this.txtZona.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtZona.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZona.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtZona.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(378, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 83;
            this.label7.Text = "Zona:";
            // 
            // btnEliminarZona
            // 
            this.btnEliminarZona.Location = new System.Drawing.Point(955, 611);
            this.btnEliminarZona.Name = "btnEliminarZona";
            this.btnEliminarZona.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarZona.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarZona.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminarZona.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarZona.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarZona.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminarZona.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarZona.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarZona.OverrideDefault.Border.Rounding = 20;
            this.btnEliminarZona.OverrideDefault.Border.Width = 1;
            this.btnEliminarZona.Size = new System.Drawing.Size(90, 44);
            this.btnEliminarZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarZona.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarZona.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminarZona.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarZona.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarZona.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminarZona.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarZona.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarZona.StateCommon.Border.Rounding = 20;
            this.btnEliminarZona.StateCommon.Border.Width = 1;
            this.btnEliminarZona.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminarZona.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminarZona.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarZona.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarZona.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarZona.StatePressed.Back.ColorAngle = 135F;
            this.btnEliminarZona.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarZona.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarZona.StatePressed.Border.ColorAngle = 135F;
            this.btnEliminarZona.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarZona.StatePressed.Border.Rounding = 20;
            this.btnEliminarZona.StatePressed.Border.Width = 1;
            this.btnEliminarZona.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarZona.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarZona.StateTracking.Back.ColorAngle = 135F;
            this.btnEliminarZona.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarZona.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarZona.StateTracking.Border.ColorAngle = 135F;
            this.btnEliminarZona.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarZona.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarZona.StateTracking.Border.Rounding = 20;
            this.btnEliminarZona.StateTracking.Border.Width = 1;
            this.btnEliminarZona.TabIndex = 82;
            this.btnEliminarZona.Values.Text = "Eliminar";
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.Location = new System.Drawing.Point(734, 611);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarZona.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarZona.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarZona.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarZona.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarZona.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarZona.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarZona.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarZona.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarZona.OverrideDefault.Border.Width = 1;
            this.btnAgregarZona.Size = new System.Drawing.Size(108, 44);
            this.btnAgregarZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarZona.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarZona.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarZona.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarZona.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarZona.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarZona.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarZona.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarZona.StateCommon.Border.Rounding = 20;
            this.btnAgregarZona.StateCommon.Border.Width = 1;
            this.btnAgregarZona.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarZona.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarZona.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarZona.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarZona.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarZona.StatePressed.Back.ColorAngle = 135F;
            this.btnAgregarZona.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarZona.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarZona.StatePressed.Border.ColorAngle = 135F;
            this.btnAgregarZona.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarZona.StatePressed.Border.Rounding = 20;
            this.btnAgregarZona.StatePressed.Border.Width = 1;
            this.btnAgregarZona.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarZona.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarZona.StateTracking.Back.ColorAngle = 135F;
            this.btnAgregarZona.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarZona.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarZona.StateTracking.Border.ColorAngle = 135F;
            this.btnAgregarZona.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarZona.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarZona.StateTracking.Border.Rounding = 20;
            this.btnAgregarZona.StateTracking.Border.Width = 1;
            this.btnAgregarZona.TabIndex = 80;
            this.btnAgregarZona.Values.Text = "Agregar";
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            // 
            // btnActualizarZona
            // 
            this.btnActualizarZona.Location = new System.Drawing.Point(848, 611);
            this.btnActualizarZona.Name = "btnActualizarZona";
            this.btnActualizarZona.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarZona.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarZona.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizarZona.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarZona.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarZona.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizarZona.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarZona.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarZona.OverrideDefault.Border.Rounding = 20;
            this.btnActualizarZona.OverrideDefault.Border.Width = 1;
            this.btnActualizarZona.Size = new System.Drawing.Size(101, 44);
            this.btnActualizarZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarZona.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarZona.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizarZona.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarZona.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarZona.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizarZona.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarZona.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarZona.StateCommon.Border.Rounding = 20;
            this.btnActualizarZona.StateCommon.Border.Width = 1;
            this.btnActualizarZona.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizarZona.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizarZona.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarZona.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarZona.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarZona.StatePressed.Back.ColorAngle = 135F;
            this.btnActualizarZona.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarZona.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarZona.StatePressed.Border.ColorAngle = 135F;
            this.btnActualizarZona.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarZona.StatePressed.Border.Rounding = 20;
            this.btnActualizarZona.StatePressed.Border.Width = 1;
            this.btnActualizarZona.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarZona.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarZona.StateTracking.Back.ColorAngle = 135F;
            this.btnActualizarZona.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarZona.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarZona.StateTracking.Border.ColorAngle = 135F;
            this.btnActualizarZona.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarZona.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarZona.StateTracking.Border.Rounding = 20;
            this.btnActualizarZona.StateTracking.Border.Width = 1;
            this.btnActualizarZona.TabIndex = 81;
            this.btnActualizarZona.Values.Text = "Actualizar";
            this.btnActualizarZona.Click += new System.EventHandler(this.btnActualizarZona_Click);
            // 
            // dgvZona
            // 
            this.dgvZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZona.Location = new System.Drawing.Point(729, 460);
            this.dgvZona.Name = "dgvZona";
            this.dgvZona.Size = new System.Drawing.Size(316, 145);
            this.dgvZona.TabIndex = 79;
            // 
            // txtPrecioTour
            // 
            this.txtPrecioTour.Enabled = false;
            this.txtPrecioTour.Location = new System.Drawing.Point(443, 530);
            this.txtPrecioTour.Name = "txtPrecioTour";
            this.txtPrecioTour.Size = new System.Drawing.Size(213, 31);
            this.txtPrecioTour.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPrecioTour.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecioTour.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecioTour.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrecioTour.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPrecioTour.StateCommon.Border.Rounding = 20;
            this.txtPrecioTour.StateCommon.Border.Width = 1;
            this.txtPrecioTour.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPrecioTour.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTour.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPrecioTour.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(368, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 77;
            this.label6.Text = "Precio:";
            // 
            // dtpFechaTour
            // 
            this.dtpFechaTour.Enabled = false;
            this.dtpFechaTour.Location = new System.Drawing.Point(443, 498);
            this.dtpFechaTour.Name = "dtpFechaTour";
            this.dtpFechaTour.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaTour.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(368, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(738, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 74;
            this.label3.Text = "Zona";
            // 
            // cmbDuración
            // 
            this.cmbDuración.Enabled = false;
            this.cmbDuración.FormattingEnabled = true;
            this.cmbDuración.Location = new System.Drawing.Point(120, 501);
            this.cmbDuración.Name = "cmbDuración";
            this.cmbDuración.Size = new System.Drawing.Size(213, 21);
            this.cmbDuración.TabIndex = 73;
            // 
            // btnEliminarTours
            // 
            this.btnEliminarTours.Location = new System.Drawing.Point(955, 358);
            this.btnEliminarTours.Name = "btnEliminarTours";
            this.btnEliminarTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEliminarTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEliminarTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarTours.OverrideDefault.Border.Rounding = 20;
            this.btnEliminarTours.OverrideDefault.Border.Width = 1;
            this.btnEliminarTours.Size = new System.Drawing.Size(90, 44);
            this.btnEliminarTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnEliminarTours.StateCommon.Back.ColorAngle = 45F;
            this.btnEliminarTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnEliminarTours.StateCommon.Border.ColorAngle = 45F;
            this.btnEliminarTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarTours.StateCommon.Border.Rounding = 20;
            this.btnEliminarTours.StateCommon.Border.Width = 1;
            this.btnEliminarTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEliminarTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEliminarTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarTours.StatePressed.Back.ColorAngle = 135F;
            this.btnEliminarTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEliminarTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEliminarTours.StatePressed.Border.ColorAngle = 135F;
            this.btnEliminarTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarTours.StatePressed.Border.Rounding = 20;
            this.btnEliminarTours.StatePressed.Border.Width = 1;
            this.btnEliminarTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarTours.StateTracking.Back.ColorAngle = 135F;
            this.btnEliminarTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEliminarTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEliminarTours.StateTracking.Border.ColorAngle = 135F;
            this.btnEliminarTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEliminarTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEliminarTours.StateTracking.Border.Rounding = 20;
            this.btnEliminarTours.StateTracking.Border.Width = 1;
            this.btnEliminarTours.TabIndex = 72;
            this.btnEliminarTours.Values.Text = "Eliminar";
            // 
            // btnAgregarTours
            // 
            this.btnAgregarTours.Location = new System.Drawing.Point(734, 358);
            this.btnAgregarTours.Name = "btnAgregarTours";
            this.btnAgregarTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAgregarTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAgregarTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarTours.OverrideDefault.Border.Rounding = 20;
            this.btnAgregarTours.OverrideDefault.Border.Width = 1;
            this.btnAgregarTours.Size = new System.Drawing.Size(108, 44);
            this.btnAgregarTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnAgregarTours.StateCommon.Back.ColorAngle = 45F;
            this.btnAgregarTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnAgregarTours.StateCommon.Border.ColorAngle = 45F;
            this.btnAgregarTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarTours.StateCommon.Border.Rounding = 20;
            this.btnAgregarTours.StateCommon.Border.Width = 1;
            this.btnAgregarTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarTours.StatePressed.Back.ColorAngle = 135F;
            this.btnAgregarTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAgregarTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAgregarTours.StatePressed.Border.ColorAngle = 135F;
            this.btnAgregarTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarTours.StatePressed.Border.Rounding = 20;
            this.btnAgregarTours.StatePressed.Border.Width = 1;
            this.btnAgregarTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarTours.StateTracking.Back.ColorAngle = 135F;
            this.btnAgregarTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAgregarTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAgregarTours.StateTracking.Border.ColorAngle = 135F;
            this.btnAgregarTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAgregarTours.StateTracking.Border.Rounding = 20;
            this.btnAgregarTours.StateTracking.Border.Width = 1;
            this.btnAgregarTours.TabIndex = 70;
            this.btnAgregarTours.Values.Text = "Agregar";
            this.btnAgregarTours.Click += new System.EventHandler(this.btnAgregarTours_Click);
            // 
            // btnActualizarTours
            // 
            this.btnActualizarTours.Location = new System.Drawing.Point(848, 358);
            this.btnActualizarTours.Name = "btnActualizarTours";
            this.btnActualizarTours.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarTours.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarTours.OverrideDefault.Back.ColorAngle = 45F;
            this.btnActualizarTours.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarTours.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarTours.OverrideDefault.Border.ColorAngle = 45F;
            this.btnActualizarTours.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarTours.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarTours.OverrideDefault.Border.Rounding = 20;
            this.btnActualizarTours.OverrideDefault.Border.Width = 1;
            this.btnActualizarTours.Size = new System.Drawing.Size(101, 44);
            this.btnActualizarTours.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarTours.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnActualizarTours.StateCommon.Back.ColorAngle = 45F;
            this.btnActualizarTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnActualizarTours.StateCommon.Border.ColorAngle = 45F;
            this.btnActualizarTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarTours.StateCommon.Border.Rounding = 20;
            this.btnActualizarTours.StateCommon.Border.Width = 1;
            this.btnActualizarTours.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizarTours.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizarTours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTours.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarTours.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarTours.StatePressed.Back.ColorAngle = 135F;
            this.btnActualizarTours.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnActualizarTours.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnActualizarTours.StatePressed.Border.ColorAngle = 135F;
            this.btnActualizarTours.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarTours.StatePressed.Border.Rounding = 20;
            this.btnActualizarTours.StatePressed.Border.Width = 1;
            this.btnActualizarTours.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarTours.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarTours.StateTracking.Back.ColorAngle = 135F;
            this.btnActualizarTours.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnActualizarTours.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnActualizarTours.StateTracking.Border.ColorAngle = 135F;
            this.btnActualizarTours.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActualizarTours.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnActualizarTours.StateTracking.Border.Rounding = 20;
            this.btnActualizarTours.StateTracking.Border.Width = 1;
            this.btnActualizarTours.TabIndex = 71;
            this.btnActualizarTours.Values.Text = "Actualizar";
            // 
            // txtVisitantesAutorizados
            // 
            this.txtVisitantesAutorizados.Enabled = false;
            this.txtVisitantesAutorizados.Location = new System.Drawing.Point(120, 574);
            this.txtVisitantesAutorizados.Name = "txtVisitantesAutorizados";
            this.txtVisitantesAutorizados.Size = new System.Drawing.Size(213, 31);
            this.txtVisitantesAutorizados.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtVisitantesAutorizados.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVisitantesAutorizados.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVisitantesAutorizados.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtVisitantesAutorizados.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtVisitantesAutorizados.StateCommon.Border.Rounding = 20;
            this.txtVisitantesAutorizados.StateCommon.Border.Width = 1;
            this.txtVisitantesAutorizados.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtVisitantesAutorizados.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitantesAutorizados.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtVisitantesAutorizados.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(23, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Máximo de visitantes autorizados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(23, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Duración:";
            // 
            // lblEspecieName
            // 
            this.lblEspecieName.AutoSize = true;
            this.lblEspecieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.lblEspecieName.Location = new System.Drawing.Point(20, 420);
            this.lblEspecieName.Name = "lblEspecieName";
            this.lblEspecieName.Size = new System.Drawing.Size(275, 37);
            this.lblEspecieName.TabIndex = 62;
            this.lblEspecieName.Text = "Detalles del Tour";
            // 
            // btnDescartarCambios
            // 
            this.btnDescartarCambios.Enabled = false;
            this.btnDescartarCambios.Location = new System.Drawing.Point(164, 621);
            this.btnDescartarCambios.Name = "btnDescartarCambios";
            this.btnDescartarCambios.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDescartarCambios.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDescartarCambios.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDescartarCambios.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDescartarCambios.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDescartarCambios.OverrideDefault.Border.ColorAngle = 45F;
            this.btnDescartarCambios.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDescartarCambios.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDescartarCambios.OverrideDefault.Border.Rounding = 20;
            this.btnDescartarCambios.OverrideDefault.Border.Width = 1;
            this.btnDescartarCambios.Size = new System.Drawing.Size(169, 44);
            this.btnDescartarCambios.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDescartarCambios.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnDescartarCambios.StateCommon.Back.ColorAngle = 45F;
            this.btnDescartarCambios.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDescartarCambios.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnDescartarCambios.StateCommon.Border.ColorAngle = 45F;
            this.btnDescartarCambios.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDescartarCambios.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDescartarCambios.StateCommon.Border.Rounding = 20;
            this.btnDescartarCambios.StateCommon.Border.Width = 1;
            this.btnDescartarCambios.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDescartarCambios.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDescartarCambios.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartarCambios.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDescartarCambios.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDescartarCambios.StatePressed.Back.ColorAngle = 135F;
            this.btnDescartarCambios.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDescartarCambios.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDescartarCambios.StatePressed.Border.ColorAngle = 135F;
            this.btnDescartarCambios.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDescartarCambios.StatePressed.Border.Rounding = 20;
            this.btnDescartarCambios.StatePressed.Border.Width = 1;
            this.btnDescartarCambios.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDescartarCambios.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDescartarCambios.StateTracking.Back.ColorAngle = 135F;
            this.btnDescartarCambios.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnDescartarCambios.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnDescartarCambios.StateTracking.Border.ColorAngle = 135F;
            this.btnDescartarCambios.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDescartarCambios.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDescartarCambios.StateTracking.Border.Rounding = 20;
            this.btnDescartarCambios.StateTracking.Border.Width = 1;
            this.btnDescartarCambios.TabIndex = 61;
            this.btnDescartarCambios.Values.Text = "Descartar Cambios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(69, 621);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGuardar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGuardar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnGuardar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGuardar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGuardar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnGuardar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuardar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGuardar.OverrideDefault.Border.Rounding = 20;
            this.btnGuardar.OverrideDefault.Border.Width = 1;
            this.btnGuardar.Size = new System.Drawing.Size(89, 44);
            this.btnGuardar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnGuardar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.btnGuardar.StateCommon.Back.ColorAngle = 45F;
            this.btnGuardar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnGuardar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.btnGuardar.StateCommon.Border.ColorAngle = 45F;
            this.btnGuardar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuardar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGuardar.StateCommon.Border.Rounding = 20;
            this.btnGuardar.StateCommon.Border.Width = 1;
            this.btnGuardar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGuardar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGuardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGuardar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGuardar.StatePressed.Back.ColorAngle = 135F;
            this.btnGuardar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGuardar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGuardar.StatePressed.Border.ColorAngle = 135F;
            this.btnGuardar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuardar.StatePressed.Border.Rounding = 20;
            this.btnGuardar.StatePressed.Border.Width = 1;
            this.btnGuardar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGuardar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGuardar.StateTracking.Back.ColorAngle = 135F;
            this.btnGuardar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGuardar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGuardar.StateTracking.Border.ColorAngle = 135F;
            this.btnGuardar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuardar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGuardar.StateTracking.Border.Rounding = 20;
            this.btnGuardar.StateTracking.Border.Width = 1;
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Values.Text = "Guardar";
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
            // txtSearchTours
            // 
            this.txtSearchTours.Location = new System.Drawing.Point(765, 47);
            this.txtSearchTours.Name = "txtSearchTours";
            this.txtSearchTours.Size = new System.Drawing.Size(280, 31);
            this.txtSearchTours.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchTours.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchTours.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchTours.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchTours.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchTours.StateCommon.Border.Rounding = 20;
            this.txtSearchTours.StateCommon.Border.Width = 1;
            this.txtSearchTours.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchTours.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTours.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchTours.TabIndex = 27;
            // 
            // dgvTours
            // 
            this.dgvTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTours.Location = new System.Drawing.Point(27, 93);
            this.dgvTours.Name = "dgvTours";
            this.dgvTours.Size = new System.Drawing.Size(1018, 259);
            this.dgvTours.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tours";
            // 
            // frmToursZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 680);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrimary);
            this.Name = "frmToursZone";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.pnlPrimary.ResumeLayout(false);
            this.pnlPrimary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel pnlPrimary;
        private System.Windows.Forms.PictureBox pbSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchTours;
        private System.Windows.Forms.DataGridView dgvTours;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtVisitantesAutorizados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEspecieName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDescartarCambios;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbDuración;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminarTours;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarTours;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizarTours;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecioTour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtZona;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEliminarZona;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarZona;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActualizarZona;
        private System.Windows.Forms.DataGridView dgvZona;
    }
}