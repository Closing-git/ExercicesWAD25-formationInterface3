import { Component, input, InputSignal, OnInit, output, OutputEmitterRef } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-exo04-articles-enfant',
  imports: [FormsModule],
  templateUrl: './exo04-articles-enfant.html',
  styleUrl: './exo04-articles-enfant.css',
})
export class Exo04ArticlesEnfant {

  public varEnfant : string = '';
  
  public outputEmetteur : OutputEmitterRef<string> = output<string>();

public ajouter(value : string) : void {
  if (value != ''){
  this.outputEmetteur.emit(value);
  this.varEnfant = '';}
}
}