<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./formInscriptionTraitement.php" method="POST">
        <label for="nom">Nom :</label>
        <input type="text" name="nom" id="nom">
        <br>
        <label for="email">E-mail</label>
        <input type="email" name="email" id="email">
        <br>

        <label for="password">Mot de passe :</label>
        <input type="password" name="password" id="password">
        <br>

        <label for="confirmPassword">Confirmation mot de passe :</label>
        <input type="password" name="confirmPassword" id="confirmPassword">
        <br>

        <label for="dateNaissance">Date de naissance :</label>
        <input type="date" name="dateNaissance" id="dateNaissance">
        <br> 
        
        <label for="hobby">Hobbies :</label>
        <input type="text" name="hobby" id="hobby">
        <br>

        <input type="submit" value="Envoyer">
    </form>

</body>

</html>