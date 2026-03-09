import { Component } from '@angular/core';
import { Exo04ArticlesEnfant } from '../exo04-articles-enfant/exo04-articles-enfant';
import { Exo04ArticlesEnfant2 } from '../exo04-articles-enfant2/exo04-articles-enfant2';


@Component({
  selector: 'app-exo04-articles',
  imports: [Exo04ArticlesEnfant, Exo04ArticlesEnfant2],
  templateUrl: './exo04-articles.html',
  styleUrl: './exo04-articles.css',
})
export class Exo04Articles {
  

  public varEnfantFromEmetteur? : string[] = ['article 1', 'article 2', 'article 3'];


public onReceivedValue(value : string){
    this.varEnfantFromEmetteur?.push(value);
}
}
