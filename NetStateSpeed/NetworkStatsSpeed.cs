using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NetStateSpeed
{
    public partial class NetworkStatsSpeed : Form
    {

        private System.Windows.Forms.Timer timer;
        private const double timerUpdate = 1000;
        private TraficModel trafic = new TraficModel();
        private static Producer producer = new Producer();
        private DataTranslation translate = new DataTranslation();
        private string host = producer.hostProduser;
        private InitializeNetworkInterface initializeNetworkInterface = new InitializeNetworkInterface();



        public NetworkStatsSpeed()
        {
            InitializeComponent();
            initializeNetworkInterface.InitializAllInterface(cmbInterface);
            RunTimer();

        }

        //таймер повторный вызов с интервалом в 1 секунду
        private void RunTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        //получение данных, что небходимо вызвать
        private void Timer_Tick(object sender, EventArgs e)
        {

            DataOutput();

            if (trafic.controller)
            {
                GetCartesianChart();

                trafic.controller = false;
            }
        }


        


        private void DataOutput()
        {
            //присвоение значения label

            var upData = new GetValueNetworkInterface();

            upData.UpdateNetworkInterface(cmbInterface, trafic);

            lblInterfaceType.Text = trafic.nameInterface;

            lblSpeed.Text = trafic.SpeedInterface.ToString();

            lblBytesReceived.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesReceived).ToString();

            lblBytesSent.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesSent).ToString();

            lblUpload.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesSentSpeedCurrent).ToString();

            lblDownload.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesReceivedSpeedCurrent).ToString();

            lblDownloadInSec.Text = translate.ValueTranslate(cmbTranslateData, trafic.downloadBytes).ToString();

            lblUploadInSec.Text = translate.ValueTranslate(cmbTranslateData, trafic.uploadBytes).ToString();

        }


        


        private async void GenerationData()
        {
            //Вызвать методы асинхронно и записать в пустой список

            var repeat = 1;
            var bandwidthCalculation = new BandwidthCalculation();
            var resSpeed = 0.0;
            try
            {
               await Task.Run(() =>
                {
                    //записать результат вычесления скорости в массив

                    for (int i = 0; i < repeat; i++)
                    {
                        resSpeed = bandwidthCalculation.GetDownloadSpeed(trafic);
                        trafic.downloadBytes = resSpeed;

                        trafic.MeasurementsSpeedReceived.Add(resSpeed);
                        resSpeed = 0.0;

                    }
                    trafic.MeasurementsSpeedAvgReceived = trafic.MeasurementsSpeedReceived.Average();

                   // trafic.downloadBytes = trafic.MeasurementsSpeedAvgReceived;

                    for (int i = 0; i < repeat; i++) 
                    {
                        resSpeed = bandwidthCalculation.GetUploadSpeed(trafic);
                        trafic.uploadBytes = resSpeed;

                        trafic.MeasurementsSpeedSent.Add(resSpeed);
                        resSpeed = 0.0;
                    }
                    trafic.MeasurementsSpeedAvgSent = trafic.MeasurementsSpeedSent.Average();

                    //trafic.uploadBytes = trafic.MeasurementsSpeedAvgSent;

                    trafic.controller = true;
                    trafic.btncontroller = false;
                });

            }
            catch (Exception ex) 
            {
                lblError.Text = ex.Message.ToString();
            }
                
        }

        private void CheckPing()
        {
            //результат проверки задержки клиент-сервер
            try
            {
                var ping = new CheckPacketDelay();
                var rez = ping.CheckPing(host);
                checkPing.Text = rez.ToString() + " ms";

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }

        private void GetCartesianChart() 
        {
            // все значения в массиве необходимо привести к выбранной еденице измерения
            var measurementsSpeedReceived = trafic.MeasurementsSpeedReceived;
            var measurementsSpeedSent = trafic.MeasurementsSpeedSent;

            var measurementsSpeedReceivedGetTranslation = new List<double>();
            var measurementsSpeedSentGetTranslation = new List<double>();

            for (int i = 0; i < measurementsSpeedReceived.Count; i++) 
            {
                measurementsSpeedReceivedGetTranslation.Add(translate.ValueTranslate(cmbTranslateData, measurementsSpeedReceived[i]));
                measurementsSpeedSentGetTranslation.Add(translate.ValueTranslate(cmbTranslateData, measurementsSpeedSent[i]));
            }

            // вызвать метод построения графика
            var buildGraph = new BuildGraph();
            buildGraph.BuildGraphSpeed(measurementsSpeedReceivedGetTranslation, measurementsSpeedSentGetTranslation, cartesianChart1);

        }


        private void buttonCheckSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (trafic.btncontroller == false)
                {
                    trafic.btncontroller = true;

                    CheckPing();

                    GenerationData();

                }
                else
                {
                    MessageBox.Show("Необходимо подождать");
                }
            }
            catch(Exception ex) 
            {
                lblError.Text = ex.Message.ToString();
            }
            



            
        }

        


        private void lblBytesReceived_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBytesSent_Click(object sender, EventArgs e)
        {

        }

        private void cmbTranslateData_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
