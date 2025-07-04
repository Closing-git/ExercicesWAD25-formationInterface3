<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple Insert</title>
</head>

<body>
    <?php
    include "./db/config.php";

    $cnx = new PDO(DSN, USER, PASSWORD);

    $sql = "INSERT INTO stagiaire (id, nom, dateNaissance, hobby) VALUES " . "(null, :nom, :dateNaissance, :hobby)" ; 

    $stmt = $cnx->prepare($sql);

    $stmt->bindValue(":nom", "Chloé");
    $dateNaissance= new DateTime("3-11-1991");
    $dateNaissanceString=$dateNaissance->format("Y-m-d");
    print($dateNaissanceString);
    $stmt->bindValue(":dateNaissance", $dateNaissanceString);
    $stmt->bindValue(":hobby", "Danser");

    $stmt->execute();

    ?>
</body>

</html>