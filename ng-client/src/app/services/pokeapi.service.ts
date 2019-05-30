import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class PokeapiService {

  constructor(private _http: HttpClient) { }

  getPokemon(url: string): Observable<IRootObject> {
    return this._http.get<IRootObject>(url);
  }

  getPokemonDetail(url: string): Observable<IRootObject> {
    return this._http.get<IRootObject>(url);
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
