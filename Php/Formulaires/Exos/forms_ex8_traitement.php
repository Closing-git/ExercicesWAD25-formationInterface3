<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $nb_tva=intval($_POST["tva"]);

    if ($nb_tva == 12) {
        $nb_tva=12.5;
    }

    print("<p>Prix HTVA : " . $_POST["nb_user"] . "</p><p>Prix TVAC : " . round($_POST["nb_user"]*((100+$nb_tva)/100), 2)) . "</p>";
    ?>
</body>
</html>