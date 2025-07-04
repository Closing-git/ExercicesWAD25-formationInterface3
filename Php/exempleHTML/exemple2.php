<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple 2</title>
</head>
<body>
    
    <?php
    $produits = [
        'ananas' => 4,
        'potirons' => 6,
        'radis' => 2,
    ];

    foreach ($produits as $nom => $prix){
        print("<p> Les $nom coûtent $prix euros. </p>");
    }

    ?>
</body>
</html>