#region Using directives
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.SerialPort;
using FTOptix.MicroController;
using FTOptix.CommunicationDriver;
using FTOptix.RAEtherNetIP;
using FTOptix.DataLogger;
using FTOptix.Store;
using FTOptix.InfluxDBStoreLocal;
using FTOptix.InfluxDBStore;
using FTOptix.WebUI;
#endregion

public class ApplicationNameLogic : BaseNetLogic
{
    public override void Start()
    {
        Label label = Owner as Label;
        label.Text = Project.Current.BrowseName;
    }

    public override void Stop()
    {
    }
}
