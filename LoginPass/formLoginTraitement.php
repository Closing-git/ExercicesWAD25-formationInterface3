<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    //Obtenir les données
    $email = $_POST['email'];
    $password = $_POST['password'];


    //Chercher user dans la DB et comparer les passwords
    include "./db/config.php";
    try {
        $cnx = new PDO(DSN, USER, PASSWORD);
    } catch (Exception $e) {
        echo $e->getMessage();
        die();
    }

    $sql = "SELECT nom, email, password FROM stagiaire WHERE email=:email";

    $stmt = $cnx->prepare($sql);
    $stmt->bindValue(":email", $email);
    $stmt->execute();
    $res = $stmt->fetch(PDO::FETCH_ASSOC);

    if ($res === false) {
        //L'utilisateur n'existe pas
        echo "<p> L'utilisateur n'existe pas </p>";
        echo "<a href=./formInscription.php>Inscription </a>";
        echo "<a href=./formLogin.php>Réessayer </a>";
    } else {
        $password_db = $res['password'];
        if (password_verify($password, $password_db)) {
            echo "<p> Bon mdp </p>";
        } else {
            echo "<p>Mauvais mdp</p>";
        }
    }

    var_dump($stmt->errorInfo());
    var_dump($res)



    ?>
</body>

</html>