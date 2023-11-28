namespace Proyectonavidad_p1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_segundos = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_minutos = new System.Windows.Forms.Label();
            this.lb_horas = new System.Windows.Forms.Label();
            this.lb_Dias = new System.Windows.Forms.Label();
            this.coposnie = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Style = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnnuevoform = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Navidad = new System.Windows.Forms.Button();
            this.btnvideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCerrarVideo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_segundos
            // 
            this.lb_segundos.AutoSize = true;
            this.lb_segundos.BackColor = System.Drawing.Color.Transparent;
            this.lb_segundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_segundos.Font = new System.Drawing.Font("Georgia", 36F);
            this.lb_segundos.ForeColor = System.Drawing.Color.White;
            this.lb_segundos.Location = new System.Drawing.Point(552, 391);
            this.lb_segundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_segundos.Name = "lb_segundos";
            this.lb_segundos.Size = new System.Drawing.Size(60, 56);
            this.lb_segundos.TabIndex = 17;
            this.lb_segundos.Text = "--";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lb_fecha.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.Color.White;
            this.lb_fecha.Location = new System.Drawing.Point(320, 10);
            this.lb_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(93, 35);
            this.lb_fecha.TabIndex = 15;
            this.lb_fecha.Text = "fecha";
            // 
            // lb_minutos
            // 
            this.lb_minutos.AutoSize = true;
            this.lb_minutos.BackColor = System.Drawing.Color.Transparent;
            this.lb_minutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_minutos.Font = new System.Drawing.Font("Georgia", 36F);
            this.lb_minutos.ForeColor = System.Drawing.Color.White;
            this.lb_minutos.Location = new System.Drawing.Point(397, 391);
            this.lb_minutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_minutos.Name = "lb_minutos";
            this.lb_minutos.Size = new System.Drawing.Size(60, 56);
            this.lb_minutos.TabIndex = 16;
            this.lb_minutos.Text = "--";
            // 
            // lb_horas
            // 
            this.lb_horas.AutoSize = true;
            this.lb_horas.BackColor = System.Drawing.Color.Transparent;
            this.lb_horas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_horas.Font = new System.Drawing.Font("Georgia", 36F);
            this.lb_horas.ForeColor = System.Drawing.Color.White;
            this.lb_horas.Location = new System.Drawing.Point(251, 391);
            this.lb_horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_horas.Name = "lb_horas";
            this.lb_horas.Size = new System.Drawing.Size(60, 56);
            this.lb_horas.TabIndex = 14;
            this.lb_horas.Text = "--";
            // 
            // lb_Dias
            // 
            this.lb_Dias.AutoSize = true;
            this.lb_Dias.BackColor = System.Drawing.Color.Transparent;
            this.lb_Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Dias.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dias.ForeColor = System.Drawing.Color.White;
            this.lb_Dias.Location = new System.Drawing.Point(129, 391);
            this.lb_Dias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Dias.Name = "lb_Dias";
            this.lb_Dias.Size = new System.Drawing.Size(60, 56);
            this.lb_Dias.TabIndex = 13;
            this.lb_Dias.Text = "--";
            // 
            // coposnie
            // 
            this.coposnie.Tick += new System.EventHandler(this.coposnie_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarVideo);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(656, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 395);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // Style
            // 
            this.Style.ButtonSpecs.FormClose.Image = global::Proyectonavidad_p1.Properties.Resources.cross;
            this.Style.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::Proyectonavidad_p1.Properties.Resources.cross;
            this.Style.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Proyectonavidad_p1.Properties.Resources.cross;
            this.Style.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Proyectonavidad_p1.Properties.Resources.cross;
            this.Style.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            this.Style.ButtonSpecs.FormMax.AllowInheritImage = false;
            this.Style.ButtonSpecs.FormMax.AllowInheritText = false;
            this.Style.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            this.Style.ButtonSpecs.FormMax.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.Style.ButtonSpecs.FormMin.Image = global::Proyectonavidad_p1.Properties.Resources.minus;
            this.Style.ButtonSpecs.FormMin.ImageStates.ImageNormal = global::Proyectonavidad_p1.Properties.Resources.minus;
            this.Style.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Proyectonavidad_p1.Properties.Resources.minus;
            this.Style.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Proyectonavidad_p1.Properties.Resources.minus;
            this.Style.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.Style.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.Style.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Style.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.Style.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.Style.FormStyles.FormMain.StateCommon.Border.ColorAngle = 45F;
            this.Style.FormStyles.FormMain.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.Style.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Style.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.Style.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.Style.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.Style.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.Style.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.Style.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Style.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Style.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.Style.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.Style.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.Style.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Style.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Style.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(744, 339);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnnuevoform
            // 
            this.btnnuevoform.Location = new System.Drawing.Point(189, 491);
            this.btnnuevoform.Name = "btnnuevoform";
            this.btnnuevoform.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.OverrideDefault.Back.ColorAngle = 90F;
            this.btnnuevoform.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnnuevoform.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.OverrideDefault.Border.ColorAngle = 90F;
            this.btnnuevoform.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.OverrideFocus.Border.ColorAngle = 90F;
            this.btnnuevoform.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.Palette = this.Style;
            this.btnnuevoform.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnnuevoform.Size = new System.Drawing.Size(166, 51);
            this.btnnuevoform.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.StateCommon.Back.ColorAngle = 90F;
            this.btnnuevoform.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnnuevoform.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.StateCommon.Border.ColorAngle = 90F;
            this.btnnuevoform.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.StateCommon.Border.Rounding = 15;
            this.btnnuevoform.StateCommon.Border.Width = 2;
            this.btnnuevoform.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnnuevoform.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnnuevoform.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnnuevoform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoform.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.StateDisabled.Back.ColorAngle = 90F;
            this.btnnuevoform.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnnuevoform.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.StateNormal.Back.ColorAngle = 90F;
            this.btnnuevoform.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnnuevoform.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.StateNormal.Border.ColorAngle = 90F;
            this.btnnuevoform.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.StatePressed.Back.ColorAngle = 90F;
            this.btnnuevoform.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnnuevoform.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.StatePressed.Border.ColorAngle = 90F;
            this.btnnuevoform.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnnuevoform.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnnuevoform.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnnuevoform.StateTracking.Back.ColorAngle = 90F;
            this.btnnuevoform.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnnuevoform.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnuevoform.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnnuevoform.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnnuevoform.StateTracking.Border.ColorAngle = 90F;
            this.btnnuevoform.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnnuevoform.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnuevoform.TabIndex = 29;
            this.btnnuevoform.Values.Text = "Juego Navideño";
            this.btnnuevoform.Click += new System.EventHandler(this.btnnuevoform_Click_1);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(82, 336);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(596, 61);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel1.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel1.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.kryptonLabel1.TabIndex = 30;
            this.kryptonLabel1.Values.Text = "Tiempo Restante Para Navidad";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(53, -2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(268, 61);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel2.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel2.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.kryptonLabel2.TabIndex = 31;
            this.kryptonLabel2.Values.Text = "Fecha Actual";
            // 
            // btn_Navidad
            // 
            this.btn_Navidad.BackColor = System.Drawing.Color.Transparent;
            this.btn_Navidad.BackgroundImage = global::Proyectonavidad_p1.Properties.Resources.santa;
            this.btn_Navidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Navidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Navidad.Location = new System.Drawing.Point(281, 81);
            this.btn_Navidad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Navidad.Name = "btn_Navidad";
            this.btn_Navidad.Size = new System.Drawing.Size(194, 233);
            this.btn_Navidad.TabIndex = 24;
            this.btn_Navidad.UseVisualStyleBackColor = false;
            this.btn_Navidad.Click += new System.EventHandler(this.btn_Navidad_Click);
            // 
            // btnvideo
            // 
            this.btnvideo.Location = new System.Drawing.Point(406, 491);
            this.btnvideo.Name = "btnvideo";
            this.btnvideo.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.OverrideDefault.Back.ColorAngle = 90F;
            this.btnvideo.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnvideo.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.OverrideDefault.Border.ColorAngle = 90F;
            this.btnvideo.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.OverrideFocus.Border.ColorAngle = 90F;
            this.btnvideo.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.Palette = this.Style;
            this.btnvideo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnvideo.Size = new System.Drawing.Size(166, 51);
            this.btnvideo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.StateCommon.Back.ColorAngle = 90F;
            this.btnvideo.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnvideo.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.StateCommon.Border.ColorAngle = 90F;
            this.btnvideo.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.StateCommon.Border.Rounding = 15;
            this.btnvideo.StateCommon.Border.Width = 2;
            this.btnvideo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnvideo.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnvideo.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnvideo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvideo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.StateDisabled.Back.ColorAngle = 90F;
            this.btnvideo.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnvideo.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.StateNormal.Back.ColorAngle = 90F;
            this.btnvideo.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnvideo.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.StateNormal.Border.ColorAngle = 90F;
            this.btnvideo.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.StatePressed.Back.ColorAngle = 90F;
            this.btnvideo.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnvideo.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.StatePressed.Border.ColorAngle = 90F;
            this.btnvideo.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnvideo.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnvideo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnvideo.StateTracking.Back.ColorAngle = 90F;
            this.btnvideo.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnvideo.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnvideo.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnvideo.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnvideo.StateTracking.Border.ColorAngle = 90F;
            this.btnvideo.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnvideo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnvideo.TabIndex = 32;
            this.btnvideo.Values.Text = "Ver Video";
            this.btnvideo.Click += new System.EventHandler(this.btnvideo_Click_1);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(246, 450);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 30);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel3.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel3.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3.TabIndex = 33;
            this.kryptonLabel3.Values.Text = "Horas";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(521, 450);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(117, 30);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel7.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel7.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel7.TabIndex = 37;
            this.kryptonLabel7.Values.Text = "Segundos";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(129, 450);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(60, 30);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel8.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel8.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel8.TabIndex = 38;
            this.kryptonLabel8.Values.Text = "Dias";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(381, 450);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(95, 30);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel9.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel9.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel9.TabIndex = 39;
            this.kryptonLabel9.Values.Text = "Minutos";
            // 
            // btnCerrarVideo
            // 
            this.btnCerrarVideo.Location = new System.Drawing.Point(315, 344);
            this.btnCerrarVideo.Name = "btnCerrarVideo";
            this.btnCerrarVideo.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.OverrideDefault.Back.ColorAngle = 90F;
            this.btnCerrarVideo.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnCerrarVideo.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.OverrideDefault.Border.ColorAngle = 90F;
            this.btnCerrarVideo.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.OverrideFocus.Border.ColorAngle = 90F;
            this.btnCerrarVideo.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.Palette = this.Style;
            this.btnCerrarVideo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCerrarVideo.Size = new System.Drawing.Size(149, 43);
            this.btnCerrarVideo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.StateCommon.Back.ColorAngle = 90F;
            this.btnCerrarVideo.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnCerrarVideo.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.StateCommon.Border.ColorAngle = 90F;
            this.btnCerrarVideo.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.StateCommon.Border.Rounding = 15;
            this.btnCerrarVideo.StateCommon.Border.Width = 2;
            this.btnCerrarVideo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnCerrarVideo.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnCerrarVideo.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnCerrarVideo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVideo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.StateDisabled.Back.ColorAngle = 90F;
            this.btnCerrarVideo.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnCerrarVideo.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.StateNormal.Back.ColorAngle = 90F;
            this.btnCerrarVideo.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnCerrarVideo.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.StateNormal.Border.ColorAngle = 90F;
            this.btnCerrarVideo.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.StatePressed.Back.ColorAngle = 90F;
            this.btnCerrarVideo.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCerrarVideo.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.StatePressed.Border.ColorAngle = 90F;
            this.btnCerrarVideo.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnCerrarVideo.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnCerrarVideo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnCerrarVideo.StateTracking.Back.ColorAngle = 90F;
            this.btnCerrarVideo.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnCerrarVideo.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCerrarVideo.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnCerrarVideo.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnCerrarVideo.StateTracking.Border.ColorAngle = 90F;
            this.btnCerrarVideo.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnCerrarVideo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCerrarVideo.TabIndex = 40;
            this.btnCerrarVideo.Values.Text = "Cerrar Video";
            this.btnCerrarVideo.Click += new System.EventHandler(this.btnCerrarVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(754, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.btnvideo);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnnuevoform);
            this.Controls.Add(this.btn_Navidad);
            this.Controls.Add(this.lb_segundos);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.lb_minutos);
            this.Controls.Add(this.lb_horas);
            this.Controls.Add(this.lb_Dias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Palette = this.Style;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Navidad;
        private System.Windows.Forms.Label lb_segundos;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_minutos;
        private System.Windows.Forms.Label lb_horas;
        private System.Windows.Forms.Label lb_Dias;
        private System.Windows.Forms.Timer coposnie;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette Style;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnnuevoform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnvideo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrarVideo;
    }
}

