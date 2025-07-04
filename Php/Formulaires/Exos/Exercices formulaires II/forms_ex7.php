<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./forms_ex7_traitement.php" method="POST">
        <label for="nb_km">Nombre de kilomètres :</label>
        <input type="number" name="nb_km" id="nb_km">
        <label for="car_type">Type de voiture :</label>
        <select name="car_type" id="car_type">
            <option value="diesel">Diesel</option>
            <option value="essence">Essence</option>
        </select>
        <input type="submit" value="Calculer le prix">

    </form>
</body>

</html>