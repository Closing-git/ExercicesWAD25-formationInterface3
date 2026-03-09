import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-demo02-bindings',
  imports: [FormsModule],
  templateUrl: './demo02-bindings.html',
  styleUrl: './demo02-bindings.css',
})
export class Demo02Bindings {

  public username: string;
  public count : number = 0;
  public isSwitch : boolean = true;

  constructor() {
    this.username = "John Doe";

  }

  public onClickIncrement() : void {
    this.count++;
  }

  public onClickCountZero() : void {
    this.count = 0;
  }

  public onClickSwitch(): void {
    this.isSwitch= !this.isSwitch;
  }
};
