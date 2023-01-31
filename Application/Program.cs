// See https://aka.ms/new-console-template for more information

using Application;

var toolbox = new ToolBoxService();
try
{
    await toolbox.ConnectAsync().ConfigureAwait(false);
    Console.WriteLine($"State is: {toolbox.State}");
    await toolbox.ReadMachinesAsync().ConfigureAwait(false);

    await toolbox.ReadMachinesAsync().ConfigureAwait(false);

        
    foreach ((var _, var machine) in toolbox.Machines)
    {
        Console.WriteLine($"Machine: Product: {machine.Product} | MachineNumber {machine.MachineNumber}");
    }

    //var versionInfoRequest = new saveVersionInfoRequest();
    //versionInfoRequest.arg0.MachineNumber = machines[0].MachineNumber;
    //versionInfoRequest.arg0.WindowsVersion = "Funny version";

    //await toolbox.saveVersionInfoAsync(versionInfoRequest);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}
finally
{
    
    await toolbox.DisConnect().ConfigureAwait(false);
    Console.WriteLine($"State is: {toolbox.State}");
}

Console.WriteLine("Press any key to close");
Console.ReadLine();


