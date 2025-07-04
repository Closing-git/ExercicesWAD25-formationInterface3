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
    $email = $_POST['email'];
    $password = $_POST['password'];
    $passwordConfirmation = $_POST['passwordConfirmation'];

    $erreurs = "";


    if ($password != $passwordConfirmation) {
        $erreurs = $erreurs . "<p>Le password n'est pas le même. </p>";
    }

    if (mb_strlen($password) < 8) {
        $erreurs = $erreurs . "Mdp trop court, il faut au moins 8 caractères";
    }

    print("Ici enregistre");

    if (mb_strlen($erreurs) > 0) {
        header("location: ./ex5-form.php?listeErreurs=" . $erreurs);
    }





    ?>
</body>

</html>