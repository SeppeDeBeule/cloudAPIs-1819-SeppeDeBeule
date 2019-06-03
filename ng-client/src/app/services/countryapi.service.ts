import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class CountryapiService {

  constructor(private _http: HttpClient) { }

  getCountries(url: string): Observable<IRootObject> {
    return this._http.get<IRootObject>(url);
  }
  pokemonInfo: IRootObject;
}

export interface IRootObject {
  id: number;
  name: string;
  iso: string;
  capital: string;
  surface_area: number;
  population: number;
}