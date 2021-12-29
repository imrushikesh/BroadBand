import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertNewLeadComponent } from './insert-new-lead.component';

describe('InsertNewLeadComponent', () => {
  let component: InsertNewLeadComponent;
  let fixture: ComponentFixture<InsertNewLeadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertNewLeadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertNewLeadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
