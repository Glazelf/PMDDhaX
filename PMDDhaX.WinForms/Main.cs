using PMDDhaX.Common;
using PMDDhaX.Injection;
using SysBot.Base;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace PMDDhaX.WinForms
{
    public partial class Main : Form
    {
#pragma warning disable CA1416 // Do not catch Win7 warning

        private static readonly string WorkingDirectory = Application.StartupPath;
        //private static readonly string ConfigPath = Path.CombineArrays(WorkingDirectory, "config.json");

        ulong OffsetPointsTotal;
        ulong OffsetPointsTotal2;

        public Main()
        {
            InitializeComponent();
        }

        public Injector SwitchInjector = new Injector();
        readonly SwitchConnectionConfig cfg = new SwitchConnectionConfig();
        readonly PointerHandler PointerHandler = new PointerHandler();
        public bool Connected = false;
        public ISwitchConnectionSync sb;

        // Declare offsets


        public void SysBotUI_Load(object sender, EventArgs e)
        {

        }

        // sb and getting values
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == false)
            {
                // Connect button behaviour
                cfg.IP = TextBoxIP.Text;
                cfg.Port = Port;
                sb = cfg.CreateSync();
                sb.Connect();

                ReloadValues();
                // Toggle buttons and fields
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;
                ButtonSysbotRead.Enabled = true;
                PointsTotalNumeric.Enabled = true;

                StatusConnection.ForeColor = Color.Green;
                StatusConnection.Text = "Connected";
                Connected = true;
                ButtonConnect.Text = "Disconnect";
                SysBotLog.Text += Environment.NewLine + "Successfully connected.";
            }
            else
            {
                // Disconnect button behaviour
                sb.Disconnect();
                // Toggle buttons and fields
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;
                ButtonSysbotRead.Enabled = false;
                PointsTotalNumeric.Enabled = false;

                StatusConnection.ForeColor = Color.Red;
                StatusConnection.Text = "Disconnected";
                Connected = false;
                ButtonConnect.Text = "Connect";
                SysBotLog.Text += Environment.NewLine + "Successfully disconnected.";
            }
        }
        private void ButtonSysbotRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void PointsTotalNumeric_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)PointsTotalNumeric.Value, OffsetPointsTotal, sb);
            BytesHandler.WriteFloat((float)PointsTotalNumeric.Value, OffsetPointsTotal2, sb);
        }

        private void ReloadValues()
        {
            //// Get offsets from pointers

            //// Read values from offsets
            OffsetPointsTotal = DataOffsets.OffsetPointsTotal;
            OffsetPointsTotal2 = DataOffsets.OffsetPointsTotal2;
            uint PointsTotal = sb.ReadBytesAbsolute(OffsetPointsTotal, 1)[0];
            PointsTotalNumeric.Value = PointsTotal;

            SysBotLog.Text += Environment.NewLine + "Successfully loaded values.";
        }
    }
}