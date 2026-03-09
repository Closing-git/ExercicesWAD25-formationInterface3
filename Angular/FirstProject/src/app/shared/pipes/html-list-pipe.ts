import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'htmlList',
})
export class HtmlListPipe implements PipeTransform {

  transform(value: string[], listType:string): string {

    if (listType !== 'ul' && listType !== 'ol') {
      throw new Error("listType must be 'ul' or 'ol'");
    }
    let result : string = `<${listType}>`;

    for (const text of value){
      result += `<li>${text}</li>`;
    }
    result += `</${listType}>`;
    return result;
  }
}
