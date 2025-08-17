import proxy.BanqueService;
import proxy.BanqueWs;
import proxy.Compte;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stub = new BanqueWs().getBanqueServicePort();
        System.out.println(stub.convert(120));
        Compte compte = stub.getCompte(1);
        System.out.println(compte.getCode());
        System.out.println(compte.getSolde());
    }
}
