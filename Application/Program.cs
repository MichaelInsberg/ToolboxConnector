// See https://aka.ms/new-console-template for more information

using ServiceReference1;


try
{
    var toolbox = new ToolboxServiceClient();
    toolbox.Open();
    var machinesRequest = new getMachinesRequest();
    var machine = toolbox.getMachines(machinesRequest);
    Console.WriteLine(machine);
}
catch (System.Exception e)
{
    Console.WriteLine(e);
}

Console.ReadLine();


