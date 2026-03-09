import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'chronoTransform',
})
export class ChronoTransformPipe implements PipeTransform {
  transform(timer: number): string {
    const hours = Math.floor(timer / 3600);
    const minutes = Math.floor((timer % 3600) / 60);
    const seconds = timer % 60;
    return `${hours.toString().padStart(2, '0')}:${minutes.toString().padStart(2, '0')}:${seconds.toString().padStart(2, '0')}`;
  }
}
