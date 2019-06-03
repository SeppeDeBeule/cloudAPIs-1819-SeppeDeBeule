import { TestBed } from '@angular/core/testing';

import { CountryapiService } from './countryapi.service';

describe('CountryapiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CountryapiService = TestBed.get(CountryapiService);
    expect(service).toBeTruthy();
  });
});
