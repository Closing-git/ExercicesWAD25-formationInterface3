import { DatePipe } from '@angular/common';
import { Component } from '@angular/core';
import { HtmlListPipe } from '../../../../shared/pipes/html-list-pipe';

@Component({
  selector: 'app-demo03-pipes',
  imports: [DatePipe,
    HtmlListPipe],
  templateUrl: './demo03-pipes.html',
  styleUrl: './demo03-pipes.css',
})
export class Demo03Pipes {

  public today : Date;
  public students : string[] = ['Alice', 'Bob', 'Charlie'];

  constructor() {
    this.today = new Date();
  }
}
