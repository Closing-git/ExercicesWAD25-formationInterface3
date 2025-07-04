<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Info morceaux</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.7/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-LN+7fdVzj6u52u30Kp6M/trliBMCMKTyK833zpbD+pXdCLuTusPj697FH4R/5mcr" crossorigin="anonymous">
    <link rel="stylesheet" href="../style/style.css">
</head>

<body>

    <?php

    //Récupérer l'id du groupe cliqué :
    $idGroupe = $_GET["idGroupe"];


    //Récupérer les morceaux

    include "../db/config.php";
    $cnx = new PDO(DSN, USER, PASSWORD);

    $sql = "SELECT * FROM morceaux WHERE groupe_id=:groupe_id";

    $stmt = $cnx->prepare($sql);
    $stmt->bindValue("groupe_id", $idGroupe, PDO::PARAM_INT);
    $stmt->execute();
    $res = $stmt->fetchAll(PDO::FETCH_ASSOC);

    print("<div class=content-morceau>");
    foreach ($res as $key => $morceau) {
        print("<div class='titre-morceau'>");
        print("<h3>" . $morceau['titre'] . "</h3");
        print("<h3> - " . $morceau['annee_sortie'] . "</h3>");
        print("</div>");
    }
    print("</div>");
    
    ?>

</body>

</html>