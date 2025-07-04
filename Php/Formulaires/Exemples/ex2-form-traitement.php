<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    print("<h2>Vous avez choisi le " . $_GET["periode"] . ", merci !");

    if (isset($_GET["voiture"])){
        print("Vous avez une voiture.");
    }
    ?>

</body>

</html>