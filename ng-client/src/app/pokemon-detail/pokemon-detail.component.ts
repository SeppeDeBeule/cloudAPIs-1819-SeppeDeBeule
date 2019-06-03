import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IDetailRootObject, PokeapiService } from '../services/pokeapi.service';

@Component({
  selector: 'app-pokemon-detail',
  templateUrl: './pokemon-detail.component.html',
  styleUrls: ['./pokemon-detail.component.css']
})
export class PokemonDetailComponent implements OnInit {

  pokedetail : IDetailRootObject;
  name : string;


  constructor(private _service:PokeapiService, private route: ActivatedRoute) { }
  
  ngOnInit() {
    this.name = this.route.snapshot.paramMap.get('name');
    this.getPokemon(`https://pokeapi.co/api/v2/pokemon/${this.name}`);
  }

  getPokemon(Url: string) {
    this._service.getPokemonDetail(Url).subscribe(pokemondetail => this.pokedetail = pokemondetail)
  }
}
