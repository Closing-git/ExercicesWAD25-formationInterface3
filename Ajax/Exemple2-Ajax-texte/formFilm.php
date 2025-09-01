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
        <input id="btnSubmit" type="submit" value="Envoyer">


    </form>
    <div id="reponse">

    </div>

    <script>
        const divReponse = document.querySelector("#reponse")

        const btnSubmit = document.querySelector("#btnSubmit")
        btnSubmit.addEventListener("click", (event) => {

            event.preventDefault();
            console.log("Clic sur bouton")

            //Requête Ajax
            let xhr = new XMLHttpRequest();

            // //Quand l'état de l'appel xhr change (état possible : 0 UNSENT, 1 OPENED, 2 HEADERS_RECEIVED, 3 LOADING, 4 DONE)
            // xhr.onreadystatechange = function() {
            //     console.log("l etat de xhr change", xhr.readyState);


            //Quand l'état est à 4, c'est à dire est DONE, lance la réponse
            xhr.onreadystatechange = function() {
                if (xhr.readyState == 4) {
                    console.log("Requete terminée");
                    //Insérer la réponse dans la div de la page même
                    divReponse.innerHTML = xhr.responseText;
                }
            }

            xhr.open("GET", "./formFilmTraitement.php");
            //Ce qui est envoyé à la page de traitement (ici null, mais plus tard on pourra envoyer les données du form)
            xhr.send(null);
        })
    </script>
</body>

</html>