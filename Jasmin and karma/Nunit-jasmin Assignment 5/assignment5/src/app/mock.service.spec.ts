import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { MockService } from '../app/mock.service';

describe('LocationService', () => {
  let locationService: MockService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule
      ],
      providers: [
        MockService
      ]
    });

    locationService = TestBed.get(MockService);
    httpMock = TestBed.get(HttpTestingController);
  });

  it('should return error if country request failed', (done) => {
    locationService.getLocations()
                   .subscribe((res: any) => {
                     expect(res.failure.error.type).toBe('ERROR_LOADING_COUNTRIES');
                     done();
                   });

    let countryRequest = httpMock.expectOne('./assets/countries.json');
    countryRequest.error(new ErrorEvent('ERROR_LOADING_COUNTRIES'));

    httpMock.verify();
  });

  it('should return error if usa request failed', (done) => {
    locationService.getLocations()
                   .subscribe((res: any) => {
                     expect(res.failure.error.type).toBe('ERROR_LOADING_COUNTRY');
                     done();
                   });
    let countryRequest = httpMock.expectOne('./assets/countries.json');
    countryRequest.flush({countries: ["usa", "norway"]});                

    let norwayRequest = httpMock.expectOne('./assets/norway.json');
    norwayRequest.flush({cities: ["Oslo", "Bergen", "Trondheim"]});

    let usaRequest = httpMock.expectOne('./assets/usa.json');
    usaRequest.error(new ErrorEvent('ERROR_LOADING_COUNTRY'));

    httpMock.verify();
  });

  it('should return error if norway request failed', (done) => {
    locationService.getLocations()
                   .subscribe((res: any) => {
                     expect(res.failure.error.type).toBe('ERROR_LOADING_COUNTRY');
                     done();
                   });
    let countryRequest = httpMock.expectOne('./assets/countries.json');
    countryRequest.flush({countries: ["usa", "norway"]});    
    
    let usaRequest = httpMock.expectOne('./assets/usa.json');
    usaRequest.flush({cities: ["New York", "Chicago", "Denver"]});

    let norwayRequest = httpMock.expectOne('./assets/norway.json');
    norwayRequest.error(new ErrorEvent('ERROR_LOADING_COUNTRY'));

    httpMock.verify();
  });

  it('should successfully get countries and cities', (done) => {
    locationService.getLocations()
                   .subscribe(res => {
                     expect(res).toEqual(
                       [
                         {country: 'USA', cities: ["New York", "Chicago", "Denver"]},
                         {country: 'NORWAY', cities: ["Oslo", "Bergen", "Trondheim"]}
                       ]
                     );
                     done();
                   });

    let countryRequest = httpMock.expectOne('./assets/countries.json');
    countryRequest.flush({countries: ["usa", "norway"]});

    let usaRequest = httpMock.expectOne('./assets/usa.json');
    usaRequest.flush({cities: ["New York", "Chicago", "Denver"]});

    let norwayRequest = httpMock.expectOne('./assets/norway.json');
    norwayRequest.flush({cities: ["Oslo", "Bergen", "Trondheim"]});

    httpMock.verify();
  });

});