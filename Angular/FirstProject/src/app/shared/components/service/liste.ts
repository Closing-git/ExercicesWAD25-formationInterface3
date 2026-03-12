import { Injectable, signal, WritableSignal } from '@angular/core';
import { IListObject } from '../../../shared/models/iListObject';

@Injectable({
  providedIn: 'root',
})
export class Liste {

  public list: WritableSignal<IListObject[]> = signal<IListObject[]>([
    { name: "Article 1", quantity: 1 },
    { name: "Article 2", quantity: 2 },
    { name: "Article 3", quantity: 3 },
    { name: "Article 4", quantity: 4 },
    { name: "Test 5", quantity: 5 }
  ]);

  public removeArticle(value: IListObject): void {
    const newList = this.list().filter(article => article !== value);
    this.list.set(newList);
  }

  public ajouterArticle(value: IListObject): void {
    if (value.name.trim() !== '' && value.quantity > 0) {
      const existingArticle = this.list().find(article => article.name === value.name);
      if (existingArticle) {
        const updatedArticle = { name: value.name, quantity: existingArticle.quantity + value.quantity };
        const newList = this.list().map(article => article.name === value.name ? updatedArticle : article);
        this.list.set(newList);
      }
      else {
        this.list.update(list => [...list, value]);
      }
    }
    else {
      alert("Veuillez entrer un nom d'article valide et/ou une quantité supérieure à 0.");
    }
  }


  public decreaseQuantity(article: IListObject): void {
    if (article.quantity > 1) {
      let updatedArticle = { name: article.name, quantity: article.quantity - 1 };
      let newList = this.list().map(a => a.name === article.name ? updatedArticle : a);
      this.list.set(newList);
    }
    else {
      this.removeArticle(article);
    }
  }

  public increaseQuantity(article: IListObject): void {
    let updatedArticle = { name: article.name, quantity: article.quantity + 1 };
    let newList = this.list().map(a => a.name === article.name ? updatedArticle : a);
    this.list.set(newList);
  }
}
