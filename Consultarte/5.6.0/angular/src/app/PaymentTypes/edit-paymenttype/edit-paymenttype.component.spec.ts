import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPaymenttypeComponent } from './edit-paymenttype.component';

describe('EditPaymenttypeComponent', () => {
  let component: EditPaymenttypeComponent;
  let fixture: ComponentFixture<EditPaymenttypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditPaymenttypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditPaymenttypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
