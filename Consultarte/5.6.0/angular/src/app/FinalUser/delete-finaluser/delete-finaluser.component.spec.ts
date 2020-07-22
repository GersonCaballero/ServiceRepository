import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteFinaluserComponent } from './delete-finaluser.component';

describe('DeleteFinaluserComponent', () => {
  let component: DeleteFinaluserComponent;
  let fixture: ComponentFixture<DeleteFinaluserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeleteFinaluserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteFinaluserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
