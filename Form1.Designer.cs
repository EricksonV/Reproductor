namespace TareaReproductor
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
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btAgg = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbCancion = new System.Windows.Forms.Label();
            this.MtBVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lbVolumen = new System.Windows.Forms.Label();
            this.MtBDuración = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(556, 150);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(215, 60);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 16;
            this.lstCanciones.Location = new System.Drawing.Point(29, 95);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(281, 308);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btAgg
            // 
            this.btAgg.Location = new System.Drawing.Point(316, 95);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(145, 36);
            this.btAgg.TabIndex = 2;
            this.btAgg.Text = "Agregar Canción";
            this.btAgg.UseVisualStyleBackColor = true;
            this.btAgg.Click += new System.EventHandler(this.btAgg_Click);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(316, 150);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(73, 42);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(396, 150);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(65, 42);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(29, 15);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(0, 17);
            this.lbCancion.TabIndex = 6;
            // 
            // MtBVolumen
            // 
            this.MtBVolumen.BackColor = System.Drawing.Color.Transparent;
            this.MtBVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtBVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtBVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtBVolumen.IndentHeight = 6;
            this.MtBVolumen.Location = new System.Drawing.Point(316, 310);
            this.MtBVolumen.Maximum = 100;
            this.MtBVolumen.Minimum = 0;
            this.MtBVolumen.Name = "MtBVolumen";
            this.MtBVolumen.Size = new System.Drawing.Size(145, 28);
            this.MtBVolumen.TabIndex = 7;
            this.MtBVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBVolumen.TickColor = System.Drawing.Color.Blue;
            this.MtBVolumen.TickHeight = 4;
            this.MtBVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBVolumen.TrackerColor = System.Drawing.Color.Blue;
            this.MtBVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtBVolumen.TrackLineColor = System.Drawing.Color.Gray;
            this.MtBVolumen.TrackLineHeight = 3;
            this.MtBVolumen.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.MtBVolumen.Value = 0;
            this.MtBVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBVolumen_ValueChanged);
            // 
            // lbVolumen
            // 
            this.lbVolumen.AutoSize = true;
            this.lbVolumen.Location = new System.Drawing.Point(316, 281);
            this.lbVolumen.Name = "lbVolumen";
            this.lbVolumen.Size = new System.Drawing.Size(63, 17);
            this.lbVolumen.TabIndex = 8;
            this.lbVolumen.Text = "Volumen";
            // 
            // MtBDuración
            // 
            this.MtBDuración.BackColor = System.Drawing.Color.Transparent;
            this.MtBDuración.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtBDuración.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtBDuración.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtBDuración.IndentHeight = 6;
            this.MtBDuración.Location = new System.Drawing.Point(32, 52);
            this.MtBDuración.Maximum = 100;
            this.MtBDuración.Minimum = 0;
            this.MtBDuración.Name = "MtBDuración";
            this.MtBDuración.Size = new System.Drawing.Size(278, 28);
            this.MtBDuración.TabIndex = 9;
            this.MtBDuración.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBDuración.TickColor = System.Drawing.Color.Blue;
            this.MtBDuración.TickHeight = 4;
            this.MtBDuración.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBDuración.TrackerColor = System.Drawing.Color.Blue;
            this.MtBDuración.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtBDuración.TrackLineColor = System.Drawing.Color.Gray;
            this.MtBDuración.TrackLineHeight = 3;
            this.MtBDuración.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.MtBDuración.Value = 0;
            this.MtBDuración.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBDuración_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(316, 222);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(145, 35);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "Eliminar Canción";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.MtBDuración);
            this.Controls.Add(this.lbVolumen);
            this.Controls.Add(this.MtBVolumen);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btAgg);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Button btAgg;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbCancion;
        private XComponent.SliderBar.MACTrackBar MtBVolumen;
        private System.Windows.Forms.Label lbVolumen;
        private XComponent.SliderBar.MACTrackBar MtBDuración;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btEliminar;
    }
}

