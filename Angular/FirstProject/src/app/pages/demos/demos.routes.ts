import { Routes } from '@angular/router';
import { Demo01Intro } from './components/demo01-intro/demo01-intro';


export const routes : Routes = [
        {path : '', redirectTo : 'intro', pathMatch : 'full'},
        {path : 'intro', component : Demo01Intro},
        {path : 'bindings', loadComponent : () => import('./components/demo02-bindings/demo02-bindings').then(m => m.Demo02Bindings)},
        {path : 'pipes', loadComponent : () => import('./components/demo03-pipes/demo03-pipes').then(m => m.Demo03Pipes)},
        {path : 'directives', loadComponent : () => import('./components/demo04-directives/demo04-directives').then(m => m.Demo04Directives)},
        {path : 'API', loadComponent : () => import('./components/demo05-api/demo05-api').then(m => m.Demo05API)},

];
