using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;

namespace KinectCapture
{
    public partial class VentanaCaptura : Form
    {
        private KinectSensor kinectSensor;

        bool capturando = false;
        bool sensorConectado = false;

        public VentanaCaptura()
        {
            InitializeComponent();
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            if (!capturando)
            {
                if (KinectSensor.KinectSensors.Count > 0)
                {
                    kinectSensor = KinectSensor.KinectSensors[0];
                    KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
                }

                kinectSensor.Start();
                lblIdConexion.Text = kinectSensor.DeviceConnectionId;

                capturando = true;
                btnCaptura.Text = "Detener captura";

                kinectSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                kinectSensor.ColorFrameReady += KinectSensor_ColorFrameReady;
                kinectSensor.DepthFrameReady += KinectSensor_DepthFrameReady;
            }
            else
            {
                if (kinectSensor != null && kinectSensor.IsRunning)
                {
                    kinectSensor.Stop();
                    capturando = false;
                    btnCaptura.Text = "Iniciar captura";
                    pbCaptura.Image = null;
                }
            }
        }

        private void KinectSensor_DepthFrameReady(object sender, DepthImageFrameReadyEventArgs e)
        {
            using (var cuadro = e.OpenDepthImageFrame())
            {
                if (cuadro != null)
                {
                    pbCaptura.Image = cuadro.ToBitmap();
                }
            }
        }

        private void KinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var cuadro = e.OpenColorImageFrame())
            {
                if (cuadro != null)
                {
                    pbCaptura.Image = crearMapaDeBits(cuadro); 
                }
            }
        }

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            lblEstado.Text = kinectSensor.Status.ToString();
        }

        private Bitmap crearMapaDeBits(ColorImageFrame cuadro)
        {
            var datosPixeles = new byte[cuadro.PixelDataLength];
            cuadro.CopyPixelDataTo(datosPixeles);

            return datosPixeles.ToBitmap(cuadro.Width, cuadro.Height);

            //var salto = cuadro.Width * cuadro.BytesPerPixel;

            //var imagenBMP = new Bitmap(cuadro.Width, cuadro.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //var datosBMP = imagenBMP.LockBits(new Rectangle(0, 0, cuadro.Width, cuadro.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, imagenBMP.PixelFormat);

            //System.Runtime.InteropServices.Marshal.Copy(datosPixeles, 0, datosBMP.Scan0, cuadro.PixelDataLength);

            //imagenBMP.UnlockBits(datosBMP);

            //return imagenBMP;
        }
    }
}
