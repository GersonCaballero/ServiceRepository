import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateFinaluserComponent } from './create-finaluser.component';

describe('CreateFinaluserComponent', () => {
  let component: CreateFinaluserComponent;
  let fixture: ComponentFixture<CreateFinaluserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateFinaluserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateFinaluserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
