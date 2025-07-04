<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./forms_ex8_traitement.php" method="POST">
        <label for="nb_user">Entrez un nombre : </label>
        <input type="number" id="nb_user" name="nb_user">
        <br>
        <label for="tva">Selectionner le taux de TVA :</label>
        <select name="tva" id="tva">
            <option value="6">6%</option>
            <option value="12">12.5%</option>
            <option value="21">21%</option>
        </select>
        <br>
        <button type="submit">Envoyer</button>

    </form>
</body>
<img src="" width="200px" alt="">

</html>