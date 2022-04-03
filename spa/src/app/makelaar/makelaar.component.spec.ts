/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MakelaarComponent } from './makelaar.component';

describe('MakelaarComponent', () => {
  let component: MakelaarComponent;
  let fixture: ComponentFixture<MakelaarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MakelaarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MakelaarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
