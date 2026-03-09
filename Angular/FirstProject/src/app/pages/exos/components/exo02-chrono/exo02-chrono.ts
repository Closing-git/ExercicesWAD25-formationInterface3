import { Component, NgZone, Signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ChronoTransformPipe } from '../../../../shared/pipes/chrono-transform-pipe';

@Component({
  selector: 'app-exo02-chrono',
  imports: [FormsModule, ChronoTransformPipe],
  templateUrl: './exo02-chrono.html',
  styleUrl: './exo02-chrono.css',
})
export class Exo02Chrono {

  public time: number;
  public chronoIsActive: boolean = false;
  private interval: any;

  constructor() {
    this.time = 0;
  }

  public startChrono(): void {
    if (!this.chronoIsActive) {
      this.interval = setInterval(() => {
        this.time++;
      }, 1000);

      this.chronoIsActive = true;
    }
  }

  public pauseChrono(): void {
    if (this.chronoIsActive) {
      clearInterval(this.interval);
      this.chronoIsActive = false;
    }
  }

  public stopChrono(): void {
    this.pauseChrono();
    this.time = 0;
  }


}
