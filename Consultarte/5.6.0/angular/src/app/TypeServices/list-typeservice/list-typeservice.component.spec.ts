import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListTypeserviceComponent } from './list-typeservice.component';

describe('ListTypeserviceComponent', () => {
  let component: ListTypeserviceComponent;
  let fixture: ComponentFixture<ListTypeserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListTypeserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListTypeserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
