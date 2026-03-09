import { Component } from '@angular/core';
import { IAnimal } from '../../../../shared/models/ianimal';
import { FormsModule, NgModel } from '@angular/forms';
import { NgStyle } from "@angular/common";

@Component({
  selector: 'app-exo03-animals',
  imports: [FormsModule, NgStyle],
  templateUrl: './exo03-animals.html',
  styleUrl: './exo03-animals.css',  
})
export class Exo03Animals {

public animals : IAnimal[];

constructor()
{
  this.animals = [
    {name : 'Rex', species : 'Chien', isWalking : false},
    {name : 'Mittens', species : 'Chat', isWalking : true},
    {name : 'Charlie', species : 'Lapin', isWalking : false},
  ]
}



public isWalkingStyle : any = {
  'color' : 'white',
  'background-color' : 'red',
}


public newAnimal : IAnimal = {name : '', species : '', isWalking : false};

public addAnimal() : void {
if (this.newAnimal.name != '' && this.newAnimal.species != ''){
  this.animals.push(this.newAnimal);
  this.newAnimal = {name : '', species : '', isWalking : false};
}
else {throw alert('Veuillez remplir tous les champs');}
}

public removeAnimal(animal : IAnimal) :void {
  this.animals = this.animals.filter(a => a != animal);
}

public switchBalade(animal: IAnimal) : void {
  animal.isWalking = !animal.isWalking;
}
};
