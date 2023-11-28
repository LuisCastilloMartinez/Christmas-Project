namespace Proyectonavidad_p1
{
    partial class Form2
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lbadivinanza = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Style = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAdivinanza = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnreiniciar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnregresoform = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.coposnie = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(229, 149);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(90, 39);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "label3";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(37, 307);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(2);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(88, 20);
            this.txtLetra.TabIndex = 23;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPalabra.Location = new System.Drawing.Point(258, 270);
            this.lblPalabra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(70, 25);
            this.lblPalabra.TabIndex = 25;
            this.lblPalabra.Text = "label3";
            // 
            // lbadivinanza
            // 
            this.lbadivinanza.AutoSize = true;
            this.lbadivinanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadivinanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbadivinanza.Location = new System.Drawing.Point(161, 73);
            this.lbadivinanza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbadivinanza.Name = "lbadivinanza";
            this.lbadivinanza.Size = new System.Drawing.Size(44, 16);
            this.lbadivinanza.TabIndex = 26;
            this.lbadivinanza.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyectonavidad_p1.Properties.Resources.pugvicto;
            this.pictureBox1.Location = new System.Drawing.Point(467, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(595, 41);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel1.StateCommon.ShortText.ColorAngle = 90F;
            this.kryptonLabel1.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "¡Bienvenido al juego de adivinanzas navideñas!";
            // 
            // btnAdivinanza
            // 
            this.btnAdivinanza.Location = new System.Drawing.Point(27, 73);
            this.btnAdivinanza.Name = "btnAdivinanza";
            this.btnAdivinanza.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.OverrideDefault.Back.ColorAngle = 90F;
            this.btnAdivinanza.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnAdivinanza.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.OverrideDefault.Border.ColorAngle = 90F;
            this.btnAdivinanza.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.OverrideFocus.Border.ColorAngle = 90F;
            this.btnAdivinanza.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.Palette = this.Style;
            this.btnAdivinanza.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAdivinanza.Size = new System.Drawing.Size(108, 53);
            this.btnAdivinanza.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.StateCommon.Back.ColorAngle = 90F;
            this.btnAdivinanza.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnAdivinanza.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.StateCommon.Border.ColorAngle = 90F;
            this.btnAdivinanza.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.StateCommon.Border.Rounding = 15;
            this.btnAdivinanza.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnAdivinanza.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnAdivinanza.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnAdivinanza.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinanza.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.StateDisabled.Back.ColorAngle = 90F;
            this.btnAdivinanza.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnAdivinanza.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.StateNormal.Back.ColorAngle = 90F;
            this.btnAdivinanza.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnAdivinanza.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.StateNormal.Border.ColorAngle = 90F;
            this.btnAdivinanza.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.StatePressed.Back.ColorAngle = 90F;
            this.btnAdivinanza.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdivinanza.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.StatePressed.Border.ColorAngle = 90F;
            this.btnAdivinanza.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnAdivinanza.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnAdivinanza.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnAdivinanza.StateTracking.Back.ColorAngle = 90F;
            this.btnAdivinanza.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnAdivinanza.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdivinanza.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnAdivinanza.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnAdivinanza.StateTracking.Border.ColorAngle = 90F;
            this.btnAdivinanza.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnAdivinanza.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdivinanza.TabIndex = 32;
            this.btnAdivinanza.Values.Text = "   Generar\r\nAdivinanza";
            this.btnAdivinanza.Click += new System.EventHandler(this.btnAdivinanza_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 270);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(154, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonLabel2.StateCommon.ShortText.ColorAngle = 45F;
            this.kryptonLabel2.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 33;
            this.kryptonLabel2.Values.Text = "Ingresa una letra";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(27, 338);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 90F;
            this.kryptonButton1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonButton1.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 90F;
            this.kryptonButton1.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.OverrideFocus.Border.ColorAngle = 90F;
            this.kryptonButton1.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.Palette = this.Style;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(108, 56);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 90F;
            this.kryptonButton1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonButton1.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 90F;
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.kryptonButton1.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.kryptonButton1.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.StateDisabled.Back.ColorAngle = 90F;
            this.kryptonButton1.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonButton1.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.StateNormal.Back.ColorAngle = 90F;
            this.kryptonButton1.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonButton1.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.StateNormal.Border.ColorAngle = 90F;
            this.kryptonButton1.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 90F;
            this.kryptonButton1.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 90F;
            this.kryptonButton1.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 90F;
            this.kryptonButton1.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.kryptonButton1.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.kryptonButton1.StateTracking.Border.ColorAngle = 90F;
            this.kryptonButton1.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 34;
            this.kryptonButton1.Values.Text = "Registrar\r\n   Letra";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Location = new System.Drawing.Point(222, 356);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.OverrideDefault.Back.ColorAngle = 90F;
            this.btnreiniciar.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnreiniciar.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.OverrideDefault.Border.ColorAngle = 90F;
            this.btnreiniciar.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.OverrideFocus.Border.ColorAngle = 90F;
            this.btnreiniciar.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.Palette = this.Style;
            this.btnreiniciar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnreiniciar.Size = new System.Drawing.Size(134, 38);
            this.btnreiniciar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.StateCommon.Back.ColorAngle = 90F;
            this.btnreiniciar.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnreiniciar.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.StateCommon.Border.ColorAngle = 90F;
            this.btnreiniciar.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.StateCommon.Border.Rounding = 15;
            this.btnreiniciar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnreiniciar.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnreiniciar.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnreiniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreiniciar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.StateDisabled.Back.ColorAngle = 90F;
            this.btnreiniciar.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnreiniciar.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.StateNormal.Back.ColorAngle = 90F;
            this.btnreiniciar.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnreiniciar.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.StateNormal.Border.ColorAngle = 90F;
            this.btnreiniciar.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.StatePressed.Back.ColorAngle = 90F;
            this.btnreiniciar.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnreiniciar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.StatePressed.Border.ColorAngle = 90F;
            this.btnreiniciar.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnreiniciar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnreiniciar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnreiniciar.StateTracking.Back.ColorAngle = 90F;
            this.btnreiniciar.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnreiniciar.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreiniciar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnreiniciar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnreiniciar.StateTracking.Border.ColorAngle = 90F;
            this.btnreiniciar.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnreiniciar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreiniciar.TabIndex = 35;
            this.btnreiniciar.Values.Text = "Otra Adivinanza";
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click_1);
            // 
            // btnregresoform
            // 
            this.btnregresoform.Location = new System.Drawing.Point(467, 354);
            this.btnregresoform.Name = "btnregresoform";
            this.btnregresoform.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.OverrideDefault.Back.ColorAngle = 90F;
            this.btnregresoform.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnregresoform.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.OverrideDefault.Border.ColorAngle = 90F;
            this.btnregresoform.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.OverrideFocus.Border.ColorAngle = 90F;
            this.btnregresoform.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.Palette = this.Style;
            this.btnregresoform.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnregresoform.Size = new System.Drawing.Size(98, 40);
            this.btnregresoform.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.StateCommon.Back.ColorAngle = 90F;
            this.btnregresoform.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnregresoform.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.StateCommon.Border.ColorAngle = 90F;
            this.btnregresoform.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.StateCommon.Border.Rounding = 15;
            this.btnregresoform.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(16)))));
            this.btnregresoform.StateCommon.Content.ShortText.ColorAngle = 90F;
            this.btnregresoform.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50;
            this.btnregresoform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresoform.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.StateDisabled.Back.ColorAngle = 90F;
            this.btnregresoform.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnregresoform.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.StateNormal.Back.ColorAngle = 90F;
            this.btnregresoform.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btnregresoform.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.StateNormal.Border.ColorAngle = 90F;
            this.btnregresoform.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.StatePressed.Back.ColorAngle = 90F;
            this.btnregresoform.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnregresoform.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.StatePressed.Border.ColorAngle = 90F;
            this.btnregresoform.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnregresoform.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.btnregresoform.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.btnregresoform.StateTracking.Back.ColorAngle = 90F;
            this.btnregresoform.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.btnregresoform.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregresoform.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(95)))));
            this.btnregresoform.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            this.btnregresoform.StateTracking.Border.ColorAngle = 90F;
            this.btnregresoform.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.btnregresoform.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregresoform.TabIndex = 36;
            this.btnregresoform.Values.Text = "Regresar";
            this.btnregresoform.Click += new System.EventHandler(this.btnregresoform_Click_1);
            // 
            // coposnie
            // 
            this.coposnie.Tick += new System.EventHandler(this.coposnie_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(633, 412);
            this.Controls.Add(this.btnregresoform);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btnAdivinanza);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbadivinanza);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Palette = this.Style;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lbadivinanza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette Style;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdivinanza;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnreiniciar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnregresoform;
        private System.Windows.Forms.Timer coposnie;
    }
}