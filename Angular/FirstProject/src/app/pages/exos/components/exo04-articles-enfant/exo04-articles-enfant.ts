import { Component, inject, input, InputSignal, OnInit, output, OutputEmitterRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Liste } from '../../../../shared/components/service/liste';
import { IListObject } from '../../../../shared/models/iListObject';

@Component({
  selector: 'app-exo04-articles-enfant',
  imports: [FormsModule],
  templateUrl: './exo04-articles-enfant.html',
  styleUrl: './exo04-articles-enfant.css',
})
export class Exo04ArticlesEnfant {
private listeService : Liste = inject(Liste);

public newArticle : IListObject = { name: '', quantity: 0 };
  
public onClickAjouter(article : IListObject) : void {
    this.listeService.ajouterArticle(article);
    this.newArticle = { name: '', quantity: 0 };
  }
}