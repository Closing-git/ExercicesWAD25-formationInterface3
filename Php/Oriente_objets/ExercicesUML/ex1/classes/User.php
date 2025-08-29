<?php

class User
{
    private string $name;
    private string $email;
    private array $posts;

    public function __construct(string $name, string $email)
    {
        $this->name = $name;
        $this->email = $email;
    }

    public function getName(): string
    {
        return $this->name;
    }

    public function getEmail(): string
    {
        return $this->email;
    }

    public function setName(string $name): void
    {
        $this->name = $name;
    }

    public function setEmail(string $email): void
    {
        $this->email = $email;
    }

    public function getPosts(): array
    {
        return $this->posts;
    }
    public function addPost(Post $post): void
    {
        $this->posts[] = $post;
    }
    public function removePost(Post $post): void
    {
        //Supprimer le post de la liste des posts, en filtrant le array, on garde
        // uniquement les posts différent de $post
        $this->posts = array_filter($this->posts, fn($p) => $p !== $post);
    }
}
