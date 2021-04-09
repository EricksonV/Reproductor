using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaReproductor.Listas;

namespace TareaReproductor
{
    public partial class Form1 : Form
    {
        bool Play = false;
        bool elimina = false;
        
        string[] archivosmp3;
        string[] rutasarchivos;
        ClsLista RutasArchivosMp3 = new ClsLista();
        ClsLista ArchivosMp3 = new ClsLista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgg_Click(object sender, EventArgs e)
        {
            lstCanciones.Items.Clear();
            OpenFileDialog Busqueda = new OpenFileDialog();
            Busqueda.Multiselect = true;
            if (Busqueda.ShowDialog() == DialogResult.OK)
            {
                archivosmp3 = Busqueda.SafeFileNames;
                rutasarchivos = Busqueda.FileNames;
                foreach (string dato in archivosmp3) {
                    ArchivosMp3.Add(dato);
                }
                foreach (string datos in rutasarchivos) {
                    RutasArchivosMp3.Add(datos);
                }
                string[] palabras = ArchivosMp3.datosenString();
                foreach (string x in palabras) {

                    lstCanciones.Items.Add(x);
                    
                }
                
            }
            
            Reproductor.URL = RutasArchivosMp3.buscarPosicion(0);
            lstCanciones.SelectedIndex = 0;
            btPlay.Text = "Pause";
            Play = true;
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasarchivos[lstCanciones.SelectedIndex];
            lbCancion.Text = archivosmp3[lstCanciones.SelectedIndex];

        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            switch (Play) {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btPlay.Text = "Play";
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btPlay.Text = "Pause";
                    Play = true;
                    break;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btPlay.Text = "Play";
            Play = false;
        }
        public void actualizarDatosTrack() {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                MtBDuración.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            } else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused) {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                MtBDuración.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarDatosTrack();
            MtBDuración.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            MtBVolumen.Value = (int)Reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizarDatosTrack();
        }

        private void MtBVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = MtBVolumen.Value;
        }

        private void MtBDuración_ValueChanged(object sender, decimal value)
        {
            Reproductor.Ctlcontrols.currentPosition = MtBDuración.Value;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            switch (elimina)
            {
                case true:
                    btEliminar.Text="Eliminar cancion";
                    elimina = false;
                    break;
                case false:
                    btEliminar.Text = "No Eliminar cancion";
                    elimina = true;
                    break;
            }

        }
    }
}
