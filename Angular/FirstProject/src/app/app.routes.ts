import { Routes } from '@angular/router';
import {Home} from './pages/home/home';
import {Demos} from './pages/demos/demos';
import {Exos} from './pages/exos/exos';
import { Demo01Intro } from './pages/demos/components/demo01-intro/demo01-intro';
import { ExoIntro } from './pages/exos/components/exo-intro/exo-intro';
import { Exo01Route } from './pages/exos/components/exo-01-route/exo-01-route';


export const routes: Routes = [
    {path : 'home', component : Home},
    {path : 'demos', component : Demos, children:[
        {path : 'intro', component : Demo01Intro}
    ]},
    {path : 'exos',component : Exos, children:[
        {path : 'intro', component : ExoIntro},
        {path : '', redirectTo : 'intro', pathMatch : 'full'},
        {path : 'routeComponent', component : Exo01Route},

    ]},
    {path : '', redirectTo : 'home', pathMatch : "full"},

];
