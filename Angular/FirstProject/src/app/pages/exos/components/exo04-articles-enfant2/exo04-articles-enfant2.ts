import { Component, inject, input, InputSignal, OnInit, output, OutputEmitterRef, Signal } from '@angular/core';
import { Liste } from '../../../../shared/components/service/liste';
import { IListObject } from '../../../../shared/models/iListObject';

@Component({
  selector: 'app-exo04-articles-enfant2',
  imports: [],
  templateUrl: './exo04-articles-enfant2.html',
  styleUrl: './exo04-articles-enfant2.css',
})
export class Exo04ArticlesEnfant2 {
private listeService : Liste = inject(Liste);

public articles : Signal<IListObject[]> = this.listeService.list;

onClickRemoveArticle(article : IListObject) : void {
  this.listeService.removeArticle(article);
}
onClickMinus(article : IListObject) : void {
  this.listeService.decreaseQuantity(article);}

onClickPlus(article : IListObject) : void {
  this.listeService.increaseQuantity(article);}
}

