<?php

class Post {
    private string $title;
    private DateTime $dateCreation;
    private User $author;

    public function __construct(string $title, DateTime $dateCreation, User $author){
        $this->title = $title;
        $this->dateCreation = $dateCreation;
        $this->author = $author;
        $author->addPost($this);
    }
    


    public function getTitle(): string {
        return $this->title;
    }

    public function getDateCreation(): DateTime {
        return $this->dateCreation;
    }

    public function getAuthor(): User {
        return $this->author;
    }

    public function setAuthor(User $author): void {
        $this->author->removePost($this);
        $this->author = $author;
        $author->addPost($this);
    }

    public function setTitle(string $title): void {
        $this->title = $title;
    }

    public function setDateCreation(DateTime $dateCreation): void {
        $this->dateCreation = $dateCreation;
    }

}