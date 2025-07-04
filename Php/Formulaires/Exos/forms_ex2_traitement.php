<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Salutations !</h1>

    <?php

    $prenom = trim(mb_strtolower($_GET['prenom']));
    $nom = trim(mb_strtolower($_GET['nom']));


    
    if ($nom == "fersing" and $prenom == "chloé") {
        print("<p> Que la force soit avec vous </p>");
        print("<a target=_blank href='https://www.starwars.com'>Star wars </a> ");
    }
    // if (strtoupper($_GET['nom']) == "FERSING" and (strtoupper($_GET['prenom']) == "CHLOE" or strtolower($_GET['prenom']) == "chloé")) {
    //     print("<p> Que la force soit avec vous </p>");
    //     print("<a target=_blank href='https://www.starwars.com'>Star wars </a> ");
    // }
    ?>
</body>

</html>