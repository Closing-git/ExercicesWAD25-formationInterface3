import { Routes } from '@angular/router';
import { ExoIntro } from './components/exo-intro/exo-intro';


export const routes : Routes =
[
    {path : 'intro', component : ExoIntro},
    {path : 'routeComponent', loadComponent : () => import('./components/exo-01-route/exo-01-route').then(m => m.Exo01Route)},
    {path : 'chrono', loadComponent : () => import('./components/exo02-chrono/exo02-chrono').then(m => m.Exo02Chrono)},
    {path : 'animals', loadComponent : () => import('./components/exo03-animals/exo03-animals').then(m => m.Exo03Animals)},
    {path : 'articles', loadComponent : () => import('./components/exo04-articles/exo04-articles').then(m => m.Exo04Articles)},
    {path : '', redirectTo : 'intro', pathMatch : 'full'},

    ]