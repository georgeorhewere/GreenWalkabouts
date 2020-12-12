import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WalkaboutsMenuComponent } from './walkabouts-menu.component';

describe('WalkaboutsMenuComponent', () => {
  let component: WalkaboutsMenuComponent;
  let fixture: ComponentFixture<WalkaboutsMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WalkaboutsMenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WalkaboutsMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
