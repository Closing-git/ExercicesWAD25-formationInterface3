<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Page de traitement</title>
</head>

<body>
    <?php
    foreach ($_GET as $key=> $value){
        print("<p> " . $key . " est " . $value . "</p>");
    }

    if ($_GET['age']<18){
        print("<h2>" . $_GET["nom"] . ", vous êtes mineur-e. </h2>");
    }
    else {
        print("<h2>" . $_GET["nom"] . ", vous êtes majeur-e. </h2>");
    }

    ?>
</body>

</html>