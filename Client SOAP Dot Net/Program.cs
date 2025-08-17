using ServiceReference;

class Program
{
    static async Task Main(string[] args)
    {
        BanqueServiceClient stub = new BanqueServiceClient();

        var convertResponse = await stub.ConvertAsync(120);
        Console.WriteLine($"Montant: {convertResponse.@return}");

        var getCompteResponse = await stub.getCompteAsync(1);
        Compte compte = getCompteResponse.@return;

        Console.WriteLine($"Compte Code: {compte.code}");
        Console.WriteLine($"Compte Solde: {compte.solde}");
        
    }
}
