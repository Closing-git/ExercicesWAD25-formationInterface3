<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    include "./connexion/db.php";

    require_once "./classes/FilmManager.php";
    try {
        $cnx = new PDO(DSN, DBUSER, DBPASS);
    } catch (Exception $e) {
        // jamais en production car ça montre des infos
        // sensibles
        echo $e->getMessage();
        die();
    }


    $filmManager = new FilmManager($cnx);

    $film1 = new Film("Titanic", 120, "Un film sur un bateau", new DateTime("2025-11-25"));
    $film2 = new Film("Histoire", 100, "Un film sur une histoire", new DateTime("2019-01-22"));

    // $filmManager->insert($film1);
    // $filmManager->insert($film2);

    // $filmManager->delete($film1);

    $filmManager->select([
        'titre'=>"Histoire",
        'duree'=>100
        ]);
    ?>

</body>

</html>