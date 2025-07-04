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

    var_dump($_POST);
    var_dump($_FILES);

    //Créer un chemin et un nom pour le fichier img uploadé

    $dossier = '../img';
    $nomFichierBD = uniqid() . date("y-m-d") . $_FILES['photo_groupe']['name'];
    $nomFichierDisque = $dossier . "/" . $nomFichierBD ;

    //Empêcher d'avoir un fichier trop lourd, on divise par 1 000 000 pour l'obtenir en Giga(?)
    if ($_FILES['photo_groupe']['size'] / 1000000 > 4) {
        throw new Exception("Accès interdit");
    }

    //Bouger le fichier du temp vers le dossier img
    move_uploaded_file($_FILES['photo_groupe']['tmp_name'],  $nomFichierDisque);


    //Choper la DB
    include "../db/config.php";
    try {
        $cnx = new PDO(DSN, USER, PASSWORD);
    } catch (Exception $e) {
        die();
    }

    $sql = 'INSERT INTO groupes (id, nom, annee_formation, lienImage, style_id) VALUES (NULL, :nom, :annee_formation, :lienImage, :style_id)';

    //Relier les données obtenu de Post à l'insert
    $stmt = $cnx->prepare($sql);
    $stmt->bindValue("nom", $_POST['nom']);
    $stmt->bindValue("lienImage", $nomFichierBD);
    $stmt->bindValue("annee_formation", $_POST['annee_formation'], PDO::PARAM_INT);
    $stmt->bindValue("style_id", $_POST['style_id'], PDO::PARAM_INT);

    $stmt->execute();

    //Donner un message de confirmation + ajouter un bouton retour accueil
    echo ("<p>Vous avez bien ajouté : " . $_POST["nom"] . " à la base de données.</p>");
    echo ('<ul class="navbar-nav me-auto mb-2 mb-lg-0">');
    echo ('<li class="nav-item">');
    echo ('<button><a class="nav-link" href="../index.php">Retour à l\'accueil</a></button>');
    echo ('</li> </ul>');

    ?>


    </form>
    </div>
</body>

</html>