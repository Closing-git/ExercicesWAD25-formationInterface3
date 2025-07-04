<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exo1 Formulaire</title>
</head>

<body>
    <form action="./ex1-form-traitement.php">
        <label for="nom">Nom :</label>
        <input type="text" id="nom" name="nom">
        <br>
        <label for="age">Votre age :</label>
        <input type="number" id="age" name="age">
        <br>
        <label for="date-inscription">Votre date d'inscription : </label>
        <input type="date" id="date-inscription" name="date-inscription">
        <br>
        <button type="submit">Envoyer</button>
        <button type="reset">Reset</button>
        <!-- <input type="submit" value="Envoyer"> -->
    </form>


</body>

</html>