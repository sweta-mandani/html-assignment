import {LoginComponent} from './login.component';
import {AuthService} from "../auth.service";

describe('Component: Login', () => {

  let component: LoginComponent;
  let service: AuthService;
  let component1: LoginComponent;
  let service1: AuthService;
  let spy: any;

  beforeEach(() => { (1)
    service = new AuthService();
    component = new LoginComponent(service);
    service1 = new AuthService();
    component1 = new LoginComponent(service);
  });

  afterEach(() => { (2)
    localStorage.removeItem('token');
    let service = null;
    let component = null;
    let service1 = null;
    let component1 = null ;
  });


  it('needsLogin returns true when the user has not been authenticated', () => {
    spy = spyOn(service, 'isAuthenticated').and.returnValue(false); (3)
    expect(component.needsLogin()).toBeTruthy();
    expect(service.isAuthenticated).toHaveBeenCalled(); (4)

  });

  it('needsLogin returns false when the user has been authenticated', () => {
    spy = spyOn(service, 'isAuthenticated').and.returnValue(true);
    expect(component.needsLogin()).toBeFalsy();
    expect(service.isAuthenticated).toHaveBeenCalled();
  });
  it('needsLogin returns true when the user has not been authenticated', () => {
    expect(component.needsLogin()).toBeTruthy();
  });

  it('needsLogin returns false when the user has been authenticated', () => {
    localStorage.setItem('token', '12345'); (3)
    expect(component.needsLogin()).toBeFalsy();
  });
});