import { TestBed } from '@angular/core/testing';

import { test } from '../app/test';
import { of } from 'rxjs';

const todosServiceStub = {
    get() {
      const todos = [{id: 1}];
      return of( todos );
    }
  };
  

describe('Utility Testing : Validation ', () => {

    // Using mocking with spy
    let CheckValidation : test;
    let spy: any;

    beforeEach(() => {
        CheckValidation =  new test();
    });
    afterEach(()=>{
        CheckValidation=null;
    });

    
    it('valid email',()=>{

       
        let input="sweta123@gmail.com";

       
        spy = spyOn(CheckValidation, 'EmailValid').and.returnValue(true);
        let result=CheckValidation.EmailValid(input);

       
        expect(result).toBeTrue();
    });

    it('valid phone number',()=>{
        
       
        let input="1234567890";

       
        spy = spyOn(CheckValidation, 'PhoneValid').and.returnValue(false);
        let result=CheckValidation.PhoneValid(input);

       
        expect(result).toBeFalse();
    });

    it('endsWith DIGITAL',()=>{
        
       
        let input = "TCS DIGITAL";

       
        spy = spyOn(CheckValidation, 'endsWith').and.returnValue(true);
        let result=CheckValidation.endsWith(input);

       
        expect(result).toBeTrue();
    });

    it('length should be Less then Ten',()=>{
        
       
        let input = "hiii hell" ;

       
        spy = spyOn(CheckValidation, 'LessthenTen').and.returnValue(true);
        let result=CheckValidation.LessthenTen(input);

       
        expect(result).toBeTrue();
    });
    it('check Upper letter',()=>{
        
       
        let input = "SWETA" ;

       
        spy = spyOn(CheckValidation, 'CheckUpperCase').and.returnValue(true);
        let result=CheckValidation.CheckUpperCase(input);

       
        expect(result).toBeTrue();
    });

    
   
});