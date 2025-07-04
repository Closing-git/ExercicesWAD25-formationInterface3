<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Insérer Groupe</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.7/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-LN+7fdVzj6u52u30Kp6M/trliBMCMKTyK833zpbD+pXdCLuTusPj697FH4R/5mcr" crossorigin="anonymous">
    <link rel="stylesheet" href="../style/style.css">
</head>

<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.7/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ndDqU0Gzau9qJ1lfW4pNLlhNTkCfHzAVBReH9diLvGRem5+R9g2FzA8ZGN954O5Q"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js"
        integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.7/dist/js/bootstrap.min.js"
        integrity="sha384-7qAoOXltbVP82dhxHAUje59V5r2YsVfBafyUDxEdApLPmcdhBPg1DKg1ERo0BZlK"
        crossorigin="anonymous"></script>



    <?php
    include "../db/config.php";

    $cnx = new PDO(DSN, USER, PASSWORD);

    $sql = "SELECT * FROM styles ORDER BY nom ASC";

    $stmt = $cnx->prepare($sql);
    $stmt->execute();
    //Stocker le résultat dans un array
    $res = $stmt->fetchAll(PDO::FETCH_ASSOC);


    echo ('<div class="content-morceau">');
    echo ('<form enctype ="multipart/form-data" action="./formInsererGroupeTraitement.php" method="POST">');
    echo ('<label for="nom">Nom du groupe</label>');
    echo ('<input type="text" name="nom" id="nom">');
    echo ('<label for="annee_formation">Année de formation</label>');
    echo ('<input type="number" name="annee_formation" id="annee_formation">');
    echo ('<label for="style">Style</label>');
    echo ('<select name="style_id" id="style">');
    foreach ($res as $style) {
        echo ('<option value="' . $style["id"] . '">' . $style["nom"] . '</option>');
    }
    echo ('</select>');
    echo ('<br>');
    echo ('<label for="photo_groupe">Ajouter une photo :</label>');
    echo ('<input type="file" name="photo_groupe" id="photo_groupe">');
    echo ('<br>');
    echo ('<input type="submit" value="Ajout du groupe" />');



    ?>


    </form>
    </div>
</body>

</html>