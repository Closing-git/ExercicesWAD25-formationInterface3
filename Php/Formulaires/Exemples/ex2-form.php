<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ex2 Formulaire</title>
</head>

<body>
    <form action="./ex2-form-traitement.php">
        <label for="periode-select">Choisissez votre période : </label>
        <select name="periode" id="periode-select">
            <option value="matin">Matinée</option>
            <option value="midi">Temps de midi</option>
            <option value="soir">Soirée</option>
        </select>
        <br>
        <label for="vehicule"></label>
        <input type="checkbox" id="vehicule" name="voiture"> Voiture</input> 
        <button type="submit">Valider</button>

    </form>
</body>

</html>