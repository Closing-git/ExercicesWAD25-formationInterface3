<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./forms_ex8_traitement.php" method="POST">
        <label for="pays">Pays :</label>
        <select name="pays" id="pays">
            <?php
            $arr_pays = [
                "Belgique",
                "France",
                "Espagne",
                "Portugal",
            ];
            foreach ($arr_pays as $pays)
                echo ('<option value="' . $pays . '">' . $pays . '</option>');
            ?>
        </select>
        <label for="langue">Langue de la page wikipedia</label>
        <select name="langue" id="langue">
            <option value="fr">Français</option>
            <option value="de">Deutsch</option>
            <option value="en">English</option>
            <option value="es">Espanõl</option>
        </select>

        <input type="submit" value="Chercher et afficher page Wikipedia">
    </form>

</body>

</html>