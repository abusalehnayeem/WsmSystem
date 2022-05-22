import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedLayoutNavMenuComponent } from './layout/nav-menu/nav-menu.component';
import { SharedLayoutSideBarComponent } from './layout/sidebar/all.component';



@NgModule({
  declarations: [SharedLayoutNavMenuComponent, SharedLayoutSideBarComponent],
  imports: [
    CommonModule
  ],
  exports: [SharedLayoutNavMenuComponent, SharedLayoutSideBarComponent]
})
export class SharedModule { }
