import { Component, OnInit } from '@angular/core';
import { CountryapiService, IRootObject } from '../services/countryapi.service';
import { IListRootObject } from '../services/pokeapi.service';

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.css']
})
export class CountriesComponent implements OnInit {

  countrydata : IRootObject;

  constructor(private _service:CountryapiService) { }

  ngOnInit() {
    this.getCountries(`https://restapi-dot-prime-sign-240906.appspot.com/api/v1/countries`);
  }

  getCountries(Url: string) {
    this._service.getCountries(Url).subscribe(pokemonlist => this.countrydata = pokemonlist);
  }

}
