import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IListRootObject, PokeapiService } from '../services/pokeapi.service';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})

export class PokemonComponent {

  pokedata : IListRootObject;

  pagenum : number;
  limit = 20;
  offset : number;

  constructor(private _service:PokeapiService, private route: ActivatedRoute) { 
    route.params.subscribe(val => {
      this.pagenum = parseInt(this.route.snapshot.paramMap.get('page'));
      this.offset = this.limit * (this.pagenum - 1);
      this.getPokemon(`https://pokeapi.co/api/v2/pokemon/?offset=${this.offset}&limit=${this.limit}`);
    });
  }

  getPokemon(Url: string) {
    this._service.getPokemon(Url).subscribe(pokemonlist => this.pokedata = pokemonlist);
  }

  getPageCount() {
    return Math.ceil(this.pokedata.count / 20);
  }
  
  getNext() {
    return `/pokemon/${this.pagenum + 1}`;
    
  }

  getPrev() {
    return `/pokemon/${this.pagenum - 1}`;
  }
}
