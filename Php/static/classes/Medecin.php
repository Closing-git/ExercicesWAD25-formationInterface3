<?php   

class Medecin{
    private $id;
    private $nom;
    private $prenom;
    private $specialite;
    private static string $codeDeontologique = "Faire le bien";


    public function __construct(int $id, string $nom, string $prenom, string $specialite){
        $this->id = $id;
        $this->nom = $nom;
        $this->prenom = $prenom;
        $this->specialite = $specialite;
    }

    public static function getCodeDeontologique():string{
        return self::$codeDeontologique;

    }
    public function getId(){
        return $this->id;
    }
    public function getNom(){
        return $this->nom;
    }
    public function getPrenom(){
        return $this->prenom;
    }
    public function getSpecialite(){
        return $this->specialite;
    }

    public function setId(int $id){
        $this->id = $id;
    }
    public function setNom(string $nom){
        $this->nom = $nom;
    }
    public function setPrenom(string $prenom){
        $this->prenom = $prenom;
    }
    public function setSpecialite(string $specialite){
        $this->specialite = $specialite;
    }


}    
