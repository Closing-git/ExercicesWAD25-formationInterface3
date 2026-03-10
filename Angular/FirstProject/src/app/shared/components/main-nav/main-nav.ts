import { Component } from '@angular/core';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'main-nav',
  imports: [RouterLink],
  templateUrl: './main-nav.html',
  styleUrl: './main-nav.css',
})
export class MainNav {}
