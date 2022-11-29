using WS.VisualizationUI.Model;

namespace WS.VisualizationUI
{
    public partial class Form1 : Form
    {
        private string deformationType;
        public Form1()
        {
            InitializeComponent();
            if (Program.signalRClient.IsConnected())
                SetResult(1);
            else
                SetResult(0);
        }

        private void pointDef_CheckedChanged(object sender, EventArgs e)
        {
            deformationType = "DEFP";
            bxCoordination.Visible = false;
            byCoordination.Visible = false;
            bxLabel.Visible = false;
            byLabel.Visible = false;
        }

        private void edgeDef_CheckedChanged(object sender, EventArgs e)
        {
            deformationType = "DEFT";
            bxCoordination.Visible = false;
            byCoordination.Visible = false;
            bxLabel.Visible = false;
            byLabel.Visible = false;
        }

        private void areaDef_CheckedChanged(object sender, EventArgs e)
        {
            deformationType = "DEFS";
            bxCoordination.Visible = true;
            byCoordination.Visible = true;
            bxLabel.Visible = true;
            byLabel.Visible = true;
        }

        private async void addDefBtn_Click(object sender, EventArgs e)
        {
            if (deformationType != null)
            {
                if (Program.signalRClient.IsConnected())
                {
                    SetResult(2);
                    Coordination coordination = new Coordination
                    {
                        Type = deformationType,
                        PointAX = (int)axCoordination.Value,
                        PointAY = (int)ayCoordination.Value,
                        PointBX = deformationType == "DEFS" ? (int)bxCoordination.Value : null,
                        PointBY = deformationType == "DEFS" ? (int)byCoordination.Value : null,
                    };
                    int result = await Program.signalRClient.SendDeformation(coordination);
                    SetResult(result);
                }
                else
                    SetResult(0);
            }
        }

        private async void createGlassBtn_Click(object sender, EventArgs e)
        {
            string serialNumber = serialNum.Text;
            if(serialNumber != null && serialNumber.Length > 0)
            {
                if (Program.signalRClient.IsConnected())
                {
                    SetResult(2);
                    int result = await Program.signalRClient.CreateGlass(serialNumber);
                    SetResult(result);
                }
                else
                    SetResult(0);
            }
        }

        private async void visualGlassBtn_Click(object sender, EventArgs e)
        {
            string serialNumber = serialNum.Text;
            if (serialNumber != null && serialNumber.Length > 0)
            {
                if (Program.signalRClient.IsConnected())
                {
                    SetResult(2);
                    int result = await Program.signalRClient.VisualGlass(serialNumber);
                    SetResult(result);
                }
                else
                    SetResult(0);
            }
        }

        private async void sendPackNumBtn_Click(object sender, EventArgs e)
        {
            string packNumber = packNum.Text;
            if (packNumber != null && packNumber.Length > 0)
            {
                if (Program.signalRClient.IsConnected())
                {
                    SetResult(2);
                    int result = await Program.signalRClient.SendPackNumber(packNumber);
                    SetResult(result);
                }
                else
                    SetResult(0);
            }
        }

        private async void sendCodeBtn_Click(object sender, EventArgs e)
        {
            string codeText = code.Text;
            if (codeText != null && codeText.Length > 0)
            {
                if (Program.signalRClient.IsConnected())
                {
                    SetResult(2);
                    int result = await Program.signalRClient.SendCode(codeText);
                    SetResult(result);
                }
                else
                    SetResult(0);
            }
        }

        private async void deleteLastDeformBtn_Click(object sender, EventArgs e)
        {
            if (Program.signalRClient.IsConnected())
            {
                SetResult(2);
                int result = await Program.signalRClient.DeleteLastDeformation();
                SetResult(result);
            }
            else
                SetResult(0);
        }
        
        public void SetResult(int result)
        {
            switch (result)
            {
                case 0:
                    SignalRBut.BackColor = Color.Red;
                    break;
                case 1:
                    SignalRBut.BackColor = Color.Green;
                    break;
                case 2:
                    SignalRBut.BackColor = Color.Orange;
                    break;
                default:
                    break;
            }
        }
    }
}