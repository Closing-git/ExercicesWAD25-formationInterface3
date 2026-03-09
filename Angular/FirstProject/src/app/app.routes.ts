import { Routes } from '@angular/router';
import {Home} from './pages/home/home';
import {Demos} from './pages/demos/demos';
import {Exos} from './pages/exos/exos';

export const routes: Routes = [
    {path : 'home', component : Home},
    {path : 'demos', component : Demos,
        loadChildren: () => import('./pages/demos/demos.routes').then(m => m.routes)},
    {path : 'exos',component : Exos, 
        loadChildren: () => import('./pages/exos/exos.routes').then(m => m.routes)},
    {path : '', redirectTo : 'home', pathMatch : "full"},
    {path : '**', loadComponent : () => import('./pages/not-found/not-found').then(m => m.NotFound)}
];
