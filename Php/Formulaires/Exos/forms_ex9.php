<!DOCTYPE html>
<html lang="fr-be">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forms ex9</title>
</head>

<body>
    <form action="./forms_ex9_traitement.php" method="post">
        <label for="chambre_double">Chambres Doubles</label>
        <input type="number" name='chambre_double' id='chambre_double' placeholder=0 min='0'>
        <label for="chambre_simple">Chambres Simples</label>
        <input type="number" name='chambre_simple' id='chambre_simple' placeholder=0 min='0'>
        <label for="suite">Suite</label>
        <input type="number" name='suite' id='suite' placeholder=0 min='0'>
        <input type="submit" value="Envoyer">
    </form>
</body>

</html>