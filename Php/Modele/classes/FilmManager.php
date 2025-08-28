<?php
require_once "./classes/Film.php";
class FilmManager
{

    private PDO $cnx;

    public function __construct(PDO $cnx)
    {
        $this->cnx = $cnx;
    }



    public function insert(Film $film)
    {

        $sql = "INSERT INTO film (id, titre, duree, description, dateSortie) ";
        $sql .= " VALUES (NULL , :titre, :duree, :description, :dateSortie )";

        // https://www.php.net/manual/fr/pdo.constants.php
        $stmt = $this->cnx->prepare($sql);

        $stmt->bindValue(":titre", $film->getTitre());
        $stmt->bindValue(":duree", $film->getDuree(), PDO::PARAM_INT);
        $stmt->bindValue(":description", $film->getDescription());
        $stmt->bindValue(":dateSortie", $film->getDateSortie()->format('Y-m-d'));

        $stmt->execute();

        $film->setId($this->cnx->lastInsertId());
    }


    public function delete(Film $film)
    {
        $sql = "DELETE FROM film WHERE id=:id";
        $stmt = $this->cnx->prepare($sql);

        $stmt->bindValue(":id", $film->getId(), PDO::PARAM_INT);
        // PARAM_INT pour forcer à ce que ce soit un entier, pour éviter les injections SQL de quelqu'un de malveillant

        $stmt->execute();
    }


    public function select(array $filtres){
        $sql = "SELECT * FROM film WHERE ";
        // Créer couples clé valeur du type cle=:cle à partir de l'array
        
        $cles = array_keys($filtres);
        var_dump($cles);

        $string_filtres="";
        foreach ($cles as $cle) {
            // Créer un array de clé =:clé qu'avec implode on lie ensemble avec des AND entre
            $arrayConditions[]=$cle. "=:" . $cle;
        }
        $string_filtres = implode(" AND ", $arrayConditions);

        $sql .= $string_filtres;
        var_dump($sql);

        
        $stmt = $this->cnx->prepare($sql);
        // On relie les valeurs avec bindValue
        foreach ($filtres as $cle => $valeur){
            $stmt->bindValue(":". $cle, $valeur);

        }
    
        $stmt->execute();
        
        // Récupération des résultats et les afficher dans un tableau associatif
        $resultats = $stmt->fetchAll(PDO::FETCH_ASSOC);
        // On transforme ensuite le Array assoc en objets
        $films = [];
        foreach ($resultats as $cle=> $arrayFilm){
            $film = new Film($arrayFilm['titre'], $arrayFilm['duree'], $arrayFilm['description'], new DateTime ($arrayFilm['dateSortie']));
            // L'id n'est pas initialisé, donc on le met manuellement avec un setId. Puisqu'on a l'ID dans le tableau associatif (mais qu'on l'a pas mis dans le constructeur)
            $film->setId ($arrayFilm['id']);
            $films[] = $film;
            
        }
        
        var_dump($resultats);
        var_dump($films);


    
}
}