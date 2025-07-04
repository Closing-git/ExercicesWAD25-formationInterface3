<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple Select mySQL</title>
</head>

<body>
    <?php
    // Inclure la config
    include "./db/config.php";

    // Créer un objet PDO avec la config + gestion erreur
    try {
        $cnx = new PDO(DSN, USER, PASSWORD);
    } catch (Exception $exceptionDB) {
        echo "<h3> Impossible de connecter à la DB </h3>";
        echo $exceptionDB->getMessage();

        die();
    }

    // Créer la requête
    $sql = "SELECT nom, hobby FROM stagiaire";

    // Préparer la requête
    $stmt = $cnx->prepare($sql);

    //Lancer la requête
    $stmt->execute();

    // Mettre les résultats dans un array (choisir le format)
    $res = $stmt->fetchAll(PDO::FETCH_ASSOC);

    //Afficher résultats
    var_dump($res);

    print("<ul>");

    // foreach ($res as $key => $stagiaire) {
    //     foreach($stagiaire as $value){
    //         print("<li>" . $value .  "</li>");
    //     }
    // }
    foreach ($res as $key => $stagiaire) {
        print("<li>" . $stagiaire["nom"] . "</li>");
    }

    print("<ul>");


    //JSON
    //Encoder en json -> Transformer un objet ou un array en string JSON
    $songs = ["Bad", "Beat it", "Thriller"];
    $personne = [
        'nom' => "Chloé",
        'hobby' => 'danser',
        'adresse' => 'Bruxelles'
    ];
    $uneDate = new DateTime();
    $people = [$personne, $personne, $personne];


    print(json_encode($songs));
    print(json_encode($uneDate));
    print(json_encode($personne));
    print(json_encode($people));

    //Interpréter un jon -> Interpreter un string Js et créer l'objet, l'array ou l'array d'objet

    ?>

    <script>
        let songs = ["Bad", "Beat it", "Thriller"]
        let personne = {
            'nom': "Chloé",
            'hobby': 'danser',
            'adresse': 'Bruxelles'
        }

        console.log(JSON.stringify(personne))
        console.log(JSON.stringify(songs))

        let film = '{"nom":"Alien", "duree":"130"}'
        console.log(JSON.parse(film))
    </script>









    ?>


</body>

</html>