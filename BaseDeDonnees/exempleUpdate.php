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

    $cnx = new PDO(DSN, USER, PASSWORD);
    $sql = "UPDATE stagiaire SET nom =:new_name WHERE nom=:old_nom";

    $stmt = $cnx->prepare($sql);

    $old_name="Sarah";
    $new_name="Carine";
    $stmt->bindValue("old_nom", $old_name, PDO::PARAM_STR);
    $stmt->bindValue("new_name", $new_name, PDO::PARAM_STR);

    $stmt->execute();

    var_dump($stmt->errorInfo());

    ?>
</body>

</html>