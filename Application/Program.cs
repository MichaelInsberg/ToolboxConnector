// See https://aka.ms/new-console-template for more information

using Jet.Toolbox;


var toolbox = new ToolboxServiceClient();
try
{

    try
    {
        await toolbox.OpenAsync();
        Console.WriteLine($"State is: {toolbox.State}");
        var machinesRequest = new getMachinesRequest();
        Console.WriteLine(machinesRequest);

        var machinesResponse = await toolbox.getMachinesAsync(machinesRequest);

        var machines = machinesResponse.@return;
        Console.WriteLine($"{machines.Length} machines received");

        foreach (var machine in machines)
        {
            Console.WriteLine($"Machine: Product: {machine.Product} | MachineNumber {machine.MachineNumber}");
        }

        //var versionInfoRequest = new saveVersionInfoRequest();
        //versionInfoRequest.arg0.MachineNumber = machines[0].MachineNumber;
        //versionInfoRequest.arg0.WindowsVersion = "Funny version";

        //await toolbox.saveVersionInfoAsync(versionInfoRequest);
    }
    catch (System.Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }

}
finally
{
    
    await toolbox.CloseAsync();
    Console.WriteLine($"State is: {toolbox.State}");
}

Console.ReadLine();


