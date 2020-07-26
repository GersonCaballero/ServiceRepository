import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTypeserviceComponent } from './edit-typeservice.component';

describe('EditTypeserviceComponent', () => {
  let component: EditTypeserviceComponent;
  let fixture: ComponentFixture<EditTypeserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditTypeserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditTypeserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
