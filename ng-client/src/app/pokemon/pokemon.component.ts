import { Component, OnInit } from '@angular/core';
import { IRootObject, Result, PokeapiService } from '../services/pokeapi.service';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})

export class PokemonComponent implements OnInit {

  pokedata : IRootObject;
  pagenum = 1;
  constructor(private _service:PokeapiService) { }

  getPokemon(Url: string) {
    this._service.getPokemon(Url).subscribe(pokemonlist => this.pokedata = pokemonlist);
  
    var pagecount = Math.floor(this.pokedata.count / 20);
  }

  ngOnInit() {
    this.getPokemon("https://pokeapi.co/api/v2/pokemon");
  }

  next() {
    this.pagenum++;
    this.getPokemon(this.pokedata.next);
  }

  prev() {
    this.pagenum--;
    this.getPokemon(this.pokedata.previous);
  }

}
