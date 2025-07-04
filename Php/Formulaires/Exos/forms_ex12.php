<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./forms_ex12_traitement.php" method="POST">
        <label for="prix">Prix des articles :</label>
        <input type="number" name="prix" id="prix">
        <label for="moyen_paiement">Moyen de paiement</label>
        <select name="moyen_paiement" id="moyen_paiement">
            <option value="Mastercard">Mastercard (+5€)</option>
            <option value="Visa">Visa(+3€)</option>
        </select>
        <input type="submit" value="Voir le prix total">
    </form>
</body>

</html>