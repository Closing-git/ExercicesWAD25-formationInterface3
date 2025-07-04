<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ex3 - Traitement</title>
</head>

<body>
    <?php
    var_dump($_POST);
    print("<p>Bonjour " . $_POST["nom"] . " " . $_POST['prenom']);
    ?>
</body>

</html>