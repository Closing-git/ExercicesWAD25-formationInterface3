import { Component, inject, OnInit} from '@angular/core';
import { Math } from '../../../../shared/components/service/math';
import { FormsModule } from "@angular/forms";

@Component({
  selector: 'app-demo05-apiform',
  imports: [FormsModule],
  templateUrl: './demo05-apiform.html',
  styleUrl: './demo05-apiform.css',
})
export class Demo05APIForm implements OnInit {
private mathService : Math = inject(Math);
public nb1 : number = 0;
public nb2 : number = 0;


public sauvegarder() : void {
  this.mathService.nb1.set(this.nb1);
  this.mathService.nb2.set(this.nb2);
}

ngOnInit(): void {
  this.nb1 = this.mathService.nb1();
  this.nb2 = this.mathService.nb2();
}
}
