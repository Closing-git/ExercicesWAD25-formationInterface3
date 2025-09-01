<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./formFilmTraitement.php" method="POST">
        <label for="titre">Titre</label>
        <input type="text" name="titre" id="titre">
        <label for="duree">Durée</label>
        <input type="number" name="duree" id="duree">
        <input type="submit" value="Envoyer">


    </form>
    <script>
        setTimeout(function (){
            console.log("callback lancé");
        }, 2000)
    </script>
</body>

</html>