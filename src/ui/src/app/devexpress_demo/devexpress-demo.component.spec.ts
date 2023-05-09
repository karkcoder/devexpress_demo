import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DevexpressDemoComponent } from './devexpress-demo.component';

describe('DevexpressDemoComponent', () => {
  let component: DevexpressDemoComponent;
  let fixture: ComponentFixture<DevexpressDemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DevexpressDemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DevexpressDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
