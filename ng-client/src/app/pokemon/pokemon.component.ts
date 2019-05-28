import { Component, OnInit } from '@angular/core';
import { IRootObject, Result, PokeapiService } from '../services/pokeapi.service';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})

export class PokemonComponent implements OnInit {

  pokemon : Result[];
  constructor(private _service:PokeapiService) { }

  ngOnInit() {
    this._service.getPokemon().subscribe(pokemonlist => this.pokemon = pokemonlist.results);
  }

}
