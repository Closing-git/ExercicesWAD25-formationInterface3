import { NgStyle } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-demo04-directives',
  imports: [NgStyle],
  templateUrl: './demo04-directives.html',
  styleUrl: './demo04-directives.css',
})
export class Demo04Directives {

  public style1 : any = {
    color : "red",
    fontSize : "20px",
    border : "1px solid black"
  }
}
