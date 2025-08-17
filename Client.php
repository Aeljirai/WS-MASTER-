<?php

    $wsdl = "http://localhost:9191?wsdl";

    $client = new SoapClient($wsdl);

    $result = $client->Convert(array('montant' => 120));
    echo "Montant: " . $result->return . "\n";
    $compte = $client->getCompte(array('code' => 1));
    echo "Compte Code: " . $compte->return->code . "\n";
    echo "Compte Solde: " . $compte->return->solde . "\n";

?>
