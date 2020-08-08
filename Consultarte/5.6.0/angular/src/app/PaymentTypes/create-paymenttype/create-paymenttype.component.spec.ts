import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatePaymenttypeComponent } from './create-paymenttype.component';

describe('CreatePaymenttypeComponent', () => {
  let component: CreatePaymenttypeComponent;
  let fixture: ComponentFixture<CreatePaymenttypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreatePaymenttypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatePaymenttypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
