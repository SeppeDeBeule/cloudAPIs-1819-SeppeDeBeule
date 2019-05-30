import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from 'src/app/home/home.component';
import { PokemonComponent} from 'src/app/pokemon/pokemon.component';
import { PokemonDetailComponent} from 'src/app/pokemon-detail/pokemon-detail.component';
import { NotfoundComponent } from 'src/app/notfound/notfound.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },                       //
  { path: 'pokemon/:page', component: PokemonComponent },           //
  { path: 'viewpokemon/:name', component: PokemonDetailComponent }, //
  { path: '', redirectTo: '/home', pathMatch: 'full' },             // Homepage   
  { path: '**', component: NotfoundComponent }                      // 404 Landing page
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
