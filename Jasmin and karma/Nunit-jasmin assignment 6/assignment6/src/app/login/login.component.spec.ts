import { TestBed, async, fakeAsync, tick, ComponentFixture } from '@angular/core/testing';
import { LoginComponent } from './login.component';
import { AuthService } from "../auth.service";
import { DebugElement } from "@angular/core";
import { By } from "@angular/platform-browser";

describe('Component: Login', () => {

    let component: LoginComponent;
    let fixture: ComponentFixture<LoginComponent>;
    let authService: AuthService;
    let el: DebugElement;
    let nativeElement;
    

    beforeEach(() => {

        
        TestBed.configureTestingModule({
            declarations: [LoginComponent],
            providers: [AuthService]
        });

      
        fixture = TestBed.createComponent(LoginComponent);
        component = fixture.componentInstance;
        authService = TestBed.get(AuthService);
        el = fixture.debugElement.query(By.css('a'));
    });

    it('Button  via fakeAsync() and tick()', fakeAsync(() => {
        expect(el.nativeElement.textContent.trim()).toBe('');
        fixture.detectChanges();
        expect(el.nativeElement.textContent.trim()).toBe('Login');

        spyOn(authService, 'isAuthenticated').and.returnValue(Promise.resolve(true));

        component.ngOnInit();
       tick();
        fixture.detectChanges();
        expect(el.nativeElement.textContent.trim()).toBe('Logout');
    }));

    it('Button  via async() and whenStable()', async(() => {
        
        fixture.detectChanges();
        expect(el.nativeElement.textContent.trim()).toBe('Login');
        spyOn(authService, 'isAuthenticated').and.returnValue(Promise.resolve(true));
        fixture.whenStable().then(() => {
          fixture.detectChanges();
          expect(el.nativeElement.textContent.trim()).toBe('Logout');
        });

        component.ngOnInit();

    }));

    it('Button  via jasmine.done', (done) => {
        fixture.detectChanges();
        expect(el.nativeElement.textContent.trim()).toBe('Login');
       let spy = spyOn(authService, 'isAuthenticated').and.returnValue(Promise.resolve(true));
       component.ngOnInit();
       spy.calls.mostRecent().returnValue.then(() => {
            fixture.detectChanges();
            expect(el.nativeElement.textContent.trim()).toBe('Logout');
           done();
        });
    });
});
