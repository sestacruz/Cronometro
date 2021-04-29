using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cronometro
{
    public class Chrono
    {
        private const int Interval = 1;
        private Timer Time = new Timer();
        private bool Setted = false;
        public Double Result { get; set; }

        public void SetChronometer()
        {
            Time.Tick += new EventHandler(Time_Tick);
            Time.Interval = Interval;
            Setted = true;
        }

        void Time_Tick(object sender, EventArgs e)
        {
            Result++;
        }

        void Time_Tick(object sender, EventArgs e, TextBox TimeInfo)
        {
            Result++;
            TimeInfo.Text = this.ToString();
        }

        public void Start()
        {
            if (!Setted)
                SetChronometer();
            Time.Start();
        }

        public void Stop()
        {
            Time.Stop();
        }

        public void ResetValue()
        {
            //Time.Dispose();
            //Time = new Timer();
            Result = 0;
        }
        public TimeSpan Value()
        {
            return TimeSpan.FromSeconds((Result * Interval) / 60);
        }
        public override string ToString()
        {
            //return string.Format(CultureInfo.CurrentCulture,"{0} ms",Result);
            //DateTime.FromOADate(Result).ToString("HH:mm:ss.fff");
            TimeSpan t = TimeSpan.FromSeconds((Result*Interval)/60);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                                 t.Hours,
                                 t.Minutes,
                                 t.Seconds);
        }
        public decimal ToDecimalValue()
        {
            TimeSpan t = TimeSpan.FromSeconds((Result * Interval) / 60);
            decimal hours = t.Hours,
                    minutes = decimal.Divide(t.Minutes, 60),
                    seconds = decimal.Divide(t.Seconds,3600);
            return decimal.Round(hours + minutes + seconds,2);

        }
    }
}