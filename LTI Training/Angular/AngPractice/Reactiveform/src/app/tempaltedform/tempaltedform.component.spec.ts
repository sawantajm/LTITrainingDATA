import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TempaltedformComponent } from './tempaltedform.component';

describe('TempaltedformComponent', () => {
  let component: TempaltedformComponent;
  let fixture: ComponentFixture<TempaltedformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TempaltedformComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TempaltedformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
