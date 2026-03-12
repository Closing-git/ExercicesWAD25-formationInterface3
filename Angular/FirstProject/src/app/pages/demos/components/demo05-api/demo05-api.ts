import { Component, computed, inject, OnInit, Signal } from '@angular/core';
import { Math } from '../../../../shared/components/service/math';
import { Demo05APIForm } from "../demo05-apiform/demo05-apiform";

@Component({
  selector: 'app-demo05-api',
  imports: [Demo05APIForm],
  providers : [],
  templateUrl: './demo05-api.html',
  styleUrl: './demo05-api.css',
})
export class Demo05API {
private mathService : Math = inject(Math);
public myNumber : Signal<number> = this.mathService.nb1;
public myNumber2 : Signal<number> = this.mathService.nb2;

public result : Signal<number> = computed(() => this.mathService.addition());

}
