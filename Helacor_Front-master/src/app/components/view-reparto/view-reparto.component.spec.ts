import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewRepartoComponent } from './view-reparto.component';

describe('ViewRepartoComponent', () => {
  let component: ViewRepartoComponent;
  let fixture: ComponentFixture<ViewRepartoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewRepartoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ViewRepartoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
