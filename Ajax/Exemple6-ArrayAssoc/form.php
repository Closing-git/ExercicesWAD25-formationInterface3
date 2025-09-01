<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    Quand on clique sur le bouton on affiche une liste contenant de noms<br>
    <form id="form">
        <button id="btnAfficher">Afficher</button>
    </form>
    <div id="divListeNoms">Ici la liste</div>

    <script>
        const btnAfficher = document.querySelector("#btnAfficher");
        const divListeNoms = document.querySelector("#divListeNoms");



        btnAfficher.addEventListener("click", (event) => {
            event.preventDefault();

            // init le div
            divListeNoms.innerHTML = "";


            let xhr = new XMLHttpRequest();

            xhr.onreadystatechange = function() {

                if (xhr.readyState == 4) {
                    let res = JSON.parse(xhr.responseText);
                    //Le résultat est un array d'objet

                    res.forEach( (element) => {
                        //Element est un objet du tableau res (donc = une personne)
                        divListeNoms.innerHTML += element.prenom + " " + element.nom + "<br>"
                    })

                }
            }

            // on doit envoyer un formulaire!
            xhr.open("POST", "./formTraitement.php");
            xhr.send(null);

        });
    </script>


</body>

</html>