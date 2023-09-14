import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListRepartosComponent } from './list-repartos.component';

describe('ListRepartosComponent', () => {
  let component: ListRepartosComponent;
  let fixture: ComponentFixture<ListRepartosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListRepartosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListRepartosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
