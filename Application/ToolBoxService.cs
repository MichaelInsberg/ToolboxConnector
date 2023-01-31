using System.Collections.Concurrent;
using System.ServiceModel;
using Jet.Toolbox;

namespace Application;

/// <summary>
/// The ToolBoxService class
/// </summary>
public sealed class ToolBoxService
{
    private readonly ToolboxServiceClient toolbox;
    private readonly ConcurrentDictionary<string, maschineDto> machines;

    /// <summary>
    /// Gets the machines
    /// </summary>
    // ToDo 4Jet Maschinen Klasse mit Translator
    public IReadOnlyDictionary<string, maschineDto> Machines => machines;

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
        machines = new ConcurrentDictionary<string, maschineDto>();
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

        var machinesResponse = await toolbox.getMachinesAsync(new getMachinesRequest()).ConfigureAwait(false);
        var machinesResponseReturn = machinesResponse.@return;
        machines.Clear();
        foreach (var machineData in machinesResponseReturn)
        {
            machines.AddOrUpdate(machineData.MachineNumber, machineData, (_, dto) => dto);
        }
    }
}
