import { Component, inject , OnInit, Signal} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Math } from '../../../../shared/components/service/math';

@Component({
  selector: 'app-demo02-bindings',
  imports: [FormsModule],
  templateUrl: './demo02-bindings.html',
  styleUrl: './demo02-bindings.css',
})
export class Demo02Bindings implements OnInit {

  public username: string;
  public count : number = 0;
  public isSwitch : boolean = true;

private mathService : Math = inject(Math);
public myNumberFrom05? : Signal<number> = this.mathService.nb1;


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

  ngOnInit(): void {
  }
};
