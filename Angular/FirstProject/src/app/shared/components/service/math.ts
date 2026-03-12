import { Injectable, Signal, signal, WritableSignal } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class Math {
  public nb1: WritableSignal<number> = signal<number>(0);
  public nb2: WritableSignal<number> = signal<number>(0);

  public addition() : number  {
    if(this.nb1 == undefined || this.nb2 == undefined){
      throw new Error("Les nombres ne sont pas définis");
    }
    return this.nb1() + this.nb2();
  }
}
