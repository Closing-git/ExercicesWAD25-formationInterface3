<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    var_dump($_POST);

    //Récupérer les données du form
    $nom = $_POST["nom"];
    $email = $_POST["email"];
    $password = $_POST["password"];
    $confirmPassword = $_POST["confirmPassword"];
    $dateNaissance =$_POST["dateNaissance"];
    $hobby =$_POST["hobby"];


    //Nettoyer et vérifier les données

    //L'inclure dans DB

    //Inclure config de db
    include "./db/config.php";

    //Connecter la DB
    try {
        $cnx = new PDO(DSN, USER, PASSWORD);
    } catch (Exception $e) {
        echo $e->getMessage();
        die();
    }

    //Créer la requête INSERT
    $sql = "INSERT INTO stagiaire (id, email, nom, dateNaissance, hobby, password) VALUES (null, :email, :nom, :dateNaissance, :hobby, :password) ";

    //Prép la requête
    $stmt = $cnx->prepare($sql);

    //Bindvalue
    $stmt -> bindValue(":nom", $nom);
    $stmt -> bindValue(":email", $email);
    $stmt -> bindValue(":dateNaissance", (new DateTime())->format("Y-m-d"));
    $stmt -> bindValue(":hobby", $hobby);
    $stmt -> bindValue(":password", password_hash($password, PASSWORD_DEFAULT));
    $stmt -> bindValue(":dateNaissance", $dateNaissance);



    //Lancer la requête
    $stmt->execute();

    //Vérifier les erreurs
    var_dump($stmt->errorInfo());
    ?>
</body>

</html>