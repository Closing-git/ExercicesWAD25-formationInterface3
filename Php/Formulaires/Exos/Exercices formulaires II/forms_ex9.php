<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>

    <?php

    $arr_pays = [
        "Maroc",
        "Mexique",
        "Espagne",
        "Belgique",
        "Angleterre",
        "Hollande",
        "Norvège",
        "Islande",
        "Finlande",
    ];

    ?>

    <form action="./forms_exo9_traitement.php" method="POST">
        <label for="pays">
            <select name="pays" id="pays"></label>

                <?php
                sort($arr_pays);
                foreach ($arr_pays as $pays) {

                    echo ('<option value="' . $pays . '">' . $pays . '</option>');
                }
                ?>
            </select>
        <input type="submit" value="Quel temps ?">

    </form>
</body>

</html>