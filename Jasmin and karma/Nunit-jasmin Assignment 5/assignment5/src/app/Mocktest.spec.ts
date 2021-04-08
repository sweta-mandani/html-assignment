import { TestBed } from '@angular/core/testing';

import { Mocktest} from '../app/Mocktest';
import { of } from 'rxjs';

const todosServiceStub = {
    get() {
      const todos = [{id: 1}];
      return of( todos );
    }
  };
  

describe('Utility Testing ', () => {

    // Using mocking with spy
    let CheckValidation : Mocktest;
    let spy: any;

    beforeEach(() => {
        CheckValidation =  new Mocktest();
    });
    afterEach(()=>{
        let CheckValidation=null;
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
    
    
   
});