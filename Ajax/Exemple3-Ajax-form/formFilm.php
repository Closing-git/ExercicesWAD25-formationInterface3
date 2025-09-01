<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form id="formFilm">
        <label for="titre">Titre</label>
        <input type="text" name="titre" id="titre">
        <input id="btnSubmit" type="submit" value="Envoyer">
    </form>

    <div id="reponse">

    </div>

    <script>
        const divReponse = document.querySelector("#reponse")
        const btnSubmit = document.querySelector("#btnSubmit")
        const formFilm = document.querySelector("#formFilm")
        const titre = document.querySelector("#titre")

        //Pour que ça écrive "en direct" quand on tape dans le form
        formFilm.addEventListener("keyup", (event) => {

            //Retirer le comportement de base
            event.preventDefault();

            //Requête Ajax
            let xhr = new XMLHttpRequest();

            //Quand l'état est à 4, c'est à dire est DONE, lance la réponse
            xhr.onreadystatechange = function() {
                if (xhr.readyState == 4) {
                    //Insérer la réponse dans la div de la page même
                    divReponse.innerHTML = xhr.responseText;
                }
            }

            //On récupère les données du formulaire, en utilisant un objet FormData 
            let formData = new FormData(formFilm);
            xhr.open("POST", "./formFilmTraitement.php");
            //On envoie les données du formulaire
            xhr.send(formData);
        })
    </script>
</body>

</html>