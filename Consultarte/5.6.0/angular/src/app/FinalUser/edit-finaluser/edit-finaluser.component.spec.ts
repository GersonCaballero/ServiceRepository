import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditFinaluserComponent } from './edit-finaluser.component';

describe('EditFinaluserComponent', () => {
  let component: EditFinaluserComponent;
  let fixture: ComponentFixture<EditFinaluserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditFinaluserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditFinaluserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
