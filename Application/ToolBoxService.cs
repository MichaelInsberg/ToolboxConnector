using System.ServiceModel;
using Jet.Toolbox;

namespace Application;

/// <summary>
/// The ToolBoxService class
/// </summary>
public sealed class ToolBoxService
{
    private readonly ToolboxServiceClient toolbox;

    /// <summary>
    /// Gets the machines
    /// </summary>
    // ToDo 4Jet Maschinen Klasse mit Translator
    public IReadOnlyCollection<maschineDto> Machines { get; private set; }

    /// <summary>
    /// Gets the state
    /// </summary>
    public CommunicationState State => toolbox.State;
    public bool IsConnected => toolbox.State == CommunicationState.Opened;

    /// <summary>
    /// Create a new instance of ToolBoxService
    /// </summary>
    public ToolBoxService()
    {
        toolbox = new ToolboxServiceClient();
    }

    public Task ConnectAsync()
    {
        //TOdo better exception??
        return IsConnected 
            ? Task.CompletedTask 
            : toolbox.OpenAsync();
    }

    public Task DisConnect()
    {
        //TOdo better exception??
        return !IsConnected
            ? Task.CompletedTask 
            : toolbox.CloseAsync();
    }

    public async Task ReadMachinesAsync()
    {
        if (!IsConnected)
        {
            throw new ToolBoxException($"{nameof(ToolBoxService)} is not connected");
        }
        var machinesRequest = new getMachinesRequest();
        var machinesResponse = await toolbox.getMachinesAsync(machinesRequest).ConfigureAwait(false);
        var machines = machinesResponse.@return;
        Machines = new List<maschineDto>(machines);
    }
}

