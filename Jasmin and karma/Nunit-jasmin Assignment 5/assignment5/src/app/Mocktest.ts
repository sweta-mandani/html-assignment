export class Mocktest{

    endsWith(val:string) {
        if (val.endsWith('DIGITAL')) { 
            return true; 
        }
        return false;
    }

    LessthenTen(data:string) {
        if (data.length < 10) {
            return true;
        }
        return false;
    }

}