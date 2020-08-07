import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListPaymenttypeComponent } from './list-paymenttype.component';

describe('ListPaymenttypeComponent', () => {
  let component: ListPaymenttypeComponent;
  let fixture: ComponentFixture<ListPaymenttypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListPaymenttypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListPaymenttypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
