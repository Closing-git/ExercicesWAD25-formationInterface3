<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple 1</title>
</head>

<body>
    <h1>BONJOUR !</h1>
    <p id="paragraphe-1">Je suis une page hébergée sur l'ordinateur de <?php $names = array("Akwa", "Chloé", "Orsula");
                                                                        print($names[1]); ?></p>

    <?php
    $nb = random_int(0, count($names) - 1);
    print("<h3>Bonjour  $names[$nb] </h3>");
    ?>
</body>
    <script>
        document.addEventListener("click", function(){
            document.getElementById("paragraphe-1").innerHTML='J\'ai cliqué sur la page';
        });
        
    </script>

</html>