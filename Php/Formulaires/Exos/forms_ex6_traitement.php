<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php

    $nb_user=intval($_GET['nb_user']);

    print("<p>Prix HTVA : ". $nb_user . "</p> <p>Prix TVAC : " . $nb_user*112/100 . "</p>");

?>
</body>
</html>