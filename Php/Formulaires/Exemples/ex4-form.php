<!DOCTYPE html>
<html lang="fr-be">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple 4</title>
</head>

<body>
    <?php
    $categories = [
        "Jeux",
        "Livres",
        "Jardin",
        "Electroménager",
        "Sport",
        "Hygiène"
    ];
    ?>


    <form action="./ex4-form-traitement.php" method="POST">
        <select name="categorie">
            <?php

            foreach ($categories as $categorie) {
                // print("<option value ='" . $categorie . "'>" . $categorie . "</option>");
                print("<option value='{$categorie}' > {$categorie} </option>");

            }


            ?>
        </select>

        <input type="search" name="product" placeholder="Chercher un produit">
        <input type="submit" value="Search">

    </form>



</body>

</html>