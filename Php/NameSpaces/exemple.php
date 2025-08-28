<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include "./classes/AutresClasses/Produit.php";
    include "./classes/Magasin/Produit.php";

    use Magasin\Produit as MagasinProduit;
    use AutresClasses\Produit as AutresClassesProduit;

    $prodMag = new MagasinProduit(1, "Produit 1", 10,1);
    $prodAutre = new AutresClassesProduit(2, "Produit 2", 20);

    $prodMag->afficher();
    $prodAutre->afficher();
    ?>
</body>
</html>