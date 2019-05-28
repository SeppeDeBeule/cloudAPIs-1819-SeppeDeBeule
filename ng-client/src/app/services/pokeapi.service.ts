import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class PokeapiService {

  constructor(private _http: HttpClient) { }

  getPokemon(): Observable<IRootObject> {
    return this._http.get<IRootObject>("https://pokeapi.co/api/v2/pokemon");
  }

  pokemonInfo: IRootObject;
}

export interface IRootObject {
  count: number;
  next: string;
  previous?: any;
  results: Result[];
}

export interface Result {
  name: string;
  url: string;
}
