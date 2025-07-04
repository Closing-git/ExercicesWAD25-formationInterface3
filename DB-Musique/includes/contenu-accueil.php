<?php

//Obtenir les groupes

include "./db/config.php";

$cnx = new PDO(DSN, USER, PASSWORD);

$sql = "SELECT * FROM groupes ORDER BY RAND() LIMIT 5";

$stmt = $cnx->prepare($sql);
$stmt->execute();
//Stocker le résultat dans un array
$res = $stmt->fetchAll(PDO::FETCH_ASSOC);
// var_dump($res);


// Afficher les groupes avec des cartes

foreach ($res as $key=>$arrayGroupe){
    print('<div class="card" style="width: 18rem;">');
    print('<img class="card-img-top" src="./img/' . $arrayGroupe["lienImage"] . '" alt="Card image cap">');
    print('<div class="card-body">');
    print('<h5 class="card-title">' . $arrayGroupe['nom'] . ' </h5>');
    print('<p class="card-text">Formé en ' . $arrayGroupe['annee_formation'] . '. </p>');
    print('<a href="./includes/affichageMorceaux.php?idGroupe=' . $arrayGroupe["id"] . ' " class="btn btn-primary">Plus d\'infos</a>');
    print('</div>');
    print('</div>');

}

