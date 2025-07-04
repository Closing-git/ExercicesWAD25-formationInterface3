<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple Filtre</title>
</head>

<body>
    <?php
    include "./db/config.php";

    $cnx = new PDO(DSN, USER, PASSWORD);

    $sql = "SELECT nom, hobby FROM stagiaire WHERE stagiaire.hobby=:hobby" ; 

    $stmt = $cnx->prepare($sql);
    $stmt->bindValue(":hobby", "danser");

    $stmt->execute();

    $res = $stmt->fetchAll(PDO::FETCH_ASSOC);

    var_dump($res);

    ?>
</body>

</html>