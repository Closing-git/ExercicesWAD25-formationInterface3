<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form id="formulaire">
        <label for="nom">Nom</label>
        <input type="text" name="nom" id="nom">
        <label for="prenom">Prenom</label>
        <input type="text" name="prenom" id="prenom">
        <input type="submit" value="Envoyer">
    </form>
    <input id="btn_like" type="submit" value="LIKER">
    <span id="nb_de_like">
        Pas liké
    </span>
    <div id="reponse">
        Le nom tapé est :
    </div>

    <script>
        const htmlForm = document.querySelector("#formulaire")
        const htmlNbLike = document.querySelector("#nb_de_like")
        const htmlReponse = document.querySelector("#reponse")
        const htmlBtnLike = document.querySelector("#btn_like")


        htmlForm.addEventListener("keyup", (event) => {
            event.preventDefault()

            let xhr = new XMLHttpRequest();

            xhr.onreadystatechange = function() {
                if (xhr.readyState == 4) {
                    console.log("test")
                    htmlReponse.innerHTML = xhr.responseText
                }
            }

            let formData = new FormData(htmlForm);
            xhr.open("POST", "./formTraitement.php");
            //On envoie les données du formulaire
            xhr.send(formData);
        })


        htmlBtnLike.addEventListener("click", (event) => {
            event.preventDefault()

            let xhr2 = new XMLHttpRequest()
            xhr2.onreadystatechange = function() {
                if (xhr2.readyState == 4) {
                    htmlNbLike.innerHTML = xhr2.responseText
                }

            }
            let contenuLike= htmlNbLike.innerHTML;
            xhr2.open("POST", "./likeCalculator.php");
            xhr2.send(null);
        })
    </script>
</body>

</html>