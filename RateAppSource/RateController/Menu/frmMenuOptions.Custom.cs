using System;
using System.Drawing;
using System.Windows.Forms;

namespace RateController.Menu
{
    public partial class frmMenuOptions
    {
        private TrackBar trackZoneTransparency;
        private TrackBar trackTargetTransparency;
        private Label lblZoneTransparency;
        private Label lblTargetTransparency;

        private void InitializeTransparencyControls()
        {
            this.trackZoneTransparency = new TrackBar();
            this.trackTargetTransparency = new TrackBar();
            this.lblZoneTransparency = new Label();
            this.lblTargetTransparency = new Label();

            this.trackZoneTransparency.Minimum = 0;
            this.trackZoneTransparency.Maximum = 255;
            this.trackZoneTransparency.TickFrequency = 10;
            this.trackZoneTransparency.Size = new Size(220, 45);
            this.trackZoneTransparency.Location = new Point(40, 540);
            this.trackZoneTransparency.Scroll += new EventHandler(this.trackZoneTransparency_Scroll);

            this.trackTargetTransparency.Minimum = 0;
            this.trackTargetTransparency.Maximum = 255;
            this.trackTargetTransparency.TickFrequency = 10;
            this.trackTargetTransparency.Size = new Size(220, 45);
            this.trackTargetTransparency.Location = new Point(270, 540);
            this.trackTargetTransparency.Scroll += new EventHandler(this.trackTargetTransparency_Scroll);

            this.lblZoneTransparency.AutoSize = true;
            this.lblZoneTransparency.Location = new Point(40, 510);
            this.lblZoneTransparency.Name = "lblZoneTransparency";
            this.lblZoneTransparency.Text = "Zone transparency";

            this.lblTargetTransparency.AutoSize = true;
            this.lblTargetTransparency.Location = new Point(270, 510);
            this.lblTargetTransparency.Name = "lblTargetTransparency";
            this.lblTargetTransparency.Text = "Target transparency";

            this.Controls.Add(this.lblZoneTransparency);
            this.Controls.Add(this.lblTargetTransparency);
            this.Controls.Add(this.trackZoneTransparency);
            this.Controls.Add(this.trackTargetTransparency);
        }

        private void trackZoneTransparency_Scroll(object sender, EventArgs e)
        {
            lblZoneTransparency.Text = $"Zone transparency: {trackZoneTransparency.Value}";
            SetButtons(true);
        }

        private void trackTargetTransparency_Scroll(object sender, EventArgs e)
        {
            lblTargetTransparency.Text = $"Target transparency: {trackTargetTransparency.Value}";
            SetButtons(true);
        }
    }
}
