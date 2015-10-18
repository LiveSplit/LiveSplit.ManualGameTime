using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Windows.Forms;

namespace LiveSplit.ManualGameTime.UI.Components
{
    public partial class ShitSplitter : Form
    {
        protected ITimerModel Model { get; set; }
        protected ManualGameTimeSettings Settings { get; set; }

        public ShitSplitter(LiveSplitState state, ManualGameTimeSettings settings)
        {
            InitializeComponent();
            Model = new TimerModel()
            {
                CurrentState = state
            };
            Settings = settings;
        }

        private void txtGameTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    var timeSpans = txtGameTime.Text.Replace(" ", "").Split('+');
                    var totalTime = TimeSpan.Zero;
                    foreach (var time in timeSpans)
                    {
                        totalTime += TimeSpanParser.Parse(time);
                    }

                    var newGameTime = totalTime + (Settings.UseSegmentTimes ? Model.CurrentState.CurrentTime.GameTime : TimeSpan.Zero);
                    Model.CurrentState.SetGameTime(newGameTime);
                    Model.Split();
                    txtGameTime.Text = "";
                }
                catch { }
            }
        }
    }
}
