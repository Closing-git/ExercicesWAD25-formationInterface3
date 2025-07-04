
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="./ex5-form-traitement.php" method="post">
        Nom <input type="text" name="nom">
        Mail <input type="email" name="email">
        Mdp <input type="password" name="password">
        Mdp confirm <input type="password" name="passwordConfirmation">
        <input type="submit" value="Envoyer">
    </form>
    <?php
    if (isset ($_GET['listeErreurs'])){
        $listeErreurs = $_GET['listeErreurs'];
        print($listeErreurs);
    }
    ?>
</body>
</html>