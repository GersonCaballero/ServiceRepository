import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTypeserviceComponent } from './create-typeservice.component';

describe('CreateTypeserviceComponent', () => {
  let component: CreateTypeserviceComponent;
  let fixture: ComponentFixture<CreateTypeserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateTypeserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateTypeserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
