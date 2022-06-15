import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';

import { IgxCardModule, IgxAvatarModule, IgxButtonModule, IgxRippleModule, IgxIconModule, IgxExpansionPanelModule, IgxListModule, IgxInputGroupModule, IgxCheckboxModule } from 'igniteui-angular';
import { ExpansionPanelsComponent } from './expansion-panels.component';

describe('ExpansionPanelsComponent', () => {
  let component: ExpansionPanelsComponent;
  let fixture: ComponentFixture<ExpansionPanelsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExpansionPanelsComponent ],
      imports: [ NoopAnimationsModule, FormsModule, IgxCardModule, IgxAvatarModule, IgxButtonModule, IgxRippleModule, IgxIconModule, IgxExpansionPanelModule, IgxListModule, IgxInputGroupModule, IgxCheckboxModule ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExpansionPanelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
