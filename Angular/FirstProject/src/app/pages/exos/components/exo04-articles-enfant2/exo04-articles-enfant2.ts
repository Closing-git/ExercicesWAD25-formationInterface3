import { Component, input, InputSignal, OnInit, output, OutputEmitterRef } from '@angular/core';

@Component({
  selector: 'app-exo04-articles-enfant2',
  imports: [],
  templateUrl: './exo04-articles-enfant2.html',
  styleUrl: './exo04-articles-enfant2.css',
})
export class Exo04ArticlesEnfant2 {

  public inputFromParent: InputSignal<string[] | undefined> = input<string[]>();

  public removeArticle(value : string) : void {
    if (this.inputFromParent() != undefined){
    this.inputFromParent()!.splice(this.inputFromParent()!.indexOf(value), 1);
    }
}}
