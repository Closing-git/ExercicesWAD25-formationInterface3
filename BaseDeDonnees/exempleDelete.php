<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include "./db/config.php";

    $cnx = new PDO (DSN, USER, PASSWORD);

    $sql="DELETE FROM stagiaire WHERE nom=:nom";

    $stmt = $cnx->prepare($sql);

    $stmt->bindValue("nom", "Paul", PDO::PARAM_STR);

    $stmt->execute();

    var_dump($stmt->errorInfo())



    ?>
</body>
</html>